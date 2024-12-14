using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game
{
    public class Car
    {
        
        public Image playerCarImage { get; set; }

      

        public Car(Image playerCar)
        {
            this.playerCarImage = playerCar;
           
        }
       
    }
}
