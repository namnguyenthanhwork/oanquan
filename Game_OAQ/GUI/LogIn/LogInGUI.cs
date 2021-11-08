using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Ultils;
using GUI.MessageBoxes;
namespace GUI
{

    //represents for the log in screen of the game 
    public partial class LogInGUI : Form
    {
        private bool flagEye = false;
        public LogInGUI() =>
            InitializeComponent();
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
        //initialize data when form loads
        private void LogInGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            DoubleBuffered = true;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Btn_LogIn.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Regist.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Exit.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_EyePass.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Ultilities.ControlUltils.changeParent(Btn_LogIn, Pbx_Login,
                new Point((Pbx_Login.Width - Btn_LogIn.Width) / 2, (Pbx_Login.Height - Btn_LogIn.Height) / 2));
            Ultilities.ControlUltils.changeParent(Btn_Regist, Pbx_Regist,
             new Point((Pbx_Regist.Width - Btn_Regist.Width) / 2, (Pbx_Regist.Height - Btn_Regist.Height) / 2));
            Ultilities.ControlUltils.changeParent(Btn_Exit, Pbx_Exit,
             new Point((Pbx_Exit.Width - Btn_Exit.Width) / 2, (Pbx_Exit.Height - Btn_Exit.Height) / 2));
            Ultilities.ControlUltils.changeParent(Btn_EyePass, Tbx_Password,
               new Point(Tbx_Password.Width - Btn_EyePass.Width - 10, 5));

            Tbx_Username.PlaceHolder = StringManagement.UsernamePlaceHolder;
            Tbx_Password.PlaceHolder = StringManagement.PasswordPlaceHolder;

            Program.runAnimation(AnimationState.FLOAT, this);

            Tbx_Username.changePH_Leave();
            Tbx_Username.changePH_Leave();
            Tbx_Password.changePH_Leave();
            Tbx_Username.Focus();

        }

        private void loadImages()
        {
            Pbx_Regist.Image = Ultilities.ControlUltils.getImageFromFile(@"LogIn\button1.png");
            Pbx_Exit.Image = Ultilities.ControlUltils.getImageFromFile(@"LogIn\button1.png");
            Pbx_Login.Image = Ultilities.ControlUltils.getImageFromFile(@"LogIn\button1.png");
            Pbx_Logo.Image = Ultilities.ControlUltils.getImageFromFile(@"LogIn\logo.png");
            Pbx_Bird.Image = Ultilities.ControlUltils.getImageFromFile(@"LogIn\bird.gif");
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"LogIn\background.jpg");
            Btn_EyePass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eyeHidden.png");
        }
        //event occur when player click log in button
        private void StartBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (Tbx_Username.Text.Equals(StringManagement.UsernamePlaceHolder) ||
                 Tbx_Password.Text.Equals(StringManagement.PasswordPlaceHolder))
                Program.changeForm(FormKind.OK_MESSAGE_BOX, new OkMessageBox(),
                    StringManagement.MessTitle, StringManagement.Alert_EmtyData);
            else
            {
                if (((AccountBLL)Program.Dic_Bundles[StringManagement.KeyDatas.AccountBLL_Key]).isExistAccount(
                        new AccountDTO(Tbx_Username.Text, Tbx_Password.Text)))// account is correct 
                {
                    Btn_LogIn.Enabled = false;
                    Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key] =
                       ((CharacterBLL)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterBLL_Key]).getCharacterDTO(Tbx_Username.Text);
                    Program.runAnimation(AnimationState.DISAPPEAR, this);
                    Program.changeForm(FormKind.START, new StartGUI());

                }
                else// account is incorrect 
                    Program.changeForm(FormKind.OK_MESSAGE_BOX, new OkMessageBox(),
                            StringManagement.MessTitle, StringManagement.FailLogIn_Mess);

            }
        }

        // event occurs when player want to exit
        private void ExitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Program.changeForm(FormKind.YES_NO_MESSAGE_BOX, new YesNoMessageBox(),
           StringManagement.MessTitle, StringManagement.Leave_Mess);
            if (((YesNoMessageBox)Program.Dic_Forms[FormKind.YES_NO_MESSAGE_BOX]).Flag)
                Application.ExitThread();
        }

        //event occurs when player want to regist an account
        private void RegistBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Regist.Enabled = false;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.REGIST, new RegistGUI());
        }

        //change background color when mouse hover
        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[Ultils.Enum.SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Cyan;
        }
        //change background color when mouse leave
        private void Btn_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.White;

        //change placeholder textboxes events 
        private void UsernameTbx_Enter(object sender, EventArgs e) =>
            ((CustomTextbox)sender).changePH_Enter();

        private void UsernameTbx_Leave(object sender, EventArgs e) =>
           ((CustomTextbox)sender).changePH_Leave();

        private void PasswordTbx_Enter(object sender, EventArgs e)
        {
            if (!flagEye)
                Tbx_Password.PasswordChar = '*';
            ((CustomTextbox)sender).changePH_Enter();
        }

        private void PasswordTbx_Leave(object sender, EventArgs e)
        {
            ((CustomTextbox)sender).changePH_Leave();
            if (Tbx_Password.Text.Equals(StringManagement.PasswordPlaceHolder) && flagEye)
                Tbx_Password.PasswordChar = '\0';
        }

        private void Tbx_TextChanged(object sender, EventArgs e) =>
            ((CustomTextbox)sender).setRule();

        private void Btn_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();

        private void Btn_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();

        private void Btn_EyePass_Click(object sender, EventArgs e)
        {
            if (Tbx_Password.PasswordChar == '*')
            {
                flagEye = true;
                Tbx_Password.PasswordChar = '\0';
                Btn_EyePass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eye.png");
            }
            else
            {
                flagEye = false;
                Tbx_Password.PasswordChar = '*';
                Btn_EyePass.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\eyeHidden.png");
            }
        }

        private void LogInGUI_FormClosing(object sender, FormClosingEventArgs e)
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