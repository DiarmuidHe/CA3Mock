using System.IO;

namespace PT1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //part2();
            part2();




        }
        static void part1()
        {
            int matches = 3;

            footBallTeam team = new footBallTeam();
            for (int i = 0; i < matches; i++)
            {
                Console.Write("Goal: ");
                int goalsScored = int.Parse(Console.ReadLine());
                Console.Write("Goal conceeded: ");
                int goalsConceeded = int.Parse(Console.ReadLine());
                team = new footBallTeam(goalsConceeded, goalsScored, matches);
            }
            Console.WriteLine(team.ToString());
        }
        static void part2()
        {
            checker ineteger = new checker();
            string path = @"../../../fb.csv";
            int counter = 0;
            string[] footBalTeams = { "Sligo", "Mayo", "Donegal", "Leitrim", "Roscommon", "Longford" };
            FileStream f = new FileStream(path, FileMode.Open);
            StreamWriter s = new StreamWriter(f);
            for (int i = 0; i < 3; i++)
            {
                int totgoalsScored = 0;
                int totgoalsScoredC = 0;
                Console.WriteLine($"{footBalTeams[counter]}, {footBalTeams[counter + 1]}");
                footBallTeam team = new footBallTeam();
                Console.Write("Enter matches played: ");
                int matches = int.Parse(Console.ReadLine());
                
                for (int j = 0; j < matches; j++)
                {

                    Console.Write("Goal: ");
                    int goalsScored = int.Parse(Console.ReadLine());
                    Console.Write("Goal conceeded: ");
                    int goalsConceeded = int.Parse(Console.ReadLine());
                    team = new footBallTeam(goalsConceeded, goalsScored, matches);
                    totgoalsScored += team.TotalScores;
                    totgoalsScoredC += team.TotalScoresC;
                }
               
               
                
                //declared stream writer
                
                s.WriteLine(string.Join(",", new String[] { footBalTeams[counter], footBalTeams[counter+1], totgoalsScored.ToString(), totgoalsScoredC.ToString() })) ;// joins the new string together and makes them comma seperated
                

                counter += 2 ;
                //closing stream writer

            }
            s.Close();
            f.Close();

        }
    }
}