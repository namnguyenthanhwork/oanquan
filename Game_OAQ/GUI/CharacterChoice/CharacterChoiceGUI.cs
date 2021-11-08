using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GUI.Ultils;
using GUI.MessageBoxes;
using GUI.Ultils.Enum;

namespace GUI
{
    public partial class CharacterChoiceGUI : Form
    {
        private PictureBox Pbx_Hover;
        private List<Image> List_Characters;
        private List<string> List_CharacterName;
        private PictureBox Pbx_Active;
        public CharacterChoiceGUI()
        {
            InitializeComponent();
            Pbx_Hover = new PictureBox();
            List_Characters = new List<Image>();
            List_CharacterName = new List<string>();
        }

        //user for smooth screen
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;
                return createParams;
            }
        }
        private void CharacterChoiceGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            DoubleBuffered = true;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Btn_Continue.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Ultilities.ControlUltils.changeParent(Lbl_Name, Pbx_Name, new Point(30, 2));
            Ultilities.ControlUltils.changeParent(Btn_Continue, Pbx_Continue,
                new Point((Pbx_Continue.Width - Btn_Continue.Width) / 2, (Pbx_Continue.Height - Btn_Continue.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_Time, Pbx_Clock,
                new Point((Pbx_Clock.Width - Lbl_Time.Width) / 2, (Pbx_Clock.Height - Lbl_Time.Height) / 2));

            Pbx_Hover.SizeMode = PictureBoxSizeMode.Zoom;
            Pbx_Hover.Size = new Size(200, 200);
            Pbx_Hover.BorderStyle = BorderStyle.Fixed3D;
            Pbx_Hover.Visible = false;
            Controls.Add(Pbx_Hover);
            Pbx_Hover.BringToFront();

            List_CharacterName.AddRange(StringManagement.List_CharacterName);
            int idxCharacter = new Random().Next(0, List_Characters.Count);
            Pbx_FullAva.Image = List_Characters[idxCharacter];
            Lbl_Name.Text = List_CharacterName[idxCharacter];
            Pbx_Active = (PictureBox)FloPnl_Choice.Controls[idxCharacter];
            Pbx_Active.BackgroundImage =
                Image.FromFile(Application.StartupPath + @"\images\CharacterChoice\activeChar.jpg");
            Timer_Clock.Enabled = true;
            Pbx_FullAva.Location = new Point(-Pbx_FullAva.Width, Pbx_FullAva.Location.Y);

            Program.runAnimation(AnimationState.SINK, this);
        }

        private void loadImages()
        {
            List<FileInfo> List_FileInfo =
                new DirectoryInfo(Application.StartupPath + @"\images\Characters\Heads").GetFiles().ToList();
            List_FileInfo.Sort((e1, e2) =>
                Int32.Parse(e1.Name.Substring(0, e1.Name.IndexOf('.'))).CompareTo(
                     Int32.Parse(e2.Name.Substring(0, e2.Name.IndexOf('.')))));
            foreach (FileInfo fileInfo in List_FileInfo)
            {
                PictureBox Pbx_Ava = new PictureBox();
                Pbx_Ava.Name = fileInfo.Name;
                Pbx_Ava.Image = Image.FromFile(fileInfo.FullName);
                Pbx_Ava.Size = new Size(132, 112);
                Pbx_Ava.SizeMode = PictureBoxSizeMode.Zoom;
                Pbx_Ava.BorderStyle = BorderStyle.Fixed3D;
                Pbx_Ava.BackgroundImage =
                    Image.FromFile(Application.StartupPath + @"\images\CharacterChoice\hoverChar.jpg");
                Pbx_Ava.BackgroundImageLayout = ImageLayout.Stretch;
                Pbx_Ava.MouseLeave += Pbx_Ava_MouseLeave;
                Pbx_Ava.MouseMove += Pbx_Ava_MouseMove;
                Pbx_Ava.MouseClick += Pbx_Ava_MouseClick;
                FloPnl_Choice.Controls.Add(Pbx_Ava);
            }
            List_FileInfo =
                new DirectoryInfo(Application.StartupPath + @"\images\Characters").GetFiles().ToList();
            List_FileInfo.Sort((e1, e2) =>
                Int32.Parse(e1.Name.Substring(0, e1.Name.IndexOf('.'))).CompareTo(
                     Int32.Parse(e2.Name.Substring(0, e2.Name.IndexOf('.')))));

            foreach (FileInfo fileInfo in List_FileInfo)
                List_Characters.Add(Image.FromFile(fileInfo.FullName));

            //load img
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"CharacterChoice\background.jpg");
            Pbx_Continue.Image = Ultilities.ControlUltils.getImageFromFile(@"CharacterChoice\continues.png");
            Pbx_Clock.Image = Ultilities.ControlUltils.getImageFromFile(@"CharacterChoice\clock.png");
            Pbx_Name.Image = Ultilities.ControlUltils.getImageFromFile(@"CharacterChoice\titleNameChar.png");
        }

        private void Pbx_Ava_MouseClick(object sender, MouseEventArgs e)
        {
            Pbx_Active.BackgroundImage =
                Image.FromFile(Application.StartupPath + @"\images\CharacterChoice\hoverChar.jpg");
            Pbx_Active = (PictureBox)sender;
            Pbx_Active.BackgroundImage =
                Ultilities.ControlUltils.getImageFromFile(@"CharacterChoice\activeChar.jpg");
            int idxCharacter =
                Int32.Parse(((PictureBox)sender).Name.Substring(0, ((PictureBox)sender).Name.IndexOf('.'))) - 1;
            Pbx_FullAva.Image = List_Characters[idxCharacter];
            Lbl_Name.Text = List_CharacterName[idxCharacter];
            Pbx_FullAva.Location = new Point(-Pbx_FullAva.Width, Pbx_FullAva.Location.Y);
            Timer_ShowAvatar.Start();
        }

        private void Pbx_Ava_MouseMove(object sender, MouseEventArgs e)
        {
            Pbx_Hover.Visible = true;
            Point Point_CurrentCursor = PointToClient(Cursor.Position);

            Pbx_Hover.Image =
                List_Characters[Int32.Parse(((PictureBox)sender).Name.Substring(0,
                                                ((PictureBox)sender).Name.IndexOf('.'))) - 1];

            Pbx_Hover.Location = new Point(Point_CurrentCursor.X - Pbx_Hover.Width - 50, Point_CurrentCursor.Y - 50);
            if (Pbx_Hover.Location.Y < 50)
                Pbx_Hover.Location = new Point(Pbx_Hover.Location.X, 50);
            if (Pbx_Hover.Location.Y + Pbx_Hover.Height > Height)
                Pbx_Hover.Location = new Point(Pbx_Hover.Location.X, Height - Pbx_Hover.Location.Y - 50);
        }
        private void Pbx_Ava_MouseLeave(object sender, EventArgs e)
        {
            Pbx_Hover.Image = null;
            Pbx_Hover.Visible = false;
        }

        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            int currTime = int.Parse(Lbl_Time.Text.Substring(0, Lbl_Time.Text.IndexOf('s')));
            if (currTime <= 20)
            {
                Program.Dic_Sounds[currTime > 5 ? SoundKind.TICK_SOUND : SoundKind.FAST_TICK_SOUND].windowsMediaPlayer.controls.play();
                Lbl_Time.Visible = true;
            }
            else
                Lbl_Time.Visible = false;

            Lbl_Time.Text = (currTime - 1).ToString() + 's';
            if (currTime - 1 <= 5)
                Lbl_Time.ForeColor = Color.Red;

            if (Lbl_Time.Text.Length == 2)
                Lbl_Time.Text = Lbl_Time.Text.Insert(0, "0");

            if (int.Parse(Lbl_Time.Text.Substring(0, Lbl_Time.Text.IndexOf('s'))) == 0)
            {
                Program.Dic_Sounds[SoundKind.TIMEUP_SOUND].windowsMediaPlayer.controls.play();
                Lbl_Time.Text = "00s";
                Btn_Continue_Click(sender, e);
            }
        }


        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            Btn_Continue.Enabled = false;
            Timer_Clock.Stop();
            Timer_Clock.Enabled = false;
            if (!Program.Dic_Bundles.ContainsKey(StringManagement.KeyDatas.PlayerAvatar_Key))
                Program.Dic_Bundles.Add(StringManagement.KeyDatas.PlayerAvatar_Key, Pbx_FullAva.Image);
            else
                Program.Dic_Bundles[StringManagement.KeyDatas.PlayerAvatar_Key] = Pbx_FullAva.Image;
            Program.runAnimation(AnimationState.DISAPPEAR, this);
            Program.changeForm(FormKind.VERSUS, new VersusGUI());
        }

        private void Btn_Continue_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Cyan;
        }

        private void Btn_Continue_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.Black;

        private void Btn_Continue_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();

        private void Btn_Continue_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();

        private void Timer_ShowAvatar_Tick(object sender, EventArgs e)
        {
            Pbx_FullAva.Location = new Point(Pbx_FullAva.Location.X + 80, Pbx_FullAva.Location.Y);
            if (Pbx_FullAva.Location.X > 0)
            {
                Pbx_FullAva.Location = new Point(0, Pbx_FullAva.Location.Y);
                Timer_ShowAvatar.Stop();
            }
        }

        private void CharacterChoiceGUI_FormClosing(object sender, FormClosingEventArgs e)
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
