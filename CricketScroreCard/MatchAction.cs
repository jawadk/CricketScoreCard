using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScroreCard
{
    class MatchAction
    {
        public static int[] BowlerSelectionInningStart(int Checking_Toss_Win, int Current_Bowler, string Team1_Name, string Team2_Name, int Team1_Code, int Team2_Code, string[,] AllTeamsPlayer)
        {
            int[] Teams_Bat_Bow = new int[5];
            if (Checking_Toss_Win == 5)
            {
                Teams_Bat_Bow[0] = Team1_Code; //Store the Team1 Code
                Console.WriteLine("These Batmans will start the innings for " + Team1_Name);
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team1_Code, i]);
                    Teams_Bat_Bow[i+1] =i;
                }

                Console.WriteLine("\n");
                Console.WriteLine("Please select the opening bowler for " + Team2_Name + " from the following: ");

                Teams_Bat_Bow[3] = Team2_Code; //Store the Team2 Code
                for (int i = 5; i < 10; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team2_Code, i]);
                }

                Current_Bowler = Convert.ToInt32(Console.ReadLine());
                Teams_Bat_Bow[4] = Current_Bowler;
            }

            else if (Checking_Toss_Win == 10)
            {
                Teams_Bat_Bow[3] = Team1_Code; //Store the Team Code
                Console.WriteLine("Please select the opening bowler for " + Team1_Name + " from the following: ");
                for (int i = 5; i < 10; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team1_Code, i]);
                }
                Current_Bowler = Convert.ToInt32(Console.ReadLine());
                Teams_Bat_Bow[4] = Current_Bowler;

                Console.WriteLine("\n");
                Console.WriteLine("These Batmans will start the innings for " + Team2_Name);

                Teams_Bat_Bow[0] = Team2_Code; //Store the Team Code
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team2_Code, i]);
                    Teams_Bat_Bow[i + 1] = i;
                }
            }
            else if (Checking_Toss_Win == 15)
            {
                Teams_Bat_Bow[0] = Team2_Code; //Store the Team Code
                Console.WriteLine("These Batmans will start the innings for " + Team2_Name);
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team2_Code, i]);
                    Teams_Bat_Bow[i + 1] = i;
                }

                Console.WriteLine("\n");
                Console.WriteLine("Please select the opening bowler for " + Team1_Name + " from the following: ");

                Teams_Bat_Bow[3] = Team2_Code; //Store the Team Code
                for (int i = 5; i < 10; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team1_Code, i]);
                }
                Console.WriteLine("\n");
                Current_Bowler = Convert.ToInt32(Console.ReadLine());
                Teams_Bat_Bow[4] = Current_Bowler;
            }
            else if (Checking_Toss_Win == 20)
            {
                Teams_Bat_Bow[3] = Team2_Code; //Store the Team Code
                Console.WriteLine("Please select the opening bowler for " + Team2_Name + " from the following: ");
                for (int i = 5; i < 10; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team2_Code, i]);
                }
                Current_Bowler = Convert.ToInt32(Console.ReadLine());
                Teams_Bat_Bow[4] = Current_Bowler;

                Console.WriteLine("\n");
                Console.WriteLine("These Batmans will start the innings for " + Team1_Name);

                Teams_Bat_Bow[0] = Team1_Code; //Store the Team Code
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team1_Code, i]);
                    Teams_Bat_Bow[i + 1] = i;
                }
                Console.WriteLine("\n");
            }
            return Teams_Bat_Bow;
        }

        public static void RotateStrike(int BallBowl)
        {
            if (BallBowl % 6 == 0)
            {

 
            }
        }

        public static void ShowBowlers(string Team_Name, int TeamBowling_Code, string[,] AllTeamsPlayer)
        {
            Console.WriteLine("Please select any bowler for " + Team_Name + " from the following: ");
            for (int i = 5; i < 10; i++)
            {
                Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[TeamBowling_Code, i]);
            }
        }
    }
}
