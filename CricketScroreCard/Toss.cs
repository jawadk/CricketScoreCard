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

        public static void TossCall(string Team1_Name, string Team2_Name, string Team1_Captain)
        {
            int TossValue = 0;
            Console.WriteLine("Great, lets move for the TOSS \n");
            Console.WriteLine("We would be like to ask from " + Team1_Name + " Captain " + Team1_Captain + " .... Heads or Tails");
            Console.WriteLine("[0] = TRAILS");
            Console.WriteLine("[1] = HEADS \n");            
            do
            {               
                TossValue = Convert.ToInt32(Console.ReadLine());

                if (TossValue > 2)
                {
                    Console.WriteLine("Invalid Code, Please enter [0] = TRAILS or [1] = HEADS");
                }
   
            } while (TossValue > 2);

            int Toss_WON = Toss.TossDesider(TossValue, Team1_Name, Team2_Name);
        }
                
    }
}
