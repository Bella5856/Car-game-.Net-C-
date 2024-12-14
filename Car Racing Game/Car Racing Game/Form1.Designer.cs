namespace Car_Racing_Game
{
    partial class Form1
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
            this.lbAllCoins = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbMode = new System.Windows.Forms.PictureBox();
            this.pbPlayerCar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnChoseMode = new System.Windows.Forms.Button();
            this.btnChoseCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAllCoins
            // 
            this.lbAllCoins.AutoSize = true;
            this.lbAllCoins.Location = new System.Drawing.Point(39, 39);
            this.lbAllCoins.Name = "lbAllCoins";
            this.lbAllCoins.Size = new System.Drawing.Size(0, 16);
            this.lbAllCoins.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStart.Image = global::Car_Racing_Game.Properties.Resources.start;
            this.btnStart.Location = new System.Drawing.Point(399, 474);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(232, 89);
            this.btnStart.TabIndex = 6;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbMode
            // 
            this.pbMode.Image = global::Car_Racing_Game.Properties.Resources.survival_mode_baner;
            this.pbMode.Location = new System.Drawing.Point(376, 113);
            this.pbMode.Name = "pbMode";
            this.pbMode.Size = new System.Drawing.Size(270, 342);
            this.pbMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMode.TabIndex = 5;
            this.pbMode.TabStop = false;
            // 
            // pbPlayerCar
            // 
            this.pbPlayerCar.Image = global::Car_Racing_Game.Properties.Resources.rase_car1;
            this.pbPlayerCar.Location = new System.Drawing.Point(115, 141);
            this.pbPlayerCar.Name = "pbPlayerCar";
            this.pbPlayerCar.Size = new System.Drawing.Size(145, 278);
            this.pbPlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayerCar.TabIndex = 4;
            this.pbPlayerCar.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Image = global::Car_Racing_Game.Properties.Resources.Turbo_Track_Triad;
            this.label1.Location = new System.Drawing.Point(89, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 89);
            this.label1.TabIndex = 3;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHelp.Image = global::Car_Racing_Game.Properties.Resources.help;
            this.btnHelp.Location = new System.Drawing.Point(399, 569);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(232, 90);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnChoseMode
            // 
            this.btnChoseMode.FlatAppearance.BorderSize = 0;
            this.btnChoseMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoseMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChoseMode.Image = global::Car_Racing_Game.Properties.Resources.chose_mode;
            this.btnChoseMode.Location = new System.Drawing.Point(68, 569);
            this.btnChoseMode.Name = "btnChoseMode";
            this.btnChoseMode.Size = new System.Drawing.Size(236, 97);
            this.btnChoseMode.TabIndex = 1;
            this.btnChoseMode.UseVisualStyleBackColor = true;
            this.btnChoseMode.Click += new System.EventHandler(this.btnChoseMode_Click);
            // 
            // btnChoseCar
            // 
            this.btnChoseCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChoseCar.FlatAppearance.BorderSize = 0;
            this.btnChoseCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoseCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChoseCar.Image = global::Car_Racing_Game.Properties.Resources.chose_car;
            this.btnChoseCar.Location = new System.Drawing.Point(68, 474);
            this.btnChoseCar.Name = "btnChoseCar";
            this.btnChoseCar.Size = new System.Drawing.Size(236, 89);
            this.btnChoseCar.TabIndex = 0;
            this.btnChoseCar.UseVisualStyleBackColor = false;
            this.btnChoseCar.Click += new System.EventHandler(this.btnChoseCar_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(744, 699);
            this.Controls.Add(this.lbAllCoins);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbMode);
            this.Controls.Add(this.pbPlayerCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnChoseMode);
            this.Controls.Add(this.btnChoseCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoseCar;
        private System.Windows.Forms.Button btnChoseMode;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPlayerCar;
        private System.Windows.Forms.PictureBox pbMode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbAllCoins;
    }
}

