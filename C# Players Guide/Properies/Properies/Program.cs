namespace Properies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Rectangle Rectangle = new(5, 4);

            Rectangle.Width = -1;
            Console.WriteLine(Rectangle.Width);
            Console.WriteLine(Rectangle.Area);

            

            Player Player = new("Indiana Jonas");
            Console.WriteLine(Player.Name);
            Player.Name = "India";
            Console.WriteLine(Player.Name);

            Console.WriteLine(Player.BirthNumber); //é uma var somente leitura, so o construtor pode alterar
        }
    }
}

public class Rectangle
{
    private int _width; // backing field
    private int _height;
    private int _area;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public int Width   // property
    {
        get { return _width; }
        set
        {
            if (value < 0) //não pode ficar negativo
                _width = 0;
            else
                _width = value;
        }
    }

    public int Height
    {
        get => _height;
        set => _width = value; 
    }

    //Simplificação do get
    public int Area => _width * _height;

    /*
    public int Area //Vc pode ter uma propery só com set ou get
    {
        get => _width * _height;
    }
    */
}

public class Player
{
    public string Name { get; set; } = "Player"; //auto-implemented property or auto property

    public int BirthNumber { get; } //Você só pode mudar o valor no construtor, pois imagine um cpf? vc quer que o valor não mude e seja construido apenas uma vez

    //Agora quando não quer que mude em nada, nem quando chamar o construtor então cria um field
    private readonly string _nameOf;

    public int Number { get; }
    //O própio compilador já inicializa a backfield e a property

    public Player(string name)
    {
        Name = name;
        Number = 5 * 5;
        BirthNumber = 1;
        _nameOf = "Eu sou o Batman"; //incializado uma vez e nao pode mudar
    }

    //usa-se quando apenas quer uma simplificação, apenas um get ou set simples.
}