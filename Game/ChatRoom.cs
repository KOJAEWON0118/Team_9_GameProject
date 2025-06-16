using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using Packet_Chat;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Game
{
    public partial class ChatRoom : Form
    {
        /* server 전용 변수*/
        TcpListener m_listener;
        private List<ClientInfo> clients = new List<ClientInfo>();// server가 client 관리를 위해 사용할 list
        private int clientCounter = 0; // 클라이언트 ID 자동 증가
        class ClientInfo // 각 client의 stream 정보
        {
            public int Id;  // 고유 식별자
            public TcpClient Client;
            public Thread Thread;
            public NetworkStream Stream;
        }
        private RoleType role;

        /*client 전용 변수*/
        TcpClient client_client; //클라이언트용
        NetworkStream client_stream; // 클라이언트용
        bool client_Connected = false;
        private CreateRoomData roomData;
        private void ConnectClient()
        {
            try
            {
                byte[] sendBuffer = new byte[1024 * 4];
                byte[] readBuffer = new byte[1024 * 4];
                client_client = new TcpClient();
                client_client.Connect("127.0.0.1", 7777); //나중에 lan으로 바꿀거
                client_stream = client_client.GetStream(); //stream생성
                client_Connected = true;

                //초기 client 입장에 대한 메세지를 server에 전송
                ChatMessage msg_enter = new ChatMessage
                {
                    Nickname = "시스템",
                    Message = roomData.Nickname+"이 입장했습니다"
                };
                Packet enter = new Packet
                {
                    Type = (int)PacketType.Chat,
                    Data = msg_enter
                };
                byte[] bytes = PacketUtil.Serialize(enter); // 직렬화
                client_stream.Write(bytes, 0, bytes.Length);  // 실제 전송

                Thread m_thread = new Thread(() =>
                {
                    try
                    {
                        while (client_Connected)
                        {
                            //서버가 보낸 데이터를 읽기. Read(읽을 데이터를 저장할 배열, 저장을 시작할 위치, 저장을 최대 몇 바이트)
                            int bytesRead = client_stream.Read(readBuffer, 0, readBuffer.Length); 
                            if (bytesRead == 0)
                                break;

                            //서버가 보낸 데이터를 다시 역질렬화(byte[]를 object로)
                            Packet packet = (Packet)PacketUtil.Deserialize(readBuffer);
                            ChatMessage msg = (ChatMessage)packet.Data;
                            AppendLog($"{msg.Nickname}: {msg.Message}");
                        }
                    }
                    catch (Exception ex)
                    {
                        AppendLog($"클라이언트 수신 오류: {ex.Message}");
                    }
                    finally
                    {
                        client_stream?.Close();
                        client_client?.Close();
                        
                        client_Connected = false;
                        AppendLog("서버 연결이 종료되었습니다.");
                    }
                });

                m_thread.IsBackground = true;
                m_thread.Start();
            }
            catch (Exception ex)
            {
                AppendLog($"서버 접속 실패: {ex.Message}");
            }                  
        }
        private void StartServer()
        {
            try
            {
                m_listener = new TcpListener(IPAddress.Any, 7777); // 서버 접속 권한 설정하기
                m_listener.Start(); // 서버열기
                AppendLog("서버가 시작되었습니다. 클라이언트 접속을 기다립니다...");

                Thread m_thread = new Thread(() =>
                {
                    while (true)
                    {
                        //clientCounter<roomData.MaxPlayers
                        try
                        {
                            TcpClient client = m_listener.AcceptTcpClient();
                            int id = clientCounter++;

                            ClientInfo info = new ClientInfo
                            {
                                Id = id,
                                Client = client,
                                Stream = client.GetStream() //stream생성
                            };
                            // 클라이언트 처리 스레드 생성
                            Thread clientThread = new Thread(() => HandleClient(info));
                            info.Thread = clientThread; 

                            lock (clients)
                            {
                                clients.Add(info);
                            }

                            clientThread.IsBackground = true;
                            clientThread.Start();
                        }
                        catch (Exception ex)
                        {
                            AppendLog("클라이언트 접속 오류: " + ex.Message);
                            break;
                        }
                    }
                });
                m_thread.IsBackground = true;
                m_thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("서버 시작 실패: " + ex.Message);
            }
        }

        //클라이언트 개별처리
        private void HandleClient(ClientInfo info)
        {
            try
            {
                byte[] buffer = new byte[1024 * 4];
                while (true)
                {
                    int bytesRead = info.Stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    Packet packet = (Packet)PacketUtil.Deserialize(buffer);
                    HandlePacket(packet);
                }
            }
            catch (Exception ex)
            {
                AppendLog($"클라이언트 {info.Id} 처리 오류: {ex.Message}");
            }
            finally
            {
                lock (clients)
                {
                    clients.Remove(info);
                }
                info.Stream?.Close();
                info.Client?.Close();
                AppendLog($"클라이언트 {info.Id} 연결 종료");
            }
        }

   

        //서버가 client들한테 broadcast할때 사용
        private void HandlePacket(Packet packet)
        {
            switch ((PacketType)packet.Type)
            {
                case PacketType.Chat:
                    ChatMessage msg = (ChatMessage)packet.Data;
                    

                    Broadcast(packet);
                    break;
            }
        }

        // client에 메세지 뿌리기
        private void Broadcast(Packet packet)
        {
            byte[] bytes = PacketUtil.Serialize(packet);

            lock (clients)
            {
                foreach (var client in clients)
                {
                    try
                    {
                        client.Stream.Write(bytes, 0, bytes.Length);
                    }
                    catch (Exception ex)
                    {
                        AppendLog($"브로드캐스트 실패 (클라이언트 {client.Id}): {ex.Message}");
                    }
                }
            }
        }

        //현재 local ip얻기(UDP braodcast 때 사용)
        string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName()); //host이름을 기반으로 여러 주소를 가져옴(IPv4, IPv6)
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString(); // ← 예: "192.168.55.22"
                }
            }
            throw new Exception("로컬 IP를 찾을 수 없습니다!");
        }

        // 로그 메세지 출력 메서드
        private void AppendLog(string msg)
        {
            if (InvokeRequired)
                this.Invoke(new Action(() => txt_log.AppendText(msg + "\r\n")));
            else
                txt_log.AppendText(msg + "\r\n");
        }



        public ChatRoom(RoleType role, CreateRoomData roomData)
        {
            InitializeComponent();
             this.role = role;
            this.roomData = roomData;  // ← 필드에 저장
        }

        private void ChatRoom_Load(object sender, EventArgs e)
        {
            name.Text = roomData.Nickname;
            password.Text = roomData.Password;
            people.Text = roomData.MaxPlayers.ToString();

            // 서버생성과 client 생성
            if (roomData.MaxPlayers == 1)
            {
                // 참가 요청 처리
                ConnectClient();
            }
            else if (roomData.MaxPlayers >= 2)
            {
                // 방 생성 처리
                StartServer();
                Thread.Sleep(200);  // (짧게 대기) 서버 준비 시간 확보
                ConnectClient();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string text = txt_Input.Text.Trim();
            if (string.IsNullOrEmpty(text))  // 공백이면 return
                return;

            ChatMessage msg = new ChatMessage
            {
                Nickname = roomData.Nickname,
                Message = text
            };

            Packet packet = new Packet
            {
                Type = (int)PacketType.Chat,
                Data = msg
            };

            byte[] bytes = PacketUtil.Serialize(packet); // 직렬화(object를 매개변수로)
            client_stream.Write(bytes, 0, bytes.Length);      // 실제 전송

            txt_Input.Clear();
            txt_Input.Focus();
        }

        private void ChatRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (roomData.MaxPlayers == 1)
            {
                // 참가 요청 처리
                
            }
            else if (roomData.MaxPlayers >= 2)
            {
                // 방 생성 처리
                this.m_listener.Stop();

            }
        }

        //enter event
        private void txt_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEnter.PerformClick(); // 보내기 버튼 클릭 효과
                e.SuppressKeyPress = true; // 엔터 입력 소리/줄바꿈 방지
            }
        }
    }
}
