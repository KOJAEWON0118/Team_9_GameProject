using Packet_Chat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Enter_Room : Form
    {
        public Enter_Room()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string nickname = txtNickname.Text;
            string password = txtPassword.Text;
            CreateRoomData roomData = new CreateRoomData
            {
                Nickname = nickname,
                Password = password,
                MaxPlayers = 1
            };
            ChatRoom CR = new ChatRoom(Packet_Chat.RoleType.Client, roomData);
            this.Hide();
            CR.ShowDialog();
            this.Show();
        }
    }
}
