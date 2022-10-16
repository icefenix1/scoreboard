using ScoreCard.Models;

namespace ScoreCard;
public class ScoreBoard
{

    private List<Match> Matches = new List<Match>();

    public ScoreBoard()
    {

    }

    public List<Game> Add(Game match)
    {        
        Matches.Add(new Match(match));
        return Get();
    }

    public List<Game> Update(Game match)
    {
        if(MatchExists(match))
        {
            Matches[GetMatchIndex(match)].CurrentGame.Update(match);
        }
        return Get();
    }

    public List<Game> Remove(Game match)
    {
        if(MatchExists(match))
        {
            Matches.RemoveAt(GetMatchIndex(match));
        }
        return Get();
    }

    private bool MatchExists(Game match)
    {
        return Matches.Any(i => 
            i.CurrentGame.Away.Name == match.Away.Name && 
            i.CurrentGame.Home.Name == match.Home.Name);
    }

    private int GetMatchIndex(Game match)
    {
        var item = Matches.First(i => 
            i.CurrentGame.Away.Name == match.Away.Name && 
            i.CurrentGame.Home.Name == match.Home.Name);
        return Matches.IndexOf(item);
    }

    public List<Game> Get()
    {   
        return Matches.OrderByDescending(ts => ts.TotalScore).ThenByDescending(start => start.TimeStarted).Select(sel => sel.CurrentGame).ToList();
    }

}
