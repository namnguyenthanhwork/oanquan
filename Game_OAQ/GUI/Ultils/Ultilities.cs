using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;
using System.Windows.Forms;
using System.Drawing;

namespace GUI
{
    public class Ultilities
    {
        public class SoundUltils
        {
            public WindowsMediaPlayer windowsMediaPlayer { get; set; }
            public SoundUltils(string URL)
            {
                windowsMediaPlayer = new WindowsMediaPlayer
                {
                    URL = Application.StartupPath + URL
                };
                windowsMediaPlayer.controls.stop();
            }
        }
        public class ControlUltils
        {
            // change parent control and set position of specontrolcific 
            public static void changeParent(Control Control_Child, Control Control_Parent, Point Point_Location)
            {
                Control_Child.Location = Control_Child.PointToClient(Control_Child.PointToScreen(Point_Location));
                Control_Child.Parent = Control_Parent;
            }
            public static Cursor changeCursorUp() => new Cursor(new Bitmap(getImageFromFile(@"\Shared\handUp.png"), new Size(50, 50)).GetHicon());
            public static Cursor changeCursorDown() => new Cursor(new Bitmap(getImageFromFile(@"\Shared\handDown.png"), new Size(50, 50)).GetHicon());
            public static Image getImageFromFile(string url) => Image.FromFile(Application.StartupPath + @"\images\" + url);

            // Arrange troopes 
            public static void arrangeTroopersInTopCells(Control Pnl_Choice)
            {
                int Padding_TopBot = 15;
                int Padding_LeftRight = 15;
                int width = Pnl_Choice.Width - Padding_LeftRight * 2;
                int height = Pnl_Choice.Height - Padding_TopBot * 2;
                ControlUltils controlUltils = new ControlUltils();
                switch (Pnl_Choice.Controls.Count)
                {
                    case 1:
                        controlUltils.arrangeOneTopBot(Pnl_Choice, width, height, Padding_TopBot, Padding_LeftRight);
                        break;
                    case 2:
                        controlUltils.arrangeTwoTopBot(Pnl_Choice, width, height, Padding_TopBot, Padding_LeftRight);
                        break;
                    case 3:
                        controlUltils.arrangeThreeTop(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 4:
                        controlUltils.arrangeFourTopBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 5:
                        controlUltils.arrangeFiveTop(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 6:
                        controlUltils.arrangeSixTopBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 7:
                        controlUltils.arrangeSevenTop(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 8:
                        controlUltils.arrangeEightTop(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 9:
                        controlUltils.arrangeNineTopBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    default:
                        controlUltils.arrangeMoreNineTopBot(Pnl_Choice, width, height, Padding_TopBot, Padding_LeftRight);
                        break;
                }

            }
            public static void arrangeTroopersInBotCells(Control Pnl_Choice)
            {
                int Padding_TopBot = 15;
                int Padding_LeftRight = 15;
                int width = Pnl_Choice.Width - Padding_LeftRight * 2;
                int height = Pnl_Choice.Height - Padding_TopBot * 2;
                ControlUltils controlUltils = new ControlUltils();
                switch (Pnl_Choice.Controls.Count)
                {
                    case 1:
                        controlUltils.arrangeOneTopBot(Pnl_Choice, width, height, Padding_TopBot, Padding_LeftRight);
                        break;
                    case 2:
                        controlUltils.arrangeTwoTopBot(Pnl_Choice, width, height, Padding_TopBot, Padding_LeftRight);
                        break;
                    case 3:
                        controlUltils.arrangeThreeeBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 4:
                        controlUltils.arrangeFourTopBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 5:
                        controlUltils.arrangeFiveBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 6:
                        controlUltils.arrangeSixTopBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 7:
                        controlUltils.arrangeSevenBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 8:
                        controlUltils.arrangeEightBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    case 9:
                        controlUltils.arrangeNineTopBot(Pnl_Choice, width, height, Padding_LeftRight);
                        break;
                    default:
                        controlUltils.arrangeMoreNineTopBot(Pnl_Choice, width, height, Padding_TopBot, Padding_LeftRight);
                        break;

                }
            }
            public static void arrangeTrooperBin(Control Pnl_Choice)
            {
                if (Pnl_Choice.Controls.Count == 1 && Pnl_Choice.Controls[0].Name.Contains("Pbx_PileStone"))
                {
                    Pnl_Choice.Controls.Clear();
                    return;
                }
                foreach (PictureBox p in Pnl_Choice.Controls)
                    p.Hide();
                PictureBox pbx = new PictureBox
                {
                    Image = getImageFromFile(@"Main\pileStone.png"),
                    Name = "Pbx_PileStone",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(60, 60),
                };
                pbx.Location = new Point((Pnl_Choice.Width - pbx.Width) / 2, (Pnl_Choice.Height - pbx.Height) / 2);
                Pnl_Choice.Controls.RemoveByKey("Pbx_PileStone");
                Pnl_Choice.Controls.Add(pbx);

            }
            public static void arrangeMandarinBin(Control Pnl_Choice)
            {
                if (Pnl_Choice.Controls.Count > 0)
                {
                    PictureBox p = (PictureBox)Pnl_Choice.Controls[0];
                    p.Size = p.Name.Contains("2") ? new Size(60, 45) : new Size(50, 35);
                    p.Location = new Point(
                         5 + (Pnl_Choice.Width - p.Width) / 2,
                        (p.Name.Contains("2") ? -5 : 5) + (Pnl_Choice.Height - p.Height) / 2);

                }
            }
            private void arrangeOneTopBot(Control Pnl_Choice, int width, int height, int Padding_TopBot, int Padding_LeftRight)
            {
                Control trooper = Pnl_Choice.Controls[0];
                trooper.Location = new Point(Padding_LeftRight + (width - trooper.Width) / 2, Padding_TopBot + (height - trooper.Height) / 2);
            }
            private void arrangeTwoTopBot(Control Pnl_Choice, int width, int height, int Padding_TopBot, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                trooper1.Location = new Point(Padding_LeftRight + (width / 2 - trooper1.Width) / 2, Padding_TopBot + (height - trooper1.Height) / 2);
                trooper2.Location = new Point(width / 2 + trooper1.Location.X, trooper1.Location.Y);
            }
            private void arrangeThreeTop(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                trooper1.Location = new Point(Padding_LeftRight + (width / 2 - trooper1.Width) / 2, (height - trooper1.Height) / 2);
                trooper2.Location = new Point(Padding_LeftRight + width / 2 + trooper1.Location.X, trooper1.Location.Y);
                trooper3.Location = new Point(
                    trooper1.Location.X + (trooper2.Location.X + trooper2.Width - trooper1.Location.X - trooper3.Width) / 2,
                    trooper1.Location.Y + trooper1.Height + 16);
            }
            private void arrangeThreeeBot(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                trooper1.Location = new Point(Padding_LeftRight + (width - trooper1.Width) / 2, (height - trooper1.Height) / 2);
                trooper2.Location = new Point(Padding_LeftRight + (width / 2 - trooper2.Width) / 2, trooper1.Location.Y + trooper1.Height + 10);
                trooper3.Location = new Point(width / 2 + trooper2.Location.X, trooper2.Location.Y);
            }
            private void arrangeFourTopBot(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                Control trooper4 = Pnl_Choice.Controls[3];
                trooper1.Location = new Point(Padding_LeftRight + (width / 2 - trooper1.Width) / 2, (height - trooper1.Height) / 2);
                trooper2.Location = new Point(width / 2 + trooper1.Location.X, trooper1.Location.Y);
                trooper3.Location = new Point(trooper1.Location.X, trooper1.Location.Y + trooper1.Height + 10);
                trooper4.Location = new Point(trooper2.Location.X, trooper3.Location.Y);
            }
            private void arrangeFiveTop(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                Control trooper4 = Pnl_Choice.Controls[3];
                Control trooper5 = Pnl_Choice.Controls[4];
                trooper1.Location = new Point(Padding_LeftRight + (width / 2 - trooper1.Width) / 2, (Pnl_Choice.Height - height) / 2);
                trooper2.Location = new Point(width / 2 + trooper1.Location.X, trooper1.Location.Y);
                trooper3.Location = new Point(trooper1.Location.X, trooper1.Location.Y + trooper1.Height + 10);
                trooper4.Location = new Point(trooper2.Location.X, trooper3.Location.Y);
                trooper5.Location = new Point(
                  trooper3.Location.X + (trooper4.Location.X + trooper4.Width - trooper3.Location.X - trooper5.Width) / 2,
                   trooper3.Location.Y + trooper3.Height + 10);
            }
            private void arrangeFiveBot(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                Control trooper4 = Pnl_Choice.Controls[3];
                Control trooper5 = Pnl_Choice.Controls[4];
                trooper1.Location = new Point(Padding_LeftRight + (width - trooper1.Width) / 2, (Pnl_Choice.Height - height) / 2);
                trooper2.Location = new Point(Padding_LeftRight + (width / 2 - trooper2.Width) / 2, trooper1.Location.Y + trooper1.Height + 10);
                trooper3.Location = new Point(width / 2 + trooper2.Location.X, trooper2.Location.Y);
                trooper4.Location = new Point(trooper2.Location.X, trooper2.Location.Y + trooper2.Height + 10);
                trooper5.Location = new Point(trooper3.Location.X, trooper4.Location.Y);
            }
            private void arrangeSixTopBot(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                Control trooper4 = Pnl_Choice.Controls[3];
                Control trooper5 = Pnl_Choice.Controls[4];
                Control trooper6 = Pnl_Choice.Controls[5];
                trooper1.Location = new Point(Padding_LeftRight + (width / 2 - trooper1.Width) / 2, (Pnl_Choice.Height - height) / 2);
                trooper2.Location = new Point(width / 2 + trooper1.Location.X, trooper1.Location.Y);
                trooper3.Location = new Point(trooper1.Location.X, trooper1.Location.Y + trooper1.Height + 10);
                trooper4.Location = new Point(trooper2.Location.X, trooper3.Location.Y);
                trooper5.Location = new Point(trooper3.Location.X, trooper3.Location.Y + trooper3.Height + 10);
                trooper6.Location = new Point(trooper4.Location.X, trooper5.Location.Y);
            }
            private void arrangeSevenTop(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                Control trooper4 = Pnl_Choice.Controls[3];
                Control trooper5 = Pnl_Choice.Controls[4];
                Control trooper6 = Pnl_Choice.Controls[5];
                Control trooper7 = Pnl_Choice.Controls[6];
                trooper1.Location = new Point(Padding_LeftRight + (width / 3 - trooper1.Width) / 2, (Pnl_Choice.Height - height) / 2);
                trooper2.Location = new Point(width / 3 + trooper1.Location.X, trooper1.Location.Y);
                trooper3.Location = new Point(width / 3 + trooper2.Location.X, trooper2.Location.Y);
                trooper4.Location = new Point(trooper1.Location.X, trooper1.Location.Y + trooper1.Height + 10);
                trooper5.Location = new Point(trooper2.Location.X, trooper4.Location.Y);
                trooper6.Location = new Point(trooper3.Location.X, trooper5.Location.Y);
                trooper7.Location = new Point(trooper5.Location.X, trooper5.Location.Y + trooper5.Height + 10);
            }
            private void arrangeSevenBot(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                Control trooper4 = Pnl_Choice.Controls[3];
                Control trooper5 = Pnl_Choice.Controls[4];
                Control trooper6 = Pnl_Choice.Controls[5];
                Control trooper7 = Pnl_Choice.Controls[6];
                trooper1.Location = new Point(Padding_LeftRight + (width - trooper1.Width) / 2, (Pnl_Choice.Height - height) / 2);
                trooper2.Location = new Point(Padding_LeftRight + (width / 3 - trooper2.Width) / 2, trooper1.Location.Y + trooper1.Height + 10);
                trooper3.Location = new Point(width / 3 + trooper2.Location.X, trooper2.Location.Y);
                trooper4.Location = new Point(width / 3 + trooper3.Location.X, trooper3.Location.Y);
                trooper5.Location = new Point(trooper2.Location.X, trooper2.Location.Y + trooper2.Height + 10);
                trooper6.Location = new Point(trooper3.Location.X, trooper3.Location.Y + trooper3.Height + 10);
                trooper7.Location = new Point(trooper4.Location.X, trooper4.Location.Y + trooper4.Height + 10);
            }
            private void arrangeEightTop(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                Control trooper4 = Pnl_Choice.Controls[3];
                Control trooper5 = Pnl_Choice.Controls[4];
                Control trooper6 = Pnl_Choice.Controls[5];
                Control trooper7 = Pnl_Choice.Controls[6];
                Control trooper8 = Pnl_Choice.Controls[7];
                trooper1.Location = new Point(Padding_LeftRight + (width / 3 - trooper1.Width) / 2, (Pnl_Choice.Height - height) / 2);
                trooper2.Location = new Point(width / 3 + trooper1.Location.X, trooper1.Location.Y);
                trooper3.Location = new Point(width / 3 + trooper2.Location.X, trooper2.Location.Y);
                trooper4.Location = new Point(trooper1.Location.X, trooper1.Location.Y + trooper1.Height + 10);
                trooper5.Location = new Point(trooper2.Location.X, trooper4.Location.Y);
                trooper6.Location = new Point(trooper3.Location.X, trooper5.Location.Y);
                trooper7.Location = new Point(
                  trooper4.Location.X + (trooper5.Location.X + trooper5.Width - trooper4.Location.X - trooper7.Width) / 2,
                   trooper4.Location.Y + trooper4.Height + 10);
                trooper8.Location = new Point(
                  trooper5.Location.X + (trooper6.Location.X + trooper6.Width - trooper5.Location.X - trooper8.Width) / 2,
                   trooper5.Location.Y + trooper5.Height + 10);
            }
            private void arrangeEightBot(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                Control trooper4 = Pnl_Choice.Controls[3];
                Control trooper5 = Pnl_Choice.Controls[4];
                Control trooper6 = Pnl_Choice.Controls[5];
                Control trooper7 = Pnl_Choice.Controls[6];
                Control trooper8 = Pnl_Choice.Controls[7];
                trooper1.Location = new Point(Padding_LeftRight + (width / 2 - trooper1.Width) / 2, (Pnl_Choice.Height - height) / 2);
                trooper2.Location = new Point(width / 2 + trooper1.Location.X, trooper1.Location.Y);
                trooper3.Location = new Point(Padding_LeftRight + (width / 3 - trooper3.Width) / 2, trooper1.Location.Y + trooper1.Height + 10);
                trooper4.Location = new Point(width / 3 + trooper3.Location.X, trooper3.Location.Y);
                trooper5.Location = new Point(width / 3 + trooper4.Location.X, trooper4.Location.Y);
                trooper6.Location = new Point(trooper3.Location.X, trooper3.Location.Y + trooper3.Height + 10);
                trooper7.Location = new Point(trooper4.Location.X, trooper4.Location.Y + trooper4.Height + 10);
                trooper8.Location = new Point(trooper5.Location.X, trooper5.Location.Y + trooper5.Height + 10);
            }
            private void arrangeNineTopBot(Control Pnl_Choice, int width, int height, int Padding_LeftRight)
            {
                Control trooper1 = Pnl_Choice.Controls[0];
                Control trooper2 = Pnl_Choice.Controls[1];
                Control trooper3 = Pnl_Choice.Controls[2];
                Control trooper4 = Pnl_Choice.Controls[3];
                Control trooper5 = Pnl_Choice.Controls[4];
                Control trooper6 = Pnl_Choice.Controls[5];
                Control trooper7 = Pnl_Choice.Controls[6];
                Control trooper8 = Pnl_Choice.Controls[7];
                Control trooper9 = Pnl_Choice.Controls[8];
                trooper1.Location = new Point(Padding_LeftRight + (width / 3 - trooper1.Width) / 2, (Pnl_Choice.Height - height) / 2);
                trooper2.Location = new Point(width / 3 + trooper1.Location.X, trooper1.Location.Y);
                trooper3.Location = new Point(width / 3 + trooper2.Location.X, trooper2.Location.Y);
                trooper4.Location = new Point(trooper1.Location.X, trooper1.Location.Y + trooper1.Height + 10);
                trooper5.Location = new Point(trooper2.Location.X, trooper4.Location.Y);
                trooper6.Location = new Point(trooper3.Location.X, trooper5.Location.Y);
                trooper7.Location = new Point(trooper4.Location.X, trooper4.Location.Y + trooper4.Height + 10);
                trooper8.Location = new Point(trooper5.Location.X, trooper7.Location.Y);
                trooper9.Location = new Point(trooper6.Location.X, trooper7.Location.Y);
            }
            private void arrangeMoreNineTopBot(Control Pnl_Choice, int width, int height, int Padding_TopBot, int Padding_LeftRight)
            {
                PictureBox Pbx_Mandarin = new PictureBox();
                foreach (PictureBox e in Pnl_Choice.Controls)
                {
                    if (!e.Name.Contains("Mandarin"))
                        e.Hide();
                    else
                        Pbx_Mandarin = e;
                }
                PictureBox Pbx_PileStone = new PictureBox
                {
                    Image = getImageFromFile(@"Main\pileStone.png"),
                    Name = "Pbx_PileStone",
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                if (Pnl_Choice.Name.Contains("Mandarin"))
                {
                    Pbx_PileStone.Size = Pbx_Mandarin.Size;
                    if (Pnl_Choice.Name.Contains("Bot"))
                    {
                        Pbx_Mandarin.Location =
                            new Point((Pnl_Choice.Width - Pbx_Mandarin.Width) / 2, (Pnl_Choice.Height / 2 - Pbx_Mandarin.Height) / 2 + 20);
                        Pbx_PileStone.Location =
                            new Point((Pnl_Choice.Width - Pbx_PileStone.Width) / 2, Pnl_Choice.Height / 2 + (Pnl_Choice.Height / 2 - Pbx_PileStone.Height) / 2 - 20);
                    }
                    else
                    {
                        Pbx_PileStone.Location =
                            new Point((Pnl_Choice.Width - Pbx_PileStone.Width) / 2, (Pnl_Choice.Height / 2 - Pbx_PileStone.Height) / 2 + 20);
                        Pbx_Mandarin.Location =
                            new Point((Pnl_Choice.Width - Pbx_Mandarin.Width) / 2, Pnl_Choice.Height / 2 + (Pnl_Choice.Height / 2 - Pbx_Mandarin.Height) / 2 - 20);
                    }
                }
                else
                {
                    Pbx_PileStone.Size = new Size(width / 2, height / 2);
                    Pbx_PileStone.Location = new Point(Padding_LeftRight + (width - Pbx_PileStone.Width) / 2, Padding_TopBot + (height - Pbx_PileStone.Height) / 2);
                }

                Pnl_Choice.Controls.RemoveByKey("Pbx_PileStone");
                Pnl_Choice.Controls.Add(Pbx_PileStone);

            }

        }
    }
}
