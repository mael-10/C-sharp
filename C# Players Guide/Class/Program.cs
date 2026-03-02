using System.Text;

namespace Class1
{
    internal class Program
    {
        public int teste = 4;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vamos.Teste(); //classe estática
            Score score = new Score(); //classe constructor
            score.name = "test";

            //È possível simplificar ao inves de colocar o nome do objeto, pode colococar apenas new para simplificar pq ele já faz a inferência
            RegistroDoUsuário user = new ();
            RegistroDoUsuário user2 = new RegistroDoUsuário();
            RegistroDoUsuário user3 = new RegistroDoUsuário(new StringBuilder("Oi"), new StringBuilder("Tudo bem?"), new StringBuilder("Futuramente serei o melhor programador ever"), 100000.00m);


            user._name = new StringBuilder("Natanel");
            user2._name = new StringBuilder("Emanuel");
            

            user.Oitu();
            user2.Oitu();
            Console.WriteLine(user2._name);
            Console.WriteLine($"Olá ! No futuro você sera o melhor e {user3.endereco} \n");
            Console.WriteLine();
        


            float a = 0.1f;
            float b = 0.2f;

            decimal c = (decimal)(a + b);

            Console.WriteLine(c);
        }

        public class Score
        {
            public string? name;
            public int points;
            public int level;

            public bool EarnedStart() => (points / level) > 10000;
        }
    }

    public class Vamos //as variáveis só vivem quando o objeto está vivo
    {
        public string? name; //instance variables
        public int age;
        public decimal saldoBancario;


        public static void Teste()
        {
            Console.WriteLine("Oiiiiii");
        }
    }

    public class RegistroDoUsuário
    {
        public StringBuilder _name;
        public StringBuilder age;
        public StringBuilder endereco;
        //Valor é inicializado no inline, se criar um construtor que o modifica, o construtor vai ter a prioridae
        public decimal saldoBancario = 0.00m;

        //Construtores são uma maneira de inicializar valores. Se não tiver nada dentro do construtor, os valores vao ser inicializados com nulos
        public RegistroDoUsuário() //constructors não pode retornar um return type
        {
            _name = new StringBuilder("name");
            age = new StringBuilder("0");
            endereco = new StringBuilder("rua");
        }

        public RegistroDoUsuário(StringBuilder name, StringBuilder m, StringBuilder z, decimal Saldo)
        {
            _name = name; age = m; endereco = z; saldoBancario = Saldo;
        }



        public bool EarnedStar() => (10 / 5) > 1000;

        public void Oitu()
        {
            Console.WriteLine("Fazendo um teste");
        }
    }
}