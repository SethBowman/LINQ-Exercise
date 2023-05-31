namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>() 
            {
                "Fallout: New Vegas",
                "Call of Duty",
                "Star Wars: Battlefront 2",
                "Fall Guys",
                "Fallout 3",
                "Legend Of Zelda: Breath of the Wild",
                "Paladins"
            };

            var orderedGames = gameNames.OrderBy(game => game.Length).ToList();
            orderedGames.ForEach(game => Console.WriteLine(game));
        }
    }
}
