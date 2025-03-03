using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
        }

        //Private just can be called to declareted class
        //The method (single void) means  that doesnt return any value
        private static void OperatorExamples()
        {
            string numberGood;
            int width = 3;
            //Add more
            width++;

            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area + "\n");

            string result = "The area";
            //Everything turns into a text
            result = result + " is " + area;
            Console.WriteLine(result + "\n");

            Console.WriteLine(result + " is Good ");

            bool truthAvalue = true;
            Console.WriteLine(truthAvalue + "\n");

            bool trueNumber = (2 > 5) || (5 > 3);
            Console.WriteLine(trueNumber);
            //Number good é string
            numberGood = Console.ReadLine();

            if (numberGood == "bom dia")
            {
                Console.WriteLine("Um bom dia para você também");

            }
            else
            {
                Console.WriteLine("Você não deu bom dia para mim :(");
            }

            int infiniteLoop = 6;

            while (infiniteLoop == 6)
            {
                Console.WriteLine(infiniteLoop);
                infiniteLoop++;
            }

            do
            {
                Console.WriteLine(infiniteLoop);
            } while (infiniteLoop == 6);

            //i goes every two numbers
            for(int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine("Aqui está os números " + i);
            }

            int p = 2;
            for (int q = 2; q < 32;
             q = q * 2)
             {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;
            }

            
        }
    }
}