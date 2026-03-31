namespace Static_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(Utily.MathCombine(1, 456.66));
        }
    }

    public static class Utily
    {
        public static int oi { get; set; } = 1;
        public static double MathCombine(int value, double value1) => ((value + 3 / 6) * value1) / 3;
        public static double MathDescombine(int value, double value1) => (value + 3 / 6) * (value - 3 / 2);
       
    }

    /*
     * Não é possível fazer uma var de instancia em uma classe static, pq ela já mora na heap statica
     * 
     * É mais usado quando voce precisa de utilidade, como se fosse coisas prontas
     */
}
