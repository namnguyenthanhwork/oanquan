
namespace GUI
{
    partial class CharacterChoiceGUI
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
            this.components = new System.ComponentModel.Container();
            this.FloPnl_Choice = new System.Windows.Forms.FlowLayoutPanel();
            this.Pbx_FullAva = new System.Windows.Forms.PictureBox();
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Pbx_Clock = new System.Windows.Forms.PictureBox();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Timer_Clock = new System.Windows.Forms.Timer(this.components);
            this.Pbx_Continue = new System.Windows.Forms.PictureBox();
            this.Pbx_Name = new System.Windows.Forms.PictureBox();
            this.Pnl_FullAvatar = new System.Windows.Forms.Panel();
            this.Timer_ShowAvatar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_FullAva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Name)).BeginInit();
            this.SuspendLayout();
            // 
            // FloPnl_Choice
            // 
            this.FloPnl_Choice.AutoScroll = true;
            this.FloPnl_Choice.BackColor = System.Drawing.Color.Transparent;
            this.FloPnl_Choice.Location = new System.Drawing.Point(733, 46);
            this.FloPnl_Choice.Name = "FloPnl_Choice";
            this.FloPnl_Choice.Size = new System.Drawing.Size(452, 482);
            this.FloPnl_Choice.TabIndex = 0;
            // 
            // Pbx_FullAva
            // 
            this.Pbx_FullAva.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_FullAva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pbx_FullAva.Location = new System.Drawing.Point(129, 120);
            this.Pbx_FullAva.Name = "Pbx_FullAva";
            this.Pbx_FullAva.Size = new System.Drawing.Size(505, 495);
            this.Pbx_FullAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_FullAva.TabIndex = 1;
            this.Pbx_FullAva.TabStop = false;
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.AutoSize = true;
            this.Btn_Continue.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Continue.FlatAppearance.BorderSize = 0;
            this.Btn_Continue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Continue.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Continue.ForeColor = System.Drawing.Color.Black;
            this.Btn_Continue.Location = new System.Drawing.Point(553, 680);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(145, 49);
            this.Btn_Continue.TabIndex = 2;
            this.Btn_Continue.Text = "Tiếp tục";
            this.Btn_Continue.UseVisualStyleBackColor = false;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            this.Btn_Continue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Continue_MouseDown);
            this.Btn_Continue.MouseLeave += new System.EventHandler(this.Btn_Continue_MouseLeave);
            this.Btn_Continue.MouseHover += new System.EventHandler(this.Btn_Continue_MouseHover);
            this.Btn_Continue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Continue_MouseUp);
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Name.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.ForeColor = System.Drawing.Color.White;
            this.Lbl_Name.Location = new System.Drawing.Point(181, 32);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(139, 42);
            this.Lbl_Name.TabIndex = 3;
            this.Lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pbx_Clock
            // 
            this.Pbx_Clock.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Clock.Location = new System.Drawing.Point(962, 569);
            this.Pbx_Clock.Name = "Pbx_Clock";
            this.Pbx_Clock.Size = new System.Drawing.Size(133, 128);
            this.Pbx_Clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Clock.TabIndex = 4;
            this.Pbx_Clock.TabStop = false;
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Time.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Time.Location = new System.Drawing.Point(981, 602);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(81, 49);
            this.Lbl_Time.TabIndex = 5;
            this.Lbl_Time.Text = "22s";
            this.Lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Clock
            // 
            this.Timer_Clock.Interval = 1000;
            this.Timer_Clock.Tick += new System.EventHandler(this.Timer_Clock_Tick);
            // 
            // Pbx_Continue
            // 
            this.Pbx_Continue.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Continue.Location = new System.Drawing.Point(515, 675);
            this.Pbx_Continue.Name = "Pbx_Continue";
            this.Pbx_Continue.Size = new System.Drawing.Size(211, 63);
            this.Pbx_Continue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Continue.TabIndex = 6;
            this.Pbx_Continue.TabStop = false;
            // 
            // Pbx_Name
            // 
            this.Pbx_Name.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Name.Location = new System.Drawing.Point(150, 27);
            this.Pbx_Name.Name = "Pbx_Name";
            this.Pbx_Name.Size = new System.Drawing.Size(195, 67);
            this.Pbx_Name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Name.TabIndex = 7;
            this.Pbx_Name.TabStop = false;
            // 
            // Pnl_FullAvatar
            // 
            this.Pnl_FullAvatar.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_FullAvatar.Location = new System.Drawing.Point(129, 112);
            this.Pnl_FullAvatar.Name = "Pnl_FullAvatar";
            this.Pnl_FullAvatar.Size = new System.Drawing.Size(505, 509);
            this.Pnl_FullAvatar.TabIndex = 8;
            // 
            // Timer_ShowAvatar
            // 
            this.Timer_ShowAvatar.Enabled = true;
            this.Timer_ShowAvatar.Interval = 1;
            this.Timer_ShowAvatar.Tick += new System.EventHandler(this.Timer_ShowAvatar_Tick);
            // 
            // CharacterChoiceGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 774);
            this.Controls.Add(this.Lbl_Name);
            this.Controls.Add(this.Pbx_Name);
            this.Controls.Add(this.Btn_Continue);
            this.Controls.Add(this.Pbx_Continue);
            this.Controls.Add(this.Lbl_Time);
            this.Controls.Add(this.Pbx_Clock);
            this.Controls.Add(this.FloPnl_Choice);
            this.Controls.Add(this.Pbx_FullAva);
            this.Controls.Add(this.Pnl_FullAvatar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharacterChoiceGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CharacterChoiceGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CharacterChoiceGUI_FormClosing);
            this.Load += new System.EventHandler(this.CharacterChoiceGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_FullAva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Name)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FloPnl_Choice;
        private System.Windows.Forms.PictureBox Pbx_FullAva;
        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.PictureBox Pbx_Clock;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.Timer Timer_Clock;
        private System.Windows.Forms.PictureBox Pbx_Continue;
        private System.Windows.Forms.PictureBox Pbx_Name;
        private System.Windows.Forms.Panel Pnl_FullAvatar;
        private System.Windows.Forms.Timer Timer_ShowAvatar;
    }
}