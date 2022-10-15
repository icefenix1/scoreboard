using ScoreCard.Models;

namespace ScoreCard;
public class ScoreBoard
{

    private List<Game> Matches {get; set;}

    public ScoreBoard()
    {
        Matches = new List<Game>();
    }

    public List<Game> Add(Game match)
    {
        return new List<Game>();
    }

    public List<Game> Update(Game match)
    {
        return new List<Game>();
    }

    public List<Game> Remove(Game match)
    {
        return new List<Game>();
    }

}
