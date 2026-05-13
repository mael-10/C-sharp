namespace Color1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color test = Color.SetColor(0, 0, 0);
            var ColorAndNumber = Color.TheColor(test);
            Console.WriteLine(test.B);
            Console.WriteLine(ColorAndNumber.Number.R);
            Console.WriteLine(ColorAndNumber.Color);
        }
    }

    public class Color()
    {
        
        private int _r, _g, _b;

        public int R
        {
            get => _r;
            private set
            {
                _r = Validate.Entry(value);
            }
        }

        public int G
        {
            get => _g;
            private set
            {
                _g = Validate.Entry(value);
            }
        }

        public int B
        {
            get => _b;
            private set
            {
                _b = Validate.Entry(value);
            }
        }


        public static Color SetColor(int r, int g, int b)
        {
           return new() { R = r, G = g, B = b }; 
        }

        //Isso obriga primeiro a ter uma instancia antes de chamar o comando.
        public static (Color Number, string Color) TheColor(Color color) 
        {
            return (color.R, color.G, color.B) switch
            {
                (255, 255, 255) => (color, "white"),
                (0, 0, 0) => (color, "black"),
                _ => (color, "unknow")
            };
        }
    }

    public static class Validate
    {
        public static int Entry(int value) => Math.Clamp(value, 0, 255);
    }
}