using GUI.Ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Ultils.Enum;
namespace GUI.Start
{
    public partial class VolumeInformationGUI : Form
    {
        private Point Point_PreCursor_BgMusic;
        private Point Point_PreCursor_OtherMusic;
        private bool Flag_BgMusic = false;
        private bool Flag_OtherMusic = false;
        public static int Width_Container;
        public static int Height_Container;
        public VolumeInformationGUI() =>

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

        public void setLocation()
        {
            if (Program.Dic_Sounds[SoundKind.MAIN_MUSIC].windowsMediaPlayer.settings.volume == 0)
                mute(Ckb_BackgroundMusic, Btn_BackgroundMusic);

            if (Program.Dic_Sounds[SoundKind.CHOICE_SOUND].windowsMediaPlayer.settings.volume == 0)
                mute(Ckb_OtherMusic, Btn_OtherMusic);

            Lbl_BackgroundMusic.Text = Program.MusicVolume.ToString();
            Btn_BackgroundMusic.Location =
                new Point((int)(Program.MusicVolume * 1.0 / 100 * (Pnl_BackgroundMusic.Width - Btn_BackgroundMusic.Width)),
                Btn_BackgroundMusic.Location.Y);
            Lbl_BackgroundMusic.Location =
                new Point(Pnl_BackgroundMusic.Location.X + Btn_BackgroundMusic.Location.X + (Btn_BackgroundMusic.Width - Lbl_BackgroundMusic.Width) / 2, Lbl_BackgroundMusic.Location.Y);
            Pbx_BackgroundMusic.Width = Btn_BackgroundMusic.Location.X;

            Lbl_OtherMusic.Text = Program.SoundVolume.ToString();
            Btn_OtherMusic.Location =
                new Point((int)(Program.SoundVolume * 1.0 / 100 * (Pnl_OtherMusic.Width - Btn_OtherMusic.Width)),
                Btn_OtherMusic.Location.Y);
            Lbl_OtherMusic.Location =
                new Point(Pnl_OtherMusic.Location.X + Btn_OtherMusic.Location.X + (Btn_OtherMusic.Width - Lbl_OtherMusic.Width) / 2, Lbl_OtherMusic.Location.Y);
            Pbx_OtherMusic.Width = Btn_OtherMusic.Location.X;
        }
        private void VolumeInformationGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            setLocation();
            StartGUI startGUI = (StartGUI)Program.Dic_Forms[FormKind.START];
            Location = new Point(startGUI.Location.X + startGUI.Width - (int)(Width_Container / 8.5) - Width,
                    startGUI.Location.Y + startGUI.Height - Height - Height_Container - 30);
            Program.runAnimation(AnimationState.SCROLL_DOWN, this);
        }
        private void loadImages()
        {
            Pbx_BackgroundMusic.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\volumeLevel.gif");
            Pbx_OtherMusic.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\volumeLevel.gif");
            Ckb_BackgroundMusic.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\volume.png");
            Ckb_OtherMusic.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\volume.png");
            Pnl_BgMusic.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\panel.png");
            Pnl_OrMusic.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\panel.png");
            Pnl_Background.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\settingBg.jpg");
        }
        private void mute(CheckBox checkBox, Button button)
        {
            checkBox.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\volume-mute.png");
            button.BackColor = Color.Red;
        }
        private void unMute(CheckBox checkBox, Button button)
        {
            checkBox.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\volume.png");
            button.BackColor = Color.White;
        }
        private void setVolumeBackgroundMusic(int vol)
        {
            Program.Dic_Sounds[SoundKind.OPENING_MUSIC].windowsMediaPlayer.settings.volume = vol;
            Program.Dic_Sounds[SoundKind.MAIN_MUSIC].windowsMediaPlayer.settings.volume = vol;
        }
        private void setVolumeOtherMusic(int vol)
        {
            Program.Dic_Sounds[SoundKind.CHOICE_SOUND].windowsMediaPlayer.settings.volume = vol;
            Program.Dic_Sounds[SoundKind.TICK_SOUND].windowsMediaPlayer.settings.volume = vol;
            Program.Dic_Sounds[SoundKind.TIMEUP_SOUND].windowsMediaPlayer.settings.volume = vol;
            Program.Dic_Sounds[SoundKind.FAST_TICK_SOUND].windowsMediaPlayer.settings.volume = vol;
            Program.Dic_Sounds[SoundKind.STONE_DROPPING_SOUND].windowsMediaPlayer.settings.volume = vol;
        }
        private Point move(Panel panel, PictureBox pictureBox, Label label, Button button, Point point)
        {
            if (button.Name.Contains("Background"))
            {
                unMute(Ckb_BackgroundMusic, button);
                setVolumeBackgroundMusic(Program.MusicVolume);
            }
            else
            {
                unMute(Ckb_OtherMusic, button);
                setVolumeOtherMusic(Program.SoundVolume);
            }
            Point Point_CurCursor = PointToClient(Cursor.Position);
            button.Location =
                new Point(button.Location.X + (Point_CurCursor.X - point.X), button.Location.Y);
            if (button.Location.X <= 0)
            {
                button.Location = new Point(0, button.Location.Y);
                pictureBox.Width = 0;
                label.Location = new Point(panel.Location.X + button.Location.X + (button.Width - label.Width) / 2, label.Location.Y);
                label.Text = "0";
                mute(button.Name.Contains("Background") ? Ckb_BackgroundMusic : Ckb_OtherMusic, button);
                return point;
            }
            if (button.Location.X >= panel.Width - button.Width)
            {
                button.Location = new Point(panel.Width - button.Width, button.Location.Y);
                pictureBox.Width = panel.Width - button.Width;
                label.Location = new Point(panel.Location.X + button.Location.X + (button.Width - label.Width) / 2, label.Location.Y);
                label.Text = "100";
                return point;
            }
            pictureBox.Width = button.Location.X;
            label.Location = new Point(panel.Location.X + button.Location.X + (button.Width - label.Width) / 2, label.Location.Y);
            label.Text = Math.Round(button.Location.X * 1.0 / (panel.Width - button.Width) * 100).ToString();
            if (label.Name.Contains("Background"))
                Program.MusicVolume = int.Parse(label.Text);
            else
                Program.SoundVolume = int.Parse(label.Text);

            return PointToClient(Cursor.Position);
        }

