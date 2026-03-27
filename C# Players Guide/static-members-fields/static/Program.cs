namespace StaticMembersFields;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Score score = new Score() { Var = 2 };
        Score score1 = new Score { Var = 3 };

        Console.WriteLine(score.Level1);
        Console.WriteLine(score.Level1);

        Player player = new Player { Name = "João"};
        Player player2 = new Player { Name = "Espedido" };
        Player player3 = new Player { Name = "Dona Maria" };
        Player player4 = new Player { Name = "Joana" };

        Player[] AllInstanceOfPlayers = new Player[] { player, player2, player3, player4 };

        Score.couterNames("João", AllInstanceOfPlayers); //chamamos pelo Score pq ele pertence a class não a instancia
    }
}

public class Score
{
    private static readonly int PointThersHold = 1000; //static uses UpperCamelCase
    public static int LevelThersHold { get;  } = 4;
    private static readonly int Points = 6; //mesma coisa que readonly 
    private static readonly int Level = 5;
    private int _teste = 1;
    public int Var { get; set; }

    public static bool IsWorthyOfTheHighScoreTable
    {
        get
        {
            if (Points < PointThersHold) return false;
            if (Level < LevelThersHold) return false;
            return true;
        }
    }

    public int Level1 => Level; //o static ele faz com que o molde a aponte para os valors estaticos, idependentemente do da instancia ele aponta para a estatica

    public static int couterNames(string playerName, Player[] playerPart)
    {
        int count = 0;

        foreach(Player namePar in playerPart) //passa a instancia para namePar
            if(namePar.Name == playerName)
                count++;

        return count;
    }
}

public class Player
{
    public string Name { get; init; }
    public decimal MoneyInYourPocket { get; private set; }

   
}