using GUI.MessageBoxes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Ultils.FormAni
{
    public class FloatAnimation : FormAnimation
    {
        public int DesY { get; set; }
        public int OffSetY { get; set; }
        public float OffSetOpacity { get; set; }
        public FloatAnimation(Form form)
        {
            this.form = form;
            timer = new Timer();
        }
        protected override void init()
        {
            OffSetY = 14;
            DesY = (Screen_Height - form.Height) / 2;
            OffSetOpacity = .01f;
            form.Location = new Point((Screen_Width - form.Width) / 2, Screen_Height);
            form.Opacity = 0;
            timer.Interval = 1;
            timer.Enabled = true;
            timer.Stop();
            timer.Tick += (e1, e2) => start();
        }

        public override void run()
        {
            init();
            timer.Start();
        }

        protected override void start()
        {
            disposeHiddenForms();
            if (!form.IsDisposed)
            {
                if (form.Location.Y > DesY)
                    form.Location = new Point(form.Location.X, form.Location.Y - OffSetY);

                if ((form.Opacity += OffSetOpacity) >= 1)
                    stop();
            }

        }
        protected override void stop()
        {
            if (!form.IsDisposed)
            
                form.Opacity = 1;
            
            timer.Stop();
            timer.Enabled = false;
            timer.Dispose();
        }
    }
}
