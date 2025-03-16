using System.Globalization;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace Guide_Begin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            //Necessary target the subject
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            //Target how biggest is that problem
            string b = Console.ReadLine();
            //Object name program
            string c = "of Doom 3000!";
            Console.WriteLine($"The {b} {a} {c} \n \n"); //It's like js template literal

            string OiBebe = a;
            Console.WriteLine(OiBebe);
            a = "sem mais nem menos";
            Console.WriteLine(a);
            Console.WriteLine($"{OiBebe} \n \n");


            numbersVo();

        }

        public static void numbersVo()
        {
            short r, f, g;
            r = f = g = 10;
            Console.WriteLine(f);

            //Most used types is int, uint, short, ushort and roughly byte
            ulong aVeryBigNumber = 10000L;
            aVeryBigNumber = 10_000_000_000L; //separator makes red easier
            aVeryBigNumber = 10_000_000_000UL;

            Console.WriteLine(aVeryBigNumber);

            byte a = 255;
            byte b = 255;

            //converting 2bytes into 4bytes
            short c = (short)(a + b);
            Console.WriteLine(c);

            //Result was casted and values went lost (510 --> 254 | 9bits to 8bits)
            byte d = (byte)(a + b);
            Console.WriteLine(d);

            
        }

       
    }
}
