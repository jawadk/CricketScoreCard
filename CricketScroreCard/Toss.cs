using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScroreCard
{
    class Toss
    {
        int TossResult = 0;        

        public static int TossDesider(int CoinSide, string Team1, string Team2)
        {
            int Heads = 1;
            int Tails = 0;

            Random rnd = new Random();

            int TossResult = rnd.Next(Tails, Heads);
            int test = rnd.Next(0, 1);
                        
            if (CoinSide == TossResult)
            {
                 Console.WriteLine("congratulations " + Team1 + " you have WON the TOSS");
            }
            else
            {
                Console.WriteLine("congratulations " + Team2 + " you have WON the TOSS");
            }
            return TossResult;
            
        }
                
    }
}
