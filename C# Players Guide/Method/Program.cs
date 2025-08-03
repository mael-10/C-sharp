namespace Method
{
    internal class Program
    {
        static int tenToOne(int number)
        {
            if(number == 1) return 1;
            Console.WriteLine(number);
            return tenToOne(number - 1);
        }
        
        static int Factorial(int number)
        {
            if (number == 1) return 1; //representa um ponto de saida, pois a recursão pode ser infinita (base case)
            return number * Factorial(number - 1);
            /*
             * primeiro chama a função fatorial e vai subtraindo o números até dar 1
             * Então a cada iteração na subtraão ele armazena os valores
             * Aí vai fazendo a operaão dos valores que recupera
             * Só retorna os valores na recursão return quando é um cálculo
             * Se não tiver uma operação de cálculo, simplesmente não retorna
             * 
             * basicamente no final recupera os valores caso queira fazer um cálculo.
            */
        }

        static int AskForNumber(string? text)
        {
            Console.WriteLine(text);
            int numberAirpiece = Convert.ToInt32(Console.ReadLine());
            return numberAirpiece;
        }

        static void Main(string[] args)
        {
            string? text = Console.ReadLine(); // Usuário digita "Olá"
            Console.WriteLine($"text no início do Main: {text}"); // Saída: text no início do Main: Olá

            ///<summary>
            /// It is okay for the method
            
            static void DisplayText(string? text)
            {
                Console.WriteLine($"Mensagem de DisplayText: {text}");
            }
            ///</summary>
            


            DisplayText(text); // Chamada da função local

            // AQUI: A variável 'text' é modificada antes de DisplayText ser chamada
            text = "Valor alterado depois!";
            Console.WriteLine($"text após alteração: {text}"); // Saída: text após alteração: Valor alterado depois!

            int i = 5;
            Count(i);

            /// <summary>
            /// Counts to the given number, starting at 1 and including the number provided.
            /// </summary>
            void Count(int numberToCountTo)
            {
                for (int index = 1; index <= numberToCountTo; index++)
                    Console.WriteLine(index);
            }

            int result = AskForNumber("What is the airspeed of unland swallow?");
            int numberFactorial = Factorial(5);
            Console.WriteLine(numberFactorial);

            Console.WriteLine(tenToOne(10));
        }
    }
}
