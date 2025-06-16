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
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.people = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ljlkj = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(12, 12);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(483, 349);
            this.txt_log.TabIndex = 0;
            // 
            // txt_Input
            // 
            this.txt_Input.Font = new System.Drawing.Font("굴림", 13F);
            this.txt_Input.Location = new System.Drawing.Point(12, 383);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(483, 27);
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
            this.btnEnter.Location = new System.Drawing.Point(516, 383);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(87, 29);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "보내기";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("굴림", 13F);
            this.name.Location = new System.Drawing.Point(674, 106);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 18);
            this.name.TabIndex = 3;
            this.name.Text = "name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("굴림", 13F);
            this.password.Location = new System.Drawing.Point(674, 143);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(89, 18);
            this.password.TabIndex = 4;
            this.password.Text = "password";
            // 
            // people
            // 
            this.people.AutoSize = true;
            this.people.Font = new System.Drawing.Font("굴림", 13F);
            this.people.Location = new System.Drawing.Point(674, 182);
            this.people.Name = "people";
            this.people.Size = new System.Drawing.Size(62, 18);
            this.people.TabIndex = 5;
            this.people.Text = "people";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(589, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "인원수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13F);
            this.label5.Location = new System.Drawing.Point(589, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "비밀번호";
            // 
            // ljlkj
            // 
            this.ljlkj.AutoSize = true;
            this.ljlkj.Font = new System.Drawing.Font("굴림", 13F);
            this.ljlkj.Location = new System.Drawing.Point(589, 106);
            this.ljlkj.Name = "ljlkj";
            this.ljlkj.Size = new System.Drawing.Size(44, 18);
            this.ljlkj.TabIndex = 6;
            this.ljlkj.Text = "이름";
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(661, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 41);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "종료";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ljlkj);
            this.Controls.Add(this.people);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.txt_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChatRoom";
            this.Text = "ChatRoom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatRoom_FormClosed);
            this.Load += new System.EventHandler(this.ChatRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.TextBox txt_Input;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label people;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ljlkj;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}