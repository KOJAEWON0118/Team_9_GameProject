﻿using System;
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
    public partial class Select_multi : Form
    {
        public Select_multi()
        {
            InitializeComponent();
        }

        private void Open_Lan_Click(object sender, EventArgs e)
        {
            Set_Room SR = new Set_Room();
            this.Hide();
            SR.ShowDialog();
            this.Show();
        }

        private void Join_Client_Click(object sender, EventArgs e)
        {
            Enter_Room ER = new Enter_Room();
            this.Hide();
            ER.ShowDialog();
            this.Show();
        }
    }
}
