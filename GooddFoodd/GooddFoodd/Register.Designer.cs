namespace GooddFoodd
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.LoginFooter = new System.Windows.Forms.Label();
            this.LoginHeader = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.UID = new System.Windows.Forms.TextBox();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogin
            // 
            this.imgLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgLogin.Image")));
            this.imgLogin.Location = new System.Drawing.Point(333, 101);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(119, 99);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogin.TabIndex = 8;
            this.imgLogin.TabStop = false;
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
            this.LoginFooter.TabIndex = 7;
            this.LoginFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.LoginHeader.TabIndex = 6;
            this.LoginHeader.Text = "GOODD FOODD";
            this.LoginHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegisterBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(211, 421);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(363, 39);
            this.RegisterBtn.TabIndex = 12;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            this.RegisterBtn.Leave += new System.EventHandler(this.RegisterBtn_Leave);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(211, 320);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(363, 38);
            this.Password.TabIndex = 11;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // UID
            // 
            this.UID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UID.Location = new System.Drawing.Point(211, 272);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(363, 38);
            this.UID.TabIndex = 10;
            this.UID.Text = "Username";
            this.UID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UID.Click += new System.EventHandler(this.UID_Click);
            this.UID.Leave += new System.EventHandler(this.UID_Leave);
            // 
            // LabelLogin
            // 
            this.LabelLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(47)))), ((int)(((byte)(115)))));
            this.LabelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelLogin.Location = new System.Drawing.Point(210, 209);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(364, 47);
            this.LabelLogin.TabIndex = 9;
            this.LabelLogin.Text = "REGISTER";
            this.LabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(211, 368);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(363, 38);
            this.ConfirmPassword.TabIndex = 13;
            this.ConfirmPassword.Text = "Confirm Password";
            this.ConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConfirmPassword.Leave += new System.EventHandler(this.ConfirmPassword_Leave);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(211, 466);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(363, 39);
            this.LoginBtn.TabIndex = 14;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.imgLogin);
            this.Controls.Add(this.LoginFooter);
            this.Controls.Add(this.LoginHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.Label LoginFooter;
        private System.Windows.Forms.Label LoginHeader;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox UID;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Button LoginBtn;
    }
}