
namespace GUI.Start
{
    partial class VolumeInformationGUI
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
            this.Pnl_Background = new System.Windows.Forms.Panel();
            this.Pnl_OrMusic = new System.Windows.Forms.Panel();
            this.Lbl_OtherSoundTitle = new System.Windows.Forms.Label();
            this.Pnl_OtherMusic = new System.Windows.Forms.Panel();
            this.Pbx_OtherMusic = new System.Windows.Forms.PictureBox();
            this.Btn_OtherMusic = new System.Windows.Forms.Button();
            this.Ckb_OtherMusic = new System.Windows.Forms.CheckBox();
            this.Lbl_OtherMusic = new System.Windows.Forms.Label();
            this.Pnl_BgMusic = new System.Windows.Forms.Panel();
            this.Lbl_BackgroundMusicTitle = new System.Windows.Forms.Label();
            this.Pnl_BackgroundMusic = new System.Windows.Forms.Panel();
            this.Btn_BackgroundMusic = new System.Windows.Forms.Button();
            this.Pbx_BackgroundMusic = new System.Windows.Forms.PictureBox();
            this.Lbl_BackgroundMusic = new System.Windows.Forms.Label();
            this.Ckb_BackgroundMusic = new System.Windows.Forms.CheckBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Pnl_Background.SuspendLayout();
            this.Pnl_OrMusic.SuspendLayout();
            this.Pnl_OtherMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_OtherMusic)).BeginInit();
            this.Pnl_BgMusic.SuspendLayout();
            this.Pnl_BackgroundMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BackgroundMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Background
            // 
            this.Pnl_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_Background.Controls.Add(this.Pnl_OrMusic);
            this.Pnl_Background.Controls.Add(this.Pnl_BgMusic);
            this.Pnl_Background.Controls.Add(this.Lbl_Title);
            this.Pnl_Background.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Background.Name = "Pnl_Background";
            this.Pnl_Background.Size = new System.Drawing.Size(496, 428);
            this.Pnl_Background.TabIndex = 0;
            // 
            // Pnl_OrMusic
            // 
            this.Pnl_OrMusic.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_OrMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_OrMusic.Controls.Add(this.Lbl_OtherSoundTitle);
            this.Pnl_OrMusic.Controls.Add(this.Pnl_OtherMusic);
            this.Pnl_OrMusic.Controls.Add(this.Ckb_OtherMusic);
            this.Pnl_OrMusic.Controls.Add(this.Lbl_OtherMusic);
            this.Pnl_OrMusic.Location = new System.Drawing.Point(19, 244);
            this.Pnl_OrMusic.Name = "Pnl_OrMusic";
            this.Pnl_OrMusic.Size = new System.Drawing.Size(450, 176);
            this.Pnl_OrMusic.TabIndex = 22;
            // 
            // Lbl_OtherSoundTitle
            // 
            this.Lbl_OtherSoundTitle.AutoSize = true;
            this.Lbl_OtherSoundTitle.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_OtherSoundTitle.Location = new System.Drawing.Point(45, 1);
            this.Lbl_OtherSoundTitle.Name = "Lbl_OtherSoundTitle";
            this.Lbl_OtherSoundTitle.Size = new System.Drawing.Size(142, 25);
            this.Lbl_OtherSoundTitle.TabIndex = 14;
            this.Lbl_OtherSoundTitle.Text = "Âm thanh khác";
            // 
            // Pnl_OtherMusic
            // 
            this.Pnl_OtherMusic.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_OtherMusic.Controls.Add(this.Pbx_OtherMusic);
            this.Pnl_OtherMusic.Controls.Add(this.Btn_OtherMusic);
            this.Pnl_OtherMusic.Location = new System.Drawing.Point(108, 60);
            this.Pnl_OtherMusic.Name = "Pnl_OtherMusic";
            this.Pnl_OtherMusic.Size = new System.Drawing.Size(299, 43);
            this.Pnl_OtherMusic.TabIndex = 15;
            // 
            // Pbx_OtherMusic
            // 
            this.Pbx_OtherMusic.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_OtherMusic.Location = new System.Drawing.Point(0, 0);
            this.Pbx_OtherMusic.Name = "Pbx_OtherMusic";
            this.Pbx_OtherMusic.Size = new System.Drawing.Size(144, 43);
            this.Pbx_OtherMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_OtherMusic.TabIndex = 10;
            this.Pbx_OtherMusic.TabStop = false;
            // 
            // Btn_OtherMusic
            // 
            this.Btn_OtherMusic.BackColor = System.Drawing.Color.White;
            this.Btn_OtherMusic.Location = new System.Drawing.Point(140, -1);
            this.Btn_OtherMusic.Name = "Btn_OtherMusic";
            this.Btn_OtherMusic.Size = new System.Drawing.Size(35, 43);
            this.Btn_OtherMusic.TabIndex = 10;
            this.Btn_OtherMusic.UseVisualStyleBackColor = false;
            this.Btn_OtherMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_OtherMusic_MouseDown);
            this.Btn_OtherMusic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_OtherMusic_MouseMove);
            this.Btn_OtherMusic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_OtherMusic_MouseUp);
            // 
            // Ckb_OtherMusic
            // 
            this.Ckb_OtherMusic.Appearance = System.Windows.Forms.Appearance.Button;
            this.Ckb_OtherMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ckb_OtherMusic.FlatAppearance.BorderSize = 0;
            this.Ckb_OtherMusic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Ckb_OtherMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Ckb_OtherMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Ckb_OtherMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckb_OtherMusic.Location = new System.Drawing.Point(35, 57);
            this.Ckb_OtherMusic.Name = "Ckb_OtherMusic";
            this.Ckb_OtherMusic.Size = new System.Drawing.Size(67, 52);
            this.Ckb_OtherMusic.TabIndex = 20;
            this.Ckb_OtherMusic.UseVisualStyleBackColor = true;
            this.Ckb_OtherMusic.CheckedChanged += new System.EventHandler(this.Ckb_OtherMusic_CheckedChanged);
            this.Ckb_OtherMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ckb_MouseDown);
            this.Ckb_OtherMusic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ckb_MouseUp);
            // 
            // Lbl_OtherMusic
            // 
            this.Lbl_OtherMusic.AutoSize = true;
            this.Lbl_OtherMusic.BackColor = System.Drawing.Color.White;
            this.Lbl_OtherMusic.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_OtherMusic.Location = new System.Drawing.Point(243, 103);
            this.Lbl_OtherMusic.Name = "Lbl_OtherMusic";
            this.Lbl_OtherMusic.Size = new System.Drawing.Size(28, 21);
            this.Lbl_OtherMusic.TabIndex = 18;
            this.Lbl_OtherMusic.Text = "50";
            // 
            // Pnl_BgMusic
            // 
            this.Pnl_BgMusic.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_BgMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_BgMusic.Controls.Add(this.Lbl_BackgroundMusicTitle);
            this.Pnl_BgMusic.Controls.Add(this.Pnl_BackgroundMusic);
            this.Pnl_BgMusic.Controls.Add(this.Lbl_BackgroundMusic);
            this.Pnl_BgMusic.Controls.Add(this.Ckb_BackgroundMusic);
            this.Pnl_BgMusic.Location = new System.Drawing.Point(19, 65);
            this.Pnl_BgMusic.Name = "Pnl_BgMusic";
            this.Pnl_BgMusic.Size = new System.Drawing.Size(450, 176);
            this.Pnl_BgMusic.TabIndex = 21;
            // 
            // Lbl_BackgroundMusicTitle
            // 
            this.Lbl_BackgroundMusicTitle.AutoSize = true;
            this.Lbl_BackgroundMusicTitle.Font = new System.Drawing.Font("Comic Sans MS", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BackgroundMusicTitle.Location = new System.Drawing.Point(38, -2);
            this.Lbl_BackgroundMusicTitle.Name = "Lbl_BackgroundMusicTitle";
            this.Lbl_BackgroundMusicTitle.Size = new System.Drawing.Size(95, 25);
            this.Lbl_BackgroundMusicTitle.TabIndex = 12;
            this.Lbl_BackgroundMusicTitle.Text = "Nhạc nền";
            // 
            // Pnl_BackgroundMusic
            // 
            this.Pnl_BackgroundMusic.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_BackgroundMusic.Controls.Add(this.Btn_BackgroundMusic);
            this.Pnl_BackgroundMusic.Controls.Add(this.Pbx_BackgroundMusic);
            this.Pnl_BackgroundMusic.Location = new System.Drawing.Point(108, 57);
            this.Pnl_BackgroundMusic.Name = "Pnl_BackgroundMusic";
            this.Pnl_BackgroundMusic.Size = new System.Drawing.Size(299, 49);
            this.Pnl_BackgroundMusic.TabIndex = 16;
            // 
            // Btn_BackgroundMusic
            // 
            this.Btn_BackgroundMusic.BackColor = System.Drawing.Color.White;
            this.Btn_BackgroundMusic.Location = new System.Drawing.Point(142, 0);
            this.Btn_BackgroundMusic.Name = "Btn_BackgroundMusic";
            this.Btn_BackgroundMusic.Size = new System.Drawing.Size(36, 49);
            this.Btn_BackgroundMusic.TabIndex = 8;
            this.Btn_BackgroundMusic.UseVisualStyleBackColor = false;
            this.Btn_BackgroundMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_BackgroundMusic_MouseDown);
            this.Btn_BackgroundMusic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_BackgroundMusic_MouseMove);
            this.Btn_BackgroundMusic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_BackgroundMusic_MouseUp);
            // 
            // Pbx_BackgroundMusic
            // 
            this.Pbx_BackgroundMusic.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_BackgroundMusic.Location = new System.Drawing.Point(0, 0);
            this.Pbx_BackgroundMusic.Name = "Pbx_BackgroundMusic";
            this.Pbx_BackgroundMusic.Size = new System.Drawing.Size(144, 49);
            this.Pbx_BackgroundMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_BackgroundMusic.TabIndex = 9;
            this.Pbx_BackgroundMusic.TabStop = false;
            // 
            // Lbl_BackgroundMusic
            // 
            this.Lbl_BackgroundMusic.AutoSize = true;
            this.Lbl_BackgroundMusic.BackColor = System.Drawing.Color.White;
            this.Lbl_BackgroundMusic.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BackgroundMusic.Location = new System.Drawing.Point(253, 108);
            this.Lbl_BackgroundMusic.Name = "Lbl_BackgroundMusic";
            this.Lbl_BackgroundMusic.Size = new System.Drawing.Size(28, 21);
            this.Lbl_BackgroundMusic.TabIndex = 17;
            this.Lbl_BackgroundMusic.Text = "50";
            // 
            // Ckb_BackgroundMusic
            // 
            this.Ckb_BackgroundMusic.Appearance = System.Windows.Forms.Appearance.Button;
            this.Ckb_BackgroundMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ckb_BackgroundMusic.FlatAppearance.BorderSize = 0;
            this.Ckb_BackgroundMusic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Ckb_BackgroundMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Ckb_BackgroundMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Ckb_BackgroundMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ckb_BackgroundMusic.Location = new System.Drawing.Point(35, 60);
            this.Ckb_BackgroundMusic.Name = "Ckb_BackgroundMusic";
            this.Ckb_BackgroundMusic.Size = new System.Drawing.Size(67, 52);
            this.Ckb_BackgroundMusic.TabIndex = 19;
            this.Ckb_BackgroundMusic.UseVisualStyleBackColor = true;
            this.Ckb_BackgroundMusic.CheckedChanged += new System.EventHandler(this.Ckb_BackgroundMusic_CheckedChanged);
            this.Ckb_BackgroundMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ckb_MouseDown);
            this.Ckb_BackgroundMusic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ckb_MouseUp);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Lbl_Title.Location = new System.Drawing.Point(94, 9);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(309, 48);
            this.Lbl_Title.TabIndex = 13;
            this.Lbl_Title.Text = "Thông tin âm lượng";
            this.Lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VolumeInformationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(495, 428);
            this.Controls.Add(this.Pnl_Background);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VolumeInformationGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "VolumeInformationGUI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VolumeInformationGUI_Load);
            this.Pnl_Background.ResumeLayout(false);
            this.Pnl_OrMusic.ResumeLayout(false);
            this.Pnl_OrMusic.PerformLayout();
            this.Pnl_OtherMusic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_OtherMusic)).EndInit();
            this.Pnl_BgMusic.ResumeLayout(false);
            this.Pnl_BgMusic.PerformLayout();
            this.Pnl_BackgroundMusic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BackgroundMusic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Background;
        private System.Windows.Forms.Panel Pnl_OtherMusic;
        private System.Windows.Forms.PictureBox Pbx_OtherMusic;
        private System.Windows.Forms.Button Btn_OtherMusic;
        private System.Windows.Forms.Label Lbl_OtherSoundTitle;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Label Lbl_BackgroundMusicTitle;
        private System.Windows.Forms.Panel Pnl_BackgroundMusic;
        private System.Windows.Forms.Button Btn_BackgroundMusic;
        private System.Windows.Forms.PictureBox Pbx_BackgroundMusic;
        private System.Windows.Forms.CheckBox Ckb_OtherMusic;
        private System.Windows.Forms.CheckBox Ckb_BackgroundMusic;
        private System.Windows.Forms.Label Lbl_OtherMusic;
        private System.Windows.Forms.Label Lbl_BackgroundMusic;
        private System.Windows.Forms.Panel Pnl_OrMusic;
        private System.Windows.Forms.Panel Pnl_BgMusic;
    }
}