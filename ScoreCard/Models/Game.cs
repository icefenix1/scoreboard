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

        internal void Update(Game update)
        {
            Home.UpdateScore(update.Home.Score);
            Away.UpdateScore(update.Away.Score);
        }

        public override bool Equals(object obj)
        {
            if((!Home.Equals(((Game)obj).Home)))
            {
                return false;
            }else if(!Away.Equals(((Game)obj).Away))
            {
                return false;
            }

            return true;
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}