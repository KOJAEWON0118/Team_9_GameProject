namespace Game
{
    partial class Main
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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSingle = new Guna.UI2.WinForms.Guna2Button();
            this.btnMulti = new Guna.UI2.WinForms.Guna2Button();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(195, 55);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(447, 208);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnSingle
            // 
            this.btnSingle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSingle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSingle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSingle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSingle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSingle.ForeColor = System.Drawing.Color.White;
            this.btnSingle.Location = new System.Drawing.Point(195, 311);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(155, 59);
            this.btnSingle.TabIndex = 1;
            this.btnSingle.Text = "싱글 모드";
            this.btnSingle.Click += new System.EventHandler(this.btnSingle_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMulti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMulti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMulti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMulti.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMulti.ForeColor = System.Drawing.Color.White;
            this.btnMulti.Location = new System.Drawing.Point(487, 311);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(155, 59);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "멀티모드";
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("굴림", 30F);
            this.lbl.Location = new System.Drawing.Point(212, 139);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(416, 40);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "게임 이미지 들어갈 곳";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSingle);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "Main";
            this.Text = "_1_Main";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSingle;
        private Guna.UI2.WinForms.Guna2Button btnMulti;
        private System.Windows.Forms.Label lbl;
    }
}