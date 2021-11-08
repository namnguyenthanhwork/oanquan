using GUI.Ultils;
using GUI.Ultils.FormAni;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI.Start
{
    public class Setting
    {
        public Panel Pnl_Container { get; set; }
        public int OffSetX { get; set; }
        public int Step { get; set; }
        public bool Dir { get; set; }
        private Timer Timer_Duration;

        private Point Point_Destination;
        private bool isShowDialog_Account = false;
        private bool isShowDialog_Volume = false;
        public Setting(Panel Pnl_Container)
        {

            this.Pnl_Container = Pnl_Container;
            init();
        }

        private void init()
        {
            UserInformationGUI.Width_Container = Pnl_Container.Width;
            UserInformationGUI.Height_Container = Pnl_Container.Height;
            VolumeInformationGUI.Width_Container = Pnl_Container.Width;
            VolumeInformationGUI.Height_Container = Pnl_Container.Height;
            OffSetX = 0;
            OffSetX = 0;
            Dir = false;
            Timer_Duration = new Timer();
            Timer_Duration.Enabled = false;
            Timer_Duration.Interval = 1;
            Timer_Duration.Tick += Timer_Duration_Tick;
            foreach (Control control in Pnl_Container.Controls)
                ((Button)control).MouseClick += Btn_MouseClick;
        }
        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "Btn_Setting":
                    Btn_Show_MouseClick(sender, e);
                    return;
                case "Btn_Account":
                    Btn_Account_MouseClick(sender, e);
                    return;
                case "Btn_Volume":
                    Btn_Volume_MouseClick(sender, e);
                    return;
            }
        }

        private void Btn_Show_MouseClick(object sender, MouseEventArgs e)
        {
            if (isShowDialog_Account || isShowDialog_Volume)
            {
                isShowDialog_Account = isShowDialog_Volume = false;
                if (Program.Dic_Forms.ContainsKey(FormKind.USER_INFORMATION))
                    Program.Dic_Forms[FormKind.USER_INFORMATION].Close();
               
                if (Program.Dic_Forms.ContainsKey(FormKind.VOLUMN_INFORMATION))
                    Program.Dic_Forms[FormKind.VOLUMN_INFORMATION].Close();
                
            }
            Point_Destination =
                new Point(Dir ? Pnl_Container.Location.X + OffSetX : Pnl_Container.Location.X - OffSetX,
                        Pnl_Container.Location.Y);

            Timer_Duration.Enabled = true;
            Timer_Duration.Start();
        }
        private void Btn_Account_MouseClick(object sender, MouseEventArgs e)
        {

            isShowDialog_Account = true;
            if (Program.Dic_Forms.ContainsKey(FormKind.USER_INFORMATION))
                Program.Dic_Forms[FormKind.USER_INFORMATION].Close();
            if (Program.Dic_Forms.ContainsKey(FormKind.VOLUMN_INFORMATION))
            {
                Program.Dic_Forms[FormKind.VOLUMN_INFORMATION].Close();
                isShowDialog_Volume = false;
            }
            Program.changeForm(FormKind.USER_INFORMATION, new UserInformationGUI());


        }
        private void Btn_Volume_MouseClick(object sender, MouseEventArgs e)
        {
            isShowDialog_Volume = true;
            if (Program.Dic_Forms.ContainsKey(FormKind.VOLUMN_INFORMATION))
            
                Program.Dic_Forms[FormKind.VOLUMN_INFORMATION].Close();
            
            if (Program.Dic_Forms.ContainsKey(FormKind.USER_INFORMATION))
            {
                Program.Dic_Forms[FormKind.USER_INFORMATION].Close();
                isShowDialog_Account = false;
            }
            Program.changeForm(FormKind.VOLUMN_INFORMATION, new VolumeInformationGUI());

        }

        public void moveLeft()
        {
            Pnl_Container.Location = Pnl_Container.Location.X > Point_Destination.X ?
                new Point(Pnl_Container.Location.X - Step, Pnl_Container.Location.Y) :
                         Point_Destination;
        }
        public void moveRight()
        {
            Pnl_Container.Location = Pnl_Container.Location.X < Point_Destination.X ?
                    new Point(Pnl_Container.Location.X + Step, Pnl_Container.Location.Y) :
                    Point_Destination;
        }
        private void Timer_Duration_Tick(object sender, EventArgs e)
        {
            if (Pnl_Container.Location.X == Point_Destination.X)
            {
                Dir = !Dir;
                Timer_Duration.Stop();
                Timer_Duration.Enabled = false;
                return;
            }
            if (!Dir)
                moveLeft();
            else
                moveRight();
        }
        public void dispose()
        {
            if (Program.Dic_Forms.ContainsKey(FormKind.USER_INFORMATION))
            {
                Program.Dic_Forms[FormKind.USER_INFORMATION].Close();
                Program.Dic_Forms.Remove(FormKind.USER_INFORMATION);
            }
            if (Program.Dic_Forms.ContainsKey(FormKind.VOLUMN_INFORMATION))
            {
                Program.Dic_Forms[FormKind.VOLUMN_INFORMATION].Close();
                Program.Dic_Forms.Remove(FormKind.VOLUMN_INFORMATION);
            }
        }
    }
}
