using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI.MainGaime
{
    public class TurnNotification 
    {
        public Label Lbl_Turn { get; set; }
        public int OffSetX { get; set; }
        public int DesX { get; set; }
        public int Delay { get; set; }
        public bool Show_Turn { get; set; }
        private Timer Timer_Left;
        private Timer Timer_Right;
        private bool direction;
        
        public TurnNotification()
        {
            Delay = 20;
            OffSetX = 10;
            direction = false;
            Timer_Left = new Timer();
            Timer_Right = new Timer();
            Timer_Left.Interval = 50;
            Timer_Right.Interval = 50;
            Timer_Left.Enabled = true;
            Timer_Right.Enabled = true;
            Timer_Left.Stop();
            Timer_Right.Stop();
            Timer_Left.Tick += Timer_Left_Tick;
            Timer_Right.Tick += Timer_Right_Tick; ;

        }

        private void Timer_Left_Tick(object sender, EventArgs e)
        {
            if (Lbl_Turn.Location.X > DesX && !direction)
            {
                Lbl_Turn.Location = new Point(Lbl_Turn.Location.X - OffSetX, Lbl_Turn.Location.Y);
                return;
            }
            Lbl_Turn.Location = new Point(DesX, Lbl_Turn.Location.Y);
            if (--Delay >= 0)
                return;
            direction = true;
            Timer_Left.Stop();
            Timer_Right.Start();
        }
        private void Timer_Right_Tick(object sender, EventArgs e)
        {
            if (Lbl_Turn.Location.X < DesX + Lbl_Turn.Width)
            {
                Lbl_Turn.Location = new Point(Lbl_Turn.Location.X + OffSetX, Lbl_Turn.Location.Y);
                return;
            }
            Lbl_Turn.Location = new Point(DesX + Lbl_Turn.Width, Lbl_Turn.Location.Y);
            direction = false;
            Delay = 20;
            Timer_Right.Stop();

        }


        public void run() => Timer_Left.Start();

    }
}
