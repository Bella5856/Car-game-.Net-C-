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
    public partial class Form1 : Form
    {

        ChoseCarForm choseCarForm = new ChoseCarForm();
        ChoseModeForm modeForm = new ChoseModeForm();
        SurvivalMode survivalMode = new SurvivalMode();
        CoinsForm coinMode = new CoinsForm();
        CombatForm combatMode = new CombatForm();
        HelpForm helpForm= new HelpForm();

        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnChoseCar_Click(object sender, EventArgs e)
        {
            
            
            if(choseCarForm.ShowDialog() == DialogResult.OK)
            { 
                pbPlayerCar.Image  = choseCarForm.car.playerCarImage;
                
            }
            
        }

        private void btnChoseMode_Click(object sender, EventArgs e)
        {

            if (modeForm.ShowDialog() == DialogResult.OK)
            {
                pbMode.Image = modeForm.mode.modeImage;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
                if(pbMode.Image != null && pbPlayerCar != null)
               {

                if(modeForm.mode !=null )
                {
                    if (modeForm.mode.modeName == "Survival")
                    {


                        survivalMode.carImage = pbPlayerCar.Image;
                        survivalMode.ShowDialog();


                    }
                    else if (modeForm.mode.modeName == "Combat") {
                        
                        combatMode.carImage=pbPlayerCar.Image;
                        combatMode.ShowDialog();
                    
                    }
                     else if (modeForm.mode.modeName == "Coins") {
                        coinMode.carImage = pbPlayerCar.Image;
                        coinMode.ShowDialog();
                        
                    }
                }
                else
                {
                    survivalMode.carImage = pbPlayerCar.Image;
                    survivalMode.ShowDialog();
                }
               
            }
                
            
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
