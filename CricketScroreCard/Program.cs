using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketScroreCard
{
    class Program
    {
        static void Main(string[] args)
        {

            int MatchOvers = 5; //T20 match total balls (6 * 20 = 120)
            int TotalBalls = MatchOvers * 6; //Total balls avaiable
            int Team1_Score = 0, Team2_Score = 0;

            int Current_Bowler, Current_Bat1, Current_bat2 = 0;

                        
            //Presentation Spash ----- START
            Console.WriteLine("   ÛÛÛÛÛÛÛÛÛ             ÛÛÛ           ÛÛÛÛÛ                ÛÛÛÛÛ   ");
            Console.WriteLine(" ÛÛÛ°°°°°ÛÛÛ             °°°           °°ÛÛÛ                °°ÛÛÛ    ");
            Console.WriteLine(" ÛÛÛ     °°°  ÛÛÛÛÛÛÛÛ  ÛÛÛÛ   ÛÛÛÛÛÛ  °ÛÛÛ ÛÛÛÛÛ  ÛÛÛÛÛÛ  ÛÛÛÛÛÛÛ  ");
            Console.WriteLine("°ÛÛÛ         °°ÛÛÛ°°ÛÛÛ°°ÛÛÛ  ÛÛÛ°°ÛÛÛ °ÛÛÛ°°ÛÛÛ  ÛÛÛ°°ÛÛÛ°°°ÛÛÛ°   ");
            Console.WriteLine("°ÛÛÛ          °ÛÛÛ °°°  °ÛÛÛ °ÛÛÛ °°°  °ÛÛÛÛÛÛ°  °ÛÛÛÛÛÛÛ   °ÛÛÛ    ");
            Console.WriteLine("°°ÛÛÛ     ÛÛÛ °ÛÛÛ      °ÛÛÛ °ÛÛÛ  ÛÛÛ °ÛÛÛ°°ÛÛÛ °ÛÛÛ°°°    °ÛÛÛ ÛÛÛ");
            Console.WriteLine("°°ÛÛÛÛÛÛÛÛÛ  ÛÛÛÛÛ     ÛÛÛÛÛ°°ÛÛÛÛÛÛ  ÛÛÛÛ ÛÛÛÛÛ°°ÛÛÛÛÛÛ   °°ÛÛÛÛÛ ");
            Console.WriteLine("°°°°°°°°°  °°°°°     °°°°°  °°°°°°  °°°° °°°°°  °°°°°°     °°°°°  ");

            Console.WriteLine("\t");

            Console.WriteLine("                 ÛÛÛÛÛ        ÛÛÛ          ");
            Console.WriteLine("    °°ÛÛÛ        °°°                       ");
            Console.WriteLine("     °ÛÛÛ        ÛÛÛÛ  ÛÛÛÛÛ ÛÛÛÛÛ  ÛÛÛÛÛÛ ");
            Console.WriteLine("     °ÛÛÛ       °°ÛÛÛ °°ÛÛÛ °°ÛÛÛ  ÛÛÛ°°ÛÛÛ");
            Console.WriteLine("     °ÛÛÛ        °ÛÛÛ  °ÛÛÛ  °ÛÛÛ °ÛÛÛÛÛÛÛ ");
            Console.WriteLine("     °ÛÛÛ      Û °ÛÛÛ  °°ÛÛÛ ÛÛÛ  °ÛÛÛ°°°  ");
            Console.WriteLine("      ÛÛÛÛÛÛÛÛÛÛÛ ÛÛÛÛÛ  °°ÛÛÛÛÛ   °°ÛÛÛÛÛÛ ");
            Console.WriteLine("    °°°°°°°°°°° °°°°°    °°°°°     °°°°°°  ");
            
            Console.WriteLine("\t");
            //Presentation Spash ----- END
                        

            string[] tdarr = { "PAKISTAN", "SRILANKA", "AUSTRALIA", "INDIA" }; // Team Details Array
            int[] tsarr = new int[2]; // Team Selected Array

            string[,] AllTeamsPlayer = new string[4, 11];

            // Team PAKISTAN 11 Players ==== CODE == 0
            AllTeamsPlayer[0, 0] = "Sarfraz Ahmed(c)";
            AllTeamsPlayer[0, 1] = "Fakhar Zaman";
            AllTeamsPlayer[0, 2] = "Azhar Ali";
            AllTeamsPlayer[0, 3] = "Babar Azam";
            AllTeamsPlayer[0, 4] = "Fahim Ashraf";
            AllTeamsPlayer[0, 5] = "Hasan Ali";
            AllTeamsPlayer[0, 6] = "Imad Wasim";
            AllTeamsPlayer[0, 7] = "Junaid Khan";
            AllTeamsPlayer[0, 8] = "Mohammad Amir";
            AllTeamsPlayer[0, 9] = "Mohammad Hafeez";
            AllTeamsPlayer[0, 10] = "Shadab Khan";

            // Team SRILANKA 11 Players  ==== CODE == 1
            AllTeamsPlayer[1, 0] = "MA Aponso";
            AllTeamsPlayer[1, 1] = "PVD Chameera";
            AllTeamsPlayer[1, 2] = "LD Chandimal";
            AllTeamsPlayer[1, 3] = "A Dananjaya";
            AllTeamsPlayer[1, 4] = "DM de Silva";
            AllTeamsPlayer[1, 5] = "PC de Silva";
            AllTeamsPlayer[1, 6] = "PWH de Silva";
            AllTeamsPlayer[1, 7] = "N Dickwella";
            AllTeamsPlayer[1, 8] = "AM Fernando";
            AllTeamsPlayer[1, 9] = "N Pradeep";
            AllTeamsPlayer[1, 10] = "DAS Gunaratne";

            // Team AUSTRALIA 11 Players  ==== CODE == 2
            AllTeamsPlayer[2, 0] = "GJ Bailey";
            AllTeamsPlayer[2, 1] = "SM Boland";
            AllTeamsPlayer[2, 2] = "NM Coulter-Nile";
            AllTeamsPlayer[2, 3] = "PJ Cummins";
            AllTeamsPlayer[2, 4] = "JP Faulkner";
            AllTeamsPlayer[2, 5] = "AJ Finch";
            AllTeamsPlayer[2, 6] = "PSP Handscomb";
            AllTeamsPlayer[2, 7] = "JW Hastings";
            AllTeamsPlayer[2, 8] = "JR Hazlewood";
            AllTeamsPlayer[2, 9] = "TM Head";
            AllTeamsPlayer[2, 10] = "SD Heazlett";

            // Team INDIA 11 Players  ==== CODE == 3
            AllTeamsPlayer[3, 0] = "Virat Kohli(c)";
            AllTeamsPlayer[3, 1] = "Rohit Sharma";
            AllTeamsPlayer[3, 2] = "Shikhar Dhawan";
            AllTeamsPlayer[3, 3] = "Yuvraj Singh";
            AllTeamsPlayer[3, 4] = "Ajinkya Rahane";
            AllTeamsPlayer[3, 5] = "Dinesh Karthik";
            AllTeamsPlayer[3, 6] = "Kedar Jadhav";
            AllTeamsPlayer[3, 7] = "MS Dhoni";
            AllTeamsPlayer[3, 8] = "Hardik Pandya";
            AllTeamsPlayer[3, 9] = "Ravichandran Ashwin";
            AllTeamsPlayer[3, 10] = "Ravindra Jadeja";

            Console.WriteLine("Please select Team1 and Team2 using their mentioned codes:");
            for (int i = 0; i < tdarr.Length; i++)
            {
                //Console.WriteLine("Team " + (i ) + " = " + tdarr[i]);
                Console.WriteLine("[" + i + "] = " + tdarr[i]);
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("");

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Please Enter the numner for Team Selection Team" + (i + 1) + " :");
                tsarr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n");

            Console.WriteLine("The match will begin soon between " + tdarr[tsarr[0]] + " VS " + tdarr[tsarr[1]]);
            Console.WriteLine("\n");

            //Store the team1 and team2 name in 2 string variables for easy use
            string Team1_Name = tdarr[tsarr[0]];
            string Team2_Name = tdarr[tsarr[1]];

            //Store the team1 and team2 Code in 2 integar variables for easy use
            int Team1_Code = tsarr[0];
            int Team2_Code = tsarr[1];

            Display d = new Display();
            d.ShowTeamPlayers(Team1_Code, AllTeamsPlayer, Team1_Name);
            d.ShowTeamPlayers(Team2_Code, AllTeamsPlayer, Team2_Name);

            int CheckingWin = Toss.TossCall(Team1_Name, Team2_Name, AllTeamsPlayer[Team1_Code, 0], AllTeamsPlayer[Team2_Code, 0]);

            d.ShowTeamPlayers(Team1_Code, AllTeamsPlayer, Team1_Name);
            d.ShowTeamPlayers(Team2_Code, AllTeamsPlayer, Team2_Name);

            if (CheckingWin == 5)
            {
                Console.WriteLine("These Batmans will start the innings for " + Team1_Name);
                for (int i = 0; i < 2; i++)
                {                    
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team1_Code, i]);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Please select the opening bowler for " + Team2_Name + " from the following: ");

                for (int i = 5; i < 10; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team2_Code, i]);
                }

                Current_Bowler = Convert.ToInt32(Console.ReadLine());
            }

            else if (CheckingWin == 10)
            {
                Console.WriteLine("Please select the opening bowler for " + Team1_Name + " from the following: ");
                for (int i = 5; i < 10; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team1_Code, i]);
                }
                Current_Bowler = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine("These Batmans will start the innings for " + Team2_Name);
                for (int i = 0; i < 2; i++)
                {
                    
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team2_Code, i]);
                }
            }
            else if (CheckingWin == 15)
            {
                Console.WriteLine("These Batmans will start the innings for " + Team2_Name);
                for (int i = 0; i < 2; i++)
                {                    
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team2_Code, i]);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Please select the opening bowler for " + Team1_Name + " from the following: ");
                for (int i = 5; i < 10; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team1_Code, i]);
                }
                Current_Bowler = Convert.ToInt32(Console.ReadLine());                
            }
            else if (CheckingWin == 20)
            {
                Console.WriteLine("Please select the opening bowler for " + Team2_Name + " from the following: ");
                for (int i = 5; i < 10; i++)
                {
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team2_Code, i]);
                }
                Current_Bowler = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine("These Batmans will start the innings for " + Team1_Name);
                for (int i = 0; i < 2; i++)
                {                    
                    Console.WriteLine("Player Code [" + i + "] " + AllTeamsPlayer[Team1_Code, i]);
                }                
            }
        }
    }
}
