using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Ultils.FormAni
{
    public class DisappearAnimation : FormAnimation
    {
        public float OffSetOpacity { get; set; }
        private static bool flag = false;
        public DisappearAnimation(Form form)
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
            OffSetOpacity = .1f;
            timer.Interval = 1;
            timer.Tick += (e1, e2) => start(); ;
            timer.Enabled = true;
            timer.Stop();
        }

        protected override void start()
        {
            disposeHiddenForms();
            if (!form.IsDisposed && (form.Opacity -= OffSetOpacity) <= 0)
            {
                //MessageBox.Show("");
                stop();
            }
        }

        protected override void stop()
        {
            if (!form.IsDisposed)
            {
                form.Hide();
                if (form.Name.Contains("LogIn") && !flag)
                {
                    flag = true;
                    form.Enabled = false;
                    foreach (Control control in form.Controls)
                        control.Dispose();
                    GC.Collect();
                }
                else
                    Program.List_HiddenForms.Add(form);
    
            }
            timer.Enabled = false;
            timer.Stop();
            timer.Dispose();
            
        }
    }
}
