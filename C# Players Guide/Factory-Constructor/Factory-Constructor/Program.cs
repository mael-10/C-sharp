namespace Factory_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = Rectangle.ChooseInputRight(); //não coloca new pq é uma classe estatica, sendo que a classe já é obrigatória retornar uma instancia
            Rectangle rectangle1 = Rectangle.ChooseInputLeft();
            Console.WriteLine($"Todos os números da direita {rectangle.RightSide}, {rectangle.LeftSide}, {rectangle.BottomSide}, {rectangle.TopSide}");
            Console.WriteLine($"Todos os números da esquerda {rectangle1.RightSide}, {rectangle1.LeftSide}, {rectangle1.BottomSide}, {rectangle1.TopSide}");
        }
    }

    internal class Rectangle
    {
        public int RightSide {  get; set; }
        public int LeftSide { get; set; }
        public int BottomSide { get; set; }
        public int TopSide { get; set; }

        private Rectangle(int rightSide, int leftSide, int bottomSide, int topSide)
        {
            RightSide = rightSide;
            LeftSide = leftSide;
            BottomSide = bottomSide;
            TopSide = topSide;
        }

        internal static Rectangle ChooseInputRight()
        {

            string? chooseValue = Console.ReadLine();
           
            int rightNumber = 0;

            if (tryParseValidation(chooseValue, rightNumber))
            {
                Console.WriteLine("Valor Inválido. Valores inicializado com 0");
            }
            else
            {
                int numberParsed = int.Parse(chooseValue);
                return new Rectangle(numberParsed * 2, numberParsed - 1, numberParsed * numberParsed - 1, 5);
            }

            return new Rectangle(0, 0, 0, 0);
        }

        internal static Rectangle ChooseInputLeft()
        {
            return new Rectangle(13, 13, 13, 13);
        }

        private static bool tryParseValidation(string? value, int convertValue)
        {
            bool validationValue = !int.TryParse(value, out convertValue) ? true : false;
            return validationValue; 
        }

        /*
         * Como 
         
         */
    }
}