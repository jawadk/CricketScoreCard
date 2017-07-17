using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScroreCard
{
    class Display
    {
        public void ShowTeamPlayers(int tsarr, string[,] AllTeams, string T1_Name)
        {
            Console.WriteLine("\n");
            Console.WriteLine(T1_Name + " match players: ");
            for (int i = 0; i < 10; i++)
            {
                if (tsarr == 0)
                {
                    Console.Write(AllTeams[0, i] + ", ");
                }
                else if (tsarr == 1)
                {
                    Console.Write(AllTeams[1, i] + ", ");
                }
                else if (tsarr == 2)
                {
                    Console.Write(AllTeams[2, i] + ", ");
                }
                else if (tsarr == 3)
                {
                    Console.Write(AllTeams[3, i] + ", ");
                }                
            }
            Console.WriteLine("\n");            
        }

        public static void ShowCodes()
        {
            Console.WriteLine("[0]           ==          No Run + Ball Missed by Batsman");
            Console.WriteLine("[1]           ==          1 RUN");
            Console.WriteLine("[2]           ==          2 RUNS");
            Console.WriteLine("[3]           ==          3 RUNS");
            Console.WriteLine("[4]           ==          4 RUNS - Boundary");
            Console.WriteLine("[5]           ==          5 RUNS");
            Console.WriteLine("[6]           ==          6 RUNS - Out of the Park Boundary!!!");
            Console.WriteLine("[7]           ==          OUT");
            Console.WriteLine("[8]           ==          8 - WHITE BALL");        
        }

        public static void ShowScore(int TeamCode, int BallBowl , int Score)
        {
            if (BallBowl %6 == 0)
            {
                if (TeamCode == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("PAKISTAN - " + Score);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\n");
                }
                else if (TeamCode == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("SRILANKA - " + Score);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\n");
                }
                else if (TeamCode == 2)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("AUSTRALIA - " + Score);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\n");
                }
                else if (TeamCode == 3)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("INDIA - " + Score);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
