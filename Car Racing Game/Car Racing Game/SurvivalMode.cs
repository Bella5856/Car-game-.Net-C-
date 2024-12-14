using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Car_Racing_Game
{
    public partial class SurvivalMode : Form
    {

        int timer = 30;
        int timerTick = 0;
       
        public Game game { get; set; }

        int roadSpeed=25;

        int trafficSpeed=15;

        public Image carImage { get; set; }
       

        public SurvivalMode()
        {
            this.KeyPreview = true;
            InitializeComponent();
            game= new Game();
          
        }

        private void SurvivalMode_Load(object sender, EventArgs e)
        {
            if (carImage != null)
            {
                pbPlayer.Image = carImage;
            }
            turnOffRestart();

            pbExplosion.Parent = pbPlayer;
            pbExplosion.BackColor = Color.Transparent;

           


        }

        private void SurvivalMode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                game.moveL= true;
               
            }
            if (e.KeyCode == Keys.Right)
            {
                game.moveR = true;
               
            }
        }

       

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible= false;
            pbStart.Visible = false;
            timer = 30;
            timer1.Start();
            timer2.Start();
            pbPlayer.Location = new Point(252, pbPlayer.Location.Y);
            game.obstacles = new List<PictureBox>();

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                game.MoveLeft(pbPlayer);   
                game.MoveRight(pbPlayer);
            
            
            timerTick += 200;
            if(timerTick == 1000)
            {
                timerTick = 0;
                timer -= 1;
                lbTimer1.Text=timer.ToString();
            }
            if(timer == 0)
            {
                gameOverWin();
                
            }
            else
            {
                gameOverLose();
            }

           

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            turnOffRestart();
            timer = 30;
            pbPlayer.Location=new Point(252,pbPlayer.Location.Y);
           game.obstacles= new List<PictureBox>();

        }

        private void turnOffRestart()
        {
            btnRestart.Visible = false;
            pbWin.Visible = false;
            pbLose.Visible = false;
           
            pbExplosion.Visible = false;
        }
        private void gameOverWin()
        {
            btnRestart.Visible = true;
           pbWin.Visible=true;
            timer1.Stop();
            timer2.Stop();
            foreach (var obstacle in game.obstacles)
            {
                obstacle.Visible = false;
            }
        }

        private void gameOverLose()
        {

            if (game.CheckCollision(pbPlayer))
            {
                
                btnRestart.Visible = true;
                timer1.Stop();
                timer2.Stop();
                pbExplosion.Location=new Point(0,31);
                pbExplosion.Visible = true;
                pbExplosion.BackColor = Color.Transparent;
                pbLose.Visible=true;
                cleanObstacles();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            pbSurvivalTrack1.Top += roadSpeed;
            pbSurvivalTrack2.Top += roadSpeed;
            if (pbSurvivalTrack2.Top > 719)
            {
                pbSurvivalTrack2.Top = -719;
               
            }
            if (pbSurvivalTrack1.Top > 719)
            {
                pbSurvivalTrack1.Top = -719;
                
            }
         

            game.MoveObstacles(trafficSpeed, panel1);

            if (game.randPosition.Next(120) < 10)
            {
                game.AddObstacle(panel1, Properties.Resources.survival_mode_bg);
            }
        }

        private void SurvivalMode_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStart.Visible = true;
            pbStart.Visible = true;
            pbExplosion.Visible = false;
            timer1.Stop();
            timer2.Stop();
            cleanObstacles();
            pbPlayer.Location = new Point(252, pbPlayer.Location.Y);
            game.obstacles = new List<PictureBox>();

        }

       private void cleanObstacles()
        {
            foreach (var obstacle in game.obstacles)
            {
                obstacle.Visible = false;
            }
        }

        private void pbWin_Click(object sender, EventArgs e)
        {

        }
    }
}
