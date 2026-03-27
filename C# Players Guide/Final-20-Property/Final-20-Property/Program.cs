namespace Final_20_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrow arrow = GetArrow();
            Console.WriteLine(arrow.Length);
            Console.WriteLine(arrow.Fletching);
            Console.WriteLine(arrow.Cost);
        }

        static Arrow GetArrow()
        {
            Arrowhead arrowhead = GetArrowheadType();
            Fletching fletching = GetFletchingType();
            float length = GetLength();

            return new Arrow { Arrowhead = arrowhead, Fletching = fletching, Length = length };
        }

        static Arrowhead GetArrowheadType()
        {
            Console.Write("Arrowhead type (steel, wood, obsidian): ");
            string input = Console.ReadLine();
            return input switch
            {
                "steel" => Arrowhead.Steel,
                "wood" => Arrowhead.Wood,
                "obsidian" => Arrowhead.Obsidian
            };
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
    }

    public class Arrow
    {
        public Arrowhead Arrowhead { get; init; } //c# permite ter enums com o mesmo nome do tipo e identificador
        public Fletching Fletching { get; init; }
        public float Length { get; init; }

        public float Cost //já retorna direto para quem chamou (isso é um property)
        {
            get
            {
                float arrowheadCost = Arrowhead switch
                {
                    Arrowhead.Steel => 10,
                    Arrowhead.Wood => 3,
                    Arrowhead.Obsidian => 5
                };

                float fletchingCost = Fletching switch
                {
                    Fletching.Plastic => 10,
                    Fletching.TurkeyFeathers => 5,
                    Fletching.GooseFeathers => 3
                };

                float shaftCost = 0.05f * Length;

                return arrowheadCost + fletchingCost + shaftCost;
            }
        }
    }

    public enum Arrowhead { Steel, Wood, Obsidian }
    public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }
}