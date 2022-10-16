using ScoreCard;
using ScoreCard.Models;

namespace ScoreCardTest;

[TestClass]
public class GetTest
{

    private readonly List<Game> InProgressMatchList = new List<Game> {
        new Game(new Team("Mexico", 0), new Team("Canada",0)),
        new Game(new Team("Spain",0), new Team("Brazil",0)),
        new Game(new Team("Germany",0), new Team("France",0)),
        new Game(new Team("Uruguay",0), new Team("Italy",0)),
        new Game(new Team("Argentina",0), new Team("Australia",0))};

    private  List<Game> ExpectedMatchList = new List<Game> {
        new Game(new Team("Argentina",0), new Team("Australia",0)),
        new Game(new Team("Uruguay",0), new Team("Italy",0)),
        new Game(new Team("Germany",0), new Team("France",0)),
        new Game(new Team("Spain",0), new Team("Brazil",0)),
        new Game(new Team("Mexico", 0), new Team("Canada",0))};        

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
    public void EmptyScoreBoard()
    {
        var Board = CreateScoreBoard(); 

        var Matches = Board.Get();       

        CollectionAssert.AreEqual(new List<Game>(),Matches);
    }

    [TestMethod]
    public void PopulatedScoreBoard()
    {
        var Board = CreatePopulatedScoreBoard(); 

        var Matches = Board.Get();

        CollectionAssert.AreEqual(ExpectedMatchList,Matches);
    }
}