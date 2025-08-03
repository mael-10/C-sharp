using System.Xml.Linq;
using System;

namespace Teste_Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.BackgroundColor = ConsoleColor.Magenta; //Background
            Console.ForegroundColor = ConsoleColor.Black; //Text

            Console.Clear(); //Using console.clear wipe out the and the entire screen will be on the colcor

            Console.Beep(100, 1000);

            Console.WriteLine("\"para com isso\"");
            Console.Write("\tpara com isso");
            Console.WriteLine("\r mais um");

            float roundedNumber = 2.998F;
            Console.WriteLine(@"Emporio\C:User\RB\Desktop");
            Console.WriteLine($"{roundedNumber:0}");

            Console.WriteLine($"{Math.Round(roundedNumber, 2)}");
            Console.WriteLine($"{roundedNumber}");

            float teste = 5;
            float teste2 = 6;

            Console.WriteLine($"{teste / teste2:0.0%}");

            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            Console.WriteLine($"{name1,20} 1");
            Console.WriteLine($"{name2,20} 34343432");
        }
    }
}