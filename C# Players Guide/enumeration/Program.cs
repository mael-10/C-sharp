namespace enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Lid current = Lid.locked;

           for (int i = 0; i <= 2; i++)
           {
                Console.Write($"The chest is {current}. What do you want to do? ");
                string? box = Console.ReadLine();

                switch (box)
                {
                    case "unlock":
                        current = Lid.unlocked;
                        break;

                    case "open":
                        current = Lid.open;
                        break;

                    case "close":
                        current = Lid.close;
                        break;

                    default:
                        Console.WriteLine("That value doesnt exist, try again \n");
                        i--;
                        break;
                }
           }

            Console.Write($"The chest is {current}. What do you want to do? ");


            int number = (int)Lid.open;
            Console.WriteLine(number); //

            current = (Lid)number;

            Console.WriteLine(current); //open
        }

        enum Lid
        {
            close,
            locked = 10,
            unlocked,
            open
        }

    }
}
