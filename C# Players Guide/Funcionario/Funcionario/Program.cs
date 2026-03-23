namespace Funcionarioo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Funcionario Funcionario = new Funcionario("Repositor") { Nome = "João da Silva", Salario = 0 };
            Funcionario.Promover("Amarrador");
            Funcionario.Salario = 300;

            Console.WriteLine($"Nome do Funcionário: {Funcionario.Nome}\n" +
                $"Cargo: {Funcionario.Cargo}\n" +
                $"Salario: {Funcionario.Salario}");
        }
    }

    internal class Funcionario
    {
        public string Nome { get; init; }
        public string Cargo { get; private set; }
        public decimal Salario { get; set; }

        public Funcionario(string cargo)
        {
            Cargo = cargo;
        }

        public void Promover(string novoCargo)
        {
            Cargo = novoCargo;
        }

    }
}