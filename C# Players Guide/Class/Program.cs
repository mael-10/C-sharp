
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
}
