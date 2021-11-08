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
using GUI.MainGaime;
using GUI.Ultils;
using GUI.MessageBoxes;
using GUI.Ultils.Enum;
namespace GUI
{
    //This class represents for main game GUI
    public partial class MainGameGUI : Form
    {
        private TurnNotification Tnf_TurnNotification;
        private PictureBox Pbx_LeftArrow;// left arrow picture box represents for left direction moving
        private PictureBox Pbx_RightArrow;// right arrow picture box represents for right direction moving
        private PictureBox Pbx_Cell;// contain Image of cell in game board
        private Panel Pnl_TrooperBin;   // bin contains troopers 
        private Panel Pnl_ManBotBin; // bin contains mandarin of bot
        private Panel Pnl_ManPlayerBin;// bin contains mandarin of player
        private Label Lbl_TrooperBin;// score label of trooper bin
        private Label Lbl_ManBotBin; // score label of bot mandarin
        private Label Lbl_ManPlayerBin;// score label of player mandarn 
        private Panel Pnl_ChoiceTemp; // temporary choice 
        private PictureBox Pbx_MovedTrooper;// use to contain moving trooper 
        private RouteBLL RouteBll_Route;// moving route
        private Panel[] Pnl_CellTable;//game board
        private Label[] Lbl_CellTable; // list of score labels 
        private CellBLL[] CellBll_Cells;// List of cells of game 
        private CellBLL CellBLL_Choice;//  cell was chosen 
        private bool Turn_Flag = true;// turn of game:  true => player, false => bot
        private int idxChoiceCell = -1;//index of cell which was chosen by player
        private int idxBotMovement = int.MaxValue; // index of bot choice
        private bool dirBotMovement = true;// direction of bot 
        private bool Flag_PlayClick = false;
        private int countDown = 10;
        private bool Back_Flag = false;
        private bool isPlayerClick = true;
        private bool isStopTimer = false;
        public MainGameGUI()
        {
            InitializeComponent();
            Pbx_LeftArrow = new PictureBox();
            Pbx_RightArrow = new PictureBox();
            Tnf_TurnNotification = new TurnNotification();
        }
        // use for smooth screen when move components in form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000;
                return createParams;
            }
        }


        //initialize data when form load event occours
        private void MainGameGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            DoubleBuffered = true;
            Btn_Back.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            //random bot avatar
            Pbx_BotAvt.Image = (Image)Program.Dic_Bundles[StringManagement.KeyDatas.BotAvatar_Key];
            Pbx_PlayerAvt.Image = (Image)Program.Dic_Bundles[StringManagement.KeyDatas.PlayerAvatar_Key];

            // show turning notification
            Tnf_TurnNotification.Lbl_Turn = Lbl_Turn;
            Tnf_TurnNotification.Lbl_Turn.Location = new Point(Width, Tnf_TurnNotification.Lbl_Turn.Location.Y);
            Tnf_TurnNotification.DesX = Width - Tnf_TurnNotification.Lbl_Turn.Width;

            // set game board
            Pnl_CellTable = new Panel[12];
            Pnl_CellTable[0] = Pnl_BotMandarin;
            Pnl_CellTable[1] = Pnl_Cell1;
            Pnl_CellTable[2] = Pnl_Cell2;
            Pnl_CellTable[3] = Pnl_Cell3;
            Pnl_CellTable[4] = Pnl_Cell4;
            Pnl_CellTable[5] = Pnl_Cell5;
            Pnl_CellTable[6] = Pnl_PlayerMandarin;
            Pnl_CellTable[7] = Pnl_Cell10;
            Pnl_CellTable[8] = Pnl_Cell9;
            Pnl_CellTable[9] = Pnl_Cell8;
            Pnl_CellTable[10] = Pnl_Cell7;
            Pnl_CellTable[11] = Pnl_Cell6;
            //set score labels
            Lbl_CellTable = new Label[12];
            Lbl_CellTable[0] = Lbl_ScoreMandiran1;
            Lbl_CellTable[1] = Lbl_ScoreCell1;
            Lbl_CellTable[2] = Lbl_ScoreCell2;
            Lbl_CellTable[3] = Lbl_ScoreCell3;
            Lbl_CellTable[4] = Lbl_ScoreCell4;
            Lbl_CellTable[5] = Lbl_ScoreCell5;
            Lbl_CellTable[6] = Lbl_ScoreMandiran2;
            Lbl_CellTable[7] = Lbl_ScoreCell10;
            Lbl_CellTable[8] = Lbl_ScoreCell9;
            Lbl_CellTable[9] = Lbl_ScoreCell8;
            Lbl_CellTable[10] = Lbl_ScoreCell7;
            Lbl_CellTable[11] = Lbl_ScoreCell6;
            //set route 
            CellBll_Cells = new CellBLL[12];
            for (int i = 0; i < 12; i++)
                CellBll_Cells[i] = new CellBLL(i, (i == 0 || i == 6) ? 1 : 5);
            RouteBll_Route = new RouteBLL(CellBll_Cells);

            //back
            Ultilities.ControlUltils.changeParent(Btn_Back, Pbx_LeftBorder, Point.Empty);


            //madarin info
            Ultilities.ControlUltils.changeParent(Lbl_MandarinAmount, Pbx_MandarinInfo,
               new Point((Pbx_MandarinInfo.Width - Lbl_MandarinAmount.Width) / 2 - 15, 35));
            Ultilities.ControlUltils.changeParent(Pbx_MandarinAmount, Pbx_MandarinInfo,
                new Point((Pbx_MandarinInfo.Width - Pbx_MandarinAmount.Width) / 2 + 15, 30));

            //mandarin
            Ultilities.ControlUltils.changeParent(Pnl_BotMandarin, Pbx_BotMandarin, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_PlayerMandarin, Pbx_PlayerMandarin, Point.Empty);

            //cell
            Ultilities.ControlUltils.changeParent(Pnl_Cell1, Pbx_Cell1, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_Cell2, Pbx_Cell2, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_Cell3, Pbx_Cell3, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_Cell4, Pbx_Cell4, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_Cell5, Pbx_Cell5, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_Cell6, Pbx_Cell6, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_Cell7, Pbx_Cell7, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_Cell8, Pbx_Cell8, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_Cell9, Pbx_Cell9, Point.Empty);
            Ultilities.ControlUltils.changeParent(Pnl_Cell10, Pbx_Cell10, Point.Empty);

            //clock
            Ultilities.ControlUltils.changeParent(Pbx_Clock, Pbx_LotusLeaf2, new Point(20, 0));
            Ultilities.ControlUltils.changeParent(Lbl_Clock, Pbx_Clock, new Point(5, (Pbx_Clock.Height - Lbl_Clock.Height) / 2));

            // containing boxes
            Ultilities.ControlUltils.changeParent(Pbx_LotusLeaf, Pbx_LeftBorder, new Point(59, 583));
            Ultilities.ControlUltils.changeParent(Pbx_PlayerBox, Pbx_LotusLeaf, new Point(43, 25));
            Ultilities.ControlUltils.changeParent(Pbx_BotMandarin1, Pbx_RightBorder, new Point(183, 701));
            Ultilities.ControlUltils.changeParent(Pbx_PlayerMandarin1, Pbx_LeftBorder, new Point(323, 701));
            Ultilities.ControlUltils.changeParent(Pbx_BotMandarin2, Pbx_LeftBorder, new Point(323, 20));
            Ultilities.ControlUltils.changeParent(Pbx_PlayerMandarin2, Pbx_RightBorder, new Point(183, 20));
            Ultilities.ControlUltils.changeParent(Pbx_BotBox, Pbx_RightBorder, new Point(405, 0));
            Ultilities.ControlUltils.changeParent(Pnl_PlayerBox, Pbx_PlayerBox, new Point(20, 10));
            Ultilities.ControlUltils.changeParent(Pnl_BotBox, Pbx_BotBox, new Point(20, 10));
            Ultilities.ControlUltils.changeParent(Pnl_PlayerMandarin1, Pbx_PlayerMandarin1, new Point(10, 5));
            Ultilities.ControlUltils.changeParent(Pnl_PlayerMandarin2, Pbx_PlayerMandarin2, new Point(10, 5));
            Ultilities.ControlUltils.changeParent(Pnl_BotMandarin1, Pbx_BotMandarin1, new Point(10, 5));
            Ultilities.ControlUltils.changeParent(Pnl_BotMandarin2, Pbx_BotMandarin2, new Point(10, 5));


            //player arrows 
            Pbx_LeftArrow.Name = "Pbx_LeftArrow";
            Pbx_RightArrow.Name = "Pbx_RightArrow";
            Pbx_LeftArrow.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\leftArrow.png");
            Pbx_RightArrow.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\rightArrow.png");
            Pbx_LeftArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            Pbx_RightArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            Pbx_LeftArrow.BackColor = Color.Transparent;
            Pbx_RightArrow.BackColor = Color.Transparent;
            Pbx_LeftArrow.MouseClick += Pbx_Arrow_MouseClick;
            Pbx_LeftArrow.MouseDown += Control_Choice_MouseDown;
            Pbx_LeftArrow.MouseUp += Control_Choice_MouseUp;
            Pbx_LeftArrow.MouseHover += Pbx_LeftArrow_MouseHover;
            Pbx_RightArrow.MouseHover += Pbx_RightArrow_MouseHover;
            Pbx_LeftArrow.MouseLeave += Pbx_LeftArrow_MouseLeave;
            Pbx_RightArrow.MouseLeave += Pbx_RightArrow_MouseLeave;
            Pbx_RightArrow.MouseClick += Pbx_Arrow_MouseClick;
            Pbx_RightArrow.MouseDown += Control_Choice_MouseDown;
            Pbx_RightArrow.MouseUp += Control_Choice_MouseUp;

            Program.runAnimation(AnimationState.SINK, this);
        }

        private void loadImages()
        {
            Pbx_PlayerStoneMandarin.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\playerMandarin.png");
            Pbx_BotStoneMandarin.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\botMandarin.png");
            Pbx_BotMandarin.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\mandarinCell.png");
            Pbx_BotMandarin.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Main\sand.jpg");
            Pbx_PlayerMandarin.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\mandarinCell.png");
            Pbx_PlayerMandarin.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Main\sand.jpg");

            Pbx_RightBorder.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\rightBorder.png");
            Pbx_LeftBorder.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\leftBorder.png");
            Pbx_LotusLeaf.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\lotusLeaf1.png");
            Pbx_LotusLeaf2.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\lotusLeaf2.png");
            Pbx_BotBox.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\box.png");
            Pbx_PlayerBox.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\box.png");

            Pbx_BotMandarin1.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\box.png");
            Pbx_BotMandarin2.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\box.png");
            Pbx_PlayerMandarin1.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\box.png");
            Pbx_PlayerMandarin2.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\box.png");

            Btn_Back.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Main\home.png");
            Pbx_MandarinAmount.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\trooper.png");
            Pbx_MandarinInfo.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\trooperInfo.png");
            Pbx_Clock.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\clock.gif");
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Main\background.jpg");

            Image Img_Troooper = Ultilities.ControlUltils.getImageFromFile(@"Main\trooper.png");
            int count = 0;
            foreach (Control control in Pnl_GameTable.Controls)
            {
                if (control.Name.Contains("Pnl_Cell"))
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        PictureBox Pbx_Trooper = new PictureBox
                        {
                            Image = (Image)Img_Troooper.Clone(),
                            BackColor = Color.Transparent,
                            Size = new Size(30, 22),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Name = "StoneTrooper" + (++count).ToString()
                        };
                        Ultilities.ControlUltils.changeParent(Pbx_Trooper, (Panel)control, new Point(0, 0));
                        ((Panel)control).Controls.Add(Pbx_Trooper);
                    }

                    if (int.Parse(control.Name.Substring("Pnl_Cell".Length, control.Name.Length - "Pnl_Cell".Length)) <= 5)
                        Ultilities.ControlUltils.arrangeTroopersInTopCells(control);
                    else
                        Ultilities.ControlUltils.arrangeTroopersInBotCells(control);
                }
                else if (control.Name.Contains("Pbx_Cell"))
                    ((PictureBox)control).Image = Ultilities.ControlUltils.getImageFromFile(@"Main\trooperCell.png");
            }

        }
        private void Pbx_RightArrow_MouseLeave(object sender, EventArgs e) =>
            Pbx_RightArrow.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\rightArrow.png");
        private void Pbx_LeftArrow_MouseLeave(object sender, EventArgs e) =>
            Pbx_LeftArrow.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\leftArrow.png");

        private void Pbx_RightArrow_MouseHover(object sender, EventArgs e) =>
            Pbx_RightArrow.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\rightArrowActive.png");

        private void Pbx_LeftArrow_MouseHover(object sender, EventArgs e) =>
            Pbx_LeftArrow.Image = Ultilities.ControlUltils.getImageFromFile(@"Main\leftArrowActive.png");

        //get index of choice
        private int getIdxChoice(Control pnl)
        {
            int idxCellPnl;
            switch (idxCellPnl = int.Parse(pnl.Name.Remove(0, "Pnl_Cell".Length)))
            {
                case 6:
                    return 11;
                case 7:
                    return 10;
                case 8:
                    return 9;
                case 9:
                    return 8;
                case 10:
                    return 7;
                default:
                    return idxCellPnl;
            };

        }

        //initialize data when player chose cell
        private void Pnl_Choice_MouseClick(object sender, MouseEventArgs e)
        {
            // check turn and have yet finished
            if (Turn_Flag && !isFinish() && !Flag_PlayClick && ((Panel)sender).Controls.Count > 0 && isPlayerClick)
            {
                Program.Dic_Sounds[SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
                Pnl_ManBotBin = Pnl_BotMandarin1;
                Pnl_ManPlayerBin = Pnl_PlayerMandarin1;
                Lbl_ManBotBin = Lbl_ScoreMandarinBotBox1;
                Lbl_ManPlayerBin = Lbl_ScoreMandarinPlayerBox1;
                Lbl_TrooperBin = Lbl_ScoreTroopePlayerBox;
                Pnl_ChoiceTemp = (Panel)sender;
                idxChoiceCell = getIdxChoice(Pnl_ChoiceTemp);
                showImage_MouseClick(Pnl_ChoiceTemp);
                Pnl_TrooperBin = Pnl_PlayerBox;
                CellBLL_Choice = new CellBLL(idxChoiceCell, int.Parse(Lbl_CellTable[idxChoiceCell].Text));
            }

        }
        private void Control_Choice_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();
        private void Control_Choice_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();

        //show direct arrow when player chose
        private void showImage_MouseClick(Control Pnl_Choice)
        {
            Pbx_LeftArrow.Show();
            Pbx_RightArrow.Show();
            if (Pbx_Cell != null && Pbx_Cell.BackColor != Color.Transparent)
                Pbx_Cell.BackColor = Color.WhiteSmoke;
            Pbx_Cell = (PictureBox)Pnl_Choice.Parent;
            Pbx_Cell.BackColor = Color.Cyan;
            Pbx_LeftArrow.Size = new Size(Pnl_Choice.Width / 3, Pnl_Choice.Height / 4);
            Pbx_RightArrow.Size = new Size(Pnl_Choice.Width / 3, Pnl_Choice.Height / 4);

            Ultilities.ControlUltils.changeParent(Pbx_LeftArrow, Pnl_Choice, new Point(0, 0));
            Ultilities.ControlUltils.changeParent(Pbx_RightArrow, Pnl_Choice, new Point(Pnl_Choice.Width - Pbx_RightArrow.Width - 5, 0));
        }

        // when player chose moving direction
        private void Pbx_Arrow_MouseClick(object sender, MouseEventArgs e)
        {
            isPlayerClick = false;
            Timer_Clock.Stop();
            Flag_PlayClick = true;
            //remove all arraow image in cell
            foreach (Panel pnl in Pnl_CellTable)
            {
                pnl.Controls.RemoveByKey("Pbx_LeftArrow");
                pnl.Controls.RemoveByKey("Pbx_RightArrow");
            }
            //set timer for moving
            bool flag;
            if (flag = ((PictureBox)sender).Name.Contains("Left"))
                moveRight();
            else
                moveLeft();
            RouteBll_Route.calRoute(CellBLL_Choice, flag);
            RouteBll_Route.load();

        }

        // bot movement 
        private void Pnl_ChoiceBot()
        {
            if (!isFinish())
            {
                Program.Dic_Sounds[SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();

                Timer_Clock.Stop();
                //initialize data
                Pnl_ManBotBin = Pnl_BotMandarin2;
                Pnl_ManPlayerBin = Pnl_PlayerMandarin2;
                Lbl_ManBotBin = Lbl_ScoreMandarinBotBox2;
                Lbl_ManPlayerBin = Lbl_ScoreMandarinPlayerBox2;
                Lbl_TrooperBin = Lbl_ScoreTroopeBotBox;
                //analyze the way for bot
                analysisBestWayForBot();
                Pnl_ChoiceTemp = Pnl_CellTable[idxBotMovement];
                Pnl_TrooperBin = Pnl_BotBox;
                CellBLL_Choice = new CellBLL(idxBotMovement, int.Parse(Lbl_CellTable[idxBotMovement].Text));
                idxChoiceCell = idxBotMovement;

                //move
                if (dirBotMovement)
                    moveRight();
                else
                    moveLeft();
                RouteBll_Route.calRoute(CellBLL_Choice, dirBotMovement);
                RouteBll_Route.load();
            }
        }

        public void stop_Timer(Timer timer)
        {
            timer.Stop();
            timer.Enabled = false;
            timer.Dispose();
        }

        //move left 
        private void moveLeft()
        {
            if (Pnl_ChoiceTemp.Controls.Count <= 0)
                return;
            if (Pnl_ChoiceTemp.Controls.Count >= 9)
                foreach (PictureBox e1 in Pnl_ChoiceTemp.Controls)
                    e1.Show();

            Pnl_ChoiceTemp.Controls.RemoveByKey("Pbx_PileStone");
            //((PictureBox)Pnl_ChoiceTemp.Parent).BackColor = Color.Cyan;
            int idx = idxChoiceCell;
            PictureBox Pbx_Step = new PictureBox();
            Panel Pnl_Picker = new Panel();
            for (int i = Pnl_ChoiceTemp.Controls.Count - 1; i >= 0; i--)
                Pnl_Picker.Controls.Add(Pnl_ChoiceTemp.Controls[i]);
            Lbl_MandarinAmount.Text = Pnl_Picker.Controls.Count.ToString();
            Pnl_ChoiceTemp.Controls.Clear();
            Pnl_ChoiceTemp.Parent.BackColor = Color.Transparent;
            Lbl_CellTable[idx].Text = Pnl_ChoiceTemp.Controls.Count.ToString();

            Timer Timer_SpreadTrooper = new Timer
            {
                Interval = 700,
                Enabled = true
            };
            Timer_SpreadTrooper.Tick += (e1, e2) =>
            {
                if (Back_Flag)
                {
                    Timer_SpreadTrooper.Stop();
                    Timer_SpreadTrooper.Dispose();
                    return;
                }
                //spread troopers each cell
                if (Pnl_Picker.Controls.Count > 0)
                {
                    --idxChoiceCell;
                    if (idxChoiceCell < 0)
                        idxChoiceCell = 11;
                    Pbx_MovedTrooper = (PictureBox)Pnl_Picker.Controls[(Pnl_Picker.Controls.Count - 1)];
                    Pnl_Picker.Controls.Remove(Pbx_MovedTrooper);
                    Pnl_CellTable[idxChoiceCell].Controls.Add(Pbx_MovedTrooper);
                    if (Pbx_Step != null)
                        Pbx_Step.BackColor = Color.WhiteSmoke;
                    Pnl_CellTable[idxChoiceCell].Parent.BackColor = Color.Brown;
                    Program.Dic_Sounds[SoundKind.STONE_DROPPING_SOUND].windowsMediaPlayer.controls.play();
                    Pbx_Step = (PictureBox)Pnl_CellTable[idxChoiceCell].Parent;

                    if (idxChoiceCell >= 0 && idxChoiceCell <= 5)
                        Ultilities.ControlUltils.arrangeTroopersInTopCells(Pnl_CellTable[idxChoiceCell]);
                    if (idxChoiceCell >= 6 && idxChoiceCell <= 11)
                        Ultilities.ControlUltils.arrangeTroopersInBotCells(Pnl_CellTable[idxChoiceCell]);
                    Lbl_CellTable[idx].Text = Pnl_ChoiceTemp.Controls.Count.ToString();
                    Lbl_CellTable[idxChoiceCell].Text = Pnl_CellTable[idxChoiceCell].Controls.Count.ToString();
                    Lbl_MandarinAmount.Text = Pnl_Picker.Controls.Count.ToString();
                }
                else
                {
                    Pnl_CellTable[idxChoiceCell].Parent.BackColor = Color.WhiteSmoke;
                    //stop when mandarin cells have troopers or mandarin  
                    if (idxChoiceCell == 1 && Pnl_CellTable[0].Controls.Count >= 0 ||
                    idxChoiceCell == 7 && Pnl_CellTable[6].Controls.Count >= 0)
                    {
                        Turn_Flag = !Turn_Flag;
                        if (Turn_Flag)
                            isPlayerClick = true;
                        Timer_SpreadTrooper.Stop();
                        Timer_SpreadTrooper.Dispose();
                        Timer_Clock.Start();
                        return;
                    }
                    //check if next cell is empty or not
                    idxChoiceCell--;
                    if (idxChoiceCell < 0)
                        idxChoiceCell = 11;
                    //if not empty, get amount troopers and back to continue spread
                    if (Pnl_CellTable[idxChoiceCell].Controls.Count > 0)
                    {
                        Pnl_ChoiceTemp = Pnl_CellTable[idxChoiceCell];
                        moveLeft();
                        Timer_SpreadTrooper.Stop();
                        Timer_SpreadTrooper.Dispose();
                        return;

                    }
                    // check if next cell empty or not
                    idxChoiceCell--;
                    if (idxChoiceCell < 0)
                        idxChoiceCell = 11;
                    // empty, stop because we have 2 consecutive blank cells
                    if (Pnl_CellTable[idxChoiceCell].Controls.Count == 0)
                    {
                        Timer_SpreadTrooper.Stop();
                        Timer_SpreadTrooper.Dispose();
                        Turn_Flag = !Turn_Flag;
                        if (Turn_Flag)
                            isPlayerClick = true;
                        Timer_Clock.Start();
                        return;
                    }
                    // eat this cell
                    eatCell();
                    Pnl_CellTable[idxChoiceCell].Controls.Clear();
                    Pnl_CellTable[idxChoiceCell].Parent.BackColor = Color.Transparent;
                    Lbl_CellTable[idxChoiceCell].Text = "0";
                    //check there have any cell can eat
                    Timer_SpreadTrooper.Stop();
                    Timer Timer_EatTrooper = new Timer
                    {
                        Interval = 700,
                        Enabled = true
                    };
                    Timer_EatTrooper.Tick += (e3, e4) =>
                    {
                        if (Back_Flag)
                        {
                            Timer_SpreadTrooper.Stop();
                            Timer_EatTrooper.Stop();
                            Timer_SpreadTrooper.Dispose();
                            Timer_EatTrooper.Dispose();

                            return;
                        }
                        idxChoiceCell--;
                        if (idxChoiceCell < 0)
                            idxChoiceCell = 11;

                        if (Pnl_CellTable[idxChoiceCell].Controls.Count > 0 || idxChoiceCell == 0 || idxChoiceCell == 6)
                        {
                            Lbl_TrooperBin.Text = "Ăn: " + (Pnl_TrooperBin.Controls.Count - 1).ToString();
                            Timer_EatTrooper.Stop();
                            Timer_EatTrooper.Dispose();
                            Timer_Clock.Start();
                            Turn_Flag = !Turn_Flag;
                            if (Turn_Flag)
                                isPlayerClick = true;
                            return;
                        }

                        idxChoiceCell--;
                        if (idxChoiceCell < 0)
                            idxChoiceCell = 11;

                        if (Pnl_CellTable[idxChoiceCell].Controls.Count == 0)
                        {
                            Lbl_TrooperBin.Text = "Ăn: " + (Pnl_TrooperBin.Controls.Count - 1).ToString();
                            Timer_EatTrooper.Stop();
                            Timer_EatTrooper.Dispose();
                            Timer_Clock.Start();
                            Turn_Flag = !Turn_Flag;
                            if (Turn_Flag)
                                isPlayerClick = true;
                            return;
                        }
                        eatCell();
                        Pnl_CellTable[idxChoiceCell].Controls.Clear();
                        Pnl_CellTable[idxChoiceCell].Parent.BackColor = Color.Transparent;
                        Lbl_CellTable[idxChoiceCell].Text = "0";
                    };
                }

            };


        }

        //move right
        private void moveRight()
        {
            if (Pnl_ChoiceTemp.Controls.Count <= 0)
                return;
            if (Pnl_ChoiceTemp.Controls.Count >= 9)
                foreach (PictureBox e1 in Pnl_ChoiceTemp.Controls)
                    e1.Show();
            Pnl_ChoiceTemp.Controls.RemoveByKey("Pbx_PileStone");
            ((PictureBox)Pnl_ChoiceTemp.Parent).BackColor = Color.Cyan;
            int idx = idxChoiceCell;
            PictureBox Pbx_Step = new PictureBox();
            Panel Pnl_Picker = new Panel();
            for (int i = Pnl_ChoiceTemp.Controls.Count - 1; i >= 0; i--)
                Pnl_Picker.Controls.Add(Pnl_ChoiceTemp.Controls[i]);
            Lbl_MandarinAmount.Text = Pnl_Picker.Controls.Count.ToString();
            Pnl_ChoiceTemp.Controls.Clear();
            Pnl_ChoiceTemp.Parent.BackColor = Color.Transparent;
            Lbl_CellTable[idx].Text = Pnl_ChoiceTemp.Controls.Count.ToString();
            Timer Timer_SpreadTrooper = new Timer
            {
                Interval = 700,
                Enabled = true
            };
            Timer_SpreadTrooper.Tick += (e1, e2) =>
            {
                if (Back_Flag)
                {
                    Timer_SpreadTrooper.Stop();
                    Timer_SpreadTrooper.Dispose();
                    return;
                }
                if (Pnl_Picker.Controls.Count > 0)
                {
                    ++idxChoiceCell;
                    if (idxChoiceCell > 11)
                        idxChoiceCell = 0;
                    Pbx_MovedTrooper = (PictureBox)Pnl_Picker.Controls[(Pnl_Picker.Controls.Count - 1)];
                    Pnl_Picker.Controls.Remove(Pbx_MovedTrooper);
                    Pnl_CellTable[idxChoiceCell].Controls.Add(Pbx_MovedTrooper);
                    if (Pbx_Step != null)
                        Pbx_Step.BackColor = Color.WhiteSmoke;
                    Pnl_CellTable[idxChoiceCell].Parent.BackColor = Color.Brown;
                    Program.Dic_Sounds[SoundKind.STONE_DROPPING_SOUND].windowsMediaPlayer.controls.play();
                    Pbx_Step = (PictureBox)Pnl_CellTable[idxChoiceCell].Parent;

                    if (idxChoiceCell >= 0 && idxChoiceCell <= 5)
                        Ultilities.ControlUltils.arrangeTroopersInTopCells(Pnl_CellTable[idxChoiceCell]);
                    if (idxChoiceCell >= 6 && idxChoiceCell <= 11)
                        Ultilities.ControlUltils.arrangeTroopersInBotCells(Pnl_CellTable[idxChoiceCell]);
                    Lbl_CellTable[idx].Text = Pnl_ChoiceTemp.Controls.Count.ToString();
                    Lbl_CellTable[idxChoiceCell].Text = Pnl_CellTable[idxChoiceCell].Controls.Count.ToString();
                    Lbl_MandarinAmount.Text = Pnl_Picker.Controls.Count.ToString();

                }
                else
                {
                    Pnl_CellTable[idxChoiceCell].Parent.BackColor = Color.WhiteSmoke;
                    //stop when mandarin cells have troopers or mandarin  
                    if (idxChoiceCell == 11 && Pnl_CellTable[0].Controls.Count >= 0 ||
                    idxChoiceCell == 5 && Pnl_CellTable[6].Controls.Count >= 0)
                    {
                        Turn_Flag = !Turn_Flag;
                        if (Turn_Flag)
                            isPlayerClick = true;
                        Timer_SpreadTrooper.Stop();
                        Timer_SpreadTrooper.Dispose();
                        Timer_Clock.Start();
                        return;
                    }
                    //check if next cell is empty or not
                    idxChoiceCell++;
                    if (idxChoiceCell > 11)
                        idxChoiceCell = 0;
                    //if not empty, get amount troopers and back to continue spread
                    if (Pnl_CellTable[idxChoiceCell].Controls.Count > 0)
                    {
                        Pnl_ChoiceTemp = Pnl_CellTable[idxChoiceCell];
                        moveRight();
                        Timer_SpreadTrooper.Stop();
                        Timer_SpreadTrooper.Dispose();
                        return;
                    }
                    // check if next cell empty or not
                    idxChoiceCell++;
                    if (idxChoiceCell > 11)
                        idxChoiceCell = 0;
                    // empty => stop because we have 2 consecutive blank cells
                    if (Pnl_CellTable[idxChoiceCell].Controls.Count == 0)
                    {
                        Turn_Flag = !Turn_Flag;
                        if (Turn_Flag)
                            isPlayerClick = true;
                        Timer_SpreadTrooper.Stop();
                        Timer_SpreadTrooper.Dispose();
                        Timer_Clock.Start();
                        return;
                    }

                    // eat this cell
                    eatCell();
                    Pnl_CellTable[idxChoiceCell].Controls.Clear();
                    Pnl_CellTable[idxChoiceCell].Parent.BackColor = Color.Transparent;
                    Lbl_CellTable[idxChoiceCell].Text = "0";
                    Timer_SpreadTrooper.Stop();
                    //check there have any cell can eat
                    Timer Timer_EatTrooper = new Timer
                    {
                        Interval = 700,
                        Enabled = true
                    };
                    Timer_EatTrooper.Tick += (e3, e4) =>
                    {
                        if (Back_Flag)
                        {
                            Timer_SpreadTrooper.Stop();
                            Timer_EatTrooper.Stop();
                            Timer_SpreadTrooper.Dispose();
                            Timer_EatTrooper.Dispose();
                            return;
                        }
                        idxChoiceCell++;
                        if (idxChoiceCell > 11)
                            idxChoiceCell = 0;

                        if (Pnl_CellTable[idxChoiceCell].Controls.Count > 0 || idxChoiceCell == 0 || idxChoiceCell == 6)
                        {
                            Lbl_TrooperBin.Text = "Ăn: " + (Pnl_TrooperBin.Controls.Count - 1).ToString();
                            Turn_Flag = !Turn_Flag;
                            if (Turn_Flag)
                                isPlayerClick = true;
                            Timer_EatTrooper.Stop();
                            Timer_EatTrooper.Dispose();
                            Timer_Clock.Start();
                            return;
                        }

                        idxChoiceCell++;
                        if (idxChoiceCell > 11)
                            idxChoiceCell = 0;

                        if (Pnl_CellTable[idxChoiceCell].Controls.Count == 0)
                        {
                            Lbl_TrooperBin.Text = "Ăn: " + (Pnl_TrooperBin.Controls.Count - 1).ToString();
                            Turn_Flag = !Turn_Flag;
                            if (Turn_Flag)
                                isPlayerClick = true;
                            Timer_EatTrooper.Stop();
                            Timer_EatTrooper.Dispose();
                            Timer_Clock.Start();
                            return;
                        }
                        eatCell();
                        Pnl_CellTable[idxChoiceCell].Controls.Clear();
                        Pnl_CellTable[idxChoiceCell].Parent.BackColor = Color.Transparent;
                        Lbl_CellTable[idxChoiceCell].Text = "0";
                    };
                    return;
                }
                //spread troopers each cell

            };


        }


        //analysis bot route
        //with each cell which have one trooper at least on it, calculate profit if chose that cell
        //return the index of cell which have the greatest profit 
        private void analysisBestWayForBot()
        {
            idxBotMovement = -1;
            dirBotMovement = false;
            if (isSpread())
            {
                spreadTroopers(Pnl_BotBox);
                for (int i = 1; i <= 5; i++)
                    RouteBLL.route[i].amo = 1;
            }


            int[,,] dataTab = new int[5, 4, 5];
            CellBLL[] route = RouteBll_Route.clone(RouteBLL.cellBLLs);

            int[] idxes = new int[5];
            int piv = 0;
            for (int i = 0; i < 5; i++)
            {

                RouteBLL.route = RouteBll_Route.clone(route);
                if (RouteBLL.route[i + 1].amo == 0)
                {
                    idxes[piv++] = i;
                    continue;
                }
                CellBLL cellBLLTemp = new CellBLL(i + 1, RouteBLL.route[i + 1].amo);
                //bot moves left
                int l = RouteBll_Route.calRoute(cellBLLTemp, false);
                RouteBll_Route.load();
                for (int j = 7; j <= 11; j++)
                {
                    //player moves left and right
                    CellBLL cellBLLTempPlayer = new CellBLL(j, RouteBLL.route[j].amo);
                    dataTab[i, 0, j - 7] = l - RouteBll_Route.calRoute(cellBLLTempPlayer, false);
                    cellBLLTempPlayer = new CellBLL(j, RouteBLL.route[j].amo);
                    dataTab[i, 1, j - 7] = l - RouteBll_Route.calRoute(cellBLLTempPlayer, true);
                }

                //bot moves right
                RouteBLL.route = RouteBll_Route.clone(route);
                cellBLLTemp = new CellBLL(i + 1, RouteBLL.route[i + 1].amo);
                int r = RouteBll_Route.calRoute(cellBLLTemp, true);
                RouteBll_Route.load();
                for (int j = 7; j <= 11; j++)
                {
                    //player moves left and right
                    CellBLL cellBLLTempPlayer = new CellBLL(j, RouteBLL.route[j].amo);
                    dataTab[i, 2, j - 7] = r - RouteBll_Route.calRoute(cellBLLTempPlayer, false);
                    cellBLLTempPlayer = new CellBLL(j, RouteBLL.route[j].amo);
                    dataTab[i, 3, j - 7] = r - RouteBll_Route.calRoute(cellBLLTempPlayer, true);
                }
            }

            //calculate the index of cell which has the greatest profit 
            RouteBLL.route = route;
            int pivTemp = 0;
            int max = Int32.MinValue;
            for (int i = 0; i < 5; i++)
            {
                if (i == idxes[pivTemp])
                {
                    pivTemp++;
                    continue;
                }
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 5; k++)
                        if (max < dataTab[i, j, k])
                        {
                            max = dataTab[i, j, k];
                            dirBotMovement = j >= 2;
                            idxBotMovement = i + 1;
                        }
            }

        }
        //eat cell => moving trooper, mandarin to bin
        private void eatCell()
        {
            for (int i = Pnl_CellTable[idxChoiceCell].Controls.Count - 1; i >= 0; i--)
            {
                Pbx_MovedTrooper = (PictureBox)Pnl_CellTable[idxChoiceCell].Controls[i];
                if (Pbx_MovedTrooper.Name.Contains("Pbx_PileStone"))
                    continue;
                if (Pbx_MovedTrooper.Name.Contains("BotStoneMandarin"))
                {
                    Pnl_ManBotBin.Controls.Add(Pbx_MovedTrooper);
                    Lbl_ManBotBin.Text = "Ăn: 1";
                    Ultilities.ControlUltils.arrangeMandarinBin(Pnl_ManBotBin);
                }
                else if (Pbx_MovedTrooper.Name.Contains("PlayerStoneMandarin"))
                {
                    Pnl_ManPlayerBin.Controls.Add(Pbx_MovedTrooper);
                    Lbl_ManPlayerBin.Text = "Ăn: 1";
                    Ultilities.ControlUltils.arrangeMandarinBin(Pnl_ManPlayerBin);
                }
                else
                {
                    Pnl_TrooperBin.Controls.Add(Pbx_MovedTrooper);
                    Ultilities.ControlUltils.arrangeTrooperBin(Pnl_TrooperBin);
                }
            }
        }
        //check game is finished of not
        private bool isFinish() => Pnl_CellTable[0].Controls.Count == 0 && Pnl_CellTable[6].Controls.Count == 0;

        //spread troooper when player or bot doesn't have any trooper
        private void spreadTroopers(Control pnl)
        {
            int piv = pnl.Controls.Count - 1;
            int diff = pnl.Name.Contains("Player") ? 6 : 0;
            for (int i = 1 + diff; i <= 5 + diff; i++)
            {
                //spread trooper
                Pnl_CellTable[i].Parent.BackColor = Color.WhiteSmoke;
                Lbl_CellTable[i].Text = "1";
                PictureBox Pbx_Trooper = new PictureBox();
                while (piv >= 0)
                {
                    if (!pnl.Controls[piv].Name.Contains("Pbx_PileStone"))
                    {
                        Pbx_Trooper = (PictureBox)pnl.Controls[piv];
                        Lbl_TrooperBin.Text = "Ăn: " +
                            (Int32.Parse(Lbl_TrooperBin.Text.Remove(0, "Ăn: ".Length)) - 1).ToString();
                        break;
                    }
                    piv--;
                }
                if (Pbx_Trooper != null)
                {
                    Pnl_CellTable[i].Controls.Add(Pbx_Trooper);
                    Pbx_Trooper.Show();
                    if (diff == 0)
                        Ultilities.ControlUltils.arrangeTroopersInTopCells(Pnl_CellTable[i]);
                    else Ultilities.ControlUltils.arrangeTroopersInBotCells(Pnl_CellTable[i]);
                    continue;
                }

                //rent trooper when don't have enough troopers to spread
                List<PictureBox> List_RentTroopers = rentTrooper(diff == 6 ? Pnl_PlayerBox : Pnl_BotBox, 5 - (i - diff));
                if (diff == 6)
                    Lbl_PlayerRent.Text = "Mươn: " +
                        (Int32.Parse(Lbl_PlayerRent.Text.Remove(0, "Mượn: ".Length)) + List_RentTroopers.Count).ToString();
                else
                    Lbl_BotRent.Text = "Mươn: " +
                         (Int32.Parse(Lbl_BotRent.Text.Remove(0, "Mượn: ".Length)) + List_RentTroopers.Count).ToString();
                for (int j = List_RentTroopers.Count - 1; j >= 0; j--)
                {
                    Pnl_CellTable[i].Controls.Add(List_RentTroopers[List_RentTroopers.Count - 1]);
                    List_RentTroopers[List_RentTroopers.Count - 1].Show();
                    if (diff == 0)
                        Ultilities.ControlUltils.arrangeTroopersInTopCells(Pnl_CellTable[i]);
                    else
                        Ultilities.ControlUltils.arrangeTroopersInBotCells(Pnl_CellTable[i]);
                    i++;
                }
            }

        }

        //withdraw troopers and pass data to result gui
        private void finishGame()
        {
            if (isFinish())
            {
                //withdraw data
                Timer_Clock.Enabled = false;
                for (int i = 1; i <= 5; i++)
                {
                    int amo = Pnl_CellTable[i].Controls.Count - 1;
                    while (amo >= 0)
                    {
                        if (Pnl_CellTable[i].Controls[amo].Name.Contains("StoneTrooper"))
                        {
                            Pnl_BotBox.Controls.Add(Pnl_CellTable[i].Controls[amo]);
                            Lbl_ScoreTroopeBotBox.Text = "Ăn: " +
                                (int.Parse(Lbl_ScoreTroopeBotBox.Text.Remove(0, "Ăn: ".Length)) + 1).ToString();
                        }
                        amo--;
                    }
                    Ultilities.ControlUltils.arrangeTrooperBin(Pnl_BotBox);
                    Lbl_CellTable[i].Text = "0";
                    Pnl_CellTable[i].Parent.BackColor = Color.Transparent;
                    Pnl_CellTable[i].Controls.Clear();
                }
                for (int i = 7; i <= 11; i++)
                {
                    int amo = Pnl_CellTable[i].Controls.Count - 1;
                    while (amo >= 0)
                    {
                        if (Pnl_CellTable[i].Controls[amo].Name.Contains("StoneTrooper"))
                        {
                            Pnl_PlayerBox.Controls.Add(Pnl_CellTable[i].Controls[amo]);
                            Lbl_ScoreTroopePlayerBox.Text = "Ăn: " +
                                (Int32.Parse(Lbl_ScoreTroopePlayerBox.Text.Remove(0, "Ăn: ".Length)) + 1).ToString();
                        }
                        amo--;
                    }
                    Ultilities.ControlUltils.arrangeTrooperBin(Pnl_PlayerBox);
                    Lbl_CellTable[i].Text = "0";
                    Pnl_CellTable[i].Parent.BackColor = Color.Transparent;
                    Pnl_CellTable[i].Controls.Clear();
                }

                //pass data 
                Program.changeForm(FormKind.RESULT, new ResultGUI());
                ResultGUI resultGUI = (ResultGUI)Program.Dic_Forms[FormKind.RESULT];
                resultGUI.result = getWinner();
                resultGUI.List_BotData.Add(
                    int.Parse(Lbl_ScoreTroopeBotBox.Text.Remove(0, "Ăn: ".Length)));
                resultGUI.List_BotData.Add(
                 int.Parse(Lbl_ScoreMandarinBotBox2.Text.Remove(0, "Ăn: ".Length)));
                resultGUI.List_BotData.Add(
                 int.Parse(Lbl_ScoreMandarinPlayerBox2.Text.Remove(0, "Ăn: ".Length)));
                resultGUI.List_BotData.Add(
                 int.Parse(Lbl_BotRent.Text.Remove(0, "Mượn: ".Length)));

                resultGUI.List_PlayerData.Add(
                 int.Parse(Lbl_ScoreTroopePlayerBox.Text.Remove(0, "Ăn: ".Length)));
                resultGUI.List_PlayerData.Add(
                 int.Parse(Lbl_ScoreMandarinBotBox1.Text.Remove(0, "Ăn: ".Length)));
                resultGUI.List_PlayerData.Add(
                 int.Parse(Lbl_ScoreMandarinPlayerBox1.Text.Remove(0, "Ăn: ".Length)));
                resultGUI.List_PlayerData.Add(
                 int.Parse(Lbl_PlayerRent.Text.Remove(0, "Mượn: ".Length)));
                resultGUI.loadData();
                Program.runAnimation(AnimationState.DISAPPEAR, this);
            }
        }

        //rent troopers when don't have enough troopers to spread
        private List<PictureBox> rentTrooper(Panel Pnl_Source, int amo)
        {
            List<PictureBox> List_RentTroopers = new List<PictureBox>();
            for (int i = Pnl_Source.Controls.Count - 1; i >= 0; i--)
            {
                if (Pnl_Source.Controls[i].Name.Contains("Pbx_PileStone"))
                    continue;
                List_RentTroopers.Add((PictureBox)Pnl_Source.Controls[i]);
                if (List_RentTroopers.Count > amo)
                    break;
            }
            return List_RentTroopers;
        }
        //check time to spread troopers 
        private bool isSpread()
        {
            for (int i = 1 + (Turn_Flag ? 6 : 0); i <= 5 + (Turn_Flag ? 6 : 0); i++)
                if (Pnl_CellTable[i].Controls.Count > 0)
                    return false;
            return true;
        }

        //countdown clock for player
        private int delayClock = 4;
        private bool showTurn = false;
        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            finishGame();
            if (Turn_Flag) // player 
            {
                int currTime = Int32.Parse(Lbl_Clock.Text);
                if (currTime <= 5)
                    Lbl_Clock.ForeColor = Color.Red;
                else
                    Lbl_Clock.ForeColor = Color.Black;
                if (currTime == countDown && Flag_PlayClick)
                    Flag_PlayClick = false;

                Pbx_Clock.Visible = true;

                if (currTime > countDown)
                    Lbl_Clock.Visible = false;
                else
                {
                    Program.Dic_Sounds[currTime > 0 ? 
                        (currTime > 5 ? SoundKind.TICK_SOUND : SoundKind.FAST_TICK_SOUND) :
                        SoundKind.TIMEUP_SOUND].windowsMediaPlayer.controls.play();
                    Lbl_Clock.Visible = true;
                }
                //show turn notification
                if (!showTurn && currTime <= countDown)
                {
                    showTurn = true;
                    Tnf_TurnNotification.Lbl_Turn.Text = StringManagement.PlayerTurn;
                    Tnf_TurnNotification.run();
                }

                if (isSpread())//spread troopers 
                {
                    Lbl_TrooperBin = Lbl_ScoreTroopePlayerBox;
                    spreadTroopers(Pnl_PlayerBox);
                    for (int i = 7; i <= 11; i++)
                        RouteBLL.route[i].amo = 1;
                }
                //if player don't chose any cell, when time up system will chose random cell and random direction
                currTime = Int32.Parse(Lbl_Clock.Text) - 1;
                //random choice of player when player đon't choose
                if (currTime < 0)
                {
                    isPlayerClick = false;
                    Timer_Clock.Stop();
                    Random random = new Random();
                    //loop until get valid position
                    while (Int32.Parse(Lbl_CellTable[(idxChoiceCell = random.Next(7, 12))].Text) == 0) { }

                    if (!isFinish())
                    {
                        for (int i = 7; i <= 11; i++)
                        {
                            Pnl_CellTable[i].Controls.RemoveByKey("Pbx_LeftArrow");
                            Pnl_CellTable[i].Controls.RemoveByKey("Pbx_RightArrow");
                            if (Pnl_CellTable[i].Controls.Count > 0)
                                Pnl_CellTable[i].Parent.BackColor = Color.WhiteSmoke;
                        }
                        Pnl_ManBotBin = Pnl_BotMandarin1;
                        Pnl_ManPlayerBin = Pnl_PlayerMandarin1;
                        Pnl_TrooperBin = Pnl_PlayerBox;
                        Lbl_ManBotBin = Lbl_ScoreMandarinBotBox1;
                        Lbl_ManPlayerBin = Lbl_ScoreMandarinPlayerBox1;
                        Lbl_TrooperBin = Lbl_ScoreTroopePlayerBox;
                        Pnl_ChoiceTemp = Pnl_CellTable[idxChoiceCell];
                        CellBLL_Choice = new CellBLL(idxChoiceCell, int.Parse(Lbl_CellTable[idxChoiceCell].Text));
                        if ((random.Next(0, 1) != 0))
                        {
                            moveRight();
                            RouteBll_Route.calRoute(CellBLL_Choice, true);
                        }
                        else
                        {
                            moveLeft();
                            RouteBll_Route.calRoute(CellBLL_Choice, false);
                        }
                        RouteBll_Route.load();
                    }
                }
                Lbl_Clock.Text = currTime >= 0 ? currTime.ToString() : "00";

                if (Lbl_Clock.Text.Length == 1)
                    Lbl_Clock.Text = Lbl_Clock.Text.Insert(0, "0");

            }
            else // bot
            {
                if (showTurn)
                {
                    showTurn = false;
                    Tnf_TurnNotification.Lbl_Turn.Text = StringManagement.BotTurn;
                    Tnf_TurnNotification.run();
                }
                Pbx_Clock.Visible = false;
                delayClock--;
                if (delayClock == 0)
                {
                    delayClock = 4;
                    Lbl_Clock.Text = countDown.ToString();
                    Pnl_ChoiceBot();
                }
            }

        }



        //get the winner base on total of score
        private int getWinner()
        {
            int botScore = int.Parse(Lbl_ScoreMandarinBotBox2.Text.Remove(0, "Ăn: ".Length)) * 10 +
                int.Parse(Lbl_ScoreMandarinPlayerBox2.Text.Remove(0, "Ăn: ".Length)) * 10 +
                int.Parse(Lbl_ScoreTroopeBotBox.Text.Remove(0, "Ăn: ".Length)) -
                int.Parse(Lbl_BotRent.Text.Remove(0, "Mượn: ".Length)) +
                int.Parse(Lbl_PlayerRent.Text.Remove(0, "Mượn: ".Length)) -
                int.Parse(Lbl_ScoreMandarinBotBox1.Text.Remove(0, "Ăn: ".Length)) * 10;

            int playerScore = int.Parse(Lbl_ScoreMandarinPlayerBox1.Text.Remove(0, "Ăn: ".Length)) * 10 +
                int.Parse(Lbl_ScoreMandarinBotBox1.Text.Remove(0, "Ăn: ".Length)) * 10 +
                int.Parse(Lbl_ScoreTroopePlayerBox.Text.Remove(0, "Ăn: ".Length)) +
                int.Parse(Lbl_BotRent.Text.Remove(0, "Mượn: ".Length)) -
                int.Parse(Lbl_PlayerRent.Text.Remove(0, "Mượn: ".Length)) -
                int.Parse(Lbl_ScoreMandarinPlayerBox2.Text.Remove(0, "Ăn: ".Length)) * 10;
            return playerScore - botScore;
        }

        private void Btn_Back_MouseClick(object sender, MouseEventArgs e)
        {
            Program.changeForm(FormKind.YES_NO_MESSAGE_BOX, new YesNoMessageBox(),
                   StringManagement.MessTitle, StringManagement.BackMainGame);
            if (((YesNoMessageBox)Program.Dic_Forms[FormKind.YES_NO_MESSAGE_BOX]).Flag)
            {
                Back_Flag = true;
                CharacterBLL characterBLL = (CharacterBLL)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterBLL_Key];
                CharacterDTO characterDTO = (CharacterDTO)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key];
                Timer_Clock.Stop();
                if (characterDTO.score >= 10)
                    characterDTO.score -= 10;
                characterBLL.saveCharacterDTO(characterDTO);
                Program.Dic_Bundles[StringManagement.KeyDatas.CharacterBLL_Key] = characterBLL;
                Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key] = characterDTO;
                Program.runAnimation(AnimationState.DISAPPEAR, this);
                Program.changeForm(FormKind.START, new StartGUI());

            }
        }
        private void Btn_Back_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Red;
        }
        private void Btn_Back_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.White;

        private void ChangeCursor_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();

        private void ChangeCursor_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();

        private void MainGameGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (Program.List_HiddenForms.Count <= 0)
            {
                Program.changeForm(FormKind.YES_NO_MESSAGE_BOX, new YesNoMessageBox(),
                StringManagement.MessTitle, StringManagement.Leave_Mess);
                if (((YesNoMessageBox)Program.Dic_Forms[FormKind.YES_NO_MESSAGE_BOX]).Flag)
                {
                    Back_Flag = true;
                    Application.ExitThread();
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;

        }
    }
}
