namespace Game
{
    partial class Enter_Room
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
            this.btnJoin = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnJoin
            // 
            this.btnJoin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnJoin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnJoin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnJoin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnJoin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnJoin.ForeColor = System.Drawing.Color.White;
            this.btnJoin.Location = new System.Drawing.Point(357, 260);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(149, 44);
            this.btnJoin.TabIndex = 15;
            this.btnJoin.Text = "들어가기";
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(45, 44);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 44);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "이전으로";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(127, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "비밀번호(4자리) : ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl1.Location = new System.Drawing.Point(210, 144);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(90, 20);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "닉네임 : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("굴림", 15F);
            this.txtPassword.Location = new System.Drawing.Point(306, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.TabIndex = 10;
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("굴림", 15F);
            this.txtNickname.Location = new System.Drawing.Point(306, 141);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(200, 30);
            this.txtNickname.TabIndex = 8;
            // 
            // Enter_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNickname);
            this.Name = "Enter_Room";
            this.Text = "Enter_Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnJoin;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNickname;
    }
}