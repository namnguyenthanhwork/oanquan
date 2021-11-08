using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Ultils.FormAni
{
    public abstract class FormAnimation
    {

        protected static int Screen_Width = Screen.PrimaryScreen.Bounds.Width;
        protected static int Screen_Height = Screen.PrimaryScreen.Bounds.Height;
        protected static int Screen_X = Screen.PrimaryScreen.Bounds.X;
        protected static int Screen_Y = Screen.PrimaryScreen.Bounds.Y;
        protected Timer timer;
        protected Form form;
        protected abstract void init();
        protected abstract void start();
        public abstract void run();
        protected abstract void stop();
        protected void disposeHiddenForms()
        {
            for (int i = Program.List_HiddenForms.Count - 1; i >= 0; i--)
            {
  
                Program.List_HiddenForms[i].Dispose();
                Program.List_HiddenForms[i].Close();
                Program.List_HiddenForms[i] = null;
                Program.List_HiddenForms.RemoveAt(Program.List_HiddenForms.Count - 1);
            }
            GC.Collect();
        }
    }
}
