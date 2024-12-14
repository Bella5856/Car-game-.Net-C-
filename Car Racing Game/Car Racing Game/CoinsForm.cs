using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public partial class CoinsForm : Form


    {

        
        public Game game { get; set; }

        int roadSpeed = 25;

        int trafficSpeed = 15;
        

        public Image carImage { get; set; }

        public CoinsForm()
        {
            this.KeyPreview = true;
            InitializeComponent();
            game=new Game();
        }

        private void CoinsForm_Load(object sender, EventArgs e)
        {
            if (carImage != null)
            {
                pbPlayer.Image = carImage;
            }

            btnRestart.Visible = false;
            pbRestart.Visible = false;
            pbExplosion.Parent = pbPlayer;
            pbExplosion.BackColor = Color.Transparent;
           
            btnStart.Visible = true;
            pbStart.Visible = true;
            lbCoins.Text=GameData.CoinCount.ToString();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            pbStart.Visible = false;

            timer1.Start();
            timer2.Start();
  

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            game.MoveLeft(pbPlayer);
            game.MoveRight(pbPlayer);
            gameOver();
        }

        private void CoinsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                game.moveL = true;

            }
            if (e.KeyCode == Keys.Right)
            {
                game.moveR = true;

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            pbCoinsTrack1.Top += roadSpeed;
            pbCoinsTrack2.Top += roadSpeed;
            if (pbCoinsTrack2.Top > 719)
            {
                pbCoinsTrack2.Top = -719;

            }
            if (pbCoinsTrack1.Top > 719)
            {
                pbCoinsTrack1.Top = -719;

            }


            game.MoveObstacles(trafficSpeed, panel1);

            if (game.randPosition.Next(150) < 10)
            {
                game.AddObstacle(panel1, Properties.Resources.coin_mode_bg);
            }
            if (game.randPosition.Next(200) < 10)
            {
                game.AddCoin(panel1, Properties.Resources.coin_mode_bg);

            }


        }

        private void gameOver()
        {

            if (game.CheckCollision(pbPlayer))
            {
                
                btnRestart.Visible = true;
                pbRestart.Visible=true;
               cleanObstaclesAndCoins();
                pbExplosion.Location = new Point(0, 31);
                pbExplosion.Visible = true;
                pbExplosion.BackColor = Color.Transparent;

               
            }

            game.CheckCoinCollision(pbPlayer, panel1, lbCoins);

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            pbPlayer.Location = new Point(252, pbPlayer.Location.Y);
            game.obstacles = new List<PictureBox>();
            game.coins = new List<PictureBox>();
            btnRestart.Visible = false;
            pbRestart.Visible = false;
            pbExplosion.Visible = false;
        }

        private void CoinsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            GameData.SaveCoins();
            btnStart.Visible = true;
            pbStart.Visible = true;
            pbExplosion.Visible = false;
            
            cleanObstaclesAndCoins();
            pbPlayer.Location = new Point(252, pbPlayer.Location.Y);
            game.obstacles = new List<PictureBox>();
            game.coins=new List<PictureBox>();
        }

        private void cleanObstaclesAndCoins()
        {
            timer1.Stop();
            timer2.Stop();
            foreach (var obstacle in game.obstacles)
            {
                obstacle.Visible = false;
            }
            foreach (var coin in game.coins)
            {
                coin.Visible = false;
            }
            
        }
    }
}
