namespace Game
{
    partial class Set_Room
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
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtMaxPlayers = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Back = new Guna.UI2.WinForms.Guna2Button();
            this.Make = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("굴림", 15F);
            this.txtNickname.Location = new System.Drawing.Point(288, 127);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(200, 30);
            this.txtNickname.TabIndex = 0;
            // 
            // txtMaxPlayers
            // 
            this.txtMaxPlayers.Font = new System.Drawing.Font("굴림", 15F);
            this.txtMaxPlayers.Location = new System.Drawing.Point(288, 176);
            this.txtMaxPlayers.Name = "txtMaxPlayers";
            this.txtMaxPlayers.Size = new System.Drawing.Size(200, 30);
            this.txtMaxPlayers.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("굴림", 15F);
            this.txtPassword.Location = new System.Drawing.Point(288, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("굴림", 15F);
            this.lbl1.Location = new System.Drawing.Point(192, 130);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(90, 20);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "닉네임 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(193, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "참여인원";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F);
            this.label3.Location = new System.Drawing.Point(109, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "비밀번호(4자리) : ";
            // 
            // Back
            // 
            this.Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(27, 30);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(149, 44);
            this.Back.TabIndex = 6;
            this.Back.Text = "이전으로";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Make
            // 
            this.Make.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Make.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Make.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Make.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Make.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Make.ForeColor = System.Drawing.Color.White;
            this.Make.Location = new System.Drawing.Point(339, 291);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(149, 44);
            this.Make.TabIndex = 7;
            this.Make.Text = "만들기";
            this.Make.Click += new System.EventHandler(this.Make_Click);
            // 
            // Set_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Make);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMaxPlayers);
            this.Controls.Add(this.txtNickname);
            this.Name = "Set_Room";
            this.Text = "Set_Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtMaxPlayers;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button Back;
        private Guna.UI2.WinForms.Guna2Button Make;
    }
}