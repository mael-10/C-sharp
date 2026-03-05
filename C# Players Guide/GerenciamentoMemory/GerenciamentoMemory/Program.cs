
namespace GerenciamentoMemory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Processor processor = GetValues();
            processor.RunProcess(6);
            processor.GetStatus();

            Processor processor2 = GetValues();
            processor2.RunProcess(7);
            processor2.GetStatus();

        }

        static Processor GetValues()
        {
            Intel modelo = GetModelos();
            int ramCapacity = GetRam();
            int usedRam = GetRamUsed();
            return new Processor(modelo, ramCapacity, usedRam);
        }

        static Intel GetModelos()
        {
            Console.WriteLine("Escolha o modelo do seu processador \n" +
                "1 - Intel i9 \n" +
                "2 - Intel i7 \n" +
                "3 - Intel i5 \n" +
                "4 - Intel i3");

            string? modelo = Console.ReadLine();

            return modelo switch
            {
                "1" => Intel.Inteli9,
                "2" => Intel.Inteli7,
                "3" => Intel.Inteli5,
                "4" => Intel.Inteli3,
                _ => Intel.IntelPentium
            };
        }

        static int GetRam()
        {
            Console.WriteLine("Qual o tamanho da ram que deseja de 1 a 128?");
            string? userInput = Console.ReadLine();
            int ram = 0;

            var dataForMethod = (UserInput: userInput, Ram: ram, Min: 1, Max: 128);

            return ram = ValidateInputsRam(dataForMethod);
        }

        static int GetRamUsed()
        {
            Console.WriteLine("Qual a quantidade de ram que está sendo usada no momento? Digite um número entre 5% a 100%");
            string? userInput = Console.ReadLine();
            int ramUsed = 0;

            var dataForMethod = (UserInput: userInput, Ram: ramUsed, Min: 5, Max: 100);


            return ramUsed = ValidateInputsRam(dataForMethod);
        }

        static int ValidateInputsRam((string? UserInput, int Ram, int Min, int Max) dataFromMethod)
        {
            while (true)
            {
                //Verifica que o número não é nulo e se pode ser convertido em inteiro
                if (dataFromMethod.UserInput != null && int.TryParse(dataFromMethod.UserInput, out dataFromMethod.Ram))
                {
                    if (dataFromMethod.Ram < dataFromMethod.Min || dataFromMethod.Ram > dataFromMethod.Max)
                    {
                        Console.Clear();
                        Console.WriteLine($"Número não corresponder entre {dataFromMethod.Min} a {dataFromMethod.Max}. Tente novamente");
                        dataFromMethod.UserInput = Console.ReadLine();
                        

                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Isso não é um número. Tente novamente");
                    dataFromMethod.UserInput = Console.ReadLine();
                    
                }
            }

            dataFromMethod.Ram = int.Parse(dataFromMethod.UserInput);

            return dataFromMethod.Ram;
        }
    }

    class Processor
    {
        private Intel _model;
        private int _ramCapacity;
        private int _usedRam;
        private bool _isOverHeading = default;

        public Processor() : this(Intel.IntelPentium, 8, 0){}

        public Processor(Intel modelo, int ramCapacity, int usedRam)
        {
            _model = modelo;
            _ramCapacity = ramCapacity;
            _usedRam = usedRam;
     
            if (_ramCapacity < 8)
            {
                _ramCapacity = 8;
            }
        }

        public void RunProcess(int memoryDemand)
        {

            if (_usedRam + memoryDemand > _ramCapacity)
            {
                Console.WriteLine("Memory Overflow! System Crash.");
                _usedRam = 0; // Reset por segurança
                return;
            }
            
            _usedRam += memoryDemand;

            float usagePercent = (float)_usedRam / _ramCapacity;
            if(usagePercent > 0.9f) _isOverHeading = true;
        }

        public void GetStatus()
        {
            Console.WriteLine($"Model: {_model} \n ");
            Console.WriteLine($"RAM AVAIABLE: {_ramCapacity}GB");
            Console.WriteLine($"HOTING? {(_isOverHeading ? "SIM" : "NÃO")}");
        }

    }

    enum Intel { Inteli9, Inteli7, Inteli5, Inteli3, IntelPentium }
}