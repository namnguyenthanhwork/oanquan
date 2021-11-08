using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Ultils.FormAni
{
    public class ScrollUp : FormAnimation
    {
        public int OffSetY { get; set; }
        public float OffSetOpacity { get; set; }
        public int DesY { get; set; }
        public ScrollUp(Form form)
        {
            this.form = form;
            timer = new Timer();

        }
        protected override void init()
        {
            OffSetY =50;
            OffSetOpacity = .012f;
            DesY = 10;
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
                form.Size = new Size(form.Width, form.Height - OffSetY);
                if (form.Opacity > 0)
                    form.Opacity -= OffSetOpacity;
                if (form.Height < DesY)
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
