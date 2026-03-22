namespace Init_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Produto produto = new Produto { Nome = "Oiii", Preco= 100.65m};

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);


        }
    }
}

internal class Produto
{
    public string Nome { get; init; }
    public decimal Preco { get; init; }
}