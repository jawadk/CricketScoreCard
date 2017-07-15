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
            
            //Presentation Spash ----- START
            Console.WriteLine("   ÛÛÛÛÛÛÛÛÛ             ÛÛÛ           ÛÛÛÛÛ                ÛÛÛÛÛ   ");
            Console.WriteLine("ÛÛÛ°°°°°ÛÛÛ           °°°           °°ÛÛÛ                °°ÛÛÛ    ");
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
            Console.WriteLine("     ÛÛÛÛÛÛÛÛÛÛÛ ÛÛÛÛÛ  °°ÛÛÛÛÛ   °°ÛÛÛÛÛÛ ");
            Console.WriteLine("    °°°°°°°°°°° °°°°°    °°°°°     °°°°°°  ");
            
            Console.WriteLine("\t");
            //Presentation Spash ----- END

            int MatchOvers = 20; //T20 match total balls (6 * 20 = 120)
            int team1_Score = 0, team2_Score = 0;

            Console.WriteLine("Please select Team1 and Team2 using their mentioned codes:");
            string[] DisplayTeamCodes = {"Australia","England","Pakistan" };
            for (int i = 0; i < DisplayTeamCodes.Length; i++)
            {
                Console.WriteLine("[" + i +"]" + DisplayTeamCodes[i]);
            }

            Console.Write("Please enter code for Team1: ");
            string Team1Code = Console.ReadLine();
            Console.Write("Please enter code for Team2: ");
            string Team2Code = Console.ReadLine();



            //string[] AUSTRALIA = { "Steven Smith(c)", "David Warner", "Pat Cummins", "Aaron Finch", "John Hastings", "Josh Hazlewood", "Travis Head", "Moises Henriques", "Chris Lynn", "Glenn Maxwell", "James Pattinson", "Mitchell Starc", "Marcus Stoinis", "Matthew Wade", "Adam Zampa" };
            //string[] PAKISTAN = { "Sarfraz Ahmed(c)", "Ahmed Shehzad", "Azhar Ali", "Babar Azam", "Fahim Ashraf", "Hasan Ali", "Imad Wasim", "Junaid Khan", "Mohammad Amir", "Mohammad Hafeez", "Shadab Khan", "Shoaib Malik", "Wahab Riaz", "Fakhar Zaman", "Haris Sohail", "Rumman Raees" };
            //string[] INDIA = { "Virat Kohli(c)", "Rohit Sharma", "Shikhar Dhawan", "Yuvraj Singh", "Ajinkya Rahane", "Dinesh Karthik", "Kedar Jadhav", "MS Dhoni", "Hardik Pandya", "Ravichandran Ashwin", "Ravindra Jadeja", "Bhuvneshwar Kumar", "Jasprit Bumrah", "Umesh Yadav", "Mohammed Shami" };

            //Console.WriteLine("******************************");

            //Console.WriteLine("The match will begin soon between " + Team1 + " VS " + Team2);

            //if (Team1 == "PAKISTAN" && Team2  == "INDIA")
            //{
            //    string[] TeamPlaying1 = PAKISTAN;
            //    string[] TeamPlaying2 = INDIA;

            //    Console.WriteLine("Great, lets move for the TOSS \n");
            //    Console.WriteLine("We would be like to ask from " + Team1 + " Captain " + TeamPlaying1[0] + " .... Heads or Tails" );
            //    Console.WriteLine("[0] = TRAILS");
            //    Console.WriteLine("[1] = HEADS \n");

            //    int TossValue = Convert.ToInt32(Console.ReadLine());
            //    int Toss_WON = Toss.TossDesider(TossValue, Team1, Team2);



            //}
        }
    }
}
