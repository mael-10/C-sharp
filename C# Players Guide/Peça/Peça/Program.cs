namespace Peça
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Chama a função get arrow
            Arrow arrow = GetArrow();
            Console.WriteLine($"Esse é o valor final {arrow.GetCost()}");

            string i = teste23();

        }

        static string teste23()
        {
            int i4 = 5;

            return i4 switch
            {
                1 => "Para com isso",
                2 => "Não entendo"
            };
        }

        static Arrow GetArrow() 
        {
            Arrowhead arrowHead = GetArrowHeadType();
            Fletching fletching = GetFletchingType();
            float length = GetLength();


            return new Arrow(arrowHead, fletching, length);
        }

        static Arrowhead GetArrowHeadType()
        {
            Console.WriteLine("Arrowhead type (steel, wood, obsidian");
            string input = Console.ReadLine();
            return input switch
            {
                "steel" => Arrowhead.Steel,
                "wood" => Arrowhead.Wood,
                "obsidian" => Arrowhead.Obsidian
            };
        }

        static float GetLength()
        {
            float length = 0;

            while (length < 60 || length > 100)
            {
                Console.Write("Arrow length (between 60 and 100): ");
                length = Convert.ToSingle(Console.ReadLine());
            }

            return length;
        }

        static Fletching GetFletchingType()
        {
            Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
            string input = Console.ReadLine();
            return input switch
            {
                "plastic" => Fletching.Plastic,
                "turkey feather" => Fletching.TurkeyFeathers,
                "goose feather" => Fletching.GooseFeathers
            };
        }
    }

    class Arrow
    {
        public Arrowhead _arrowhead;
        public Fletching _fletching;
        public float _length;

        //Constroi o objeto mas apenas a referencia é armazenada. Ele aponta para o objeto construido
        public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _length = length;
        }

        public float GetCost()
        {
            float arrowheadCost = _arrowhead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5
            };

            float fletchingCost = _fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeathers => 5,
                Fletching.GooseFeathers => 3
            };

            float shaftCost = 0.05f * _length;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }

    enum Arrowhead { Steel, Wood, Obsidian };
    enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }
}