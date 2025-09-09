
namespace Class
{
    internal class Program
    {
        public string name2;

        static void Main(string[] args)
        {
            string Name1 = ""; //uma variável local
            Program program = new Program(); //instancia para acessar as variáveis globais

            program.name2 = Name1;
            Console.WriteLine("Hello, World!");

            Score score = new Score(); //SCORE IS A CONSTRUCTOR
            score.name = "RD-D2"; //we access that throught a instance 
            score.points = 111122; //that isn
            score.level = 52; //Aqui puxamos da instancia, no console.writeLine, puxamos da própia class

            if (score.EarnedStar())
                Console.WriteLine("Your earned a star");


            Score score2 = new Score(); //Mesmo que esteja chamando a mesma classe é uma outra instancia, ou seja a heap é diferente
            score2.name = "How to do it";
            score2.points = 1;

            Score score3 = new Score(); //o construtor é para incializar a variável com algum valor
            Console.WriteLine(score3.name);

            int[] form = new int[3];

            Score2 maisUmaVez = new Score2("Oi bebe", 50, 100);

            Score3 maisUmaVez3 = new Score3("Vamos mais uma vez", 20, 30);

            Score4 score4DD = new Score4("Score 4", 10, 43.5f);//chama um

            Score4 score4DD5 = new Score4(); //reutiliza

            Score first = new(); //Essa é uma maneira de leaving off class name. Ou seja, fica mais resumido
        }
    }

    class Score //class is on the heap
    {
        public string name;
        public int points;
        public int level;

        public Score() //constructores ensure that a variavel ensure that it begins in a good stats. Assigning initial values to each field is common.
        {
            name = "Unknown";
            points = 0;
            level = 1;
        }

        public bool EarnedStar() => (points / level) > 1000;
    }

    class Score2 //class is on the heap
    {
        public string name;
        public int points;
        public int level;

        public Score2(string name, int points, int level) //constructores ensure that a variavel ensure that it begins in a good stats. Assigning initial values to each field is common.
        {
            this.name = name;
            this.points = points;
            this.level = level; //o this indica as variáveis globais, pois sem isso pode acontecer shadowing
        }
    }

    class Score3 //class is on the heap
    {
        public string _name;
        public int _points;
        public int _level;

        public Score3(string name, int points, int level) //constructores ensure that a variavel ensure that it begins in a good stats. Assigning initial values to each field is common.
        {
            _name = name;
            _points = points;
            _level = level; //o underscore é mais usado, mas faz o mesmo papel do this
        }
    }

    class Score4
    {
        public string _name;
        public int _points;
        public float _level;

        public Score4() : this("Unknown", 10, 43.5f) //basicamente reusa o construtor com outros parametros sem construir do zero
        {
            Console.WriteLine($"Será que esse é o novo construtor: {_name}");
            Console.WriteLine($"Será que esse é o novo construtor: {_points}");
            Console.WriteLine($"Será que esse é o novo construtor: {_level}");
        } //isso é basicamente chamando um método mas estamos chamando um construtor

        public Score4(string name, int points, float level) //resusa esse construtor
        {
            _name = name;
            _points = points;
            _level = level;
        }
    }

    //Usar uma classe sem construtor explícito é útil quando você não se importa com valores iniciais ou quando os valores podem ser configurados diretamente depois que o objeto for criado.
}
