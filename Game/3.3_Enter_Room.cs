using Packet_Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.ConstrainedExecution;

namespace Game
{
    public partial class Enter_Room : Form
    {
        string serverIp = "", roomName = "", server_password = "", maxPlayers = "", port = "", count = "";
        public Enter_Room()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Enter_Room_Load(object sender, EventArgs e)
        {
            StartRoomDiscovery();
        }

        //udp 클라이언트를 열고  server를 기다리는 메소드
        private void StartRoomDiscovery()
        {
            new Thread(() =>
            {
                UdpClient udp = new UdpClient(50000);
                IPEndPoint remote = new IPEndPoint(IPAddress.Any, 0);

                while (true)
                {
                    try
                    {
                        byte[] data = udp.Receive(ref remote);
                        string msg = Encoding.UTF8.GetString(data);
                        if (msg.StartsWith("SERVER_IP:"))
                        {


                            string[] parts = msg.Split(';');
                            foreach (string part in parts)
                            {
                                if (part.StartsWith("SERVER_IP:"))
                                    serverIp = part.Substring("SERVER_IP:".Length);
                                else if (part.StartsWith("PORT:"))
                                    port = part.Substring("PORT:".Length);
                                else if (part.StartsWith("NAME:"))
                                    roomName = part.Substring("NAME:".Length);
                                else if (part.StartsWith("PWD:"))
                                    server_password = part.Substring("PWD:".Length);
                                else if (part.StartsWith("MAX:"))
                                    maxPlayers = part.Substring("MAX:".Length);
                                else if (part.StartsWith("Count:"))
                                    count = part.Substring("Count:".Length);
                            }

                            // ListView에 추가 (중복 체크 및 갱신은 필요에 따라 추가)
                            this.Invoke(new Action(() =>
                            {
                                var lvi = new ListViewItem(roomName + "의 게임방");      // 0번 컬럼: 방이름
                                lvi.SubItems.Add(count + "/" + maxPlayers);             // 1번 컬럼: 인원수
                                lvi.SubItems.Add(server_password);                             // 2번 컬럼: 비밀번호 (실제 값)
                                lvi.SubItems.Add(serverIp);                             // 3번 컬럼: IP
                                lvi.SubItems.Add(port);                                 // 4번 컬럼: 포트

                                // 중복 체크: 메인 컬럼(방이름), IP, 포트로 비교
                                bool exists = false;
                                foreach (ListViewItem item in RoomList.Items)
                                {
                                    if (item.Text == roomName + "의 게임방" &&
                                        item.SubItems[3].Text == serverIp &&
                                        item.SubItems[4].Text == port)
                                    {
                                        exists = true;
                                        // 필요하면 정보 갱신(업데이트)
                                        break;
                                    }
                                }
                                if (!exists)
                                    RoomList.Items.Add(lvi);
                            }));
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("UDP 수신 오류: " + ex.Message);
                    }
                }
                udp.Close(); // 종료 로직 추가 가능
            })
            { IsBackground = true }.Start();
        }

        private void RoomList_ItemActivate(object sender, EventArgs e)
        {
            if (RoomList.SelectedItems.Count == 0)
            {
                MessageBox.Show("방을 선택하세요!");
                return;
            }

            var selectedItem = RoomList.SelectedItems[0];

            string nickname = txtNickname.Text;
            string password = txtPassword.Text;


            string countInfo = selectedItem.SubItems[1].Text;   // "2/4"
            string roomPassword = selectedItem.SubItems[2].Text; // 실제 비밀번호
            string serverIp = selectedItem.SubItems[3].Text;
            string serverPort = selectedItem.SubItems[4].Text;

            // 현재/최대 인원 분리
            int cur = 0, max = 0;
            if (countInfo.Contains("/"))
            {
                var tokens = countInfo.Split('/');
                int.TryParse(tokens[0], out cur);
                int.TryParse(tokens[1], out max);
            }

            // 1. 비밀번호 체크
            if (!string.IsNullOrEmpty(roomPassword) && password != roomPassword)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다!");
                return;
            }
            // 2. 인원 초과 체크
            else if (cur >= max)
            {
                MessageBox.Show("방 정원이 다 찼습니다!");
                return;
            }
            // 3. 입장 가능
            else
            {
                CreateRoomData roomData = new CreateRoomData
                {
                    Nickname = nickname,
                    Password = password,
                    MaxPlayers = max
                };

                ChatRoom CR = new ChatRoom(Packet_Chat.RoleType.Client, roomData);
                this.Hide();
                CR.ShowDialog();
                this.Show();
            }
        }
    }
}
