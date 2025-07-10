namespace Questao8
{
    internal class Program
    {

        static void arrayTest()
        {
            int[] scores = new int[10];
            scores = new int[20];

            for (int i = 0; i < scores.Length; i++) 
            {
                scores[i] = i + 2;
                Console.WriteLine($"Scores position {i} is {scores[i]}");

            }

            byte[] data = new byte[10];
            data[9] = 1;
            data[8] = 3;

            byte[] data2 = data[6..^1]; //vai copiar da sexta posição até última

            foreach (byte b in data2)
            {
                Console.WriteLine(b);
            }

            byte[] arrayRangeSet = new byte[] { 2, 3, 5, 7, 8, 9 };
            
        }

        static void Switchs()
        {
            Console.WriteLine("Choose a product number from 1 to 7 to find out one from your wished list market");
            byte choice = Convert.ToByte(Console.ReadLine());

            string? value = null;
            string? nameOfProduct = null;

            switch (choice)
            {
                case 1:
                    value = "10";
                    nameOfProduct = "Rope";
                    break;

                case 2:
                    value = "15";
                    nameOfProduct = "Torches";
                    break;

                case 3:
                    value = "25";
                    nameOfProduct = "Climbing equipament";
                    break;

                case 4:
                    value = "1";
                    nameOfProduct = "Clean Water";
                    break;

                case 5:
                    value = "20";
                    nameOfProduct = "Machete";
                    break;

                case 6:
                    value = "200";
                    nameOfProduct = "Canoe";
                    break;

                case 7:
                    value = "1";
                    nameOfProduct = "Food Supplies";
                    break;

                default:
                    Console.WriteLine("This number doesnt exist on the list");
                    break;
            }

            

            Console.Write("Whats your name: ");
            string? name = Console.ReadLine();

            if(name.ToLower() == "ismael")
            {
                double newValue = Convert.ToDouble(value) / 2;
                Console.WriteLine($"{nameOfProduct} cost 50% off with value: {newValue:0.00} gold");
            }
            else
            {
                Console.WriteLine($"{nameOfProduct} cost {value} gold");
            }



            while (true)
            {
                Console.Write("Think of a number and type it here: ");
                string? input = Console.ReadLine();
             
                int number = Convert.ToInt32(input);

                if (number == 12)
                {
                    Console.WriteLine("I don't like that number. Pick another one.");   
                    continue; //volta para o inicio do loop
                }

                break;
            }

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    Console.WriteLine($"oiiiiiii");

        }

        static void Main(string[] args)
        {
            Console.Title = "Defense of Consolas";

            Console.Write("Target Row? ");
            int row  = Convert.ToInt32(Console.ReadLine());
            Console.Write("Target Column? ");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"({row}, {column - 1})");
            Console.WriteLine($"({row + 1}, {column})");
            Console.WriteLine($"({row}, {column + 1})");
            Console.WriteLine($"({row - 1}, {column})");
            
            Console.Clear();
            Switchs();
            arrayTest();
        }
    }
}
