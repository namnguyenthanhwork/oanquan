using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.MessageBoxes;
using GUI.Ultils;
namespace GUI
{
    //this class uses for show GUI of Hint option in game 
    public partial class HintGUI : Form
    {
        private bool dirTitle = false;
        private int piv = 0;
        public HintGUI() =>
            InitializeComponent();
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;
                return createParams;
            }
        }
        //load form
        private void HintGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            DoubleBuffered = true;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Btn_Home.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Ultilities.ControlUltils.changeParent(Btn_Home, Pbx_Home, new Point(Btn_Home.Location.X, Btn_Home.Location.Y));
            Ultilities.ControlUltils.changeParent(Lbl_Title, Pbx_Title,
                new Point((Pbx_Title.Width - Lbl_Title.Width) / 2, (Pbx_Title.Height - Lbl_Title.Height) / 2));
            Lbl_Title.Text = string.Empty;

            Program.runAnimation(AnimationState.SINK, this);
        }
        private void loadImages()
        {
            Pbx_Home.Image = Ultilities.ControlUltils.getImageFromFile(@"Result\back.png");
            Pbx_Tutorial.Image = Ultilities.ControlUltils.getImageFromFile(@"Hint\border.png");
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Hint\background.jpg");
            Pbx_Title.Image = Ultilities.ControlUltils.getImageFromFile(@"LogIn\button.png");
        }
        //change background of the button when mouse hover
        private void Btn_Home_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[Ultils.Enum.SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Black;
        }

        //change background of the button when mouse leave
        private void Btn_Home_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.DarkCyan;

        //set effect of the title
        private void Timer_Title_Tick(object sender, EventArgs e)
        {
            if (!dirTitle)
                if (Lbl_Title.Text.Length > 1)
                    Lbl_Title.Text = Lbl_Title.Text.Substring(0, Lbl_Title.Text.Length - 1);
                else
                {
                    Lbl_Title.Text = string.Empty;
                    dirTitle = true;
                }
            else
            {
                Lbl_Title.Text += StringManagement.GameTitle[piv++];
                if (piv == StringManagement.GameTitle.Length)
                {
                    piv = 0;
                    dirTitle = false;
                }
            }
        }

        //back to start menu 
        private void Btn_Home_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Home.Enabled = false;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.START, new StartGUI());
        }

        private void Btn_Home_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();

        private void Btn_Home_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();

        private void HintGUI_FormClosing(object sender, FormClosingEventArgs e)
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
