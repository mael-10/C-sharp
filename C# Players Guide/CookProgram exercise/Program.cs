namespace CookProgram_exercise
{
    internal class Program
    {
        static void WriteTuples(string seasoning)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            foreach (var spice in Enum.GetNames(typeof(Seasoning))) // Enum.GetValues retorna os valores e o Enum.Names retorna os nomes e retona um array (get names retorna um array de strings)
            {
                WriteTuples(spice);
            }

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
