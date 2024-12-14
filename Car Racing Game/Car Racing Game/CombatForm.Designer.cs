namespace Car_Racing_Game
{
    partial class CombatForm
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
            this.lbLives = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbHSCtxt = new System.Windows.Forms.Label();
            this.lbHighScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbExplosion = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pbRestart = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.pbRestart);
            this.panel1.Controls.Add(this.lbHighScore);
            this.panel1.Controls.Add(this.lbHSCtxt);
            this.panel1.Controls.Add(this.pbStart);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbExplosion);
            this.panel1.Controls.Add(this.lbLives);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbPlayer);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 719);
            this.panel1.TabIndex = 0;
            // 
            // lbLives
            // 
            this.lbLives.AutoSize = true;
            this.lbLives.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Italic);
            this.lbLives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbLives.Location = new System.Drawing.Point(3, 43);
            this.lbLives.Name = "lbLives";
            this.lbLives.Size = new System.Drawing.Size(34, 34);
            this.lbLives.TabIndex = 6;
            this.lbLives.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Italic);
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbScore.Location = new System.Drawing.Point(122, 0);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(34, 34);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score:";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbHSCtxt
            // 
            this.lbHSCtxt.AutoSize = true;
            this.lbHSCtxt.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Italic);
            this.lbHSCtxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbHSCtxt.Location = new System.Drawing.Point(190, 100);
            this.lbHSCtxt.Name = "lbHSCtxt";
            this.lbHSCtxt.Size = new System.Drawing.Size(195, 34);
            this.lbHSCtxt.TabIndex = 9;
            this.lbHSCtxt.Text = "High Score:";
            // 
            // lbHighScore
            // 
            this.lbHighScore.AutoSize = true;
            this.lbHighScore.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Italic);
            this.lbHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbHighScore.Location = new System.Drawing.Point(402, 100);
            this.lbHighScore.Name = "lbHighScore";
            this.lbHighScore.Size = new System.Drawing.Size(34, 34);
            this.lbHighScore.TabIndex = 10;
            this.lbHighScore.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Car_Racing_Game.Properties.Resources.line;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 555);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbExplosion
            // 
            this.pbExplosion.Image = global::Car_Racing_Game.Properties.Resources.explosion;
            this.pbExplosion.Location = new System.Drawing.Point(191, 555);
            this.pbExplosion.Name = "pbExplosion";
            this.pbExplosion.Size = new System.Drawing.Size(64, 64);
            this.pbExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExplosion.TabIndex = 7;
            this.pbExplosion.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Silver;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Image = global::Car_Racing_Game.Properties.Resources.restart;
            this.btnRestart.Location = new System.Drawing.Point(240, 275);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(240, 98);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Silver;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Image = global::Car_Racing_Game.Properties.Resources.start;
            this.btnStart.Location = new System.Drawing.Point(243, 275);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(237, 98);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::Car_Racing_Game.Properties.Resources.rase_car1;
            this.pbPlayer.Location = new System.Drawing.Point(315, 580);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(70, 123);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbStart
            // 
            this.pbStart.Image = global::Car_Racing_Game.Properties.Resources.combat_start;
            this.pbStart.Location = new System.Drawing.Point(191, 137);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(330, 339);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbStart.TabIndex = 11;
            this.pbStart.TabStop = false;
            // 
            // pbRestart
            // 
            this.pbRestart.Image = global::Car_Racing_Game.Properties.Resources.restart_to_try_again;
            this.pbRestart.Location = new System.Drawing.Point(191, 201);
            this.pbRestart.Name = "pbRestart";
            this.pbRestart.Size = new System.Drawing.Size(330, 196);
            this.pbRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRestart.TabIndex = 12;
            this.pbRestart.TabStop = false;
            // 
            // CombatForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(741, 743);
            this.Controls.Add(this.panel1);
            this.Name = "CombatForm";
            this.Text = "CombatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CombatForm_FormClosing);
            this.Load += new System.EventHandler(this.CombatForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CombatForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CombatForm_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbLives;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbExplosion;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHighScore;
        private System.Windows.Forms.Label lbHSCtxt;
        private System.Windows.Forms.PictureBox pbRestart;
        private System.Windows.Forms.PictureBox pbStart;
    }
}