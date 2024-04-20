using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PT1
{
    internal class footBallTeam
    {

        private int totalScores = 0;
        private int totalScoresC = 0;
        private int goalPreformance = 0;
        private string _name;
        private string _oponentName;
        private int _goalsScored;
        private int _goalsConceded;
        private int _matches;
        private int _totPoints;
        static private int _teamNumber;
        public int TotalScores
        {
            get { return totalScores; }
            set
            {
                totalScores = value;
            }
        }
        public int TotalScoresC
        {
            get { return totalScoresC; }
            set
            {
                totalScoresC = value;
            }
        }
        public int GoalsScored
        {
            get { return _goalsScored; }
            set
            {
                _goalsScored = value;
            }
        }
        public int GoalsConceded
        {
            get { return _goalsConceded; }
            set
            {
                _goalsConceded = value;
            }
        }
        public int Matches
        {
            get { return _matches; }
            set
            {
                _matches = value;
            }
        }
        public int TotPoints
        {
            get { return _totPoints; }
            set
            {
                if (value < 0)
                {
                    _totPoints = 0;
                }
                else
                {
                    _totPoints = value;
                }
            }
        }
        public footBallTeam() 
        {
            
            _teamNumber++;
        }
        public footBallTeam(int gs, int gc, int m)
        {
            _name = "bestTeam";
            GoalsScored = gs;
            GoalsConceded = gc;
            Matches = m;


            TotPoints += AddMatchResult(GoalsScored, GoalsConceded, ref totalScores, ref totalScoresC);
            TotalScores = totalScores;
            TotalScoresC = totalScoresC;
            goalPreformance = CalculateGoalPerformance(totalScores, totalScoresC);
            
            
        }

        public static int AddMatchResult(int gc, int gs, ref int totgs, ref int totgc)
        {
            
            totgs += gs;
            totgc += gc;
            if (gs > gc)
            {
                return 2; 
            }
            else if (gs < gc)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            
        }
        public static int CalculateGoalPerformance(int totalScores, int totalScoresC)
        {
            return totalScores - totalScoresC;
        }
        public override string ToString()
        {
            return _teamNumber +": "+ _name +"\nTotalScores: " + totalScores + "\nTotalScoresC: "+ totalScoresC + "\nMatches: " + Matches + "\nTotal Points: "+ _totPoints + "\nGoal Preformance: " + goalPreformance;
        }
       

    }
}
