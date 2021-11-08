using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Ultils;
using GUI.Ultils.FormAni;
using GUI.MessageBoxes;
namespace GUI
{
    public partial class RegistGUI : Form
    {
        private static int USERNAME_MAX_LENGTH = 20;
        private static int USERNAME_MIN_LENGTH = 8;
        private static int PASSWORD_MAX_LENGTH = 20;
        private static int PASSWORD_MIN_LENGTH = 8;
        private static int NAME_MAX_LENGTH = 20;
        private static int NAME_MIN_LENGTH = 8;
        public static Button Btn_HelpTemp;
        private bool flagEyePass = false;
        private bool flagEyeRequiredPass = false;
        public RegistGUI() => InitializeComponent();
        // use for smooth screen
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;
                return createParams;
            }
        }

        private void RegistGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            DoubleBuffered = true;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Btn_Regist.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Back.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Help.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_EyePass.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_EyeRequiredPass.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);

            Ultilities.ControlUltils.changeParent(Lbl_TitleRegist, Pbx_TitleRegist, new Point(44, 75));
            Ultilities.ControlUltils.changeParent(Btn_Help, Pbx_Help, new Point(34, 85));
            Ultilities.ControlUltils.changeParent(Btn_EyePass, Tbx_Password,
                new Point(Tbx_Password.Width - Btn_EyePass.Width - 10, 5));
            Ultilities.ControlUltils.changeParent(Btn_EyeRequiredPass, Tbx_RequiredPassword,
                new Point(Tbx_RequiredPassword.Width - Btn_EyeRequiredPass.Width - 10, 5));
            Ultilities.ControlUltils.changeParent(Btn_Back, Pbx_BackBtnBg,
                new Point((Pbx_BackBtnBg.Width - Btn_Back.Width) / 2 - 10, (Pbx_BackBtnBg.Height - Btn_Back.Height) / 2 + 5));
            Ultilities.ControlUltils.changeParent(Btn_Regist, Pbx_RegistBtnBg,
               new Point((Pbx_RegistBtnBg.Width - Btn_Regist.Width) / 2 + 10, (Pbx_RegistBtnBg.Height - Btn_Regist.Height) / 2 + 5));

            Tbx_Username.PlaceHolder = StringManagement.UsernamePlaceHolder;
            Tbx_Password.PlaceHolder = StringManagement.PasswordPlaceHolder;
            Tbx_RequiredPassword.PlaceHolder = StringManagement.RequiredPasswordPlaceHolder;
            Tbx_Name.PlaceHolder = StringManagement.NamePlaceHolder;

            Tbx_Username.changePH_Leave();
            Tbx_Password.changePH_Leave();
            Tbx_RequiredPassword.changePH_Leave();
            Tbx_Name.changePH_Leave();
            Tbx_Username.Focus();

            Btn_HelpTemp = Btn_Help;
            Program.runAnimation(AnimationState.SINK, this);
        }
        private void loadImages()
        {
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\background.jpg");
            Pbx_Bird.Image = Ultilities.ControlUltils.getImageFromFile(@"Regist\bird.gif");
            Pbx_TitleRegist.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\banner.png");
            Pbx_RegistBtnBg.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\left.png");
            Pbx_BackBtnBg.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\right.png");
            Pbx_Help.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Result\back.png");
            Btn_EyePass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eyeHidden.png");
            Btn_EyeRequiredPass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eyeHidden.png");
        }

        private void Btn_Regist_Click(object sender, EventArgs e)
        {

            if (Program.Dic_Forms.ContainsKey(FormKind.REGIST_HELP))
            {
                Program.Dic_Forms[FormKind.REGIST_HELP].Close();
                Program.Dic_Forms.Remove(FormKind.REGIST_HELP);
            }
            AccountBLL accountBLL = (AccountBLL)Program.Dic_Bundles[StringManagement.KeyDatas.AccountBLL_Key];
            CharacterBLL characterBLL = (CharacterBLL)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterBLL_Key];
            bool flag = true;
            if (accountBLL.isExistUsername(Tbx_Username.Text))
            {
                Lbl_AlertUsername.Text = StringManagement.Alert_ExistUsername;
                flag = false;
            }
            if (Tbx_Username.Text.Length < USERNAME_MIN_LENGTH ||
                Tbx_Username.Text.Length > USERNAME_MAX_LENGTH)
            {
                Lbl_AlertUsername.Text = StringManagement.Alert_UserNameLength;
                flag = false;
            }
            if (characterBLL.isExitName(Tbx_Name.Text))
            {
                Lbl_AlertCharacterName.Text = StringManagement.Alert_ExistName;
                flag = false;
            }
            if (Tbx_Password.Text.Length < PASSWORD_MIN_LENGTH ||
                Tbx_Password.Text.Length > PASSWORD_MAX_LENGTH)
            {
                Lbl_AlertPassword.Text = StringManagement.Alert_PasswordLength;
                flag = false;
                flag = false;
            }
            if (Tbx_Name.Text.Length < NAME_MIN_LENGTH || Tbx_Name.Text.Length > NAME_MAX_LENGTH)
            {
                Lbl_AlertCharacterName.Text = StringManagement.Alert_NameLength;
                flag = false;
            }
            if (Tbx_Password.Text != Tbx_RequiredPassword.Text)
            {
                Lbl_AlertPassword.Text = StringManagement.Alert_NotMatchPassword;
                flag = false;
            }
            if (Tbx_Username.Text == String.Empty || Tbx_Username.Text ==
                StringManagement.UsernamePlaceHolder)
            {
                Lbl_AlertUsername.Text = StringManagement.Alert_EmtyData;
                flag = false;
            }
            if (Tbx_Password.Text == String.Empty || Tbx_Password.Text ==
                StringManagement.PasswordPlaceHolder)
            {
                Lbl_AlertPassword.Text = StringManagement.Alert_EmtyData;
                flag = false;
            }
            if (Tbx_RequiredPassword.Text == String.Empty ||
                Tbx_RequiredPassword.Text == StringManagement.RequiredPasswordPlaceHolder)
            {
                Lbl_AlertRequiredPass.Text = StringManagement.Alert_EmtyData;
                flag = false;
            }
            if (Tbx_Name.Text == String.Empty || Tbx_Name.Text == StringManagement.NamePlaceHolder)
            {
                Lbl_AlertCharacterName.Text = StringManagement.Alert_EmtyData;
                flag = false;
            }
            if (!flag)
                return;
            accountBLL.saveAccountDTO(new AccountDTO(Tbx_Username.Text, Tbx_Password.Text));
            characterBLL.saveCharacterDTO(new CharacterDTO(Tbx_Username.Text, Tbx_Name.Text, 0));
            Tbx_Username.Text = Tbx_Password.Text = Tbx_RequiredPassword.Text = Tbx_Name.Text = string.Empty;
            Tbx_Username.changePH_Leave();
            Tbx_Password.changePH_Leave();
            Tbx_RequiredPassword.changePH_Leave();
            Tbx_Name.changePH_Leave();
            Tbx_Password.PasswordChar = Tbx_RequiredPassword.PasswordChar = '\0';
            Btn_EyePass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eyeHidden.png");
            Btn_EyeRequiredPass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eyeHidden.png");
            flagEyePass = flagEyeRequiredPass = false;
            Tbx_Username.Focus();
            Program.changeForm(FormKind.OK_MESSAGE_BOX, new OkMessageBox(),
                            StringManagement.MessTitle, StringManagement.SuccessfulRegist_Mess);

        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            Btn_Back.Enabled = false;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.LOG_IN, new LogInGUI());
            Btn_Back.Enabled = false;
            if (Program.Dic_Forms.ContainsKey(FormKind.REGIST_HELP))
            {
                Program.Dic_Forms[FormKind.REGIST_HELP].Close();
                Program.Dic_Forms.Remove(FormKind.REGIST_HELP);
            }
        }

        //change placeholder textboxes events 
        private void UsernameTbx_Enter(object sender, EventArgs e)
        {
            Lbl_AlertUsername.Text = String.Empty;
            ((CustomTextbox)sender).changePH_Enter();
        }

        private void UsernameTbx_Leave(object sender, EventArgs e) =>
           ((CustomTextbox)sender).changePH_Leave();

        private void PasswordTbx_Enter(object sender, EventArgs e)
        {
            if (!flagEyePass)
                Tbx_Password.PasswordChar = '*';
            Lbl_AlertPassword.Text = String.Empty;
            ((CustomTextbox)sender).changePH_Enter();
        }

        private void PasswordTbx_Leave(object sender, EventArgs e)
        {
            ((CustomTextbox)sender).changePH_Leave();
            if (Tbx_Password.Text.Equals(StringManagement.PasswordPlaceHolder) && flagEyePass)
                Tbx_Password.PasswordChar = '\0';
        }

        private void PasswordRequiredTbx_Enter(object sender, EventArgs e)
        {
            if (!flagEyeRequiredPass)
                Tbx_RequiredPassword.PasswordChar = '*';
            Lbl_AlertRequiredPass.Text = String.Empty;
            ((CustomTextbox)sender).changePH_Enter();
        }

        private void PasswordRequiredTbx_Leave(object sender, EventArgs e)
        {
            ((CustomTextbox)sender).changePH_Leave();
            if (Tbx_RequiredPassword.Text.Equals(StringManagement.RequiredPasswordPlaceHolder) && flagEyeRequiredPass)
                Tbx_RequiredPassword.PasswordChar = '\0';
        }
        private void NameTbx_Enter(object sender, EventArgs e)
        {
            Lbl_AlertCharacterName.Text = String.Empty;
            ((CustomTextbox)sender).changePH_Enter();
        }

        private void NameTbx_Leave(object sender, EventArgs e) => ((CustomTextbox)sender).changePH_Leave();

        //change background color when mouse hover
        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[Ultils.Enum.SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Blue;
        }
        //change background color when mouse leave
        private void Btn_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.White;

        private void Btn_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();

        private void Btn_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();

        private void Tbx_TextChanged(object sender, EventArgs e) =>
            ((CustomTextbox)sender).setRule();

        private void Btn_Help_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Help.Enabled = false;
            Program.changeForm(FormKind.REGIST_HELP, new Regist.RegistHelpGUI());
            Program.Dic_Forms[FormKind.REGIST_HELP].Location = Location;
        }

        private void Btn_Eye_Click(object sender, EventArgs e)
        {

            if (Tbx_Password.PasswordChar == '*')
            {
                flagEyePass = true;
                Tbx_Password.PasswordChar = '\0';
                Btn_EyePass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eye.png");
            }
            else
            {
                flagEyePass = false;
                Tbx_Password.PasswordChar = '*';
                Btn_EyePass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eyeHidden.png");
            }
        }

        private void Btn_HideEye_Click(object sender, EventArgs e)
        {
            if (Tbx_RequiredPassword.PasswordChar == '*')
            {
                flagEyeRequiredPass = true;
                Tbx_RequiredPassword.PasswordChar = '\0';
                Btn_EyeRequiredPass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eye.png");
            }
            else
            {
                flagEyeRequiredPass = false;
                Tbx_RequiredPassword.PasswordChar = '*';
                Btn_EyeRequiredPass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eyeHidden.png");
            }
        }

        private void RegistGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.List_HiddenForms.Count <= 0)
            {
                Program.changeForm(FormKind.YES_NO_MESSAGE_BOX, new YesNoMessageBox(),
                StringManagement.MessTitle, StringManagement.Leave_Mess);
                if (((YesNoMessageBox)Program.Dic_Forms[FormKind.YES_NO_MESSAGE_BOX]).Flag)
                    Application.ExitThread();
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
