namespace replicator2
{
    internal class Program
    {
        static void multiDimension()
        {
            int[][] matrix = new int[2][]; //its array of array
            matrix[0] = new int[] {1, 2, 3};
            matrix[1] = new int[5]; //inside there are 5 line (value 0)
            matrix[2] = new int[] {8, 9, 10, 7};

            int[,] matrix2 = { { 1, 3, 5 }, { 1, 3, 5 } };
            int[,] matrix4 = new int[3,5];

            int[][] matrix3 = new int[][] {
                new int[] { 1, 3, 5 },
                new int[] { 1, 3, 5 },
                new int[] { 1, 3, 5, 10, 8}
            };

            //diference of Array and array of Array is that array has fixed size and Array of Array has flexible size

        }

        static void Main(string[] args)
        {
            int[] origial = new int[5];
            int[] replicator = new int[5];
            int[] form = { 1, 2, 3 }; //ou
            int[] form2 = new int[] {4, 5, 6};

            form2 = form[1..^1]; //copy along the way

            Console.WriteLine("Type 5 numbers bellow: ");
            for (int i = 0; i < origial.Length; i++) 
            {
                origial[i] = Convert.ToInt32(Console.ReadLine());
                replicator[i] = origial[i];
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Esse é o valor original {origial[i]}");
                Console.WriteLine($"Esse é o valor do replicator {replicator[i]}");
            }

            foreach (int replice in replicator) // for loap is easy to read and slightly slower than for loop
                forEachMethod(replice);

            string bebe = "eu estava aqui uma vez sem";
            string[] teste = bebe.Split(' ');

            foreach (string item in teste)
            {
                Console.WriteLine($" \n Mostrando todos os splits {item}");
            }
        }

        static void forEachMethod(int replice)
        {
            Console.WriteLine($"\n Writing playlist in replicator {replice}");

            Console.WriteLine("Multidimensional array");
            multiDimension(); 
        }
    }
}
