using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public int PlayerScore { get; set; }
        public bool Out;
        public int flag = 0;
        public Cricket()
        {
            PlayerScore = 0;
        }
        public void Score(int playerScore)
        {
            if (Out == false)
            {
                if (playerScore <= 6 && playerScore >= 0)
                {
                    PlayerScore += playerScore;
                }
            }
        }
    }
}
