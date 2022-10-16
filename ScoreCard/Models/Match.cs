using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreCard.Models
{
    public class Match
    {
        public Game CurrentGame{get; private set;}
        public DateTime TimeStarted {get;}

        public int TotalScore {get{
            return CurrentGame.Home.Score + CurrentGame.Away.Score;
        }}

        public Match(Game game)
        {
            TimeStarted = DateTime.Now;
            CurrentGame = game;
        }        
    }
}