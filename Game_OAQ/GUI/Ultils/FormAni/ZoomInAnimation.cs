using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Ultils.FormAni
{
    public class ZoomInAnimation : FormAnimation
    {
        private Size size;
        public int OffSetX { get; set; }
        public int OffSetY { get; set; }
        public float OffSetOpacity { get; set; }


        public ZoomInAnimation(Form form)
        {
            this.form = form;
            timer = new Timer();
        }
        protected override void init()
        {
            OffSetOpacity = .008f;
            size = form.Size;
            form.Location = new Point((Screen_Width - form.Width) / 2, (Screen_Height - form.Height) / 2);
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
            if (!form.IsDisposed && (form.Opacity += OffSetOpacity) >= 1)
                stop();
        }

        protected override void stop()
        {
            timer.Stop();
            timer.Enabled = false;
            timer.Dispose();
        }
    }
}
