﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScroreCard
{
    class Toss
    {
        int TossResult = 0;        

        public static void TossDesider(int CoinSide, string Team1, string Team2, string Team1_Captain, string Team2_Captain)
        {
            int Heads = 1;
            int Tails = 0;

            Random rnd = new Random();

            int TossResult = rnd.Next(Tails, Heads);
            int test = rnd.Next(0, 1);
                        
            if (CoinSide == TossResult)
            {
                Console.WriteLine("Congratulations " + Team1 + " you have WON the TOSS");
                Console.WriteLine("Soo, " + Team1_Captain + " What you would like to do you first ?");
                Console.WriteLine("[0] = BATTING");
                Console.WriteLine("[1] = FIELDING/BOWLNG");

                int Selection = Convert.ToInt32(Console.ReadLine());

                if (Selection == 0)
                {
                    Console.WriteLine("Great....!!!! " + Team1_Captain + "you have choosed BATTING...");
                }
                else
                {
                    Console.WriteLine("Interesting decision....!!!! " + Team1_Captain + "you have choosed BOWLING...");    
                }
            }
            else
            {
                Console.WriteLine("Congratulations " + Team2 + " you have WON the TOSS");
                Console.WriteLine("Soo, " + Team2_Captain + " What you would like to do you first ?");
                Console.WriteLine("[0] = BATTING");
                Console.WriteLine("[1] = FIELDING/BOWLNG");

                int Selection = Convert.ToInt32(Console.ReadLine());
                
                if (Selection == 0)
                {
                    Console.WriteLine("Great....!!!! " + Team2_Captain + "you have choosed BATTING...");
                }
                else
                {
                    Console.WriteLine("Interesting decision....!!!! " + Team2_Captain + "you have choosed BOWLING...");
                }
            }
        }

        public static void TossCall(string Team1_Name, string Team2_Name, string Team1_Captain, string Team2_Captain)
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

            Toss.TossDesider(TossValue, Team1_Name, Team2_Name, Team1_Captain, Team2_Captain);
        }
                
    }
}
