using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Racing_Game
{
    internal class HighScore
    {
        public static int Hscore { get; set; } = 0;


        public static void SaveScore()
        {
            System.IO.File.WriteAllText("score.txt", Hscore.ToString());
        }

    
        public static void LoadScore()
        {
            if (System.IO.File.Exists("score.txt"))
            {
                string scoreText = System.IO.File.ReadAllText("score.txt");
                if (int.TryParse(scoreText, out int score))
                {
                    Hscore = score;
                }
            }
        }
    }
}
