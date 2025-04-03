namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal totalPies = 1000.5M;
            decimal slicesPerPie = 5;
            decimal totalSlices = totalPies / slicesPerPie;
            Console.WriteLine(totalSlices);
        }
    }
}
