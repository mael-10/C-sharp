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

            Console.WriteLine("Sir Meleca answer questions below");
            Console.WriteLine("estate: ");
            short melecaEstate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("duchy: ");
            short melecaDutchy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("province: ");
            short melecaProvince = Convert.ToInt16(Console.ReadLine());

            melecaEstate *= 1;
            melecaDutchy *= 3;
            melecaProvince *= 6;
            int melecaTotal = melecaEstate + melecaDutchy + melecaProvince;

            Console.WriteLine("Sir Casik answer questions below");
            Console.WriteLine("estate: ");
            short casikEstate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("duchy: ");
            short casikDutchy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("province: ");
            short casikProvince = Convert.ToInt16(Console.ReadLine());

            casikEstate *= 1;
            casikDutchy *= 3;
            casikProvince *= 6;
            int CasikTotal = casikEstate + casikDutchy + casikProvince;

            Console.WriteLine("Sir Balik answer questions below");
            Console.WriteLine("estate: ");
            short BalikEstate = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("duchy: ");
            short BalikDutchy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("province: ");
            short BalikProvince = Convert.ToInt16(Console.ReadLine());

            BalikEstate *= 1;
            BalikDutchy *= 3;
            BalikProvince *= 6;
            int BalikTotal = BalikEstate + BalikDutchy + BalikProvince;

            Console.WriteLine($"Sir meleca, your final result: {melecaTotal}");
            Console.WriteLine($"Sir Casik, your final result: {casikProvince}");
            Console.WriteLine($"Sir Casik, your final result: {BalikTotal}");
        }
    }
}
