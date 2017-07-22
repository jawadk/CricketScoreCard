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
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("----  [0]     =    No Run + Ball Missed by Batsman  ----");
            Console.WriteLine("----  [1]     =    1 RUN                            ----");
            Console.WriteLine("----  [2]     =    2 RUNS                           ----");
            Console.WriteLine("----  [3]     =    3 RUNS                           ----");
            Console.WriteLine("----  [4]     =    4 RUNS - Boundary                ----");
            Console.WriteLine("----  [5]     =    5 RUNS                           ----");
            Console.WriteLine("----  [6]     =    6 RUNS - Out of the Park Boundary! --");
            Console.WriteLine("----  [7]     =    OUT                              ----");
            Console.WriteLine("----  [8]     =    8 - WHITE BALL                   ----");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\n");
        }

        public static void ShowScore(int TeamCode, int BallBowl, int Score, int wicketFalls)
        {
            if (BallBowl %6 == 0)
            {
                if (TeamCode == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("PAKISTAN - " + Score + "-" + wicketFalls);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\n");
                }
                else if (TeamCode == 1)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("SRILANKA - " + Score + "-" + wicketFalls);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\n");
                }
                else if (TeamCode == 2)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("AUSTRALIA - " + Score + "-" + wicketFalls);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\n");
                }
                else if (TeamCode == 3)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("INDIA - " + Score + "-" + wicketFalls);
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\n");
                }
            }
        }

        public static void ShowMatchResult(int Score1, int Score2, string Team1_Name, string Team2_Name, int wicketFallsTeam1, int wicketFallsTeam2)
        {

            Console.WriteLine(Team1_Name + ": " + Score1 + "-" + wicketFallsTeam1);
            Console.WriteLine(Team2_Name + ": " + Score2 + "-" + wicketFallsTeam2);

            if (Score1 < Score2)
            {
                Console.WriteLine("Congratulations..... Team " + Team2_Name);
                Console.WriteLine("You have won the match " + Team2_Name);
            }

            else if (Score1 > Score2)
            {
                Console.WriteLine("Congratulations..... Team " + Team1_Name);
                Console.WriteLine("You have won the match " + Team1_Name);
            }
            else if (Score1 == Score2)
            {
                Console.WriteLine("MATCH TIED");
            }

            Console.ReadLine();
        }

        public static void ShowScoreCard(int[] BatsmansCode, int[] BowlerCode, int Score1, int[] Boundary_Batting, string[,] AllTimePlayers, int TeamBattingCode, int TeamBowlingCode)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Innings BOUNDARIES  ");
            Console.WriteLine("4(s) BOUNDARIES         " + Boundary_Batting[0]);
            Console.WriteLine("6(s) BOUNDARIES         " + Boundary_Batting[1]);

            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("---BatsmanCode              Players          RUNS");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("---[" + i + "]     " + AllTimePlayers[TeamBattingCode, i] + "         " + BatsmansCode[i]);
            }

            Console.WriteLine("\n");

            Console.WriteLine("--------------------------------------");
                Console.WriteLine("---BowlersCode              Bowlers                 " + "WICKETS");
            for (int i = 5; i < 9; i++)
            {
                Console.WriteLine("---BpwlerCode [" + i + "]  +     " + AllTimePlayers[TeamBowlingCode, i] + "      " + BowlerCode[i]);
            }
 
        }
    }
}
