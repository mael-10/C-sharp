namespace The_Locked_Door
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Door door = Door.SetPassword();
            door.SetUpStatus();
            door.ChangeStatus();
        }
    }

    public class Door
    {
        public string? DoorStatus { get; private set; }
        private string? _password;

        private Door(string? password)
        {
            if(string.IsNullOrEmpty(password)) 
                throw new ArgumentNullException(nameof(password), "Null or empty password");
            _password = password;

        }

        public static Door SetPassword()
        {
            Console.WriteLine("Write out password: ");
            return new(validatePassword()); 
        }

        private static string validatePassword()
        {
            string? password;
            do
            {
                password = Console.ReadLine();

                if (string.IsNullOrEmpty(password))
                {
                    Console.Clear();
                    Console.WriteLine("Write out a real password: ");
                }
                    

            } while (string.IsNullOrEmpty(password));

            Console.WriteLine("Password attached with success");

            return password;
        }

        public void SetUpStatus()
        {
            while(DoorStatus is null) //se ele é nulo, força uma entrada de dados
            {
                Console.WriteLine("Setup your first status of your door (Open, Close, Lock)");
                switch (Console.ReadLine()?.ToLower() ?? "Null")
                {
                    case "open":
                        DoorStatus = "open";
                        break;
                    case "close":
                        DoorStatus = "close";
                        break;
                    case "lock":
                        DoorStatus = "lock";
                        break;
                    default:
                        Console.WriteLine("\nTheres no option for that. Try again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }   
        }

        public void ChangeStatus()
        {
            if(DoorStatus is null) //Se é nulo, então não tem valor para testar. Acaba por aí
                return;

            string? saveState = DoorStatus; //salva o estado pq não há como colocar statement no switch expression
            string? savePasswordStatus = _password; //salva o estato antigo da password
            
            Console.WriteLine($"Which options (Open, Close, Lock, Unlock) do you'd like to change on Door Status. Your actual: {DoorStatus}");
            string? userOptionInput = Console.ReadLine()?.ToLower() ?? "Unknown";

            DoorStatus = (DoorStatus, userOptionInput) switch //usando tuplas no switch expression para mudar o door status
            {
                ("close", "open") => "open",
                ("open", "close") => "close",
                ("close", "lock") => "lock",
                ("lock", "unlock") => changeOldPassword(),
               _ => DoorStatus //No option for your door
            };

            if (DoorStatus != saveState) // se não matches é pq mudou
            {  
                Console.WriteLine($"Your status's door was changed for {DoorStatus}");

                if(_password != savePasswordStatus)
                    Console.WriteLine($"\nYour password was changed and now is {_password}");
            } 
            else
                Console.WriteLine("It doesnt matches");
        }

        private string? changeOldPassword()
        {
            Console.Clear();
            Console.WriteLine("Enter your previous password ");
            string? previousPassword = Console.ReadLine();
            if (_password == previousPassword)
            {
                Console.WriteLine("Enter a new password: ");
                _password = validatePassword();
                return "unlock";
            }
            else
                return DoorStatus; //Se parmanece o mesmo, significa que não mudou
        }
    }
} 