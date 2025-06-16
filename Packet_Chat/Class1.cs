using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;



namespace Packet_Chat
{
    public enum RoleType
    {
        Server = 0,
        Client = 1
    }

    public enum PacketType
    {
        Chat = 0,
        StartGame = 1
        // 필요에 따라 추가 가능
    }

    public static class PacketUtil
    {
        public static byte[] Serialize(object o) // packet(type과 data)가 들어옴
        {
            using (MemoryStream ms = new MemoryStream()) //직렬화된 데이터를 메모리에 저장할 공간을 생성
            {
                BinaryFormatter bf = new BinaryFormatter();  //.NET의 객체 <-> 이진 데이터(byte[]) 변환기
                bf.Serialize(ms, o); // 객체 o를 MemoryStream에 이진 형식으로 기록
                return ms.ToArray(); //최종 결과: byte[] 형태로 바뀐 직렬화된 Packet
            }
        }

        public static object Deserialize(byte[] bt) //Packet.Type 값 (예: 0), Packet.Data 객체 (ChatMessage 같은 실제 내용물)이 들어있음
        {
            using (MemoryStream ms = new MemoryStream(bt))
            {
                BinaryFormatter bf = new BinaryFormatter(); //.NET의 객체 <-> 이진 데이터(byte[]) 변환기
                return bf.Deserialize(ms);
            }
        }
    }


    //전송 포멧
    [Serializable]
    public class Packet
    {
        public int Type;
        public object Data; // 전송에 필요한 모든 데이터를 object로 묶어서 처리한다.
    }


    [Serializable]
    public class CreateRoomData
    {
        public string Nickname;
        public int MaxPlayers;
        public string Password;
    }

    //실제 데이터 2
    [Serializable]
    public class ChatMessage
    {
        public string Nickname;
        public string Message;
    }

    public class Class1
    {
    }
}
