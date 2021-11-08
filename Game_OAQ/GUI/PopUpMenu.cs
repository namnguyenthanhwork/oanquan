using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using DTO;
using WMPLib;
namespace GUI
{
    //action of the popup menu
    public interface IPopUpMenu
    {
        void show(); // show the pop up menu
        void hide(); // hide the pop up menu
        void load(); // load data for the pop up menu
    }

    //The pop up menu in Maingame GUI
    public class MainGamePopUpMenu : IPopUpMenu
    {
        public Panel Pnl_PopUpMenu { get; set; }
        public Button Btn_PopUpMenu { get; set; }
        public FlowLayoutPanel Flo_PopUpMenu { get; set; }
        public Label Lbl_HeaderPopUpMenu { get; set; }
        public Label Lbl_FooterPopUpMenu { get; set; }
        public MainGameSubMenu mainGameSubMenu { get; set; }

        public CharacterDTO characterDTO { get; set; }
        //initialize data 
        public MainGamePopUpMenu(Panel Pnl_PopUpMenu, Button Btn_PopUpMenu)
        {
            this.Pnl_PopUpMenu = Pnl_PopUpMenu;
            this.Pnl_PopUpMenu.BringToFront();
            this.Btn_PopUpMenu = Btn_PopUpMenu;
            Flo_PopUpMenu = new FlowLayoutPanel();
            Lbl_HeaderPopUpMenu = new Label();
            Lbl_FooterPopUpMenu = new Label();
            characterDTO = new CharacterDTO();
            mainGameSubMenu = new MainGameSubMenu(Flo_PopUpMenu);

        }
        //load properties 
        public void load()
        {
            Pnl_PopUpMenu.BringToFront();
            Flo_PopUpMenu.Name = "Flo_PopUpMenu";
            Lbl_HeaderPopUpMenu.Name = "Lbl_HeaderPopUpMenu";
            Lbl_FooterPopUpMenu.Name = "Lbl_FootPopUpMenu";
            Pnl_PopUpMenu.Controls.Add(Lbl_HeaderPopUpMenu);
            Pnl_PopUpMenu.Controls.Add(Flo_PopUpMenu);
            Pnl_PopUpMenu.Controls.Add(Lbl_FooterPopUpMenu);
            Lbl_HeaderPopUpMenu.Text = "Ô ăn quan";
            Lbl_FooterPopUpMenu.Text = "Open University";
            Lbl_HeaderPopUpMenu.Font = new Font("Snap ITC", 22, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_FooterPopUpMenu.Font = new Font("Snap ITC", 10, FontStyle.Regular, GraphicsUnit.Point, 0);


            Lbl_HeaderPopUpMenu.AutoSize = true;
            Lbl_FooterPopUpMenu.AutoSize = true;
            Lbl_HeaderPopUpMenu.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_FooterPopUpMenu.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_FooterPopUpMenu.ForeColor = Color.Red;
            Flo_PopUpMenu.BackColor = Color.LightBlue;
            Flo_PopUpMenu.Size = new Size(
                                Pnl_PopUpMenu.Width - Btn_PopUpMenu.Width,
                                600 - Lbl_HeaderPopUpMenu.Height - Lbl_FooterPopUpMenu.Height - 25);
            Lbl_HeaderPopUpMenu.Location = new Point(
              (Pnl_PopUpMenu.Width - Btn_PopUpMenu.Width - Lbl_HeaderPopUpMenu.Width) / 2, Btn_PopUpMenu.Location.Y);
            Flo_PopUpMenu.Location = new Point(0,
                Lbl_HeaderPopUpMenu.Location.Y + Lbl_HeaderPopUpMenu.Height + 10);
            Lbl_FooterPopUpMenu.Location = new Point(
                 (Pnl_PopUpMenu.Width - Btn_PopUpMenu.Width - Lbl_FooterPopUpMenu.Width) / 2,
                 Flo_PopUpMenu.Location.Y + Flo_PopUpMenu.Height + 10);

            mainGameSubMenu.characterDTO = characterDTO;
            mainGameSubMenu.load();
        }


        public void hide() =>
                   Pnl_PopUpMenu.Size = new Size(Pnl_PopUpMenu.Width - 100, Pnl_PopUpMenu.Height - 100);

        public void show() =>
             Pnl_PopUpMenu.Size = new Size(Pnl_PopUpMenu.Width + 25, Pnl_PopUpMenu.Height + 25);

    }

    //represents for the sub menu of the pop up menu in main game 
    public class MainGameSubMenu
    {
        public FlowLayoutPanel Flo_SubMenu { get; set; }
        public Label Lbl_Score { get; set; }
        public Label Lbl_Quote { get; set; }
        public SubMenuButton SubMenuBtn_Menu { get; set; }
        public SubMenuButton SubMenuBtn_InforPlayer { get; set; }
        public SubMenuButton SubMenuBtn_InforGame { get; set; }

