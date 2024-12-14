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
    public partial class ChoseCarForm : Form
    {

        
        public Car car { get; set; }
        public ChoseCarForm()
        {
            InitializeComponent();
            GameData.LoadCoins();
        }

        private void btnRaceCar1_Click(object sender, EventArgs e)
        {
            car = new Car(pbRaceCar1.Image);
            DialogResult = DialogResult.OK;
        }

        private void btnRaceCar2_Click(object sender, EventArgs e)
        {
            car = new Car(pbRaceCar2.Image);
            DialogResult = DialogResult.OK;
        }

        private void btnRaceCar3_Click(object sender, EventArgs e)
        {
            car = new Car(pbRaceCar3.Image);
            DialogResult = DialogResult.OK;
        }

        private void btnRaceCar4_Click(object sender, EventArgs e)
        {
            car = new Car(pbRaceCar4.Image);
            DialogResult = DialogResult.OK;
        }

        private void btnRaceCar5_Click(object sender, EventArgs e)
        {
            car = new Car(pbRaceCar5.Image);
            DialogResult = DialogResult.OK;
        }

        private void ChoseCarForm_Load(object sender, EventArgs e)
        {
            lbAllCoins.Text=GameData.CoinCount.ToString();
        }

        private void btnBuyWhite_Click(object sender, EventArgs e)
        {
            if(GameData.CoinCount >= 20)
            {
                btnBuyWhite.Visible = false;
               
                GameData.CoinCount -= 20;
                lbAllCoins.Text = GameData.CoinCount.ToString();
                GameData.SaveCoins();
                
            }
        }

        private void btnBuyPurple_Click(object sender, EventArgs e)
        {
            if(GameData.CoinCount >= 50)
            {
                btnBuyPurple.Visible = false;
                GameData.CoinCount -= 50;
                lbAllCoins.Text = GameData.CoinCount.ToString();
                GameData.SaveCoins();
            }
        }

        private void btnBuyGold_Click(object sender, EventArgs e)
        {
            if (GameData.CoinCount >= 100)
            {
                btnBuyGold.Visible = false;
                GameData.CoinCount -= 100;
                lbAllCoins.Text = GameData.CoinCount.ToString();
                GameData.SaveCoins();
            }
        }
    }
}
