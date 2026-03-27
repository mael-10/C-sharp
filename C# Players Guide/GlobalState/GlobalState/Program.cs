namespace GlobalState
{
    internal class Program
    {
        static void ValidateEntry(bool valueTrue) //só passa Global só ser for instancia
        {
            if (valueTrue) { Console.WriteLine("Acesso valido"); }
            else { Console.WriteLine("Acesso negado"); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //O acesso está aberto para todos
            Global._validateEntry = true;
            ValidateEntry(Global._validateEntry);

            //O acesso está fechado para todos
            Global._validateEntry = false;
            ValidateEntry(Global._validateEntry);
        }

        public class Global
        {
            public static bool _validateEntry;

        }
    }

    /* O global state pode ser perigoso 
     * Porque se você tem partes de uma field que usa em várias partes
     * Uma mudança nesse valor pode causar um negação no codigo
     * E causar erros em cascata.
     * 
     * O certo é passar valores de maneira que exista uma validação,
     * Onde apenas com as regras especificas os valores podem mudar
     */
}