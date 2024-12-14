using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Racing_Game
{
    public static class GameData
    {

        public static int CoinCount { get; set; } = 0;
      
        public static void SaveCoins()
        {
            System.IO.File.WriteAllText("coins.txt", CoinCount.ToString());
        }

        public static void LoadCoins()
        {
            if (System.IO.File.Exists("coins.txt"))
            {
                string coinsText = System.IO.File.ReadAllText("coins.txt");
                if (int.TryParse(coinsText, out int coins))
                {
                    CoinCount = coins;
                }
            }
        }
    }
}
