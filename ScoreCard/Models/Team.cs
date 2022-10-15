using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreCard.Models
{
    public class Team
    {
        public string Name {get;}
        public int Score {get; private set;}

        public Team(string name, int score = 0)
        {
            Name = name;
            Score = score;
        }
    }
}