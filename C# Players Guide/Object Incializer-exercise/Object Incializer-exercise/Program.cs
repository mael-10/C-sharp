namespace Object_Incializer_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = ClassCarValues();

            Console.WriteLine($"O Modelo: {car.Modelo}, A marca: {car.Marca} O Ano: {car.Ano}");
        }

        static Car ClassCarValues()
        {
            var carOptions = (Marca: SelectOptions("a Marca"), Modelo: SelectOptions("o Modelo"), Ano: SelectOptions("o Ano")); //(usei tuplas pois são variávies que se relacionada, o que deixa menos verboso)
            
            Console.WriteLine("Modelo escolhido com sucesso");
            Thread.Sleep(2000);
            Console.Clear();

            return new Car { Modelo = carOptions.Modelo, Marca = carOptions.Marca, Ano = carOptions.Ano }; //object inicializer
        }

        static string? SelectOptions(string text)
        {
            Console.WriteLine($"Qual {text} do carro?");
            string? selectOptionCar = Console.ReadLine(); //StringBuilder sempre cria um objeto então nunca vai ser nulo, por isso selectOptionCar == null (com stringBuilder) não funciona

            while (string.IsNullOrEmpty(selectOptionCar))
            {
                Console.WriteLine("Valor nullo não permitido \n");
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine($"Digite novamente {text}");
                selectOptionCar = Console.ReadLine();
                Console.Clear();
            }

            return selectOptionCar.ToString();
        }
    }

    internal class Car
    {
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
        public string? Ano { get; set; }

    }
}