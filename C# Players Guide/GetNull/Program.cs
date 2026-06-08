namespace GetNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            User usuarioDoCaos = new User(1, (new (string?, int)[] { ("Maria", 20), (null, 25) }, "João", 20));
            string UserRef = usuarioDoCaos?.UserInfo.Contatos[1].Nome ?? "Usuário não encontrado";
            Console.WriteLine(UserRef);
        }
    }

    public class User
    {
        public int Id { get; set; }
        public ((string? Nome, int Idade)[] Contatos, string? Name, int Idade) UserInfo { get; set; } //--> Nome e idade do usuário w mostra Nome e Idade do contato dos usuários

        public User(int id, ((string?, int)[], string, int) info)
        {
            Id = id;
            UserInfo = info;
        }
    }

    public class UserAccount
    {
        public User User { get; private set; }

        public int ValueAccount { get; private set; }

        public UserAccount(User user) { User = user; }
    }
}
