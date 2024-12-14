using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class CombatForm : Form
    {

        int playerSpeed = 15;
        Random rand = new Random();
        bool goleft, goright;
        int enemyFrequency = 30;
        
        int timerTick = 0;
        bool fire=false;

        Game game;

     

        CombatClass combat;
       

       
        public Image carImage { get; set; }
        public CombatForm()
        {
            this.KeyPreview = true;
            InitializeComponent();
            game = new Game();
            combat = new CombatClass(panel1, lbLives);
        }

        private void CombatForm_Load(object sender, EventArgs e)
        {
            if (carImage != null)
            {
                pbPlayer.Image = carImage;
            }
            btnRestart.Visible= false;
            pbRestart.Visible= false;
            pbExplosion.Visible = false;
            HighScore.LoadScore();
            lbHighScore.Text = HighScore.Hscore.ToString();
        }

        private void CombatForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if(e.KeyCode == Keys.Space)
            {
                fire = true;
            }
        }

        private void CombatForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                fire = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goleft == true && pbPlayer.Left > 10)
            {
                pbPlayer.Left -= playerSpeed;
            }
            if (goright == true && pbPlayer.Left < 644)
            {
                pbPlayer.Left += playerSpeed;
            }

          
            combat.MoveObstacles();

            if (rand.Next(1000) < enemyFrequency)
            {
                combat.AddEnemy();
            }

            if (rand.Next(1000) < 2)
            {
                combat.AddHeart();
            }

            combat.CheckHeartCollision(pbPlayer);

            if (combat.GameOver(pbPlayer))
            {
                btnRestart.Visible = true;
                pbRestart.Visible=true;
                pbExplosion.Parent = pbPlayer;
                pbExplosion.Location = new Point(0, 31);
                pbExplosion.Visible = true;
                pbExplosion.BackColor = Color.Transparent;
                restart();
                stopTimer();
                saveHighScore();
            }
            combat.MoveFireballs(pbPlayer);
            lbScore.Text = combat.score.ToString();

        }

        private void saveHighScore()
        {
            if (combat.score > HighScore.Hscore)
            {
                HighScore.Hscore = combat.score;
                HighScore.SaveScore();

                lbHighScore.Text = HighScore.Hscore.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible=false;
            pbStart.Visible = false;
            startTimer();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnRestart.Visible = false;
            pbRestart.Visible = false;
           
            cleanLists();
            pbExplosion.Visible=false;
            startTimer();

        }
        private void startTimer()
        {
            timer1.Start();
            timer2.Start();
            lbHighScore.Visible = false;
            lbHSCtxt.Visible = false;
        }

        private void CombatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
             saveHighScore();
            btnRestart.Visible = false;
            pbRestart.Visible=false;
            btnStart.Visible = true;
            pbStart.Visible = true;
            combat.Clean();
            cleanLists();
            restart();
            stopTimer();
           
            lbScore.Text = combat.score.ToString();
        }

        private void stopTimer()
        {
            timer1.Stop();
            timer2.Stop();
            lbHighScore.Visible = true;
            lbHSCtxt.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (fire)
            {
                combat.playerFire(pbPlayer);
            }
            combat.EnemyFireRandomly();
            timerTick++;
            if(timerTick%60==0)
            {
                combat.enemiSpeed += 1;
                playerSpeed+=4;
                combat.fireballSpeed+=3;
                enemyFrequency += 5;
            }
           

        }

        private void restart()
        {
            combat.enemiSpeed = 2;
            playerSpeed = 15;
            combat.fireballSpeed = 20;
            enemyFrequency= 20;
            
        }

        private void cleanLists()
        {
            
            combat.enemies = new List<EnemyPictureBox>();
            combat.hearts = new List<PictureBox>();
            combat.fireBalls = new List<PictureBox>();
            combat.enemiFireballs= new List<PictureBox>();
            combat.lives = 3;
            lbLives.Text = combat.lives.ToString();
            combat.score = 0;
  
            
        }

    }
  
}
