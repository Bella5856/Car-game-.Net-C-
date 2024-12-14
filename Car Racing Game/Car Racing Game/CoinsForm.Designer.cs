namespace Car_Racing_Game
{
    partial class CoinsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCoins = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.pbRestart = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbExplosion = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbCoinsTrack2 = new System.Windows.Forms.PictureBox();
            this.pbCoinsTrack1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoinsTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoinsTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.pbRestart);
            this.panel1.Controls.Add(this.pbStart);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbExplosion);
            this.panel1.Controls.Add(this.lbCoins);
            this.panel1.Controls.Add(this.pbPlayer);
            this.panel1.Controls.Add(this.pbCoinsTrack2);
            this.panel1.Controls.Add(this.pbCoinsTrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 719);
            this.panel1.TabIndex = 0;
            // 
            // lbCoins
            // 
            this.lbCoins.AutoSize = true;
            this.lbCoins.Font = new System.Drawing.Font("Noto Sans Cond", 15F, System.Drawing.FontStyle.Bold);
            this.lbCoins.Location = new System.Drawing.Point(108, 20);
            this.lbCoins.Name = "lbCoins";
            this.lbCoins.Size = new System.Drawing.Size(0, 34);
            this.lbCoins.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Silver;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Image = global::Car_Racing_Game.Properties.Resources.restart;
            this.btnRestart.Location = new System.Drawing.Point(184, 299);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(234, 92);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pbRestart
            // 
            this.pbRestart.Image = global::Car_Racing_Game.Properties.Resources.restart_to_try_again;
            this.pbRestart.Location = new System.Drawing.Point(134, 222);
            this.pbRestart.Name = "pbRestart";
            this.pbRestart.Size = new System.Drawing.Size(330, 196);
            this.pbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRestart.TabIndex = 10;
            this.pbRestart.TabStop = false;
            // 
            // pbStart
            // 
            this.pbStart.Image = global::Car_Racing_Game.Properties.Resources.coins_start;
            this.pbStart.Location = new System.Drawing.Point(134, 147);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(330, 339);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStart.TabIndex = 9;
            this.pbStart.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImage = global::Car_Racing_Game.Properties.Resources.coin_mode_bg;
            this.pictureBox1.Image = global::Car_Racing_Game.Properties.Resources.coin;
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbExplosion
            // 
            this.pbExplosion.Image = global::Car_Racing_Game.Properties.Resources.explosion;
            this.pbExplosion.Location = new System.Drawing.Point(134, 547);
            this.pbExplosion.Name = "pbExplosion";
            this.pbExplosion.Size = new System.Drawing.Size(64, 64);
            this.pbExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExplosion.TabIndex = 5;
            this.pbExplosion.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkGray;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = global::Car_Racing_Game.Properties.Resources.start;
            this.btnStart.Location = new System.Drawing.Point(184, 299);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(234, 92);
            this.btnStart.TabIndex = 3;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackgroundImage = global::Car_Racing_Game.Properties.Resources.coin_mode_bg;
            this.pbPlayer.Image = global::Car_Racing_Game.Properties.Resources.rase_car1;
            this.pbPlayer.Location = new System.Drawing.Point(251, 542);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(70, 123);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.TabStop = false;
            // 
            // pbCoinsTrack2
            // 
            this.pbCoinsTrack2.Image = global::Car_Racing_Game.Properties.Resources.Coin_Track;
            this.pbCoinsTrack2.Location = new System.Drawing.Point(0, -719);
            this.pbCoinsTrack2.Name = "pbCoinsTrack2";
            this.pbCoinsTrack2.Size = new System.Drawing.Size(572, 719);
            this.pbCoinsTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoinsTrack2.TabIndex = 1;
            this.pbCoinsTrack2.TabStop = false;
            // 
            // pbCoinsTrack1
            // 
            this.pbCoinsTrack1.Image = global::Car_Racing_Game.Properties.Resources.Coin_Track;
            this.pbCoinsTrack1.Location = new System.Drawing.Point(0, 0);
            this.pbCoinsTrack1.Name = "pbCoinsTrack1";
            this.pbCoinsTrack1.Size = new System.Drawing.Size(572, 719);
            this.pbCoinsTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoinsTrack1.TabIndex = 0;
            this.pbCoinsTrack1.TabStop = false;
            // 
            // CoinsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(595, 752);
            this.Controls.Add(this.panel1);
            this.Name = "CoinsForm";
            this.Text = "CoinsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoinsForm_FormClosing);
            this.Load += new System.EventHandler(this.CoinsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoinsForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoinsTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoinsTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCoinsTrack1;
        private System.Windows.Forms.PictureBox pbCoinsTrack2;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbCoins;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbExplosion;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbRestart;
        private System.Windows.Forms.PictureBox pbStart;
    }
}