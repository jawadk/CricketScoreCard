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
    }
}
