namespace Game
{
    partial class ChatRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_log = new System.Windows.Forms.TextBox();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.btnEnter = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.Game4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Game3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Game2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Game1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Game4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(12, 285);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(407, 120);
            this.txt_log.TabIndex = 0;
            // 
            // txt_Input
            // 
            this.txt_Input.Font = new System.Drawing.Font("굴림", 13F);
            this.txt_Input.Location = new System.Drawing.Point(12, 411);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(407, 27);
            this.txt_Input.TabIndex = 1;
            this.txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Input_KeyDown);
            // 
            // btnEnter
            // 
            this.btnEnter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(442, 409);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(87, 29);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "보내기";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "종료";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Game4
            // 
            this.Game4.ImageRotate = 0F;
            this.Game4.Location = new System.Drawing.Point(572, 83);
            this.Game4.Name = "Game4";
            this.Game4.Size = new System.Drawing.Size(177, 157);
            this.Game4.TabIndex = 13;
            this.Game4.TabStop = false;
            // 
            // Game3
            // 
            this.Game3.Image = global::Game.Properties.Resources.Race_image;
            this.Game3.ImageRotate = 0F;
            this.Game3.Location = new System.Drawing.Point(389, 83);
            this.Game3.Name = "Game3";
            this.Game3.Size = new System.Drawing.Size(177, 157);
            this.Game3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Game3.TabIndex = 12;
            this.Game3.TabStop = false;
            // 
            // Game2
            // 
            this.Game2.Image = global::Game.Properties.Resources.Land_Battle;
            this.Game2.ImageRotate = 0F;
            this.Game2.Location = new System.Drawing.Point(206, 83);
            this.Game2.Name = "Game2";
            this.Game2.Size = new System.Drawing.Size(177, 157);
            this.Game2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Game2.TabIndex = 11;
            this.Game2.TabStop = false;
            // 
            // Game1
            // 
            this.Game1.Image = global::Game.Properties.Resources.Break_Block;
            this.Game1.ImageRotate = 0F;
            this.Game1.Location = new System.Drawing.Point(23, 83);
            this.Game1.Name = "Game1";
            this.Game1.Size = new System.Drawing.Size(177, 157);
            this.Game1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Game1.TabIndex = 10;
            this.Game1.TabStop = false;
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Game4);
            this.Controls.Add(this.Game3);
            this.Controls.Add(this.Game2);
            this.Controls.Add(this.Game1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.txt_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChatRoom";
            this.Text = "ChatRoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatRoom_FormClosed);
            this.Load += new System.EventHandler(this.ChatRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Game4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Game1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.TextBox txt_Input;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox Game1;
        private Guna.UI2.WinForms.Guna2PictureBox Game2;
        private Guna.UI2.WinForms.Guna2PictureBox Game3;
        private Guna.UI2.WinForms.Guna2PictureBox Game4;
    }
}