using System.ComponentModel;
using System.Threading.Tasks.Sources;

namespace Tuples
{
    internal class Program
    {
        static (string NameEmployee, byte AgeEmployee)[] getEmployeeInfoOnDataBase()  //or (string NameEmployee[], byte ageEmployee[], bool isTrue)
        {
            return new (string, byte)[3] //se fosse outro elemento simples seria individual como 'return (...)'
            {
                ("João", 20),
                ("Paulo", 15),
                ("Fernanda", 21)
            };
        }

        static void moreTuppleExamples()
        {
            (string[] EmployeeName, int[] EmployeeAge) company = (new string[3] { "Jonh", "Master", "Kenia" }, new int[3] { 20, 28, 45 }); //string name array

            //há outra forma onde todos são arrays

            var newCompany = (Names3: new string[3] { "Jonh", "Master", "Kenia" }, Numbers: new int[3] { 20, 28, 45 }, TrueOrFalse: true);

            var newCompany1 = (new (string, int)[3] { ("Jonh", 20), ("Master", 28), ("Kenia", 45) }, true); //Mesma forma que o getEmployeed, mas mais simplificado só que mais difícil de ler

            //outra forma 

            // criando um algoritmo  para parabenizar os funcionários que tem 20 anos de empresa.

            Console.WriteLine(" \n \n Vamos parabenizar um funcionário que tem 20 anos de empresa \n ");
            var happyForTwenthYear = getEmployeeInfoOnDataBase();

            //Console.WriteLine(happyForTwenthYear[0].NameEmployee);

            foreach (var row in happyForTwenthYear)
            {
                if (row.AgeEmployee == 20)
                {
                    Console.WriteLine($"Parabéns {row.NameEmployee} você completou {row.AgeEmployee}. Receba seu prêmio");
                }
            }

            foreach ((string testeString, byte teste) in happyForTwenthYear) //estou desestruturando array em tupla de maneira explicita
            {

                Console.WriteLine($"Esse é o string do array {testeString} e os números: {teste}");
            }

            byte x = 4;
            byte y = 5;

            (x, y) = (y, x); //isso troca as ordens


            var a = (X: 2, Y: 4);
            var b = (U: 2, V: 4);
            Console.WriteLine(a == b); //tuplas são value type, ao menos que encontre um reference type, pois vai pegar a referencia e não 

            happyForTwenthYear[0].NameEmployee = Convert.ToString(Numbers.One); //vai pegar One e colocar no happyForTwenthYear
        }

        static (string Nome, int Pontos, bool Existe) CallWithoutParameterTuple() => ("Ismael", 18, false); //retorna o tipo

        static (string Teste, int Tabela) CallTupleWithParameter((string Nome, int PontosJJ, bool Existe) tete) //vai passar uma tupla como parametro e irá retorna como parâmetro
        {
            return (tete.Nome, tete.PontosJJ + 6);
        }

        static void Main(string[] args)
        {
            (int, string? Name, char) score = (2, "Para", 'a'); //create a tuple for organizes code (declara com os nomes)
            var teste = (2, "Para", 'a'); //tuple less longer with var

            score.Name= Convert.ToString(Testes.testeA);

            Console.WriteLine(score.Name); //that way isnt good for tuples's names
            Console.WriteLine(score.Item1);
            Console.WriteLine(teste.Item3);

            (int desInt, string destName, _) = score; //Está descontruindo apenas o int e a string, o resto é ignorado pois só quero esses valores

            //names with var

            var table = (Table1: "1*1", Result: 1); //declara com var

            Console.WriteLine(table.Result); //with names and var is more organized

            var result = CallWithoutParameterTuple();

            Console.WriteLine(result.Pontos);

            var finalTuple = CallTupleWithParameter(result);

            Console.WriteLine($"Esse é o elementos  do número: {finalTuple.Tabela}");

            moreTuppleExamples();
        }

        enum Testes //Enum is a type
        { 
            testeA,
            testeB
        }

    }

    enum Numbers
    {
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten
    }
}
