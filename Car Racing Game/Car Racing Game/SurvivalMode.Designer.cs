namespace Car_Racing_Game
{
    partial class SurvivalMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurvivalMode));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTimer1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.pbWin = new System.Windows.Forms.PictureBox();
            this.pbLose = new System.Windows.Forms.PictureBox();
            this.pbExplosion = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pbSurvivalTrack1 = new System.Windows.Forms.PictureBox();
            this.pbSurvivalTrack2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurvivalTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurvivalTrack2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.pbWin);
            this.panel1.Controls.Add(this.pbLose);
            this.panel1.Controls.Add(this.pbExplosion);
            this.panel1.Controls.Add(this.lbTimer1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.pbPlayer);
            this.panel1.Controls.Add(this.pbStart);
            this.panel1.Controls.Add(this.pbSurvivalTrack1);
            this.panel1.Controls.Add(this.pbSurvivalTrack2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 719);
            this.panel1.TabIndex = 2;
            // 
            // lbTimer1
            // 
            this.lbTimer1.AutoSize = true;
            this.lbTimer1.BackColor = System.Drawing.Color.Black;
            this.lbTimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTimer1.ForeColor = System.Drawing.Color.White;
            this.lbTimer1.Location = new System.Drawing.Point(45, 23);
            this.lbTimer1.Name = "lbTimer1";
            this.lbTimer1.Size = new System.Drawing.Size(34, 25);
            this.lbTimer1.TabIndex = 9;
            this.lbTimer1.Text = "30";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Silver;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Image = global::Car_Racing_Game.Properties.Resources.restart;
            this.btnRestart.Location = new System.Drawing.Point(166, 299);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(232, 89);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pbWin
            // 
            this.pbWin.Image = global::Car_Racing_Game.Properties.Resources.you_win;
            this.pbWin.Location = new System.Drawing.Point(120, 106);
            this.pbWin.Name = "pbWin";
            this.pbWin.Size = new System.Drawing.Size(330, 339);
            this.pbWin.TabIndex = 18;
            this.pbWin.TabStop = false;
            this.pbWin.Click += new System.EventHandler(this.pbWin_Click);
            // 
            // pbLose
            // 
            this.pbLose.Image = global::Car_Racing_Game.Properties.Resources.you_lose;
            this.pbLose.Location = new System.Drawing.Point(120, 106);
            this.pbLose.Name = "pbLose";
            this.pbLose.Size = new System.Drawing.Size(330, 339);
            this.pbLose.TabIndex = 17;
            this.pbLose.TabStop = false;
            // 
            // pbExplosion
            // 
            this.pbExplosion.Image = global::Car_Racing_Game.Properties.Resources.explosion;
            this.pbExplosion.Location = new System.Drawing.Point(145, 579);
            this.pbExplosion.Name = "pbExplosion";
            this.pbExplosion.Size = new System.Drawing.Size(64, 64);
            this.pbExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExplosion.TabIndex = 15;
            this.pbExplosion.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Silver;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = global::Car_Racing_Game.Properties.Resources.start;
            this.btnStart.Location = new System.Drawing.Point(166, 235);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(234, 95);
            this.btnStart.TabIndex = 6;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Black;
            this.pbPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayer.Image")));
            this.pbPlayer.Location = new System.Drawing.Point(252, 562);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(70, 123);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbStart
            // 
            this.pbStart.Image = global::Car_Racing_Game.Properties.Resources.survival_start;
            this.pbStart.Location = new System.Drawing.Point(120, 106);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(330, 339);
            this.pbStart.TabIndex = 16;
            this.pbStart.TabStop = false;
            // 
            // pbSurvivalTrack1
            // 
            this.pbSurvivalTrack1.Image = ((System.Drawing.Image)(resources.GetObject("pbSurvivalTrack1.Image")));
            this.pbSurvivalTrack1.Location = new System.Drawing.Point(0, 0);
            this.pbSurvivalTrack1.Name = "pbSurvivalTrack1";
            this.pbSurvivalTrack1.Size = new System.Drawing.Size(572, 719);
            this.pbSurvivalTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSurvivalTrack1.TabIndex = 1;
            this.pbSurvivalTrack1.TabStop = false;
            // 
            // pbSurvivalTrack2
            // 
            this.pbSurvivalTrack2.Image = ((System.Drawing.Image)(resources.GetObject("pbSurvivalTrack2.Image")));
            this.pbSurvivalTrack2.Location = new System.Drawing.Point(0, -719);
            this.pbSurvivalTrack2.Name = "pbSurvivalTrack2";
            this.pbSurvivalTrack2.Size = new System.Drawing.Size(572, 719);
            this.pbSurvivalTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSurvivalTrack2.TabIndex = 7;
            this.pbSurvivalTrack2.TabStop = false;
            // 
            // SurvivalMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(596, 743);
            this.Controls.Add(this.panel1);
            this.Name = "SurvivalMode";
            this.Text = "SurvivalMode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SurvivalMode_FormClosing);
            this.Load += new System.EventHandler(this.SurvivalMode_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SurvivalMode_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurvivalTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurvivalTrack2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbSurvivalTrack1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbSurvivalTrack2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lbTimer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pbExplosion;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.PictureBox pbWin;
        private System.Windows.Forms.PictureBox pbLose;
    }
}