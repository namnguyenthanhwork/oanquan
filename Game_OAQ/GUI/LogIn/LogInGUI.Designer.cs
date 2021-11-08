
namespace GUI
{
    partial class LogInGUI
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
            this.Pnl_Btn = new System.Windows.Forms.Panel();
            this.Btn_Regist = new System.Windows.Forms.Button();
            this.Pbx_Regist = new System.Windows.Forms.PictureBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Pbx_Exit = new System.Windows.Forms.PictureBox();
            this.Btn_LogIn = new System.Windows.Forms.Button();
            this.Pbx_Login = new System.Windows.Forms.PictureBox();
            this.Pnl_Inp = new System.Windows.Forms.Panel();
            this.Btn_EyePass = new System.Windows.Forms.Button();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_Account = new System.Windows.Forms.Label();
            this.Pbx_Bird = new System.Windows.Forms.PictureBox();
            this.Pbx_Logo = new System.Windows.Forms.PictureBox();
            this.Lbl_Version = new System.Windows.Forms.Label();
            this.Tbx_Password = new GUI.CustomTextbox();
            this.Tbx_Username = new GUI.CustomTextbox();
            this.Pnl_Btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Regist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Login)).BeginInit();
            this.Pnl_Inp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Btn
            // 
            this.Pnl_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Btn.Controls.Add(this.Btn_Regist);
            this.Pnl_Btn.Controls.Add(this.Pbx_Regist);
            this.Pnl_Btn.Controls.Add(this.Btn_Exit);
            this.Pnl_Btn.Controls.Add(this.Pbx_Exit);
            this.Pnl_Btn.Controls.Add(this.Btn_LogIn);
            this.Pnl_Btn.Controls.Add(this.Pbx_Login);
            this.Pnl_Btn.Location = new System.Drawing.Point(12, 447);
            this.Pnl_Btn.Name = "Pnl_Btn";
            this.Pnl_Btn.Size = new System.Drawing.Size(650, 249);
            this.Pnl_Btn.TabIndex = 1;
            // 
            // Btn_Regist
            // 
            this.Btn_Regist.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Regist.FlatAppearance.BorderSize = 0;
            this.Btn_Regist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Regist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Regist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regist.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regist.ForeColor = System.Drawing.Color.White;
            this.Btn_Regist.Location = new System.Drawing.Point(145, 98);
            this.Btn_Regist.Name = "Btn_Regist";
            this.Btn_Regist.Size = new System.Drawing.Size(154, 40);
            this.Btn_Regist.TabIndex = 1;
            this.Btn_Regist.TabStop = false;
            this.Btn_Regist.Text = "Đăng ký";
            this.Btn_Regist.UseVisualStyleBackColor = false;
            this.Btn_Regist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegistBtn_MouseClick);
            this.Btn_Regist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_Regist.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.Btn_Regist.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            this.Btn_Regist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Pbx_Regist
            // 
            this.Pbx_Regist.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Regist.Location = new System.Drawing.Point(110, 88);
            this.Pbx_Regist.Name = "Pbx_Regist";
            this.Pbx_Regist.Size = new System.Drawing.Size(225, 58);
            this.Pbx_Regist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Regist.TabIndex = 12;
            this.Pbx_Regist.TabStop = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.ForeColor = System.Drawing.Color.White;
            this.Btn_Exit.Location = new System.Drawing.Point(144, 179);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(154, 32);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.TabStop = false;
            this.Btn_Exit.Text = "Thoát";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitBtn_MouseClick);
            this.Btn_Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_Exit.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.Btn_Exit.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            this.Btn_Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Pbx_Exit
            // 
            this.Pbx_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Exit.Location = new System.Drawing.Point(110, 166);
            this.Pbx_Exit.Name = "Pbx_Exit";
            this.Pbx_Exit.Size = new System.Drawing.Size(225, 56);
            this.Pbx_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Exit.TabIndex = 11;
            this.Pbx_Exit.TabStop = false;
            // 
            // Btn_LogIn
            // 
            this.Btn_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.Btn_LogIn.FlatAppearance.BorderSize = 0;
            this.Btn_LogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_LogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_LogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LogIn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogIn.ForeColor = System.Drawing.Color.White;
            this.Btn_LogIn.Location = new System.Drawing.Point(150, 21);
            this.Btn_LogIn.Name = "Btn_LogIn";
            this.Btn_LogIn.Size = new System.Drawing.Size(148, 40);
            this.Btn_LogIn.TabIndex = 0;
            this.Btn_LogIn.TabStop = false;
            this.Btn_LogIn.Text = "Đăng nhập";
            this.Btn_LogIn.UseVisualStyleBackColor = false;
            this.Btn_LogIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartBtn_MouseClick);
            this.Btn_LogIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_LogIn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.Btn_LogIn.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            this.Btn_LogIn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Pbx_Login
            // 
            this.Pbx_Login.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Login.Location = new System.Drawing.Point(110, 12);
            this.Pbx_Login.Name = "Pbx_Login";
            this.Pbx_Login.Size = new System.Drawing.Size(225, 58);
            this.Pbx_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Login.TabIndex = 10;
            this.Pbx_Login.TabStop = false;
            // 
            // Pnl_Inp
            // 
            this.Pnl_Inp.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Inp.Controls.Add(this.Btn_EyePass);
            this.Pnl_Inp.Controls.Add(this.Lbl_Password);
            this.Pnl_Inp.Controls.Add(this.Lbl_Account);
            this.Pnl_Inp.Controls.Add(this.Tbx_Password);
            this.Pnl_Inp.Controls.Add(this.Tbx_Username);
            this.Pnl_Inp.Location = new System.Drawing.Point(20, 278);
            this.Pnl_Inp.Name = "Pnl_Inp";
            this.Pnl_Inp.Size = new System.Drawing.Size(505, 138);
            this.Pnl_Inp.TabIndex = 0;
            // 
            // Btn_EyePass
            // 
            this.Btn_EyePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_EyePass.FlatAppearance.BorderSize = 0;
            this.Btn_EyePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_EyePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_EyePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EyePass.Location = new System.Drawing.Point(386, 88);
            this.Btn_EyePass.Name = "Btn_EyePass";
            this.Btn_EyePass.Size = new System.Drawing.Size(35, 25);
            this.Btn_EyePass.TabIndex = 20;
            this.Btn_EyePass.TabStop = false;
            this.Btn_EyePass.UseVisualStyleBackColor = true;
            this.Btn_EyePass.Click += new System.EventHandler(this.Btn_EyePass_Click);
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_Password.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Password.Location = new System.Drawing.Point(29, 84);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(117, 29);
            this.Lbl_Password.TabIndex = 3;
            this.Lbl_Password.Text = "Mật khẩu";
            this.Lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Account
            // 
            this.Lbl_Account.AutoSize = true;
            this.Lbl_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_Account.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Account.Location = new System.Drawing.Point(28, 24);
            this.Lbl_Account.Name = "Lbl_Account";
            this.Lbl_Account.Size = new System.Drawing.Size(128, 29);
            this.Lbl_Account.TabIndex = 0;
            this.Lbl_Account.Text = "Tài khoản";
            this.Lbl_Account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pbx_Bird
            // 
            this.Pbx_Bird.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Bird.Location = new System.Drawing.Point(20, -16);
            this.Pbx_Bird.Name = "Pbx_Bird";
            this.Pbx_Bird.Size = new System.Drawing.Size(132, 113);
            this.Pbx_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Bird.TabIndex = 7;
            this.Pbx_Bird.TabStop = false;
            // 
            // Pbx_Logo
            // 
            this.Pbx_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Logo.Location = new System.Drawing.Point(1036, 3);
            this.Pbx_Logo.Name = "Pbx_Logo";
            this.Pbx_Logo.Size = new System.Drawing.Size(192, 199);
            this.Pbx_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Logo.TabIndex = 8;
            this.Pbx_Logo.TabStop = false;
            // 
            // Lbl_Version
            // 
            this.Lbl_Version.AutoSize = true;
            this.Lbl_Version.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Version.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Lbl_Version.Location = new System.Drawing.Point(1089, 738);
            this.Lbl_Version.Name = "Lbl_Version";
            this.Lbl_Version.Size = new System.Drawing.Size(139, 27);
            this.Lbl_Version.TabIndex = 9;
            this.Lbl_Version.Text = "Version 1.0.0";
            this.Lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tbx_Password
            // 
            this.Tbx_Password.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Password.Location = new System.Drawing.Point(163, 83);
            this.Tbx_Password.Name = "Tbx_Password";
            this.Tbx_Password.PasswordChar = '*';
            this.Tbx_Password.PlaceHolder = null;
            this.Tbx_Password.Size = new System.Drawing.Size(273, 41);
            this.Tbx_Password.TabIndex = 1;
            this.Tbx_Password.TextChanged += new System.EventHandler(this.Tbx_TextChanged);
            this.Tbx_Password.Enter += new System.EventHandler(this.PasswordTbx_Enter);
            this.Tbx_Password.Leave += new System.EventHandler(this.PasswordTbx_Leave);
            // 
            // Tbx_Username
            // 
            this.Tbx_Username.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Username.Location = new System.Drawing.Point(163, 20);
            this.Tbx_Username.Name = "Tbx_Username";
            this.Tbx_Username.PlaceHolder = null;
            this.Tbx_Username.Size = new System.Drawing.Size(273, 41);
            this.Tbx_Username.TabIndex = 0;
            this.Tbx_Username.TextChanged += new System.EventHandler(this.Tbx_TextChanged);
            this.Tbx_Username.Enter += new System.EventHandler(this.UsernameTbx_Enter);
            this.Tbx_Username.Leave += new System.EventHandler(this.UsernameTbx_Leave);
            // 
            // LogInGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 774);
            this.Controls.Add(this.Lbl_Version);
            this.Controls.Add(this.Pbx_Logo);
            this.Controls.Add(this.Pbx_Bird);
            this.Controls.Add(this.Pnl_Inp);
            this.Controls.Add(this.Pnl_Btn);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LogInGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "LogInGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInGUI_FormClosing);
            this.Load += new System.EventHandler(this.LogInGUI_Load);
            this.Pnl_Btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Regist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Login)).EndInit();
            this.Pnl_Inp.ResumeLayout(false);
            this.Pnl_Inp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Btn;
        private System.Windows.Forms.Button Btn_LogIn;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Regist;
        private System.Windows.Forms.Panel Pnl_Inp;
        private CustomTextbox Tbx_Password;
        private CustomTextbox Tbx_Username;
        private System.Windows.Forms.PictureBox Pbx_Bird;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_Account;
        private System.Windows.Forms.PictureBox Pbx_Logo;
        private System.Windows.Forms.PictureBox Pbx_Login;
        private System.Windows.Forms.Label Lbl_Version;
        private System.Windows.Forms.PictureBox Pbx_Regist;
        private System.Windows.Forms.PictureBox Pbx_Exit;
        private System.Windows.Forms.Button Btn_EyePass;
    }
}

