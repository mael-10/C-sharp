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
            ulong aVeryBigNumber = 1000000000000000UL; // Precisa de UL porque o valor é maior que o limite de um int
            aVeryBigNumber = 10_000_000_000L;
            aVeryBigNumber = 10_000_000_000UL; //separator makes red easier

            Console.WriteLine(aVeryBigNumber);

            byte a = 255;
            byte b = 255;

            //converting 2bytes into 4bytes
            short c = (short)(a + b);
            Console.WriteLine(c);

            //Result was casted and values went lost (510 --> 254 | 9bits to 8bits)
            byte d = (byte)(a + b);
            Console.WriteLine(d);

            byte a1 = 200;
            byte b2 = 100;
            int resultado = a + b; // Promovido para int, resultado é 300
            short c3 = (short)(a + b); // Conversão explícita para short - Overflow! will be 44)

            //good code for int
            int a3 = 200;
            int b4 = 100;
            int c5 = a + b; // Sem overflow, c é 300
            Console.WriteLine($"{c} \n \n"); // Saída: 300

            byte nova = 0b00000001;
            Console.WriteLine(nova);

            int forma = 0x0F00FF;
            Console.WriteLine(forma);
        }
    }
}
