namespace Game
{
    partial class Select
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Open_Lan = new Guna.UI2.WinForms.Guna2Button();
            this.Open_Wan = new Guna.UI2.WinForms.Guna2Button();
            this.Join_Client = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Open_Lan
            // 
            this.Open_Lan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Open_Lan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Open_Lan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Open_Lan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Open_Lan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Open_Lan.ForeColor = System.Drawing.Color.White;
            this.Open_Lan.Location = new System.Drawing.Point(233, 98);
            this.Open_Lan.Name = "Open_Lan";
            this.Open_Lan.Size = new System.Drawing.Size(276, 53);
            this.Open_Lan.TabIndex = 0;
            this.Open_Lan.Text = "Lan 서버 열기";
            this.Open_Lan.Click += new System.EventHandler(this.Open_Lan_Click);
            // 
            // Open_Wan
            // 
            this.Open_Wan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Open_Wan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Open_Wan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Open_Wan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Open_Wan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Open_Wan.ForeColor = System.Drawing.Color.White;
            this.Open_Wan.Location = new System.Drawing.Point(233, 176);
            this.Open_Wan.Name = "Open_Wan";
            this.Open_Wan.Size = new System.Drawing.Size(276, 53);
            this.Open_Wan.TabIndex = 1;
            this.Open_Wan.Text = "Wan 서버 열기";
            // 
            // Join_Client
            // 
            this.Join_Client.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Join_Client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Join_Client.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Join_Client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Join_Client.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Join_Client.ForeColor = System.Drawing.Color.White;
            this.Join_Client.Location = new System.Drawing.Point(233, 261);
            this.Join_Client.Name = "Join_Client";
            this.Join_Client.Size = new System.Drawing.Size(276, 53);
            this.Join_Client.TabIndex = 2;
            this.Join_Client.Text = "Client 참여";
            this.Join_Client.Click += new System.EventHandler(this.Join_Client_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Join_Client);
            this.Controls.Add(this.Open_Wan);
            this.Controls.Add(this.Open_Lan);
            this.Name = "Select";
            this.Text = "Select";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button Open_Lan;
        private Guna.UI2.WinForms.Guna2Button Open_Wan;
        private Guna.UI2.WinForms.Guna2Button Join_Client;
    }
}

