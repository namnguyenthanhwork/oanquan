using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Ultils.FormAni
{
    class ScalingUp : FormAnimation
    {
        public int DesX { get; set; }
        public int DesY { get; set; }
        public int OffSetX { get; set; }
        public int OffSetY { get; set; }
        public float OffSetOpacity { get; set; }
        public ScalingUp(Form form)
        {
            this.form = form;
            timer = new Timer();
        }
        protected override void init()
        {
            DesX = 360;
            DesY = 620;
            OffSetY = 40;
            OffSetX = 20;
            form.Opacity = 0;
            OffSetOpacity = .05f;
            form.Size = new Size(1, 1);
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
                if (form.Width < DesX)
                    form.Size = new Size(form.Width + OffSetX, form.Height);
                if (form.Height < DesY)
                    form.Size = new Size(form.Width, form.Height + OffSetY);
                if (form.Opacity < 1)
                    form.Opacity += OffSetOpacity;
                if (form.Width >= DesX && form.Height >= DesY && form.Opacity >= 1)
                    stop();
            }
        }

        protected override void stop()
        {
            if (!form.IsDisposed)
                form.Size = new Size(DesX, DesY);
            timer.Stop();
            timer.Enabled = false;
            timer.Dispose();

        }
    }
}
