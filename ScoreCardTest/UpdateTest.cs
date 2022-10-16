using ScoreCard;
using ScoreCard.Models;

namespace ScoreCardTest;

[TestClass]
public class UpdateTest
{
    private readonly List<Game> ExpectedMatchList = new List<Game> {
        new Game(new Team("South Africa", 1), new Team("Norway",10)),
        new Game(new Team("Spain",3), new Team("Brazil",4)),
        new Game(new Team("Mexico", 5), new Team("Canada",1)),
        new Game(new Team("Uruguay",2), new Team("Italy",3)),
        new Game(new Team("Argentina",3), new Team("Australia",1)),
        new Game(new Team("Germany",1), new Team("France",0))};         
        

    private readonly List<Game> InProgressMatchList = new List<Game> {
        new Game(new Team("South Africa", 1), new Team("Norway",9)),
        new Game(new Team("Mexico", 5), new Team("Canada",1)),
        new Game(new Team("Spain",3), new Team("Brazil",4)),
        new Game(new Team("Germany",1), new Team("France",0)),
        new Game(new Team("Uruguay",2), new Team("Italy",3)),
        new Game(new Team("Argentina",3), new Team("Australia",1))}; 

    private readonly Game SingleInProgress = new Game(new Team("South Africa", 1), new Team("Norway",9));           

    private readonly List<Game> ExpectedSingleInProgressMatchList = new List<Game> {
        new Game(new Team("South Africa", 1), new Team("Norway",10))};           


private readonly List<Game> ExpectedMatchListWithEqualScore = new List<Game> {
        new Game(new Team("Mexico", 10), new Team("Canada",1)),
        new Game(new Team("South Africa", 1), new Team("Norway",10)),
        new Game(new Team("Spain",3), new Team("Brazil",4)),        
        new Game(new Team("Uruguay",2), new Team("Italy",3)),
        new Game(new Team("Argentina",3), new Team("Australia",1)),
        new Game(new Team("Germany",1), new Team("France",0))};         
        

    private readonly List<Game> InProgressMatchListWithEqualScore = new List<Game> {
        new Game(new Team("South Africa", 1), new Team("Norway",9)),
        new Game(new Team("Mexico", 10), new Team("Canada",1)),
        new Game(new Team("Spain",3), new Team("Brazil",4)),
        new Game(new Team("Germany",1), new Team("France",0)),
        new Game(new Team("Uruguay",2), new Team("Italy",3)),
        new Game(new Team("Argentina",3), new Team("Australia",1))};

    private readonly Game UpdatedGame = new Game(new Team("South Africa", 1), new Team("Norway",10));    

    private ScoreBoard CreateScoreBoard()
    {
        var toReturn =  new ScoreBoard();
        return toReturn;
    }

    private ScoreBoard CreateSingelEntryScoreBoard()
    {
        var toReturn =  CreateScoreBoard();
        toReturn.Add(SingleInProgress);

        return toReturn;
    }    

    private ScoreBoard CreatePopulatedScoreBoard(List<Game> gameList)
    {
        var toReturn =  CreateScoreBoard();
        foreach(var g in gameList){
            toReturn.Add(g);
        }
        return toReturn;
    }

    [TestMethod]
    public void UpdateToSingleItemScoreBoard()
    {
        var Board = CreateSingelEntryScoreBoard(); 

        var Matches = Board.Update(UpdatedGame);       

        CollectionAssert.AreEqual(ExpectedSingleInProgressMatchList,Matches);
    }

    [TestMethod]
    public void UpdateToMultiEntryScoreBoard()
    {
        var Board = CreatePopulatedScoreBoard(InProgressMatchList); 

        var Matches = Board.Update(UpdatedGame);       

        CollectionAssert.AreEqual(ExpectedMatchList,Matches);
    }

    [TestMethod]
    public void UpdateToMultiEntryScoreBoardWithEqualScores()
    {
        var Board = CreatePopulatedScoreBoard(InProgressMatchListWithEqualScore); 

        var Matches = Board.Update(UpdatedGame);       

        CollectionAssert.AreEqual(ExpectedMatchListWithEqualScore,Matches);
    }
}