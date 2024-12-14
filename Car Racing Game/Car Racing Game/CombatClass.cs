using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    
    public class CombatClass
    {

        public List<EnemyPictureBox> enemies;
        public List<PictureBox> fireBalls;
        public List<PictureBox> hearts;
        public List<PictureBox> enemiFireballs;
        private Random rand = new Random();
        public int enemiSpeed { get; set; } = 2;
        Game game;
        private int heartSpeed { get; set; } = 30;

        public int fireballSpeed { get; set; } = 20;

        public int enemiFireballSpeed { get; set; } = 30;
        public int lives { get; set; } = 3;
        public int score { get; set; } = 0;
        private Panel panel;
        private Label lbLives;


        public CombatClass(Panel panel, Label lbLives)
        {
            enemies = new List<EnemyPictureBox>();
            fireBalls = new List<PictureBox>();
            hearts = new List<PictureBox>();
            enemiFireballs= new List<PictureBox>();
            this.panel = panel;
            this.lbLives = lbLives;
            game=new Game();
        }
        public void AddEnemy()
        {
            int x = rand.Next(10, 644);
            EnemyPictureBox pbEnemi = new EnemyPictureBox();
            pbEnemi.Size = new Size(70, 123);
            pbEnemi.BackColor = Color.Black;
            pbEnemi.Location = new Point(x, -pbEnemi.Height);
            pbEnemi.SizeMode = PictureBoxSizeMode.StretchImage;
           
             game.ChangeObstacleCar(pbEnemi); 

            bool overlap = false;
            foreach (var enemi in enemies)
            {
                if (enemi.Bounds.IntersectsWith(pbEnemi.Bounds))
                {
                    overlap = true;
                    break;
                }
            }

            if (!overlap)
            {
                panel.Controls.Add(pbEnemi);
                pbEnemi.BringToFront();
                enemies.Add(pbEnemi);
            }
            else
            {
                pbEnemi.Dispose();
            }
        }

        

        public void AddHeart()
        {
            int x = rand.Next(10, 644);
            PictureBox pbHeart = new PictureBox
            {
                Size = new Size(50, 50), 
                BackColor = Color.Black,
                Location = new Point(x, -50), 
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.heart 
            };

            bool overlap = false;
            foreach (var heart in hearts)
            {
                if (heart.Bounds.IntersectsWith(pbHeart.Bounds))
                {
                    overlap = true;
                    break;
                }
            }

            if (!overlap)
            {
                panel.Controls.Add(pbHeart);
                pbHeart.BringToFront();
                hearts.Add(pbHeart);
            }
            else
            {
                pbHeart.Dispose();
            }
        }

        public void MoveObstacles()
        {
            foreach (var enemi in enemies)
            {
                enemi.Top += enemiSpeed;
                if (enemi.Top > panel.Height)
                {
                    panel.Controls.Remove(enemi);
                    lives--;
                    lbLives.Text = lives.ToString();
                }
            }

            foreach (var heart in hearts)
            {
                heart.Top += heartSpeed;
                if (heart.Top > panel.Height)
                {
                    panel.Controls.Remove(heart);
                }
            }
            hearts.RemoveAll(c => !c.Visible);
            enemies.RemoveAll(o => o.Top > panel.Height);
        }

        public void MoveFireballs(PictureBox pbPlayer)
        {
            foreach (var fireball in fireBalls)
            {
                fireball.Top -= fireballSpeed;

                foreach (var enemi in enemies)
                {
                    if (fireball.Bounds.IntersectsWith(enemi.Bounds))
                    {
                        enemi.HitCount--;
                        fireball.Visible = false;
                        panel.Controls.Remove(fireball);
                        

                        if (enemi.HitCount <= 0)
                        {
                            enemi.Visible = false;
                            panel.Controls.Remove(enemi);
                            score++;
                        }
                    }
                }
            }
            fireBalls.RemoveAll(f => !f.Visible);
            enemies.RemoveAll(e => !e.Visible);


            foreach (var fireball in enemiFireballs)
            {
                fireball.Top += enemiFireballSpeed;

               
                if (fireball.Bounds.IntersectsWith(pbPlayer.Bounds))
                {
                    
                    lives--;
                    lbLives.Text = lives.ToString();
                    fireball.Visible = false;
                    panel.Controls.Remove(fireball);
                }
            }

            
            enemiFireballs.RemoveAll(f => !f.Visible);
        }

        public bool CheckCollision(PictureBox pbPlayer)
        {
            foreach (var enemi in enemies)
            {
                if (enemi.Bounds.IntersectsWith(pbPlayer.Bounds))
                {
                    enemi.Visible = false;
                    enemies.Remove(enemi);
                    return true;
                }
            }
            return false;
        }

        public void CheckHeartCollision(PictureBox pbPlayer)
        {
            foreach (var heart in hearts)
            {
                if (heart.Bounds.IntersectsWith(pbPlayer.Bounds))
                {
                    lives++;
                    lbLives.Text = lives.ToString(); 
                    heart.Visible = false;
                    panel.Controls.Remove(heart);
                }
            }
            hearts.RemoveAll(c => !c.Visible);

           
        }

        public void playerFire(PictureBox pbPlayer)
        {
            PictureBox pbFireball = new PictureBox
            {
                Size = new Size(25, 25),
                BackColor = Color.Black,
                Image = Properties.Resources.fire_ball_power_up,
                Location = new Point(pbPlayer.Left + pbPlayer.Width / 2 - 5, pbPlayer.Top - 30),
                SizeMode = PictureBoxSizeMode.StretchImage,
            };

            fireBalls.Add(pbFireball);
            panel.Controls.Add(pbFireball);
            pbFireball.BringToFront();
            pbFireball.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        public void Clean()
        {
            foreach (var heart in hearts)
            {
                heart.Visible = false;
            }
            foreach (var enemi in enemies)
            {
                enemi.Visible = false;
            }
            foreach (var fireball in fireBalls)
            {
                fireball.Visible = false;
            }
            foreach (var enemifireball in enemiFireballs)
            {
                enemifireball.Visible = false;
            }
        }

        public bool GameOver(PictureBox pbPlayer)
        {
            if (CheckCollision(pbPlayer))
            {
                lives--;
                lbLives.Text = lives.ToString();
            }

            if (lives == 0)
            {
                Clean();
                return true;
            }
            return false;
        }

        public void EnemyFireRandomly()
        {
            if (rand.Next(1000) < 35) 
            {
                if (enemies.Count > 0)
                {
                    int index = rand.Next(enemies.Count);
                    EnemyPictureBox selectedEnemy = enemies[index];

                    PictureBox pbFireball = new PictureBox
                    {
                        Size = new Size(25, 25),
                        BackColor = Color.Black,
                        Image = Properties.Resources.fireball_fire,
                        
                        Location = new Point(selectedEnemy.Left + selectedEnemy.Width / 2 - 5, selectedEnemy.Bottom + 5),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Tag = "EnemyFireball" 
                    };

                    enemiFireballs.Add(pbFireball);
                    panel.Controls.Add(pbFireball);
                    pbFireball.BringToFront();
                    pbFireball.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
            }
        }
    }
}
