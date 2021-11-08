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

namespace GUI.Regist
{
    public partial class RegistHelpGUI : Form
    {
        public RegistHelpGUI()=>
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
        private void loadImages()
        {
            BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Regist\registHelpBg.jpg");
            Btn_Close.BackgroundImage = Ultilities.ControlUltils.getImageFromFile(@"Login\button1.png");
        }

        private void RegistHelpGUI_Load(object sender, EventArgs e)
        {
            loadImages();
            Cursor = Ultilities.ControlUltils.changeCursorUp();
            Program.runAnimation(AnimationState.SCALING_UP, this);

        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Program.runAnimation(AnimationState.SCALING_DOWN, this);
            RegistGUI.Btn_HelpTemp.Enabled = true;
        }
        //change background color when mouse hover
        private void Btn_MouseHover(object sender, EventArgs e)
        {
            Program.Dic_Sounds[Ultils.Enum.SoundKind.CHOICE_SOUND].windowsMediaPlayer.controls.play();
            ((Button)sender).ForeColor = Color.Blue;
        }
        //change background color when mouse leave
        private void Btn_MouseLeave(object sender, EventArgs e) =>
            ((Button)sender).ForeColor = Color.Cyan;

        private void Btn_MouseDown(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorDown();

        private void Btn_MouseUp(object sender, MouseEventArgs e) =>
            Cursor = Ultilities.ControlUltils.changeCursorUp();
    }
}
