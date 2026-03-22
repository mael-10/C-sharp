namespace Property_and_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Aluno alunonota = new("Emanuel");
            alunonota.Nota = 50.7f;

            Console.WriteLine($"Nome do aluno: {alunonota.Name} \n" +
                $"Nota: {alunonota.Nota}");
        }
    }
}

internal class Aluno
{
    public string Name { get; } //1- Sem get aceita nomes apenas no construtor. 2- Init aceita nomes só no construtor ou object inicializer 3- Private set aceita valores (mudança) apenas dentro da class
    private float _nota;

    public Aluno(string name)
    {
        Name = name;
    }

    public float Nota 
    {
        get => _nota;
        set
        {
            _nota = value < 0 ? 0 : value;
        }
    }
}