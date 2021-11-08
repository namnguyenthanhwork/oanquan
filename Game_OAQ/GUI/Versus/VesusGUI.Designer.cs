
namespace GUI
{
    partial class VersusGUI
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
            this.Pnl_Player = new System.Windows.Forms.Panel();
            this.Pbx_Player = new System.Windows.Forms.PictureBox();
            this.Pnl_Bot = new System.Windows.Forms.Panel();
            this.Pbx_Bot = new System.Windows.Forms.PictureBox();
            this.Timer_Avt = new System.Windows.Forms.Timer(this.components);
            this.Lbl_Player = new System.Windows.Forms.Label();
            this.Lbl_Bot = new System.Windows.Forms.Label();
            this.Pbx_PlayerBg = new System.Windows.Forms.PictureBox();
            this.Pbx_BotBg = new System.Windows.Forms.PictureBox();
            this.Pnl_Loading = new System.Windows.Forms.Panel();
            this.Lbl_Loading = new System.Windows.Forms.Label();
            this.Timer_Loading = new System.Windows.Forms.Timer(this.components);
            this.Lbl_TitleLoading = new System.Windows.Forms.Label();
            this.Lbl_ResultLoading = new System.Windows.Forms.Label();
            this.Pnl_Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Player)).BeginInit();
            this.Pnl_Bot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Bot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_PlayerBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BotBg)).BeginInit();
            this.Pnl_Loading.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_Player
            // 
            this.Pnl_Player.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Player.Controls.Add(this.Pbx_Player);
            this.Pnl_Player.Location = new System.Drawing.Point(103, 189);
            this.Pnl_Player.Name = "Pnl_Player";
            this.Pnl_Player.Size = new System.Drawing.Size(340, 410);
            this.Pnl_Player.TabIndex = 0;
            // 
            // Pbx_Player
            // 
            this.Pbx_Player.Location = new System.Drawing.Point(0, 0);
            this.Pbx_Player.Name = "Pbx_Player";
            this.Pbx_Player.Size = new System.Drawing.Size(340, 410);
            this.Pbx_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Player.TabIndex = 0;
            this.Pbx_Player.TabStop = false;
            // 
            // Pnl_Bot
            // 
            this.Pnl_Bot.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_Bot.Controls.Add(this.Pbx_Bot);
            this.Pnl_Bot.Location = new System.Drawing.Point(794, 189);
            this.Pnl_Bot.Name = "Pnl_Bot";
            this.Pnl_Bot.Size = new System.Drawing.Size(340, 410);
            this.Pnl_Bot.TabIndex = 1;
            // 
            // Pbx_Bot
            // 
            this.Pbx_Bot.Location = new System.Drawing.Point(0, 0);
            this.Pbx_Bot.Name = "Pbx_Bot";
            this.Pbx_Bot.Size = new System.Drawing.Size(340, 410);
            this.Pbx_Bot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Bot.TabIndex = 1;
            this.Pbx_Bot.TabStop = false;
            // 
            // Timer_Avt
            // 
            this.Timer_Avt.Enabled = true;
            this.Timer_Avt.Interval = 1;
            this.Timer_Avt.Tick += new System.EventHandler(this.Timer_Avt_Tick);
            // 
            // Lbl_Player
            // 
            this.Lbl_Player.AutoSize = true;
            this.Lbl_Player.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Player.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Player.ForeColor = System.Drawing.Color.White;
            this.Lbl_Player.Location = new System.Drawing.Point(553, 52);
            this.Lbl_Player.Name = "Lbl_Player";
            this.Lbl_Player.Size = new System.Drawing.Size(111, 32);
            this.Lbl_Player.TabIndex = 2;
            this.Lbl_Player.Text = "Người chơi";
            this.Lbl_Player.UseCompatibleTextRendering = true;
            // 
            // Lbl_Bot
            // 
            this.Lbl_Bot.AutoSize = true;
            this.Lbl_Bot.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Bot.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bot.ForeColor = System.Drawing.Color.White;
            this.Lbl_Bot.Location = new System.Drawing.Point(629, 675);
            this.Lbl_Bot.Name = "Lbl_Bot";
            this.Lbl_Bot.Size = new System.Drawing.Size(46, 32);
            this.Lbl_Bot.TabIndex = 3;
            this.Lbl_Bot.Text = "Máy";
            this.Lbl_Bot.UseCompatibleTextRendering = true;
            // 
            // Pbx_PlayerBg
            // 
            this.Pbx_PlayerBg.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_PlayerBg.Location = new System.Drawing.Point(524, 43);
            this.Pbx_PlayerBg.Name = "Pbx_PlayerBg";
            this.Pbx_PlayerBg.Size = new System.Drawing.Size(167, 52);
            this.Pbx_PlayerBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_PlayerBg.TabIndex = 4;
            this.Pbx_PlayerBg.TabStop = false;
            // 
            // Pbx_BotBg
            // 
            this.Pbx_BotBg.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_BotBg.Location = new System.Drawing.Point(574, 665);
            this.Pbx_BotBg.Name = "Pbx_BotBg";
            this.Pbx_BotBg.Size = new System.Drawing.Size(167, 52);
            this.Pbx_BotBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_BotBg.TabIndex = 5;
            this.Pbx_BotBg.TabStop = false;
            // 
            // Pnl_Loading
            // 
            this.Pnl_Loading.Controls.Add(this.Lbl_Loading);
            this.Pnl_Loading.Location = new System.Drawing.Point(349, 741);
            this.Pnl_Loading.Name = "Pnl_Loading";
            this.Pnl_Loading.Size = new System.Drawing.Size(584, 20);
            this.Pnl_Loading.TabIndex = 6;
            // 
            // Lbl_Loading
            // 
            this.Lbl_Loading.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Loading.Name = "Lbl_Loading";
            this.Lbl_Loading.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Loading.TabIndex = 0;
            // 
            // Timer_Loading
            // 
            this.Timer_Loading.Tick += new System.EventHandler(this.Timer_Loading_Tick);
            // 
            // Lbl_TitleLoading
            // 
            this.Lbl_TitleLoading.AutoSize = true;
            this.Lbl_TitleLoading.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_TitleLoading.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TitleLoading.Location = new System.Drawing.Point(244, 738);
            this.Lbl_TitleLoading.Name = "Lbl_TitleLoading";
            this.Lbl_TitleLoading.Size = new System.Drawing.Size(90, 26);
            this.Lbl_TitleLoading.TabIndex = 7;
            this.Lbl_TitleLoading.Text = "Đang tải:";
            // 
            // Lbl_ResultLoading
            // 
            this.Lbl_ResultLoading.AutoSize = true;
            this.Lbl_ResultLoading.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_ResultLoading.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ResultLoading.Location = new System.Drawing.Point(957, 738);
            this.Lbl_ResultLoading.Name = "Lbl_ResultLoading";
            this.Lbl_ResultLoading.Size = new System.Drawing.Size(40, 26);
            this.Lbl_ResultLoading.TabIndex = 8;
            this.Lbl_ResultLoading.Text = "0%";
            // 
            // VersusGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 774);
            this.Controls.Add(this.Lbl_ResultLoading);
            this.Controls.Add(this.Lbl_TitleLoading);
            this.Controls.Add(this.Pnl_Loading);
            this.Controls.Add(this.Lbl_Bot);
            this.Controls.Add(this.Lbl_Player);
            this.Controls.Add(this.Pbx_BotBg);
            this.Controls.Add(this.Pbx_PlayerBg);
            this.Controls.Add(this.Pnl_Bot);
            this.Controls.Add(this.Pnl_Player);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VersusGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VesusGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VersusGUI_FormClosing);
            this.Load += new System.EventHandler(this.VersusGUI_Load);
            this.Pnl_Player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Player)).EndInit();
            this.Pnl_Bot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Bot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_PlayerBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BotBg)).EndInit();
            this.Pnl_Loading.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Player;
        private System.Windows.Forms.Panel Pnl_Bot;
        private System.Windows.Forms.PictureBox Pbx_Player;
        private System.Windows.Forms.PictureBox Pbx_Bot;
        private System.Windows.Forms.Timer Timer_Avt;
        private System.Windows.Forms.Label Lbl_Player;
        private System.Windows.Forms.Label Lbl_Bot;
        private System.Windows.Forms.PictureBox Pbx_PlayerBg;
        private System.Windows.Forms.PictureBox Pbx_BotBg;
        private System.Windows.Forms.Panel Pnl_Loading;
        private System.Windows.Forms.Label Lbl_Loading;
        private System.Windows.Forms.Timer Timer_Loading;
        private System.Windows.Forms.Label Lbl_TitleLoading;
        private System.Windows.Forms.Label Lbl_ResultLoading;
    }
}