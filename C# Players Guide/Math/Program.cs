namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float totalPies = 1000.5F;
            float slicesPerPie = 5;
            float totalSlices = totalPies / slicesPerPie;
            Console.WriteLine($"{totalSlices} \n");

            int partialResult = 2 + 5;
            int result = partialResult * 2;

            Console.WriteLine("Type triangles's height out");
            float baseOfTriangle = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Type triangles's lenght base out");
            float heightOfTriangle = Convert.ToSingle(Console.ReadLine());
            float area = baseOfTriangle * heightOfTriangle / 2;

            Console.WriteLine($"The area is: {area}"); //Two numbers after point

            int a = 5 / 2;
            Console.WriteLine(a + "\n");

            Console.WriteLine("How many eggs all sisters gathered today?");
            int eggsNum = Convert.ToInt32(Console.ReadLine());
            int eggsEachSister = eggsNum / 4;
            int eggsForDuckbear = eggsNum % 4;
            Console.WriteLine($"Eggs for each of four sisters {eggsEachSister}");
            Console.WriteLine($"Eggs for duckerbear {eggsForDuckbear} \n \n");

            //Kingdom exercise
            Console.WriteLine("Sir Meleca answer questions below");
            Console.WriteLine("estate: ");
            short melecaEstate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("duchy: ");
            short melecaDutchy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("province: ");
            short melecaProvince = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nSir Casik answer questions below");
            Console.WriteLine("estate: ");
            short casikEstate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("duchy: ");
            short casikDutchy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("province: ");
            short casikProvince = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nSir Balik answer questions below");
            Console.WriteLine("estate: ");
            short BalikEstate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("duchy: ");
            short BalikDutchy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("province: ");
            short BalikProvince = Convert.ToInt16(Console.ReadLine());

            int melecaTotal = melecaEstate * 1 + melecaDutchy * 3 + melecaProvince * 6;
            int CasikTotal = casikEstate * 1 + casikDutchy * 3 + casikProvince * 6;
            int BalikTotal = BalikEstate * 1 + BalikDutchy * 3 + BalikProvince * 6;

            Console.WriteLine($"\n\nSir Meleca, your final result: {melecaTotal}");
            Console.WriteLine($"Sir Casik, your final result: {CasikTotal}");
            Console.WriteLine($"Sir Basik, your final result: {BalikTotal}");

            int x = 5;
            int y = x++;  // x is 6, y is 5
            y = x++; // x is 7, y is 6
            Console.WriteLine(y);

            short q = 2;
            short b = 3;
            int total = q + b; // The values q and b are converted to ints automatically.

            Console.WriteLine(b.GetType()); //System.Int16 is the type
            Console.WriteLine(total.GetType()); //System.Int32
            short teste = (short)(q + b); // The values q and b now is shorts

            float w = 60.5f;
            float wwc = 60.5f;
            float sum = w + wwc;

            Console.WriteLine(sum + "Here");

            int smaller = Math.Min(2, 10);
            int larger = Math.Max(2, 10);

            Console.WriteLine(smaller);
            Console.WriteLine(larger);

            double ww2 = 3;
        }
    }
}
