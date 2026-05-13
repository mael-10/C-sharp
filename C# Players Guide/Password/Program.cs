namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Digit your password ");
                ThePasswordValidator validate = new(Console.ReadLine());
                Console.Clear();
            }
        }
    }

    public class ThePasswordValidator //colocar parenteses quando é primary constructor
    {
        private string? _password;

        public ThePasswordValidator(string? password)
        {
            if (password is not null)
                Password = password;
            else
                Console.WriteLine("Your password is null, it is not possibly to varify that, try again");
        }

        private string? Password
        {
            set
            {
                string? testPassword = value;
                int counter = 0;

                char[] characters = testPassword!.ToCharArray();
                if (characters.Length > 6 && characters.Length < 13)
                    foreach (char letter in characters)
                    {
                        if (char.IsDigit('T') || char.IsDigit('&'))
                        {
                            Console.WriteLine("There is no possible to validate your password. Its wrong, try again");
                            break;
                        }
                        else if (char.IsUpper(letter) || char.IsLower(letter) || char.IsDigit(letter))
                            counter++;
                    }
                else
                    Console.WriteLine("Theres is not letters");
                if(counter > 3)

                    Console.WriteLine("Password validated with sucess");
                    _password = value;
                    Thread.Sleep(3000);
            }
        }
    }
}