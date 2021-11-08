
namespace GUI.MessageBoxes
{
    partial class OkMessageBox
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
            this.Lbl_ContentMessage = new System.Windows.Forms.Label();
            this.Lbl_TitleMessage = new System.Windows.Forms.Label();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_ContentMessage
            // 
            this.Lbl_ContentMessage.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ContentMessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ContentMessage.ForeColor = System.Drawing.Color.Black;
            this.Lbl_ContentMessage.Location = new System.Drawing.Point(56, 85);
            this.Lbl_ContentMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ContentMessage.Name = "Lbl_ContentMessage";
            this.Lbl_ContentMessage.Size = new System.Drawing.Size(349, 82);
            this.Lbl_ContentMessage.TabIndex = 0;
            this.Lbl_ContentMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_TitleMessage
            // 
            this.Lbl_TitleMessage.AutoSize = true;
            this.Lbl_TitleMessage.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_TitleMessage.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleMessage.Location = new System.Drawing.Point(187, 22);
            this.Lbl_TitleMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_TitleMessage.Name = "Lbl_TitleMessage";
            this.Lbl_TitleMessage.Size = new System.Drawing.Size(70, 35);
            this.Lbl_TitleMessage.TabIndex = 8;
            this.Lbl_TitleMessage.Text = "Title";
            this.Lbl_TitleMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Confirm.FlatAppearance.BorderSize = 0;
            this.Btn_Confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Confirm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Confirm.Location = new System.Drawing.Point(193, 208);
            this.Btn_Confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(107, 50);
            this.Btn_Confirm.TabIndex = 10;
            this.Btn_Confirm.Text = "Đồng ý";
            this.Btn_Confirm.UseVisualStyleBackColor = false;
            this.Btn_Confirm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Confirm_MouseClick);
            this.Btn_Confirm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_Confirm.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.Btn_Confirm.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            this.Btn_Confirm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // Btn_Close
            // 
            this.Btn_Close.AutoSize = true;
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(397, 7);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(55, 58);
            this.Btn_Close.TabIndex = 11;
            this.Btn_Close.Text = "X";
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            this.Btn_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseDown);
            this.Btn_Close.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            this.Btn_Close.MouseHover += new System.EventHandler(this.Btn_MouseHover);
            this.Btn_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_MouseUp);
            // 
            // OkMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 271);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Lbl_ContentMessage);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lbl_TitleMessage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OkMessageBox";
            this.Text = "OkMessageBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OkMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_ContentMessage;
        private System.Windows.Forms.Label Lbl_TitleMessage;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Button Btn_Close;
    }
}