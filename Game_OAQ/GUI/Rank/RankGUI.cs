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
using GUI.MessageBoxes;
using GUI.Ultils;
namespace GUI
{
    //show rank of score of players 
    public partial class RankGUI : Form
    {
        private List<CharacterDTO> characterDTOs;
        public RankGUI()
        {
            InitializeComponent();
            characterDTOs = new List<CharacterDTO>();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;
                return createParams;
            }
        }
        // event form load 
        private void RankGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            DoubleBuffered = true;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Btn_Home.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Ultilities.ControlUltils.changeParent(Lbl_NameR1, Pbx_BgR1,
                new Point((Pbx_BgR1.Width - Lbl_NameR1.Width) / 2, (Pbx_BgR1.Height - Lbl_NameR1.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_NameR2, Pbx_BgR2,
                new Point((Pbx_BgR2.Width - Lbl_NameR2.Width) / 2, (Pbx_BgR2.Height - Lbl_NameR2.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_NameR3, Pbx_BgR3,
                new Point((Pbx_BgR3.Width - Lbl_NameR3.Width) / 2, (Pbx_BgR3.Height - Lbl_NameR3.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_Title, Pbx_TitleRank, new Point(48, 32));
            Ultilities.ControlUltils.changeParent(Btn_Home, Pbx_Home, new Point(10, 22));

            characterDTOs =
                ((CharacterBLL)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterBLL_Key]).getCharacterDTOs();
            characterDTOs.Sort((e1, e2) => -e1.score.CompareTo(e2.score));
            Lbl_NameR1.Text = characterDTOs[0].name;
            Lbl_ScoreR1.Text = characterDTOs[0].score.ToString();
            if (characterDTOs.Count >= 2)
            {
                Lbl_NameR2.Text = characterDTOs[1].name;
                Lbl_ScoreR2.Text = characterDTOs[1].score.ToString();
            }
            if (characterDTOs.Count >= 3)
            {
                Lbl_NameR3.Text = characterDTOs[2].name;
                Lbl_ScoreR3.Text = characterDTOs[2].score.ToString();
            }

            Program.runAnimation(AnimationState.SINK, this);
        }
        private void loadImages()
        {
            Pbx_R1.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\r1.png");
            Pbx_R2.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\r2.png");
            Pbx_R3.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\r3.png");
            Pbx_BgR1.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");
            Pbx_BgR2.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");
            Pbx_BgR3.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Rank\background.jpg");
            Pbx_Home.Image = Ultilities.ControlUltils.getImageFromFile(@"Shared\back.png");
            Pbx_TitleRank.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\banner.png");
        }

        // change background color of the button when mouse hover
        private void Btn_Home_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[Ultils.Enum.SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Black;
        }
        //change background color of the button when mouse leave 
        private void Btn_Home_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.DarkCyan;

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

        private void RankGUI_FormClosing(object sender, FormClosingEventArgs e)
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
