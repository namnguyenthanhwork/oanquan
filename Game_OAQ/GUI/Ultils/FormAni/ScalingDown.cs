using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Ultils.FormAni
{
    class ScalingDown : FormAnimation
    {
        public int OffSetX { get; set; }
        public int OffSetY { get; set; }
        public float OffSetOpacity { get; set; }
        public ScalingDown(Form form)
        {
            this.form = form;
            timer = new Timer();
        }
        protected override void init()
        {
            OffSetY = 80;
            OffSetX = 40;
            OffSetOpacity = .012f;
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
                form.Size = new Size(form.Width - OffSetX, form.Height - OffSetY);
                if (form.Opacity > 0)
                    form.Opacity -= OffSetOpacity;
                if (form.Width < 10 && form.Height < 10)
                    stop();
            }

        }

        protected override void stop()
        {
            if (!form.IsDisposed)
            {
                form.Hide();
                Program.List_HiddenForms.Add(form);
            }
            timer.Enabled = false;
            timer.Stop();
            timer.Dispose();
        }
    }
}
