namespace GooddFoodd
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginHeader = new System.Windows.Forms.Label();
            this.LoginFooter = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.UID = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.AlertPanel = new System.Windows.Forms.Panel();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.User = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.AlertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginHeader
            // 
            this.LoginHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.LoginHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHeader.Location = new System.Drawing.Point(0, 0);
            this.LoginHeader.Name = "LoginHeader";
            this.LoginHeader.Size = new System.Drawing.Size(784, 75);
            this.LoginHeader.TabIndex = 0;
            this.LoginHeader.Text = "GOODD FOODD";
            this.LoginHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginFooter
            // 
            this.LoginFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.LoginFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFooter.Location = new System.Drawing.Point(0, 532);
            this.LoginFooter.Name = "LoginFooter";
            this.LoginFooter.Size = new System.Drawing.Size(784, 28);
            this.LoginFooter.TabIndex = 1;
            this.LoginFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelLogin
            // 
            this.LabelLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(47)))), ((int)(((byte)(115)))));
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelLogin.Location = new System.Drawing.Point(210, 274);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(364, 47);
            this.LabelLogin.TabIndex = 2;
            this.LabelLogin.Text = "LOGIN";
            this.LabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UID
            // 
            this.UID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UID.Location = new System.Drawing.Point(211, 326);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(363, 38);
            this.UID.TabIndex = 3;
            this.UID.Text = "Username";
            this.UID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UID_MouseClick);
            this.UID.Leave += new System.EventHandler(this.UID_Leave);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(211, 370);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(363, 38);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // imgLogin
            // 
            this.imgLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgLogin.Image")));
            this.imgLogin.Location = new System.Drawing.Point(294, 87);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(196, 172);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogin.TabIndex = 5;
            this.imgLogin.TabStop = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(211, 445);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(182, 39);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegisterBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(399, 445);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(175, 39);
            this.RegisterBtn.TabIndex = 7;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // AlertPanel
            // 
            this.AlertPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AlertPanel.Controls.Add(this.AlertLabel);
            this.AlertPanel.Controls.Add(this.pictureBox1);
            this.AlertPanel.Location = new System.Drawing.Point(212, 488);
            this.AlertPanel.Name = "AlertPanel";
            this.AlertPanel.Size = new System.Drawing.Size(361, 39);
            this.AlertPanel.TabIndex = 11;
            this.AlertPanel.Visible = false;
            // 
            // AlertLabel
            // 
            this.AlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertLabel.Location = new System.Drawing.Point(47, 4);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(305, 31);
            this.AlertLabel.TabIndex = 1;
            this.AlertLabel.Tag = "";
            this.AlertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(211, 415);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(140, 24);
            this.Admin.TabIndex = 12;
            this.Admin.TabStop = true;
            this.Admin.Text = "ADMIN";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Leave += new System.EventHandler(this.Admin_Leave);
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(434, 415);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(140, 24);
            this.User.TabIndex = 13;
            this.User.TabStop = true;
            this.User.Text = "USER";
            this.User.UseVisualStyleBackColor = true;
            this.User.Leave += new System.EventHandler(this.Admin_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.AlertPanel);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.imgLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.LoginFooter);
            this.Controls.Add(this.LoginHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GooddFoodd";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.AlertPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginHeader;
        private System.Windows.Forms.Label LoginFooter;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox UID;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Panel AlertPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.RadioButton User;
    }
}

