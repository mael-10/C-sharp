namespace CookProgram_exercise
{
    internal class Program
    {
        static int checkedAccoutNumber(int numberValidated)
        {
            if (numberValidated < 0) //não valida maior
            {
                Console.WriteLine(" \n Execução encerrada, colocou um código que não exise \n");
                Environment.Exit(1); //0 indica o programa terminou com sucesso e o 1 para código de erro
            }

            return numberValidated;
        }

        static int validateStringtoIntNumber(string? numberIsValidate)
        {
            if(!string.IsNullOrEmpty(numberIsValidate) && int.TryParse(numberIsValidate, out int value)) //se a string não é vazia e se pode ser convertida em um int
                return value;

            return -1;
        }

        static void WriteTuples(string seasoning, byte index)
        {
            Console.Write($"{index}- {seasoning} ");
        }

        static void CallForEacheTypeEnum(Type enumType)
        {
            byte index = 0;
            Console.WriteLine($"Esse é o enumType {enumType}"); //mostra o caminho onde e o tipo da variável

            foreach (string spice in Enum.GetNames(enumType)) // Enum.GetValues retorna os valores e o Enum.Names retorna os nomes e retona um array (get names retorna um array de strings)
            {
                index++;
                WriteTuples(spice, index);
            }
        }

        static void Main(string[] args)
        {
            (TypeFood typeFood, Ingredient ingredient, Seasoning seasoning) completeFood;
            List<int> attachmentName = new List<int>();

            Type[] arraysType = { typeof(TypeFood), typeof(Ingredient), typeof(Seasoning) };
            string[] headline = { "TypeFood", "Ingredient", "Seasoning" };

            for (int i = 0; i < headline.Length; i++)
            {
                Console.WriteLine($"Choose a {headline[i]} according numbers"); //escreve a legenda
                CallForEacheTypeEnum(arraysType[i]); //looping para escrever as informações na tela
                string? chooseNumber = Console.ReadLine(); //pode para o usuário escolher o número correspondente
                int numberValidated = validateStringtoIntNumber(chooseNumber); //valida se o número é realmete um número
                numberValidated--; //tira uma unidade para encontrar o caminho
                attachmentName.Add(checkedAccoutNumber(numberValidated)); //adicionma uma lista para ser convertido
            }

            completeFood.typeFood = (TypeFood)attachmentName[0];
            completeFood.ingredient = (Ingredient)attachmentName[1];
            completeFood.seasoning = (Seasoning)attachmentName[2];

            Console.WriteLine($"Esse é o resultado final {completeFood.typeFood} {completeFood.ingredient} {completeFood.seasoning}");
        }

        enum TypeFood
        {
            Soup,
            Stew,
            Gumbo 
        }

        enum Ingredient
        {
            Mushrooms,
            Chicken,
            Carrots,
            Potatoes
        }

        enum Seasoning
        {
            Spicy,
            Salt,
            Sweet
        }
    }
}
