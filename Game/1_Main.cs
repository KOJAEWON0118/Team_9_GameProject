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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Select_multi Mt = new Select_multi();
            this.Hide();
            Mt.ShowDialog();
            this.Show();

        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            Select_Single Sm = new Select_Single();
            this.Hide();
            Sm.ShowDialog();
            this.Show();
        }
    }
}
