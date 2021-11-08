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

namespace GUI
{
    public partial class VersusGUI : Form
    {
        private List<Image> List_BotImages;
        public VersusGUI()
        {
            InitializeComponent();
            List_BotImages = new List<Image>();
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
        private void VersusGUI_Load(object sender, EventArgs e)
        {
            
            loadImages();
            DoubleBuffered = true;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Ultilities.ControlUltils.changeParent(Pbx_Player, Pnl_Player, new Point(0, -Pnl_Player.Height));
            Ultilities.ControlUltils.changeParent(Pbx_Bot, Pnl_Bot, new Point(0, Pnl_Bot.Height));
            Ultilities.ControlUltils.changeParent(Lbl_Player, Pbx_PlayerBg,
                new Point((Pbx_PlayerBg.Width - Lbl_Player.Width) / 2, (Pbx_PlayerBg.Height - Lbl_Player.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_Bot, Pbx_BotBg,
                new Point((Pbx_BotBg.Width - Lbl_Bot.Width) / 2, (Pbx_BotBg.Height - Lbl_Bot.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_Loading, Pnl_Loading, Point.Empty);

            Pbx_Player.Image = (Image)Program.Dic_Bundles[StringManagement.KeyDatas.PlayerAvatar_Key];
            Pbx_Bot.Image = List_BotImages[new Random().Next(0, List_BotImages.Count)];
            if (!Program.Dic_Bundles.ContainsKey(StringManagement.KeyDatas.BotAvatar_Key))
                Program.Dic_Bundles.Add(StringManagement.KeyDatas.BotAvatar_Key, Pbx_Bot.Image);
            else
                Program.Dic_Bundles[StringManagement.KeyDatas.BotAvatar_Key] = Pbx_Bot.Image;

            Program.runAnimation(AnimationState.ZOOM_IN, this);
        }
        private void loadImages()
        {
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Versus\background.jpg");
            DirectoryInfo directoryInfo = new DirectoryInfo(Application.StartupPath + @"\images\Characters");
            foreach (FileInfo fileInfo in directoryInfo.GetFiles())
                List_BotImages.Add(Image.FromFile(fileInfo.FullName));
            Pbx_PlayerBg.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");
            Pbx_BotBg.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");

        }
        private int delay = 150;
        private void Timer_Avt_Tick(object sender, EventArgs e)
        {
            if (--delay > 0)
                return;
            Pbx_Player.Location = new Point(Pbx_Player.Location.X, Pbx_Player.Location.Y + 15);
            Pbx_Bot.Location = new Point(Pbx_Bot.Location.X, Pbx_Bot.Location.Y - 15);
            if (Pbx_Player.Location.Y >= Pbx_Bot.Location.Y)
            {
                Pbx_Player.Location = Pbx_Bot.Location = Point.Empty;
                Timer_Avt.Stop();
                Timer_Avt.Enabled = false;
                Timer_Loading.Enabled = true;
            }
        }

        private void Timer_Loading_Tick(object sender, EventArgs e)
        {
            Timer_Loading.Interval = new Random().Next(100,1500);
            Lbl_Loading.BackColor = Color.Cyan;
            Lbl_Loading.Width += new Random().Next(1, 100);
            Lbl_ResultLoading.Text = 
                (Math.Round(Lbl_Loading.Width * 1.0 / Pnl_Loading.Width, 2) * 100).ToString() + "%";
            if (Lbl_Loading.Width >= Pnl_Loading.Width)
            {
                Lbl_ResultLoading.Text = "100%";
                Lbl_Loading.Width = Pnl_Loading.Width;
                Timer_Loading.Stop();
                Timer_Loading.Enabled = false;
                Program.runAnimation(AnimationState.DISAPPEAR, this);
                Program.changeForm(FormKind.MAIN_GAME, new MainGameGUI());
                Program.Dic_Sounds[Ultils.Enum.SoundKind.MAIN_MUSIC].windowsMediaPlayer.controls.stop();
            }
        }

        private void VersusGUI_FormClosing(object sender, FormClosingEventArgs e)
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
