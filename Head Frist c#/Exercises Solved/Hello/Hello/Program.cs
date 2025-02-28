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
            Console.WriteLine(truthAvalue);
        }
    }
}