using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using GUI.Ultils;

namespace GUI.Start
{
    public partial class UserInformationGUI : Form
    {
        public static int Width_Container;
        public static int Height_Container;
        public UserInformationGUI() =>

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
        private void UserInformationGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            CharacterDTO characterDTO = (CharacterDTO)Program.Dic_Bundles[StringManagement.KeyDatas.CharacterDTO_Key];
            Lbl_Username.Text = characterDTO.username;
            Lbl_Name.Text = characterDTO.name;
            Lbl_Score.Text = characterDTO.score.ToString();
            Lbl_Score.Location = new Point((Width - Lbl_Score.Width) / 2, Lbl_Score.Location.Y);
            Ultilities.ControlUltils.changeParent(Lbl_Title, Pbx_Title,
                new Point((Pbx_Title.Width - Lbl_Title.Width) / 2, (Pbx_Title.Height - Lbl_Title.Height) / 2));
            Ultilities.ControlUltils.changeParent(Lbl_ScoreTitle, Pbx_Score,
                 new Point((Pbx_Score.Width - Lbl_ScoreTitle.Width) / 2, 20));

            StartGUI startGUI = (StartGUI)Program.Dic_Forms[FormKind.START];
            Location = new Point(startGUI.Location.X + startGUI.Width - (int)(Width_Container / 2.2) - Width,
                    startGUI.Location.Y + startGUI.Height - Height - Height_Container - 30);
            Program.runAnimation(AnimationState.SCROLL_DOWN, this);
        }

        private void loadImages()
        {
            Pbx_Title.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");
            Pbx_Score.Image = Ultilities.ControlUltils.getImageFromFile(@"Rank\rank.png");
            Pnl_Bg.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Start\settingBg.jpg");
        }
    }
}
