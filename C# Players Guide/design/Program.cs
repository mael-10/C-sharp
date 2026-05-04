namespace design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            teste1 outroT = new teste1();

            outroT.method(new test2 { Outra = 1 });
            Console.WriteLine(outroT.Oi?.Outra);
        }
    }
}

public class teste1
{
    public test2? Oi { get; private set; }
    
    public void method(test2 oii)
    {
      Oi = oii; //apenas a referencia
    }
}

public class test2
{
    public int Outra { get; init; }
}