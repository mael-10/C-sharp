namespace Heap_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "oiiiiii";
            string b = a;
            b += "e";
            Console.WriteLine(a);
            Console.WriteLine(b);

            int[] form = { 1, 2 };
            int[] form2 = { 2, 3 };

            bool validate = (form[1] == form2[0]);


            Console.WriteLine($"{validate}");
        }
    }
}
