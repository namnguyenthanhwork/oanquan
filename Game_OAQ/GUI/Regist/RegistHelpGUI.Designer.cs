
namespace GUI.Regist
{
    partial class RegistHelpGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Tbx_Content = new System.Windows.Forms.TextBox();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_Title.Location = new System.Drawing.Point(61, 48);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(233, 28);
            this.Lbl_Title.TabIndex = 0;
            this.Lbl_Title.Text = "Hướng dẫn đăng ký";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tbx_Content
            // 
            this.Tbx_Content.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Content.Location = new System.Drawing.Point(32, 94);
            this.Tbx_Content.Multiline = true;
            this.Tbx_Content.Name = "Tbx_Content";
            this.Tbx_Content.ReadOnly = true;
            this.Tbx_Content.Size = new System.Drawing.Size(290, 441);
            this.Tbx_Content.TabIndex = 1;
            this.Tbx_Content.TabStop = false;
            this.Tbx_Content.Text = "Thông tin tài khoản chỉ gồm các kí tự a  - z, A - Z, 0 - 9\r\n\r\nChiều dài " +
    "mỗi thông tin từ 8 - 20 kí tự\r\n";
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Close.Location = new System.Drawing.Point(96, 550);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(163, 50);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "Đóng";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            this.Btn_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_Close.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.Btn_Close.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            this.Btn_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // RegistHelpGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(354, 620);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Tbx_Content);
            this.Controls.Add(this.Lbl_Title);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistHelpGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RegistHelpGUI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RegistHelpGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.TextBox Tbx_Content;
        private System.Windows.Forms.Button Btn_Close;
    }
}