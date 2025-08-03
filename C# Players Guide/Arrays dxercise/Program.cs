namespace Arrays_dxercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos colocar vendinha de estoque \n \n");
            sbyte[] estoque = { 2, 2, 3, 5, 10, 15};

            Console.WriteLine("Agora vou fazer a soma dos kits que foram levados pelo cliente");
            int add = 0;
            foreach(int item in estoque)
            {
                add += item;
            }

            Console.WriteLine($"Aqui está todos os valores somados{add}");

            estoque[^1] = 10;

            sbyte[,] tableCost = new sbyte[3,2];
            tableCost[0, 0] = 5;
            

            Console.WriteLine($" \n {tableCost.Length} \n");
            Console.WriteLine($"{tableCost.GetLength(0)} \n"); //conta o lenght de linha
            Console.WriteLine($"{tableCost.GetLength(1)} \n"); //conta o lenght de coluna

            Console.WriteLine($"Esse é o valor da posição [0][0]: {tableCost[0, 0]}");
            for (int i = 0; i < tableCost.GetLength(0); i++)
            {
                for (int j = 0; j < tableCost.GetLength(1); j++)
                {
                    tableCost[i, j] = (sbyte)(i * 2); //Literais constantes que cabem no tipo: O compilador permite conversão implícita. sbyte abc = 2 pois sabe o intervalo;
                    //Variáveis ou resultados de expressões que podem exceder o tipo: O compilador exige conversão explícita para evitar potencial perda de dados em tempo de execução. sbyte x = i; ❌ sbyte x = (sbyte)i;
                    //também toda a expressão retorna um int;
                    Console.WriteLine($"Esse é o valor da posição [{i}][{j}]: {tableCost[i, j]}");
                }
            }

            teste();
        }

        static void teste()
        {

        }
    }
}
