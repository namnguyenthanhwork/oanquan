using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Ultils.FormAni
{
    public class ScrollDown : FormAnimation
    {
        public int OffSetY { get; set; }
        public float OffSetOpacity { get; set; }
        public int DesY { get; set; }
        public Point Location { get; set; }
        public ScrollDown(Form form)
        {
            this.form = form;
            timer = new Timer();

        }
        protected override void init()
        {
            OffSetY =60;
            OffSetOpacity = .1f;
            DesY = form.Location.Y + form.Height;
            form.Size = new Size(form.Width, 1);
            form.Opacity = 0;
            timer.Interval = 1;
            timer.Tick += (e1, e2) => start();
            timer.Enabled = true;
            timer.Stop();
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
                form.Size = new Size(form.Width, form.Location.Y + form.Height < DesY ? form.Height + OffSetY : DesY - form.Location.Y);
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
