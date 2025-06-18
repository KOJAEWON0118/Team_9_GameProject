using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Select_Single : Form
    {
        public Select_Single()
        {
            InitializeComponent();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            Game_Memory GM = new Game_Memory();

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            BrickBreaker.BrickBreaker bb = new BrickBreaker.BrickBreaker();
            bb.Show();
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            WindowsFormsApp2.Form1 ff = new WindowsFormsApp2.Form1();
            ff.Show();
        }
    }
}
