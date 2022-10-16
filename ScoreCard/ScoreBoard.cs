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
        return Get();
    }

    public List<Game> Remove(Game match)
    {
        return Get();
    }

    private List<Game> Get()
    {
        var toReturn = new List<Game>();
        toReturn.AddRange(Matches.OrderByDescending(ts => ts.TotalScore).OrderByDescending(start => start.TimeStarted).Select(sel => sel.CurrentGame).ToList());
        return toReturn;
    }

}
