using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Ultils.FormAni
{
    public class SinkAnimation : FormAnimation
    {
        public int DesY { get; set; }
        public int OffSetY { get; set; }

        public float OffSetOpacity { get; set; }
        public SinkAnimation(Form form)
        {
            this.form = form;
            timer = new Timer();
        }
        public override void run()
        {
            init();
            timer.Start();
        }

        protected override void init()
        {
            DesY = (Screen_Height - form.Height) / 2;
            OffSetOpacity = .016f;
            OffSetY = 20;
            form.Location = new Point((Screen_Width - form.Width) / 2, -form.Height);
            form.Opacity = 0;
            timer.Interval = 1;
            timer.Tick += (e1, e2) => start();
            timer.Enabled = true;
            timer.Stop();
        }

        protected override void start()
        {
            disposeHiddenForms();
            if (!form.IsDisposed)
            {
                if (form.Location.Y < DesY)
                    form.Location = new Point(form.Location.X, form.Location.Y + OffSetY);
                if ((form.Opacity += OffSetOpacity) >= 1)
                {
                    form.Location = new Point(form.Location.X, DesY);
                    stop();
                }
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
