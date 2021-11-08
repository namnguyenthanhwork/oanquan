using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Ultils;
using GUI.MessageBoxes;
using GUI.Ultils.Enum;
namespace GUI
{
    //start menu 
    public partial class StartGUI : Form
    {
        private bool dirTitle = false;//direction of the title: false=> left to right, true => right to left 
        private Start.Setting St_Setting;
        public StartGUI()
        {
            InitializeComponent();
            St_Setting = new Start.Setting(Pnl_Setting);

        }
        //use for smooth screen
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;
                return createParams;
            }
        }
        //initialize data 
        private void StartGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            DoubleBuffered = true;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Program.Dic_Sounds[SoundKind.OPENING_MUSIC].windowsMediaPlayer.controls.pause();
            Program.Dic_Sounds[SoundKind.MAIN_MUSIC].windowsMediaPlayer.controls.play();
            Program.Dic_Sounds[SoundKind.MAIN_MUSIC].windowsMediaPlayer.settings.setMode("loop", true);
            Btn_Start.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Rank.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Hint.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Exit.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Setting.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Volume.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Btn_Account.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Ultilities.ControlUltils.changeParent(Btn_Start, Pbx_Start,
                new Point((Pbx_Start.Width - Btn_Start.Width) / 2, 53));
            Ultilities.ControlUltils.changeParent(Btn_Rank, Pbx_Rank,
                new Point((Pbx_Rank.Width - Btn_Rank.Width) / 2 , 60));
            Ultilities.ControlUltils.changeParent(Btn_Hint, Pbx_Hint,
                new Point((Pbx_Hint.Width - Btn_Hint.Width) / 2, 30));
            Ultilities.ControlUltils.changeParent(Btn_Exit, Pbx_Exit,
                new Point(35, 20));

            Pbx_RightBird.Location = new Point(-Lbl_Title.Width - Pbx_RightBird.Width, Pbx_RightBird.Location.Y);
            Pbx_LeftBird.Location = new Point(Width + Lbl_Title.Width, Pbx_LeftBird.Location.Y);
            Lbl_Title.Location = new Point(-Lbl_Title.Width, Lbl_Title.Location.Y);

            St_Setting.Pnl_Container.Location = new Point(Width - Btn_Setting.Width - 10, Height - Pnl_Setting.Height - 15);
            St_Setting.Step = 5;
            St_Setting.OffSetX = St_Setting.Pnl_Container.Width - Btn_Setting.Width - 20;

            Program.runAnimation(AnimationState.ZOOM_IN, this);

        }
        private void loadImages()
        {
            Pbx_Start.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\wood.png");
            Pbx_Rank.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\wood.png");
            Pbx_Hint.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\wood.png");
            Pbx_Exit.Image = Ultilities.ControlUltils.getImageFromFile(@"Shared\back.png");
            Pbx_Char2.Image = Ultilities.ControlUltils.getImageFromFile(@"Characters\6.png");
            Pbx_Char1.Image = Ultilities.ControlUltils.getImageFromFile(@"Characters\7.png");
            Pbx_Char3.Image = Ultilities.ControlUltils.getImageFromFile(@"Characters\8.png");
            Pbx_RightBird.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\rightBird.gif");
            Pbx_LeftBird.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\leftBird.gif");
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\background.jpg");
            Btn_Account.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\info.png");
            Btn_Volume.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\music.png");
            Btn_Setting.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\setting.png");
        }
        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Cyan;
        }

        private void Btn_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.Black;

        private void Btn_Exit_MouseClick(object sender, MouseEventArgs e)
        {
            Program.changeForm(FormKind.YES_NO_MESSAGE_BOX, new YesNoMessageBox(),
                StringManagement.MessTitle, StringManagement.Leave_Mess);
            if (((YesNoMessageBox)Program.Dic_Forms[FormKind.YES_NO_MESSAGE_BOX]).Flag)
            {
                Btn_Exit.Enabled = false;
                St_Setting.dispose();
                Program.runAnimation(AnimationState.DISAPPEAR, this);
                Program.changeForm(FormKind.LOG_IN, new LogInGUI());
                Program.Dic_Sounds[SoundKind.MAIN_MUSIC].windowsMediaPlayer.controls.pause();
                Program.Dic_Sounds[SoundKind.OPENING_MUSIC].windowsMediaPlayer.controls.play();
                Program.Dic_Sounds[SoundKind.OPENING_MUSIC].windowsMediaPlayer.settings.setMode("loop", true);
            }
        }

        private void Btn_Hint_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Hint.Enabled = false;
            St_Setting.dispose();
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.HINT, new HintGUI());
            Btn_Hint.Enabled = false;

        }

        private void Btn_Rank_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Rank.Enabled = false;
            Btn_Rank.Enabled = false;
            St_Setting.dispose();
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.RANK, new RankGUI());


        }

        private void Btn_Start_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Start.Enabled = false;
            Btn_Start.Enabled = false;
            St_Setting.dispose();
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.CHARACTER_CHOICE, new CharacterChoiceGUI());


        }
        //efect of the title
        private void Timer_StartGUI_Tick(object sender, EventArgs e)
        {
            if (!dirTitle && Pbx_RightBird.Location.X > Width)
            {
                Lbl_Title.Location = new Point(Width, Lbl_Title.Location.Y);
                Pbx_RightBird.Location =
                    new Point(-Lbl_Title.Width - Pbx_RightBird.Width, Pbx_RightBird.Location.Y);
                dirTitle = true;
                return;
            }
            else if (dirTitle && Pbx_LeftBird.Location.X + Pbx_RightBird.Width <= 0)
            {
                Lbl_Title.Location = new Point(-Lbl_Title.Width, Lbl_Title.Location.Y);
                Pbx_LeftBird.Location = new Point(Width + Lbl_Title.Width, Pbx_LeftBird.Location.Y);
                dirTitle = false;
                return;
            }

            if (!dirTitle)
            {
                Lbl_Title.Location = new Point(Lbl_Title.Location.X + 3, Lbl_Title.Location.Y);
                Pbx_RightBird.Location = new Point(Pbx_RightBird.Location.X + 3, Pbx_RightBird.Location.Y);
            }
            else
            {
                Lbl_Title.Location = new Point(Lbl_Title.Location.X - 3, Lbl_Title.Location.Y);
                Pbx_LeftBird.Location = new Point(Pbx_LeftBird.Location.X - 3, Pbx_LeftBird.Location.Y);
            }

        }

        private void Btn_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();

        private void Btn_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();

        private void StartGUI_FormClosing(object sender, FormClosingEventArgs e)
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
