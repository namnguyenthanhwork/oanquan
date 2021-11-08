using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GUI
{
    public class CustomTextbox : TextBox
    {
        public string PlaceHolder { get; set; }
        private int length = 0;
        public CustomTextbox() => Text = PlaceHolder;
        //remove the placeholder text when player focus
        public void changePH_Enter()
        {
            if (Text.Equals(PlaceHolder))
            {
                BackColor = Color.LightGreen;
                Text = string.Empty;
                ForeColor = Color.Black;
            }
        }

        //change placeholder text when mouse leave
        public void changePH_Leave()
        {
            if (Text == string.Empty)
            {
                BackColor = Color.White;
                Text = PlaceHolder;
                ForeColor = Color.LightGray;
            }
        }

        public void setRule()
        {
            if (Text.Equals(PlaceHolder))
                return;
            TextBox Tbx_Re = this;
            if (Tbx_Re.Text.Length > length)
            {
                int c = Tbx_Re.Text[Tbx_Re.Text.Length - 1];
                if (!(c >= 48 && c <= 57 || c >= 65 && c <= 90 || c >= 97 && c <= 122))
                    Tbx_Re.Text = Tbx_Re.Text.Substring(0, Tbx_Re.Text.Length - 1);
            }
            length = Tbx_Re.Text.Length;
            if (Tbx_Re.Text.Length > 0)
                Tbx_Re.SelectionStart = Tbx_Re.Text.Length;

        }
    }
}
