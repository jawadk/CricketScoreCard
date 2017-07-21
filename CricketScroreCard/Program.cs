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
            int[] Team_First_BattingLine = new int[11];         //Store the FIRST batting team runs
            int[,] Team_Second_BattingLine = new int[2, 11];     //Store the SECOND batting team runs
            int[] Team1_BowlingLine = new int[11];
            int[,] Team2_BowlingLine = new int[2, 11];

            int[] Boundary_Batting1 = new int[2];
            Boundary_Batting1[0] = 0;       //Counting FOURs
            Boundary_Batting1[1] = 0;       //Counting SIXs
            int[] Boundary_Batting2 = new int[2];

            int Batsman1 = 0;
            int Batsman2 = 0;
            int Stricker = 1;           //TO handle the Batsman Strike 
            int WhiteBowled = 0;
            int BatsmanMaxCode = 1;
            int wicketFallsTeam1 = 0;
            int wicketFallsTeam2 = 0;


            int MatchOvers = 3; //T20 match total balls (6 * 20 = 120)
            int TotalBalls = MatchOvers * 6; //Total balls avaiable
            int TotalBalls_Fixed = MatchOvers * 6; //Decrearing this variable to run the complete total balls (FOR LOOP)
            int BallBowl = 0;                       //Counting Valid Balls
            int Score1 = 0, Score2 = 0;             //Counting Score for FirstBatting and Second Batting

            int Current_Bowler = 0;
                                    
            //Presentation Spash ----- START
            Console.WriteLine("    ÛÛÛÛÛÛÛÛÛ             ÛÛÛ           ÛÛÛÛÛ                ÛÛÛÛÛ   ");
            Console.WriteLine("  ÛÛÛ°°°°°ÛÛÛ             °°°           °°ÛÛÛ                °°ÛÛÛ    ");
            Console.WriteLine(" Û ÛÛ     °°°  ÛÛÛÛÛÛÛÛ  ÛÛÛÛ   ÛÛÛÛÛÛ  °ÛÛÛ ÛÛÛÛÛ  ÛÛÛÛÛÛ  ÛÛÛÛÛÛÛ  ");
            Console.WriteLine("° ÛÛÛ         °°ÛÛÛ°°ÛÛÛ°°ÛÛÛ  ÛÛÛ°°ÛÛÛ °ÛÛÛ°°ÛÛÛ  ÛÛÛ°°ÛÛÛ°°°ÛÛÛ°   ");
            Console.WriteLine("° ÛÛÛ          °ÛÛÛ °°°  °ÛÛÛ °ÛÛÛ °°°  °ÛÛÛÛÛÛ°  °ÛÛÛÛÛÛÛ   °ÛÛÛ    ");
            Console.WriteLine(" °°ÛÛÛ     ÛÛÛ °ÛÛÛ      °ÛÛÛ °ÛÛÛ  ÛÛÛ °ÛÛÛ°°ÛÛÛ °ÛÛÛ°°°    °ÛÛÛ ÛÛÛ");
            Console.WriteLine("  °°ÛÛÛÛÛÛÛÛÛ  ÛÛÛÛÛ     ÛÛÛÛÛ°°ÛÛÛÛÛÛ  ÛÛÛÛ ÛÛÛÛÛ°°ÛÛÛÛÛÛ   °°ÛÛÛÛÛ ");
            Console.WriteLine("    °°°°°°°°°  °°°°°     °°°°°  °°°°°°  °°°° °°°°°  °°°°°°     °°°°°  ");

            Console.WriteLine("\t");

            Console.WriteLine("                 ÛÛÛÛÛ        ÛÛÛ          ");
            Console.WriteLine("    °°ÛÛÛ        °°°                       ");
            Console.WriteLine("     °ÛÛÛ        ÛÛÛÛ  ÛÛÛÛÛ ÛÛÛÛÛ  ÛÛÛÛÛÛ ");
            Console.WriteLine("     °ÛÛÛ       °°ÛÛÛ °°ÛÛÛ °°ÛÛÛ  ÛÛÛ°°ÛÛÛ");
            Console.WriteLine("     °ÛÛÛ        °ÛÛÛ  °ÛÛÛ  °ÛÛÛ °ÛÛÛÛÛÛÛ ");
            Console.WriteLine("     °ÛÛÛ      Û °ÛÛÛ  °°ÛÛÛ ÛÛÛ  °ÛÛÛ°°°  ");
            Console.WriteLine("      ÛÛÛÛÛÛÛÛÛÛÛ ÛÛÛÛÛ  °°ÛÛÛÛÛ   °°ÛÛÛÛÛÛ ");
            Console.WriteLine("      °°°°°°°°°°° °°°°°    °°°°°     °°°°°°  ");
            
            Console.WriteLine("\t");
            //Presentation Spash ----- END
                        

            string[] tdarr = { "PAKISTAN", "SRILANKA", "AUSTRALIA", "INDIA" }; // Team Details Array           

            string[,] AllTeamsPlayer = new string[4, 11];

            // Team PAKISTAN 11 Players ==== CODE == 0
                        // 0 = TEEAM ----- 0 = TeamPlayer
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


            int[] tsarr = new int[2]; // Team Selected Array --- USER INPUT
            Console.WriteLine("Please select Team1 and Team2 using their mentioned codes:");
            for (int i = 0; i < tdarr.Length; i++)
            {
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
            d.ShowTeamPlayers(Team1_Code, AllTeamsPlayer, Team1_Name);          //This function displays the TEAM1 players
            d.ShowTeamPlayers(Team2_Code, AllTeamsPlayer, Team2_Name);          //This function displays the TEAM2 players

            int Checking_Toss_Win = Toss.TossCall(Team1_Name, Team2_Name, AllTeamsPlayer[Team1_Code, 0], AllTeamsPlayer[Team2_Code, 0]);

            d.ShowTeamPlayers(Team1_Code, AllTeamsPlayer, Team1_Name);          //This function displays the TEAM1 players
            d.ShowTeamPlayers(Team2_Code, AllTeamsPlayer, Team2_Name);          //This function displays the TEAM2 players

            int[] SelectedBatBowl = MatchAction.BowlerSelectionInningStart(Checking_Toss_Win, Current_Bowler, Team1_Name, Team2_Name, Team1_Code, Team2_Code, AllTeamsPlayer);

            int TeamBatting_Code = SelectedBatBowl[0];            //First Batting Team Code
            int Battman_1_Code = SelectedBatBowl[1];                //BATSMAN1 Code
            int Battman_2_Code = SelectedBatBowl[2];                 //BATSMAN2 Code
            int TeamBowling_Code = SelectedBatBowl[3];            //First BOWLING Team Code
            int Team_Bowler_Code = SelectedBatBowl[4];            //First BOWLER 
            Current_Bowler = Team_Bowler_Code;

            for (int i = 1; i <= TotalBalls_Fixed; i++)
            {
                if (wicketFallsTeam1 < 9)
                {
                    
                
                Display.ShowCodes(); // This method shows the Codes for activity
                int Action_Input = Convert.ToInt32(Console.ReadLine());

                if (Action_Input == 0)
                {
                    Score1 = Score1 + 0;            //Adding 0 in Total Score
                    TotalBalls = --TotalBalls;    //Decrease 1 ball from total balls
                    BallBowl = BallBowl + 1;
                    if (Stricker == 1)
                    {
                        //Batsman1 = Batsman1 + 0;
                        Team_First_BattingLine[Battman_1_Code] = Team_First_BattingLine[Battman_1_Code] + 0;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 0;
                            
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer); 
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    else if (Stricker == 0)
                    {
                        //Batsman2 = Batsman2 + 0;
                        Team_First_BattingLine[Battman_2_Code] = Team_First_BattingLine[Battman_2_Code] + 0;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        
                        /*Batsman2 Transfering the strike to Batsman1 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 1;
                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    Display.ShowScore(TeamBatting_Code, BallBowl, Score1, wicketFallsTeam1);                    
                }
                else if (Action_Input == 1)
                {
                    Score1 = Score1 + 1;            //Adding 0 in Total Score
                    TotalBalls = --TotalBalls;    //Decrease 1 ball from total balls
                    BallBowl = BallBowl + 1;

                    if (Stricker == 1)
                    {
                        //Batsman1 = Batsman1 + 1;
                        Team_First_BattingLine[Battman_1_Code] = Team_First_BattingLine[Battman_1_Code] + 1;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        Stricker = 0;
                        
                        /*Batsman1 Transfering the strike to Batsman2 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 1;
                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    else if (Stricker == 0)
                    {
                        //Batsman2 = Batsman2 + 1;
                        Team_First_BattingLine[Battman_2_Code] = Team_First_BattingLine[Battman_2_Code] + 1;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        Stricker = 1;

                        /*Batsman2 Transfering the strike to Batsman1 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 0;
                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    Display.ShowScore(TeamBatting_Code, BallBowl, Score1, wicketFallsTeam1);
                }
                else if (Action_Input == 2)
                {
                    Score1 = Score1 + 2;            //Adding 0 in Total Score
                    TotalBalls = --TotalBalls;    //Decrease 1 ball from total balls
                    BallBowl = BallBowl + 1;

                    if (Stricker == 1)
                    {
                        //Batsman1 = Batsman1 + 2;
                        Team_First_BattingLine[Battman_1_Code] = Team_First_BattingLine[Battman_1_Code] + 2;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler

                        /*Batsman1 Transfering the strike to Batsman2 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 0;
                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    else if (Stricker == 0)
                    {
                        //Batsman2 = Batsman2 + 2;
                        Team_First_BattingLine[Battman_2_Code] = Team_First_BattingLine[Battman_2_Code] + 2;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler

                        /*Batsman2 Transfering the strike to Batsman1 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 1;
                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    Display.ShowScore(TeamBatting_Code, BallBowl, Score1, wicketFallsTeam1);
                }
                else if (Action_Input == 3)
                {
                    //Adding 0 in Total Score
                    Score1 = Score1 + 3;

                    //Decrease 1 ball from total balls
                    TotalBalls = --TotalBalls;    
                    BallBowl = BallBowl + 1;

                    if (Stricker == 1)
                    {
                        //Batsman1 = Batsman1 + 3;
                        Team_First_BattingLine[Battman_1_Code] = Team_First_BattingLine[Battman_1_Code] + 3;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        Stricker = 0;
                        
                        /*Batsman1 Transfering the strike to Batsman2 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 1;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    else if (Stricker == 0)
                    {
                        //Batsman2 = Batsman2 + 3;
                        Team_First_BattingLine[Battman_2_Code] = Team_First_BattingLine[Battman_2_Code] + 3;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        Stricker = 1;

                        /*Batsman2 Transfering the strike to Batsman1 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 0;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    Display.ShowScore(TeamBatting_Code, BallBowl, Score1, wicketFallsTeam1);
                }
                else if (Action_Input == 4)
                {
                    //Adding 0 in Total Score
                    Score1 = Score1 + 4;

                    //Counting Boundary - 4
                    Boundary_Batting1[0] = Boundary_Batting1[0] + 1;

                    //Decrease 1 ball from total balls
                    TotalBalls = --TotalBalls;    
                    BallBowl = BallBowl + 1;

                    if (Stricker == 1)
                    {
                        //Batsman1 = Batsman1 + 4;                        
                        Team_First_BattingLine[Battman_1_Code] = Team_First_BattingLine[Battman_1_Code] + 4;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        
                        /*Batsman1 Transfering the strike to Batsman2 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 0;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    else if (Stricker == 0)
                    {
                        //Batsman2 = Batsman2 + 4;                        
                        Team_First_BattingLine[Battman_2_Code] = Team_First_BattingLine[Battman_2_Code] + 4;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        
                        /*Batsman2 Transfering the strike to Batsman1 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 1;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    Display.ShowScore(TeamBatting_Code, BallBowl, Score1, wicketFallsTeam1);
                }
                else if (Action_Input == 5)
                {
                    //Adding 0 in Total Score
                    Score1 = Score1 + 5;

                    //Decrease 1 ball from total balls
                    TotalBalls = --TotalBalls;       
                    BallBowl = BallBowl + 1;

                    if (Stricker == 1)
                    {
                        //Batsman1 = Batsman1 + 5;
                        Team_First_BattingLine[Battman_1_Code] = Team_First_BattingLine[Battman_1_Code] + 5;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        Stricker = 0;
                        
                        /*Batsman1 Transfering the strike to Batsman2 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 1;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    else if (Stricker == 0)
                    {
                        //Batsman2 = Batsman2 + 5;
                        Team_First_BattingLine[Battman_2_Code] = Team_First_BattingLine[Battman_2_Code] + 5;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        Stricker = 1;

                        /*Batsman2 Transfering the strike to Batsman1 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 0;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    Display.ShowScore(TeamBatting_Code, BallBowl, Score1, wicketFallsTeam1);
                }
                else if (Action_Input == 6)
                {
                    //Adding 0 in Total Score
                    Score1 = Score1 + 6;

                    //Counting Boundary - 6 Runs
                    Boundary_Batting1[1] = Boundary_Batting1[1] + 1;    

                    //Decrease 1 ball from total balls
                    TotalBalls = --TotalBalls;
                    BallBowl = BallBowl + 1;

                    if (Stricker == 1)
                    {
                        //Batsman1 = Batsman1 + 6;
                        Team_First_BattingLine[Battman_1_Code] = Team_First_BattingLine[Battman_1_Code] + 6;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        
                        /*Batsman1 Transfering the strike to Batsman2 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 0;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    else if (Stricker == 0)
                    {
                        //Batsman2 = Batsman2 + 6;
                        Team_First_BattingLine[Battman_2_Code] = Team_First_BattingLine[Battman_2_Code] + 6;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler

                        /*Batsman2 Transfering the strike to Batsman1 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 1;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    Display.ShowScore(TeamBatting_Code, BallBowl, Score1, wicketFallsTeam1);
                }
                else if (Action_Input == 7)     //Batsman Out Conditions
                {
                    //Adding 0 in Total Score
                    Score1 = Score1 + 0;

                    //Decrease 1 ball from total balls
                    TotalBalls = --TotalBalls;
                    BallBowl = BallBowl + 1;
                    Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler

                    if (Stricker == 1)
                    {
                        //Batsman1 = Batsman1 + 3;
                        ++BatsmanMaxCode;
                        ++wicketFallsTeam1;
                        Battman_1_Code = BatsmanMaxCode;                        
                        Stricker = 1;

                        /*Batsman1 Transfering the strike to Batsman2 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 0;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    else if (Stricker == 0)
                    {
                        //Batsman2 = Batsman2 + 3;
                        ++BatsmanMaxCode;
                        ++wicketFallsTeam1;
                        Battman_2_Code = BatsmanMaxCode;
                        Team1_BowlingLine[Current_Bowler] = Team1_BowlingLine[Current_Bowler] + 1;          //Counting Bowled Balls by Bowler
                        Stricker = 0;

                        /*Batsman2 Transfering the strike to Batsman1 after OVER completion*/
                        if (BallBowl % 6 == 0)
                        {
                            Stricker = 1;

                            //Show the Bowler list for next over selection
                            MatchAction.ShowBowlers(Team1_Name, TeamBowling_Code, AllTeamsPlayer);
                            Current_Bowler = Convert.ToInt32(Console.ReadLine());                            
                        }
                    }
                    Display.ShowScore(TeamBatting_Code, BallBowl, Score1, wicketFallsTeam1);
                }

                else if (Action_Input == 8)
                {
                    //Adding 1 in Total Score (WHITE BALL)
                    Score1 = Score1 + 1;
                    WhiteBowled = WhiteBowled + 1;
                }

            }
        }
        }
    }
}
