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
    public partial class Set_Room : Form
    {
        public Set_Room()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Make_Click(object sender, EventArgs e)
        {
            string nickname = txtNickname.Text;
            string password = txtPassword.Text;

            // 최대 인원수 파싱
            bool isParsed = int.TryParse(txtMaxPlayers.Text, out int maxPlayers);

            // 유효성 검사
            if (!isParsed || maxPlayers < 2 || maxPlayers > 8)
            {
                MessageBox.Show("참여 인원 수는 2명 이상 8명 이하의 정수여야 합니다.", "입력 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaxPlayers.Clear();         // 값 비우기
                txtMaxPlayers.Focus();         // 커서 다시 위치
                return;                        // 실행 중단은 유지하되 UX를 자연스럽게
            }

            // 유효한 값일 경우
            CreateRoomData roomData = new CreateRoomData
            {
                Nickname = nickname,
                Password = password,
                MaxPlayers = maxPlayers
            };

            ChatRoom CR = new ChatRoom(Packet_Chat.RoleType.Server, roomData);
            this.Hide();
            CR.ShowDialog();
            this.Show();

            //비밀번호, 닉네임, 방 인원 제한수도 전달
        }
    }
}
