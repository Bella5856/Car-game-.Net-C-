using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public class Game
    {
        private Random rand = new Random();
       
        public Random randPosition { get; set; }

        public int[] rows = { 30, 141, 252, 363, 474 };
        public List<PictureBox> obstacles = new List<PictureBox>();

        public List<PictureBox> coins = new List<PictureBox>();

        public  bool moveL { get; set; }= false;
        public bool moveR { get; set; } = false;

        public Game()
        {
            randPosition = new Random();
        }
        public void MoveLeft(PictureBox pbPlayer)
        {
            if (moveL && pbPlayer.Location.X > 30)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X - 111, pbPlayer.Location.Y);

            }
            moveL = false;
        }

        public void MoveRight(PictureBox pbPlayer)
        {
            if (moveR && pbPlayer.Location.X < 474)
            {
                pbPlayer.Location = new Point(pbPlayer.Location.X + 111, pbPlayer.Location.Y);

            }
            moveR = false;
        }

        public void ChangeObstacleCar(PictureBox tempCar)
        {
            int randomObstacle = rand.Next(1, 7);
            switch (randomObstacle)
            {
                case 1:
                    tempCar.Image = Properties.Resources.obstacle1png;
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.obstacle2;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.obstacle3;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.obstacle4;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.obstacle5;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.obstacle6;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.obstacle8;
                    break;
            }
        }

        public void AddObstacle(Panel panel, Image bg)
        {
            int x = rows[randPosition.Next(rows.Length)];

            PictureBox pbObstacle = new PictureBox();
            pbObstacle.Size = new Size(70, 123);
            pbObstacle.BackgroundImage = bg;
            pbObstacle.Location = new Point(x, -pbObstacle.Height);
            pbObstacle.SizeMode = PictureBoxSizeMode.StretchImage;
            ChangeObstacleCar(pbObstacle);

            bool overlap = false;
            foreach (var obstacle in obstacles)
            {
                if (obstacle.Bounds.IntersectsWith(pbObstacle.Bounds))
                {
                    overlap = true;
                    break;
                }
            }

            if (!overlap)
            {
                panel.Controls.Add(pbObstacle);
                pbObstacle.BringToFront();
                obstacles.Add(pbObstacle);
            }
            else
            {
                pbObstacle.Dispose();
            }
        }

        public void AddCoin(Panel panel, Image bg)
        {
            int x = rows[randPosition.Next(rows.Length)];
            PictureBox pbCoin = new PictureBox
            {
                Size = new Size(50, 50), 
                BackgroundImage = bg,
                Location = new Point(x, -50), 
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.coin 
            };

            bool overlap = false;
            foreach (var coin in coins)
            {
                
                    if (coin.Bounds.IntersectsWith(pbCoin.Bounds) )
                    {
                        overlap = true;
                        break;
                    }
                
                
            }

            if (!overlap)
            {
                panel.Controls.Add(pbCoin);
                pbCoin.BringToFront();
                coins.Add(pbCoin);
            }
            else
            {
                pbCoin.Dispose();
            }
        }

        public void CheckCoinCollision(PictureBox pbPlayer, Panel panel, Label lblCoinsCollected)
        {
            foreach (var coin in coins)
            {
                if (coin.Bounds.IntersectsWith(pbPlayer.Bounds) )
                {
                    GameData.CoinCount++;
                    lblCoinsCollected.Text = GameData.CoinCount.ToString(); // Update the UI if necessary
                    coin.Visible = false;
                    panel.Controls.Remove(coin);
                }
            }
            coins.RemoveAll(c => !c.Visible);
        }

        public void MoveObstacles(int trafficSpeed, Panel panel)
        {
            foreach (var obstacle in obstacles)
            {
                obstacle.Top += trafficSpeed;

                if (obstacle.Top > panel.Height)
                {
                    panel.Controls.Remove(obstacle);
                }
            }
            obstacles.RemoveAll(o => o.Top > panel.Height);


            foreach (var coin in coins)
            {
                coin.Top += trafficSpeed;

                if (coin.Top > panel.Height)
                {
                    panel.Controls.Remove(coin);
                }
            }
            obstacles.RemoveAll(o => o.Top > panel.Height);


        }

        public bool CheckCollision(PictureBox pbPlayer)
        {
            foreach (var obstacle in obstacles)
            {
                if (obstacle.Bounds.IntersectsWith(pbPlayer.Bounds))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
