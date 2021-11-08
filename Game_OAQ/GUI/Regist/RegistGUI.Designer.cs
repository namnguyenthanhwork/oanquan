
namespace GUI
{
    partial class RegistGUI
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
            this.Btn_Regist = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Pnl_Inp = new System.Windows.Forms.Panel();
            this.Btn_EyeRequiredPass = new System.Windows.Forms.Button();
            this.Btn_EyePass = new System.Windows.Forms.Button();
            this.Lbl_AlertRequiredPass = new System.Windows.Forms.Label();
            this.Lbl_RegistName = new System.Windows.Forms.Label();
            this.Lbl_AlertCharacterName = new System.Windows.Forms.Label();
            this.Lbl_RegistRequiredPass = new System.Windows.Forms.Label();
            this.Lbl_AlertPassword = new System.Windows.Forms.Label();
            this.Lbl_RegistPass = new System.Windows.Forms.Label();
            this.Lbl_AlertUsername = new System.Windows.Forms.Label();
            this.Lbl_RegistAcc = new System.Windows.Forms.Label();
            this.Tbx_RequiredPassword = new GUI.CustomTextbox();
            this.Tbx_Name = new GUI.CustomTextbox();
            this.Tbx_Password = new GUI.CustomTextbox();
            this.Tbx_Username = new GUI.CustomTextbox();
            this.Lbl_TitleRegist = new System.Windows.Forms.Label();
            this.Pbx_RegistBtnBg = new System.Windows.Forms.PictureBox();
            this.Pbx_TitleRegist = new System.Windows.Forms.PictureBox();
            this.Pbx_Bird = new System.Windows.Forms.PictureBox();
            this.Pbx_BackBtnBg = new System.Windows.Forms.PictureBox();
            this.Btn_Help = new System.Windows.Forms.Button();
            this.Pbx_Help = new System.Windows.Forms.PictureBox();
            this.Pnl_Inp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_RegistBtnBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_TitleRegist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BackBtnBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Help)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Regist
            // 
            this.Btn_Regist.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Regist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Regist.FlatAppearance.BorderSize = 0;
            this.Btn_Regist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Regist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Regist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regist.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regist.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_Regist.Location = new System.Drawing.Point(189, 518);
            this.Btn_Regist.Name = "Btn_Regist";
            this.Btn_Regist.Size = new System.Drawing.Size(209, 59);
            this.Btn_Regist.TabIndex = 4;
            this.Btn_Regist.TabStop = false;
            this.Btn_Regist.Text = "Đăng ký";
            this.Btn_Regist.UseVisualStyleBackColor = false;
            this.Btn_Regist.Click += new System.EventHandler(this.Btn_Regist_Click);
            this.Btn_Regist.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_Regist.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.Btn_Regist.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            this.Btn_Regist.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Back.FlatAppearance.BorderSize = 0;
            this.Btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Back.ForeColor = System.Drawing.Color.White;
            this.Btn_Back.Location = new System.Drawing.Point(432, 518);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(202, 59);
            this.Btn_Back.TabIndex = 5;
            this.Btn_Back.TabStop = false;
            this.Btn_Back.Text = "Quay lại";
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            this.Btn_Back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_Back.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.Btn_Back.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            this.Btn_Back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Pnl_Inp
            // 
            this.Pnl_Inp.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Inp.Controls.Add(this.Btn_EyeRequiredPass);
            this.Pnl_Inp.Controls.Add(this.Btn_EyePass);
            this.Pnl_Inp.Controls.Add(this.Lbl_AlertRequiredPass);
            this.Pnl_Inp.Controls.Add(this.Lbl_RegistName);
            this.Pnl_Inp.Controls.Add(this.Lbl_AlertCharacterName);
            this.Pnl_Inp.Controls.Add(this.Lbl_RegistRequiredPass);
            this.Pnl_Inp.Controls.Add(this.Lbl_AlertPassword);
            this.Pnl_Inp.Controls.Add(this.Lbl_RegistPass);
            this.Pnl_Inp.Controls.Add(this.Lbl_AlertUsername);
            this.Pnl_Inp.Controls.Add(this.Lbl_RegistAcc);
            this.Pnl_Inp.Controls.Add(this.Tbx_RequiredPassword);
            this.Pnl_Inp.Controls.Add(this.Tbx_Name);
            this.Pnl_Inp.Controls.Add(this.Tbx_Password);
            this.Pnl_Inp.Controls.Add(this.Tbx_Username);
            this.Pnl_Inp.Location = new System.Drawing.Point(169, 180);
            this.Pnl_Inp.Name = "Pnl_Inp";
            this.Pnl_Inp.Size = new System.Drawing.Size(499, 268);
            this.Pnl_Inp.TabIndex = 9;
            // 
            // Btn_EyeRequiredPass
            // 
            this.Btn_EyeRequiredPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_EyeRequiredPass.FlatAppearance.BorderSize = 0;
            this.Btn_EyeRequiredPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_EyeRequiredPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_EyeRequiredPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EyeRequiredPass.Location = new System.Drawing.Point(446, 150);
            this.Btn_EyeRequiredPass.Name = "Btn_EyeRequiredPass";
            this.Btn_EyeRequiredPass.Size = new System.Drawing.Size(35, 25);
            this.Btn_EyeRequiredPass.TabIndex = 19;
            this.Btn_EyeRequiredPass.UseVisualStyleBackColor = true;
            this.Btn_EyeRequiredPass.Click += new System.EventHandler(this.Btn_HideEye_Click);
            // 
            // Btn_EyePass
            // 
            this.Btn_EyePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_EyePass.FlatAppearance.BorderSize = 0;
            this.Btn_EyePass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_EyePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_EyePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EyePass.Location = new System.Drawing.Point(446, 86);
            this.Btn_EyePass.Name = "Btn_EyePass";
            this.Btn_EyePass.Size = new System.Drawing.Size(35, 25);
            this.Btn_EyePass.TabIndex = 19;
            this.Btn_EyePass.UseVisualStyleBackColor = true;
            this.Btn_EyePass.Click += new System.EventHandler(this.Btn_Eye_Click);
            // 
            // Lbl_AlertRequiredPass
            // 
            this.Lbl_AlertRequiredPass.AutoSize = true;
            this.Lbl_AlertRequiredPass.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_AlertRequiredPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_AlertRequiredPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_AlertRequiredPass.ForeColor = System.Drawing.Color.Aqua;
            this.Lbl_AlertRequiredPass.Location = new System.Drawing.Point(229, 186);
            this.Lbl_AlertRequiredPass.Name = "Lbl_AlertRequiredPass";
            this.Lbl_AlertRequiredPass.Size = new System.Drawing.Size(0, 17);
            this.Lbl_AlertRequiredPass.TabIndex = 22;
            // 
            // Lbl_RegistName
            // 
            this.Lbl_RegistName.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_RegistName.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RegistName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_RegistName.Location = new System.Drawing.Point(3, 208);
            this.Lbl_RegistName.Name = "Lbl_RegistName";
            this.Lbl_RegistName.Size = new System.Drawing.Size(203, 39);
            this.Lbl_RegistName.TabIndex = 7;
            this.Lbl_RegistName.Text = "Tên người chơi";
            this.Lbl_RegistName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_AlertCharacterName
            // 
            this.Lbl_AlertCharacterName.AutoSize = true;
            this.Lbl_AlertCharacterName.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_AlertCharacterName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_AlertCharacterName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_AlertCharacterName.ForeColor = System.Drawing.Color.Aqua;
            this.Lbl_AlertCharacterName.Location = new System.Drawing.Point(229, 252);
            this.Lbl_AlertCharacterName.Name = "Lbl_AlertCharacterName";
            this.Lbl_AlertCharacterName.Size = new System.Drawing.Size(0, 17);
            this.Lbl_AlertCharacterName.TabIndex = 21;
            // 
            // Lbl_RegistRequiredPass
            // 
            this.Lbl_RegistRequiredPass.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_RegistRequiredPass.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RegistRequiredPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Lbl_RegistRequiredPass.Location = new System.Drawing.Point(3, 138);
            this.Lbl_RegistRequiredPass.Name = "Lbl_RegistRequiredPass";
            this.Lbl_RegistRequiredPass.Size = new System.Drawing.Size(226, 52);
            this.Lbl_RegistRequiredPass.TabIndex = 6;
            this.Lbl_RegistRequiredPass.Text = "Nhập lại mật khẩu";
            this.Lbl_RegistRequiredPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_AlertPassword
            // 
            this.Lbl_AlertPassword.AutoSize = true;
            this.Lbl_AlertPassword.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_AlertPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_AlertPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_AlertPassword.ForeColor = System.Drawing.Color.Aqua;
            this.Lbl_AlertPassword.Location = new System.Drawing.Point(229, 122);
            this.Lbl_AlertPassword.Name = "Lbl_AlertPassword";
            this.Lbl_AlertPassword.Size = new System.Drawing.Size(0, 17);
            this.Lbl_AlertPassword.TabIndex = 20;
            // 
            // Lbl_RegistPass
            // 
            this.Lbl_RegistPass.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_RegistPass.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RegistPass.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_RegistPass.Location = new System.Drawing.Point(3, 74);
            this.Lbl_RegistPass.Name = "Lbl_RegistPass";
            this.Lbl_RegistPass.Size = new System.Drawing.Size(220, 56);
            this.Lbl_RegistPass.TabIndex = 5;
            this.Lbl_RegistPass.Text = "Nhập mật khẩu";
            this.Lbl_RegistPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_AlertUsername
            // 
            this.Lbl_AlertUsername.AutoSize = true;
            this.Lbl_AlertUsername.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_AlertUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_AlertUsername.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_AlertUsername.ForeColor = System.Drawing.Color.Aqua;
            this.Lbl_AlertUsername.Location = new System.Drawing.Point(229, 58);
            this.Lbl_AlertUsername.Name = "Lbl_AlertUsername";
            this.Lbl_AlertUsername.Size = new System.Drawing.Size(0, 17);
            this.Lbl_AlertUsername.TabIndex = 19;
            // 
            // Lbl_RegistAcc
            // 
            this.Lbl_RegistAcc.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_RegistAcc.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RegistAcc.ForeColor = System.Drawing.Color.Ivory;
            this.Lbl_RegistAcc.Location = new System.Drawing.Point(3, 2);
            this.Lbl_RegistAcc.Name = "Lbl_RegistAcc";
            this.Lbl_RegistAcc.Size = new System.Drawing.Size(220, 68);
            this.Lbl_RegistAcc.TabIndex = 4;
            this.Lbl_RegistAcc.Text = "Tên tài khoản";
            this.Lbl_RegistAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tbx_RequiredPassword
            // 
            this.Tbx_RequiredPassword.BackColor = System.Drawing.Color.White;
            this.Tbx_RequiredPassword.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tbx_RequiredPassword.ForeColor = System.Drawing.Color.White;
            this.Tbx_RequiredPassword.Location = new System.Drawing.Point(229, 142);
            this.Tbx_RequiredPassword.Name = "Tbx_RequiredPassword";
            this.Tbx_RequiredPassword.PasswordChar = '*';
            this.Tbx_RequiredPassword.PlaceHolder = null;
            this.Tbx_RequiredPassword.Size = new System.Drawing.Size(259, 37);
            this.Tbx_RequiredPassword.TabIndex = 2;
            this.Tbx_RequiredPassword.TextChanged += new System.EventHandler(this.Tbx_TextChanged);
            this.Tbx_RequiredPassword.Enter += new System.EventHandler(this.PasswordRequiredTbx_Enter);
            this.Tbx_RequiredPassword.Leave += new System.EventHandler(this.PasswordRequiredTbx_Leave);
            // 
            // Tbx_Name
            // 
            this.Tbx_Name.BackColor = System.Drawing.Color.White;
            this.Tbx_Name.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tbx_Name.ForeColor = System.Drawing.Color.White;
            this.Tbx_Name.Location = new System.Drawing.Point(229, 207);
            this.Tbx_Name.Name = "Tbx_Name";
            this.Tbx_Name.PlaceHolder = null;
            this.Tbx_Name.Size = new System.Drawing.Size(259, 37);
            this.Tbx_Name.TabIndex = 3;
            this.Tbx_Name.TextChanged += new System.EventHandler(this.Tbx_TextChanged);
            this.Tbx_Name.Enter += new System.EventHandler(this.NameTbx_Enter);
            this.Tbx_Name.Leave += new System.EventHandler(this.NameTbx_Leave);
            // 
            // Tbx_Password
            // 
            this.Tbx_Password.BackColor = System.Drawing.Color.White;
            this.Tbx_Password.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tbx_Password.ForeColor = System.Drawing.Color.White;
            this.Tbx_Password.Location = new System.Drawing.Point(229, 78);
            this.Tbx_Password.Name = "Tbx_Password";
            this.Tbx_Password.PasswordChar = '*';
            this.Tbx_Password.PlaceHolder = null;
            this.Tbx_Password.Size = new System.Drawing.Size(259, 37);
            this.Tbx_Password.TabIndex = 1;
            this.Tbx_Password.TextChanged += new System.EventHandler(this.Tbx_TextChanged);
            this.Tbx_Password.Enter += new System.EventHandler(this.PasswordTbx_Enter);
            this.Tbx_Password.Leave += new System.EventHandler(this.PasswordTbx_Leave);
            // 
            // Tbx_Username
            // 
            this.Tbx_Username.BackColor = System.Drawing.Color.White;
            this.Tbx_Username.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tbx_Username.ForeColor = System.Drawing.Color.Black;
            this.Tbx_Username.Location = new System.Drawing.Point(229, 14);
            this.Tbx_Username.Name = "Tbx_Username";
            this.Tbx_Username.PlaceHolder = null;
            this.Tbx_Username.Size = new System.Drawing.Size(259, 37);
            this.Tbx_Username.TabIndex = 0;
            this.Tbx_Username.TextChanged += new System.EventHandler(this.Tbx_TextChanged);
            this.Tbx_Username.Enter += new System.EventHandler(this.UsernameTbx_Enter);
            this.Tbx_Username.Leave += new System.EventHandler(this.UsernameTbx_Leave);
            // 
            // Lbl_TitleRegist
            // 
            this.Lbl_TitleRegist.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_TitleRegist.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleRegist.ForeColor = System.Drawing.Color.White;
            this.Lbl_TitleRegist.Location = new System.Drawing.Point(302, 61);
            this.Lbl_TitleRegist.Name = "Lbl_TitleRegist";
            this.Lbl_TitleRegist.Size = new System.Drawing.Size(212, 55);
            this.Lbl_TitleRegist.TabIndex = 14;
            this.Lbl_TitleRegist.Text = "Đăng ký";
            this.Lbl_TitleRegist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pbx_RegistBtnBg
            // 
            this.Pbx_RegistBtnBg.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_RegistBtnBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pbx_RegistBtnBg.Location = new System.Drawing.Point(154, 454);
            this.Pbx_RegistBtnBg.Name = "Pbx_RegistBtnBg";
            this.Pbx_RegistBtnBg.Size = new System.Drawing.Size(263, 179);
            this.Pbx_RegistBtnBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_RegistBtnBg.TabIndex = 15;
            this.Pbx_RegistBtnBg.TabStop = false;
            // 
            // Pbx_TitleRegist
            // 
            this.Pbx_TitleRegist.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_TitleRegist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pbx_TitleRegist.Location = new System.Drawing.Point(258, -14);
            this.Pbx_TitleRegist.Name = "Pbx_TitleRegist";
            this.Pbx_TitleRegist.Size = new System.Drawing.Size(289, 202);
            this.Pbx_TitleRegist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_TitleRegist.TabIndex = 13;
            this.Pbx_TitleRegist.TabStop = false;
            // 
            // Pbx_Bird
            // 
            this.Pbx_Bird.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Bird.Location = new System.Drawing.Point(380, 0);
            this.Pbx_Bird.Name = "Pbx_Bird";
            this.Pbx_Bird.Size = new System.Drawing.Size(70, 47);
            this.Pbx_Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Bird.TabIndex = 12;
            this.Pbx_Bird.TabStop = false;
            // 
            // Pbx_BackBtnBg
            // 
            this.Pbx_BackBtnBg.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_BackBtnBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pbx_BackBtnBg.Location = new System.Drawing.Point(413, 454);
            this.Pbx_BackBtnBg.Name = "Pbx_BackBtnBg";
            this.Pbx_BackBtnBg.Size = new System.Drawing.Size(255, 179);
            this.Pbx_BackBtnBg.TabIndex = 16;
            this.Pbx_BackBtnBg.TabStop = false;
            // 
            // Btn_Help
            // 
            this.Btn_Help.AutoSize = true;
            this.Btn_Help.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Help.FlatAppearance.BorderSize = 0;
            this.Btn_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Help.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Help.Location = new System.Drawing.Point(29, 72);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Size = new System.Drawing.Size(102, 34);
            this.Btn_Help.TabIndex = 17;
            this.Btn_Help.TabStop = false;
            this.Btn_Help.Text = "Hướng dẫn";
            this.Btn_Help.UseVisualStyleBackColor = false;
            this.Btn_Help.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Help_MouseClick);
            this.Btn_Help.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.Btn_Help.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            // 
            // Pbx_Help
            // 
            this.Pbx_Help.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pbx_Help.Location = new System.Drawing.Point(-7, -11);
            this.Pbx_Help.Name = "Pbx_Help";
            this.Pbx_Help.Size = new System.Drawing.Size(256, 131);
            this.Pbx_Help.TabIndex = 18;
            this.Pbx_Help.TabStop = false;
            // 
            // RegistGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 620);
            this.Controls.Add(this.Btn_Help);
            this.Controls.Add(this.Pbx_Help);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Regist);
            this.Controls.Add(this.Pbx_BackBtnBg);
            this.Controls.Add(this.Pbx_RegistBtnBg);
            this.Controls.Add(this.Pbx_Bird);
            this.Controls.Add(this.Lbl_TitleRegist);
            this.Controls.Add(this.Pbx_TitleRegist);
            this.Controls.Add(this.Pnl_Inp);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "RegistGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistGUI_FormClosing);
            this.Load += new System.EventHandler(this.RegistGUI_Load);
            this.Pnl_Inp.ResumeLayout(false);
            this.Pnl_Inp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_RegistBtnBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_TitleRegist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BackBtnBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_Regist;
        private System.Windows.Forms.Panel Pnl_Inp;
        private CustomTextbox Tbx_Name;
        private CustomTextbox Tbx_Password;
        private CustomTextbox Tbx_Username;
        private CustomTextbox Tbx_RequiredPassword;
        private System.Windows.Forms.Label Lbl_RegistName;
        private System.Windows.Forms.Label Lbl_RegistRequiredPass;
        private System.Windows.Forms.Label Lbl_RegistPass;
        private System.Windows.Forms.Label Lbl_RegistAcc;
        private System.Windows.Forms.Label Lbl_TitleRegist;
        private System.Windows.Forms.PictureBox Pbx_RegistBtnBg;
        private System.Windows.Forms.PictureBox Pbx_TitleRegist;
        private System.Windows.Forms.PictureBox Pbx_Bird;
        private System.Windows.Forms.PictureBox Pbx_BackBtnBg;
        private System.Windows.Forms.Button Btn_Help;
        private System.Windows.Forms.PictureBox Pbx_Help;
        private System.Windows.Forms.Label Lbl_AlertRequiredPass;
        private System.Windows.Forms.Label Lbl_AlertCharacterName;
        private System.Windows.Forms.Label Lbl_AlertPassword;
        private System.Windows.Forms.Label Lbl_AlertUsername;
        private System.Windows.Forms.Button Btn_EyePass;
        private System.Windows.Forms.Button Btn_EyeRequiredPass;
    }
}