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
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.RoomList = new System.Windows.Forms.ListView();
            this.RoomName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxPeople = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 32);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "이전으로";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(326, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "비밀번호(4자리) : ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("굴림", 13F);
            this.lbl1.Location = new System.Drawing.Point(12, 61);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(80, 18);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "닉네임 : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("굴림", 15F);
            this.txtPassword.Location = new System.Drawing.Point(488, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 30);
            this.txtPassword.TabIndex = 10;
            // 
            // txtNickname
            // 
            this.txtNickname.Font = new System.Drawing.Font("굴림", 15F);
            this.txtNickname.Location = new System.Drawing.Point(98, 56);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(200, 30);
            this.txtNickname.TabIndex = 8;
            // 
            // RoomList
            // 
            this.RoomList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RoomName,
            this.MaxPeople});
            this.RoomList.FullRowSelect = true;
            this.RoomList.HideSelection = false;
            this.RoomList.Location = new System.Drawing.Point(25, 123);
            this.RoomList.Name = "RoomList";
            this.RoomList.Size = new System.Drawing.Size(588, 287);
            this.RoomList.TabIndex = 16;
            this.RoomList.UseCompatibleStateImageBehavior = false;
            this.RoomList.View = System.Windows.Forms.View.Details;
            this.RoomList.ItemActivate += new System.EventHandler(this.RoomList_ItemActivate);
            // 
            // RoomName
            // 
            this.RoomName.Text = "방이름";
            this.RoomName.Width = 479;
            // 
            // MaxPeople
            // 
            this.MaxPeople.Text = "인원수";
            this.MaxPeople.Width = 503;
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(639, 366);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 44);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "방새로고침";
            // 
            // Enter_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.RoomList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNickname);
            this.Name = "Enter_Room";
            this.Text = "Enter_Room";
            this.Load += new System.EventHandler(this.Enter_Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.ListView RoomList;
        private System.Windows.Forms.ColumnHeader RoomName;
        private System.Windows.Forms.ColumnHeader MaxPeople;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}