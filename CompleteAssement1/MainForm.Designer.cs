namespace CompleteAssement1
{
    partial class MainForm
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
            this.FarShootingBtn = new System.Windows.Forms.Button();
            this.ReloadingBtn = new System.Windows.Forms.Button();
            this.GunRotateBtn = new System.Windows.Forms.Button();
            this.ShootingBtn = new System.Windows.Forms.Button();
            this.Gamebgimz = new System.Windows.Forms.PictureBox();
            this.Retrybtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gamebgimz)).BeginInit();
            this.SuspendLayout();
            // 
            // FarShootingBtn
            // 
            this.FarShootingBtn.BackColor = System.Drawing.SystemColors.Info;
            this.FarShootingBtn.Location = new System.Drawing.Point(40, 348);
            this.FarShootingBtn.Name = "FarShootingBtn";
            this.FarShootingBtn.Size = new System.Drawing.Size(157, 56);
            this.FarShootingBtn.TabIndex = 2;
            this.FarShootingBtn.Text = "Shootng Far";
            this.FarShootingBtn.UseVisualStyleBackColor = false;
            this.FarShootingBtn.Click += new System.EventHandler(this.ShootAwayBt_Click);
            // 
            // ReloadingBtn
            // 
            this.ReloadingBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ReloadingBtn.Location = new System.Drawing.Point(37, 258);
            this.ReloadingBtn.Name = "ReloadingBtn";
            this.ReloadingBtn.Size = new System.Drawing.Size(160, 57);
            this.ReloadingBtn.TabIndex = 5;
            this.ReloadingBtn.Text = "Reloading Gun";
            this.ReloadingBtn.UseVisualStyleBackColor = false;
            this.ReloadingBtn.Click += new System.EventHandler(this.LoadBt_Click);
            // 
            // GunRotateBtn
            // 
            this.GunRotateBtn.BackColor = System.Drawing.SystemColors.Info;
            this.GunRotateBtn.Location = new System.Drawing.Point(40, 160);
            this.GunRotateBtn.Name = "GunRotateBtn";
            this.GunRotateBtn.Size = new System.Drawing.Size(157, 58);
            this.GunRotateBtn.TabIndex = 6;
            this.GunRotateBtn.Text = "Rotate Your Gun";
            this.GunRotateBtn.UseVisualStyleBackColor = false;
            this.GunRotateBtn.Click += new System.EventHandler(this.SpinBt_Click);
            // 
            // ShootingBtn
            // 
            this.ShootingBtn.BackColor = System.Drawing.SystemColors.Info;
            this.ShootingBtn.Location = new System.Drawing.Point(251, 348);
            this.ShootingBtn.Name = "ShootingBtn";
            this.ShootingBtn.Size = new System.Drawing.Size(189, 56);
            this.ShootingBtn.TabIndex = 1;
            this.ShootingBtn.Text = "Shoot Bullet";
            this.ShootingBtn.UseVisualStyleBackColor = false;
            this.ShootingBtn.Click += new System.EventHandler(this.GunShootBt_Click);
            // 
            // Gamebgimz
            // 
            this.Gamebgimz.Image = global::CompleteAssement1.Properties.Resources.GunBc;
            this.Gamebgimz.Location = new System.Drawing.Point(-1, -7);
            this.Gamebgimz.Name = "Gamebgimz";
            this.Gamebgimz.Size = new System.Drawing.Size(706, 445);
            this.Gamebgimz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gamebgimz.TabIndex = 0;
            this.Gamebgimz.TabStop = false;
            // 
            // Retrybtn
            // 
            this.Retrybtn.BackColor = System.Drawing.SystemColors.Info;
            this.Retrybtn.Location = new System.Drawing.Point(502, 348);
            this.Retrybtn.Name = "Retrybtn";
            this.Retrybtn.Size = new System.Drawing.Size(163, 59);
            this.Retrybtn.TabIndex = 7;
            this.Retrybtn.Text = "Retry Game";
            this.Retrybtn.UseVisualStyleBackColor = false;
            this.Retrybtn.Click += new System.EventHandler(this.PlayAgainBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.Retrybtn);
            this.Controls.Add(this.GunRotateBtn);
            this.Controls.Add(this.ReloadingBtn);
            this.Controls.Add(this.FarShootingBtn);
            this.Controls.Add(this.ShootingBtn);
            this.Controls.Add(this.Gamebgimz);
            this.Name = "MainForm";
            this.Text = " MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.Gamebgimz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Gamebgimz;
        private System.Windows.Forms.Button ShootingBtn;
        private System.Windows.Forms.Button FarShootingBtn;
        private System.Windows.Forms.Button ReloadingBtn;
        private System.Windows.Forms.Button GunRotateBtn;
        private System.Windows.Forms.Button Retrybtn;
    }
}

