using ScoreCard;
using ScoreCard.Models;

namespace ScoreCardTest;

[TestClass]
public class AddTest
{

    private readonly List<Game> InProgressMatchList = new List<Game> {
        new Game(new Team("Mexico", 0), new Team("Canada",0)),
        new Game(new Team("Spain",0), new Team("Brazil",0)),
        new Game(new Team("Germany",0), new Team("France",0)),
        new Game(new Team("Uruguay",0), new Team("Italy",0)),
        new Game(new Team("Argentina",0), new Team("Australia",0))};

    private readonly List<Game> ExpectedMatchList = new List<Game> {
        new Game(new Team("South Africa", 0), new Team("Norway",0)),
        new Game(new Team("Mexico", 0), new Team("Canada",0)),
        new Game(new Team("Spain",0), new Team("Brazil",0)),
        new Game(new Team("Germany",0), new Team("France",0)),
        new Game(new Team("Uruguay",0), new Team("Italy",0)),
        new Game(new Team("Argentina",0), new Team("Australia",0))};        

    private readonly Game CreatedGame = new Game(new Team("South Africa", 0), new Team("Norway",0));

    private ScoreBoard CreateScoreBoard()
    {
        var toReturn =  new ScoreBoard();
        return toReturn;
    }

    private ScoreBoard CreatePopulatedScoreBoard()
    {
        var toReturn =  CreateScoreBoard();
        foreach(var g in InProgressMatchList){
            toReturn.Add(g);
        }
        return toReturn;
    }

    [TestMethod]
    public void AddToEmptyScoreBoard()
    {
        var Board = CreateScoreBoard(); 

        var Matches = Board.Add(CreatedGame);       

        Assert.AreEqual(new List<Game>{CreatedGame},Matches);
    }

    [TestMethod]
    public void AddToPopulatedScoreBoard()
    {
        var Board = CreatePopulatedScoreBoard(); 

        var Matches = Board.Add(CreatedGame);       

        Assert.AreEqual(ExpectedMatchList,Matches);
    }
}