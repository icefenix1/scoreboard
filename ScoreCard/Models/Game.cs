using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreCard.Models
{
    public class Game
    {
        public Team Home {get; private set;}
        public Team Away {get; private set;}

        public Game(Team home, Team away)
        {
            Home = home;
            Away = away;
        }
    }
}