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

            Global id = new Global();
        }

        public class Global
        {
            private int _id;

            public static bool _validateEntry;

            public static int PointThreshold { get; set; } = 1000;

            private static int teste;

            //static constructor não pode ter parâmetros, e não pode ter private ou public
            //No fundo é a mesma coisa que uma inicialização inline, só que pode colocar validação
            //static é rodado no runtime
            static Global() 
            {
                _validateEntry = false;
            }

            /*
             * Parametros só fazem sentido quando quer comportamento diferente
             * Se ele (o class static) recebesse parâmetros os valores estaticos
             * Iria mudar toda hora pq ele pertece a classe.
             * É como se as instancias a e b (instancias) apontasse para a heap estatica
             * 
             * Apenas os valores vivem na heap estatica
             * 
             *  Nenhum modificador de acesso pq ninguém chama ele — só o runtime, uma única vez. 
             *  
             *  Quando vc faz Global id = new Global(); ele tá chamando a instancia e não o static
             */
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