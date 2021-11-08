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
    //This class uses for store and show result after finish game 
    public partial class ResultGUI : Form
    {

        public List<int> List_BotData { get; set; }//contains data of bot: 
        public List<int> List_PlayerData { get; set; }//contains data of player
        public int result { get; set; } // final result 

        public ResultGUI()
        {
            InitializeComponent();
            List_BotData = new List<int>();
            List_PlayerData = new List<int>();
            Program.Dic_Sounds[Ultils.Enum.SoundKind.MAIN_MUSIC].windowsMediaPlayer.controls.play();
            Program.Dic_Sounds[Ultils.Enum.SoundKind.MAIN_MUSIC].windowsMediaPlayer.settings.setMode("loop", true);
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

        //initialize data when form load
        private void ResultGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            DoubleBuffered = true;
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Btn_Home.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);

            Ultilities.ControlUltils.changeParent(Btn_Home, Pbx_BackHome, new Point(50, 100));
            Ultilities.ControlUltils.changeParent(Lbl_Result, Pbx_WinLose,
                new Point((Pbx_WinLose.Width - 20 - (Lbl_Score.Width + Lbl_Result.Width)) / 2,
                (Pbx_WinLose.Height - Lbl_Result.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_Score, Pbx_WinLose,
                new Point(Lbl_Result.Location.X + Lbl_Result.Width - 5, Lbl_Result.Location.Y + 3));
            Ultilities.ControlUltils.changeParent(TloPnl_Bot, Pbx_Rs1, new Point(45, 30));
            Ultilities.ControlUltils.changeParent(TloPnl_Player, Pbx_Rs2, new Point(45, 30));
            Ultilities.ControlUltils.changeParent(Lbl_Bot, Pbx_TitleBot,
                new Point((Pbx_TitleBot.Width - Lbl_Bot.Width) / 2, (Pbx_TitleBot.Height - Lbl_Bot.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_Player, Pbx_TitlePlayer,
                 new Point((Pbx_TitlePlayer.Width - Lbl_Player.Width) / 2, (Pbx_TitlePlayer.Height - Lbl_Player.Height) / 2));
            //location of the title
            Lbl_Title.Location = new Point(Width, Lbl_Title.Location.Y);
            Pbx_Bird.Location = new Point(Lbl_Title.Location.X + Lbl_Title.Width,
               Lbl_Title.Location.Y - 31);

            Program.runAnimation(AnimationState.ZOOM_IN, this);
        }
        private void loadImages()
        {
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Result\background.jpg");
            Pbx_BackHome.Image = Ultilities.ControlUltils.getImageFromFile(@"Result\back.png");
            Pbx_Bird.Image = Ultilities.ControlUltils.getImageFromFile(@"Start\leftBird.gif");
            Pbx_WinLose.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");
            Pbx_Rs1.Image = Ultilities.ControlUltils.getImageFromFile(@"Result\pannel.png");
            Pbx_Rs2.Image = Ultilities.ControlUltils.getImageFromFile(@"Result\pannel.png");
            Pbx_TitleBot.Image = Ultilities.ControlUltils.getImageFromFile(@"Login\button.png");
            Pbx_TitlePlayer.Image = Ultilities.ControlUltils.getImageFromFile(@"Login\button.png");
        }
        //title animation
        private void Timer_Title_Tick(object sender, EventArgs e)
        {
            Lbl_Title.Location =
                new Point(Lbl_Title.Location.X < -Lbl_Title.Width ? Width : Lbl_Title.Location.X - 5,
                            Lbl_Title.Location.Y);
            Pbx_Bird.Location =
                new Point(Lbl_Title.Location.X + Lbl_Title.Width, Lbl_Title.Location.Y - 31);
        }


        //load data after finish game to show from MainGmaeGUI
        public void loadData()
        {
            CharacterDTO characterDTO = (CharacterDTO)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key];
            CharacterBLL characterBLL = (CharacterBLL)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterBLL_Key];
            if (result > 0)
            {
                Lbl_Result.Text = StringManagement.WinTitle;
                Lbl_Score.Text = StringManagement.WinScore;
                Lbl_Result.ForeColor = Lbl_Score.ForeColor = Color.Lime;
                characterDTO.score += 10;
            }
            else if (result < 0)
            {
                Lbl_Result.Text = StringManagement.LoseTitle;
                Lbl_Score.Text = StringManagement.LoseScore;
                Lbl_Result.ForeColor = Lbl_Score.ForeColor = Color.Red;
                characterDTO.score -= 10;
                if (characterDTO.score < 0)
                    characterDTO.score = 0;
            }
            else
            {
                Lbl_Result.Text = StringManagement.DrawTitle;
                Lbl_Score.Text = StringManagement.DrawScore;
                Lbl_Result.ForeColor = Lbl_Score.ForeColor = Color.Yellow;
            }

            int totalBot = List_BotData[0] + List_BotData[1] * 10 + List_BotData[2] * 10 -
                List_BotData[3] + List_PlayerData[3];
            int totalPlayer = List_PlayerData[0] + List_PlayerData[1] * 10 + List_PlayerData[2] * 10 -
                List_PlayerData[3] + List_BotData[3];
            Lbl_AmoTrooper1.Text = $"{List_BotData[0]} (x1)";
            Lbl_AmoManBot1.Text = $"{List_BotData[1]} (x10)";
            Lbl_AmoManPlayer1.Text = $"{List_BotData[2]} (x10)";
            Lbl_AmoRent1.Text = $"{List_BotData[3]} (x1)";
            Lbl_AmoTotal1.Text = totalBot.ToString();

            Lbl_AmoTrooper2.Text = $"{List_PlayerData[0]} (x1)";
            Lbl_AmoManBot2.Text = $"{List_PlayerData[1]} (x10)";
            Lbl_AmoManPlayer2.Text = $"{List_PlayerData[2]} (x10)";
            Lbl_AmoRent2.Text = $"{List_PlayerData[3]} (x1)";
            Lbl_AmoTotal2.Text = totalPlayer.ToString();

            Lbl_RateTrooper1.Text = $"{Math.Round(List_BotData[0] * 1.0f / (List_BotData[0] + List_PlayerData[0]) * 100, 2)}%";
            Lbl_RateManBot1.Text = $"{Math.Round(List_BotData[1] * 1.0f / (List_BotData[1] + List_PlayerData[1]) * 100, 2)}%";
            Lbl_RateManPlayer1.Text = $"{Math.Round(List_BotData[2] * 1.0f / (List_BotData[2] + List_PlayerData[2]) * 100, 2)}%";
            Lbl_RateRent1.Text = $"{((List_BotData[3] + List_PlayerData[3]) == 0 ? 0 : (Math.Round(List_BotData[3] * 1.0f / (List_BotData[3] + List_PlayerData[3]) * 100, 2)))}%";
            Lbl_RateTotal1.Text = $"{Math.Round(totalBot * 1.0f / (totalBot + totalPlayer) * 100, 2)}%";

            Lbl_RateTrooper2.Text = $"{Math.Round(List_PlayerData[0] * 1.0f / (List_PlayerData[0] + List_BotData[0]) * 100, 2)}%";
            Lbl_RateManBot2.Text = $"{Math.Round(List_PlayerData[1] * 1.0f / (List_PlayerData[1] + List_BotData[1]) * 100, 2)}%";
            Lbl_RateManPlayer2.Text = $"{Math.Round(List_PlayerData[2] * 1.0f / (List_PlayerData[2] + List_BotData[2]) * 100, 2)}%";
            Lbl_RateRent2.Text = $"{((List_PlayerData[3] + List_BotData[3]) == 0 ? 0 : (Math.Round(List_PlayerData[3] * 1.0f / (List_PlayerData[3] + List_BotData[3]) * 100, 2)))}%";
            Lbl_RateTotal2.Text = $"{Math.Round(totalPlayer * 1.0f / (totalPlayer + totalBot) * 100, 2)}%";
            characterBLL.saveCharacterDTO(characterDTO);
            Program.Dic_Bundles["CharacterDTO"] = characterDTO;
        }
        //change back color of the button when mouse hover 
        private void Btn_Home_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[Ultils.Enum.SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.DarkCyan;
        }
        //change back color of the button when mouse leave 
        private void Btn_Home_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.Black;

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

        private void ResultGUI_FormClosing(object sender, FormClosingEventArgs e)
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