        public CharacterDTO characterDTO { get; set; }
        //initialize data
        public MainGameSubMenu(FlowLayoutPanel Flo_SubMenu)
        {
            this.Flo_SubMenu = Flo_SubMenu;
            Lbl_Score = new Label();
            SubMenuBtn_Menu = new SubMenuButton();
            SubMenuBtn_InforPlayer = new SubMenuButton();
            SubMenuBtn_InforGame = new SubMenuButton();
            Lbl_Quote = new Label();
        }
        //load data 
        public void load()
        {

            Lbl_Score.Name = "Lbl_Score";
            SubMenuBtn_Menu.Btn_choice.Name = "Btn_Menu";
            SubMenuBtn_InforGame.Btn_choice.Name = "Btn_InforGame";
            SubMenuBtn_InforPlayer.Btn_choice.Name = "Btn_InforPlayer";
            Lbl_Quote.Name = "Lbl_Quote";
            Flo_SubMenu.Width -= 5;

            Flo_SubMenu.AutoScrollMinSize = new Size(Flo_SubMenu.Width - 25, Flo_SubMenu.Height);
            Flo_SubMenu.VerticalScroll.Maximum = 5;
            Flo_SubMenu.VerticalScroll.Minimum = 1;

            Flo_SubMenu.VerticalScroll.Visible = true;
            Flo_SubMenu.HorizontalScroll.Visible = true;
            Flo_SubMenu.Controls.Add(Lbl_Score);
            Flo_SubMenu.Controls.Add(Lbl_Quote);
            Flo_SubMenu.Controls.Add(SubMenuBtn_InforPlayer.Btn_choice);
            Flo_SubMenu.Controls.Add(SubMenuBtn_InforPlayer.Flo_dataBin);
            Flo_SubMenu.Controls.Add(SubMenuBtn_InforGame.Btn_choice);
            Flo_SubMenu.Controls.Add(SubMenuBtn_InforGame.Flo_dataBin);
            Flo_SubMenu.Controls.Add(SubMenuBtn_Menu.Btn_choice);

            Lbl_Score.ForeColor = Color.Red;
            Lbl_Score.AutoSize = false;
            Lbl_Quote.AutoSize = false;
            SubMenuBtn_InforGame.Flo_dataBin.Size = new Size(Flo_SubMenu.Width - 25, 0);
            SubMenuBtn_InforPlayer.Flo_dataBin.Size = new Size(Flo_SubMenu.Width - 25, 0);

            Lbl_Score.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_Quote.TextAlign = ContentAlignment.MiddleCenter;
            SubMenuBtn_Menu.Btn_choice.TextAlign = ContentAlignment.MiddleCenter;
            SubMenuBtn_InforPlayer.Btn_choice.Size = new Size(Flo_SubMenu.Width - 25, 50);
            SubMenuBtn_InforGame.Btn_choice.Size = new Size(Flo_SubMenu.Width - 25, 50);
            SubMenuBtn_Menu.Btn_choice.Size = new Size(Flo_SubMenu.Width - 25, 50);
            Lbl_Score.Size = new Size(Flo_SubMenu.Width, 50);
            Lbl_Quote.Size = new Size(Flo_SubMenu.Width - 5, 200);
            SubMenuBtn_InforPlayer.Btn_choice.Font = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubMenuBtn_InforGame.Btn_choice.Font = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubMenuBtn_Menu.Btn_choice.Font = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Score.Font = new Font("Times New Roman", 35, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Quote.Font = new Font("Monotype Corsiva", 13, FontStyle.Italic, GraphicsUnit.Point, 0);
            SubMenuBtn_Menu.Btn_choice.BackColor = Color.LightGreen;
            SubMenuBtn_InforPlayer.Btn_choice.BackColor = Color.LightGreen;
            SubMenuBtn_InforGame.Btn_choice.BackColor = Color.LightGreen;
            Lbl_Score.Text = characterDTO.score.ToString();
            Lbl_Quote.Text = "Hàng trầu hàng cau \n" +
                            "Là hàng con gái \n" +
                            "Hàng bánh hàng trái \n" +
                            "Là hàng bà già \n" +
                            "Hàng hương hàng hoa \n" +
                            "Là hàng cúng Phật. \n";
            SubMenuBtn_Menu.Btn_choice.Text = "Menu";
            SubMenuBtn_InforPlayer.Btn_choice.Text = "Thông tin người chơi";
            SubMenuBtn_InforGame.Btn_choice.Text = "Thông tin trò chơi";

            //information of player
            Label Lbl_TitleNamePlayer = new Label();
            Label Lbl_NamePlayer = new Label();
            Label Lbl_TitleScorePlayer = new Label();
            Label Lbl_ScorePlayer = new Label();

            Lbl_TitleNamePlayer.Text = "Tên người chơi";
            Lbl_NamePlayer.Text = characterDTO.name;
            Lbl_TitleScorePlayer.Text = "Điểm số người chơi";
            Lbl_ScorePlayer.Text = characterDTO.score.ToString();
            Lbl_TitleNamePlayer.AutoSize = false;
            Lbl_NamePlayer.AutoSize = false;
            Lbl_TitleScorePlayer.AutoSize = false;
            Lbl_ScorePlayer.AutoSize = false;

            Lbl_TitleNamePlayer.Size = new Size(SubMenuBtn_InforPlayer.Flo_dataBin.Width, 50);
            Lbl_NamePlayer.Size = new Size(SubMenuBtn_InforPlayer.Flo_dataBin.Width, 50);
            Lbl_TitleScorePlayer.Size = new Size(SubMenuBtn_InforPlayer.Flo_dataBin.Width, 50);
            Lbl_ScorePlayer.Size = new Size(SubMenuBtn_InforPlayer.Flo_dataBin.Width, 50);

            Lbl_TitleNamePlayer.Font = new Font("Monotype Corsiva", 17, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_NamePlayer.Font = new Font("Monotype Corsiva", 22, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_TitleScorePlayer.Font = new Font("Monotype Corsiva", 17, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_ScorePlayer.Font = new Font("Monotype Corsiva", 22, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_TitleNamePlayer.TextAlign = ContentAlignment.MiddleLeft;
            Lbl_NamePlayer.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_TitleScorePlayer.TextAlign = ContentAlignment.MiddleLeft;
            Lbl_ScorePlayer.TextAlign = ContentAlignment.MiddleCenter;

            Lbl_TitleNamePlayer.BackColor = Color.Transparent;
            Lbl_NamePlayer.BackColor = Color.Transparent;
            Lbl_TitleScorePlayer.BackColor = Color.Transparent;
            Lbl_ScorePlayer.BackColor = Color.Transparent;

            Lbl_TitleNamePlayer.ForeColor = Color.Black;
            Lbl_NamePlayer.ForeColor = Color.Red;
            Lbl_TitleScorePlayer.ForeColor = Color.Black;
            Lbl_ScorePlayer.ForeColor = Color.Red;

            SubMenuBtn_InforPlayer.Flo_dataBin.Controls.Add(Lbl_TitleNamePlayer);
            SubMenuBtn_InforPlayer.Flo_dataBin.Controls.Add(Lbl_NamePlayer);
            SubMenuBtn_InforPlayer.Flo_dataBin.Controls.Add(Lbl_TitleScorePlayer);
            SubMenuBtn_InforPlayer.Flo_dataBin.Controls.Add(Lbl_ScorePlayer);

            //information of game
            SubMenuBtn_InforGame.offsetFlo = 100;
            Label Lbl_TitleVersion = new Label();
            Label Lbl_Version = new Label();
            Lbl_TitleVersion.Text = "Phiên bản";
            Lbl_Version.Text = "1.0.0.1";
            Lbl_TitleVersion.AutoSize = false;
            Lbl_Version.AutoSize = false;
            Lbl_TitleVersion.Size = new Size(SubMenuBtn_InforPlayer.Flo_dataBin.Width, 50);
            Lbl_Version.Size = new Size(SubMenuBtn_InforPlayer.Flo_dataBin.Width, 50);
            Lbl_TitleVersion.Font = new Font("Monotype Corsiva", 17, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Version.Font = new Font("Monotype Corsiva", 22, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_TitleVersion.TextAlign = ContentAlignment.MiddleLeft;
            Lbl_Version.TextAlign = ContentAlignment.MiddleCenter;
            Lbl_TitleVersion.BackColor = Color.Transparent;
            Lbl_Version.BackColor = Color.Transparent;
            Lbl_TitleVersion.ForeColor = Color.White;
            Lbl_Version.ForeColor = Color.Red;

            SubMenuBtn_InforGame.Flo_dataBin.Controls.Add(Lbl_TitleVersion);
            SubMenuBtn_InforGame.Flo_dataBin.Controls.Add(Lbl_Version);
        }

        public class SubMenuButton
        {
            public Button Btn_choice { get; set; }
            public FlowLayoutPanel Flo_dataBin { get; set; }

            private bool flag = false;
            public int offsetFlo { get; set; }
            public SubMenuButton()
            {
                Btn_choice = new Button();
                Flo_dataBin = new FlowLayoutPanel();
                Btn_choice.MouseClick += Btn_choice_MouseClick;
                Btn_choice.MouseHover += Btn_MouseHover;
                Btn_choice.MouseLeave += Btn_MouseLeave;
                Flo_dataBin.Height = 0;
                Flo_dataBin.BackColor = Color.WhiteSmoke;
                Flo_dataBin.BackgroundImage = Properties.Resources.sand;
                Flo_dataBin.BackgroundImageLayout = ImageLayout.Stretch;
                offsetFlo = 200;

            }
            private void Btn_choice_MouseClick(object sender, MouseEventArgs e) =>
                Flo_dataBin.Height = (flag = !flag) ? offsetFlo : 0;
            private void Btn_MouseLeave(object sender, EventArgs e) =>
                    ((Button)sender).BackColor = Color.LightGreen;
            private void Btn_MouseHover(object sender, EventArgs e)
            {
                WindowsMediaPlayer choice = new WindowsMediaPlayer();
                choice.URL = SoundPath.Sound_choice;
                choice.controls.play();
                ((Button)sender).BackColor = Color.LightPink;
            }

        }



    }
}