        private void Btn_BackgroundMusic_MouseDown(object sender, MouseEventArgs e)
        {
            Point_PreCursor_BgMusic = PointToClient(Cursor.Position);
            Flag_BgMusic = true;
            Cursor = Ultilities.ControlUltils.changeCursorDown();
        }

        private void Btn_BackgroundMusic_MouseMove(object sender, MouseEventArgs e)
        {
            if (Flag_BgMusic)
            {
                Point_PreCursor_BgMusic = move(Pnl_BackgroundMusic,
                                                Pbx_BackgroundMusic,
                                                Lbl_BackgroundMusic,
                                                Btn_BackgroundMusic,
                                                Point_PreCursor_BgMusic);
                setVolumeBackgroundMusic(int.Parse(Lbl_BackgroundMusic.Text));
            }
        }

        private void Btn_BackgroundMusic_MouseUp(object sender, MouseEventArgs e)
        {
            Flag_BgMusic = false;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
        }
        private void Btn_OtherMusic_MouseDown(object sender, MouseEventArgs e)
        {
            Point_PreCursor_OtherMusic = PointToClient(Cursor.Position);
            Flag_OtherMusic = true;
            Cursor = Ultilities.ControlUltils.changeCursorDown();
        }

        private void Btn_OtherMusic_MouseMove(object sender, MouseEventArgs e)
        {
            if (Flag_OtherMusic)
            {
                Point_PreCursor_OtherMusic = move(Pnl_OtherMusic,
                                                Pbx_OtherMusic,
                                                Lbl_OtherMusic,
                                                Btn_OtherMusic,
                                                Point_PreCursor_OtherMusic);
                setVolumeOtherMusic(int.Parse(Lbl_OtherMusic.Text));
            }
        }

        private void Btn_OtherMusic_MouseUp(object sender, MouseEventArgs e)
        {
            Flag_OtherMusic = false;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
        }
        private void Ckb_BackgroundMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
            {
                unMute(Ckb_BackgroundMusic, Btn_BackgroundMusic);
                setVolumeBackgroundMusic(Program.MusicVolume);
            }
            else
            {
                mute(Ckb_BackgroundMusic, Btn_BackgroundMusic);
                setVolumeBackgroundMusic(0);
            }
        }

        private void Ckb_OtherMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (!((CheckBox)sender).Checked)
            {
                unMute(Ckb_OtherMusic, Btn_OtherMusic);
                setVolumeOtherMusic(Program.SoundVolume);
            }
            else
            {
                mute(Ckb_OtherMusic, Btn_OtherMusic);
                setVolumeOtherMusic(0);
            }
        }

        private void Ckb_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();

        private void Ckb_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();
    }
}
