using BC = BCrypt.Net;

namespace Cofre_Digital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    //Classe de IO vai retornar o DTO
    public static class Criar
    {
        public static CadastroGeralDto Usuario()
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 10000);

            Console.WriteLine("Qual o seu nome?"); //cpf também é sensivel então eu faria: 123-falsjdirtu4eiu%@¨$%$#98ahbsfdk-4-00 o que bate com a LGPD, onde falsjdirtu4eiu%@¨$%$#98ahbsfd é o CPF criptografado completo
            string? userName = Console.ReadLine(); //-> A primeira coisa que tem que morrer é a senha exposta na heap, por isso é limpo a referência

            Console.WriteLine("Qual o seu CPF?");
            string? cpf = Console.ReadLine();

            Console.WriteLine("Qual a senha do cofre?");
            string? cofreSenha = Console.ReadLine();

            // Retorna o DTO Gerazão, plano, sem hierarquia. Amigável para a borda.
            return new CadastroGeralDto
            {
                UsuarioId = id,
                UsuarioNome = userName,
                UsuarioCpf = cpf,
                CofreSenha = cofreSenha,
            };
        }
    }

    // 1. DTO Anêmico e Limpo
    public class CadastroGeralDto
    {
        public int UsuarioId { get; init; }
        public string? UsuarioNome { get; init; }
        public string? UsuarioCpf { get; init; }
        public string? CofreSenha { get; init; }

        // O DTO agora é apenas uma "sacola de dados". 
        // Zero lógica interna, zero chamadas ao Garbage Collector.
    }

    // 2. Separação de Criptografia (Hash vs. Simétrica)
    public static class Seguranca
    {
        // Para Senhas: Hash unidirecional (BCrypt)
        public static string HashSenha(string senha) => BC.BCrypt.HashPassword(senha);
        public static bool VerificarSenha(string senha, string hash) => BC.BCrypt.Verify(senha, hash);

        // Para LGPD (CPF): Criptografia Simétrica (Exemplo AES)
        // Permite reverter o dado para uso interno ou para buscas em banco de dados
        public static string EncriptarDadoSensivel(string dadoCru)
        {
            // Na vida real, usaria Aes.Create() aqui
            return $"[AES-ENCRIPTADO]-{dadoCru}";
        }

        public static string DesencriptarDadoSensivel(string dadoCriptografado)
        {
            return dadoCriptografado.Replace("[AES-ENCRIPTADO]-", "");
        }
    }

    public class Usuarios
    {
        // 3. Tipagem Consistente
        public int Id { get; private init; } // Mudou de string para int para bater com o DTO/IO
        public string? Nome { get; private init; }
        private readonly string? _cpfEncriptado;

        private Usuarios(int id, string? nome, string? cpfEncriptado)
        {
            if (id <= 0 || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpfEncriptado))
                throw new ArgumentException("Dados inválidos para criação do usuário");

            Id = id;
            Nome = nome;
            _cpfEncriptado = cpfEncriptado;
        }

        public static Usuarios Create(int id, string? nome, string? cpfEncriptado)
        {
            return new Usuarios(id, nome, cpfEncriptado);
        }
    }

    public class Cofre
    {
        private readonly string? _userName;
        private decimal _saldo;
        private Gateway _portaDoCofre;
        private string? _senhaCofreHash;

        // 1. CONSTRUTOR DE REIDRATAÇÃO (O Banco de Dados usa)
        // Ele aceita o estado COMPLETO salvo no banco, sem alterar nada.
        private Cofre(string userName, string senhaCofreHash)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(senhaCofreHash))
                throw new ArgumentException("Dados inválidos para criação do Cofre");

            _userName = userName;
            _senhaCofreHash = senhaCofreHash;
            _saldo = 0.0m;
            _portaDoCofre = Gateway.Fechado;
        }

        // 2. FACTORY DE NASCIMENTO (O Usuário usa no I/O)
        // Aqui sim, nós definimos as regras de "como um cofre nasce do zero"
        public static Cofre CriarNovo(string userName, string senhaCrua)
        {
            string hash = Seguranca.HashSenha(senhaCrua);

            // Nasce com saldo 0 e porta fechada
            return new Cofre(userName, hash);
        }

        // ... (DepositarMoeda e AbrirCofre continuam iguais, perfeitos)

        // A única forma de alterar o saldo é através do método de negócio
        public void DepositarMoeda(decimal valorMoeda)
        {
            if (_portaDoCofre != Gateway.Aberto)
                throw new InvalidOperationException("O cofre está trancado");

            if (Moeda.ValidarMoeda(valorMoeda))
            {
                _saldo += valorMoeda; // Só aqui o saldo muda!
            }
        }

        public void AbrirCofre(string senhaCrua)
        {
            if (_portaDoCofre == Gateway.Fechado)
            {
                if (Seguranca.VerificarSenha(senhaCrua, _senhaCofreHash!))
                {
                    _portaDoCofre = Gateway.Aberto;
                }
                else
                    throw new UnauthorizedAccessException("Senha incorreta");
            }
            else
                throw new UnauthorizedAccessException("A porta já está aberta.");
        }

        public void FecharCofre()
        {
            _portaDoCofre = Gateway.Fechado;
        }
    }

    public static class Moeda //Classe de lógica
    {
        public static bool ValidarMoeda(decimal moeda)
        {

            return moeda switch
            {
                0.10m or 0.25m or 0.50m or 1.00m => true,
                _ => false
            };
        }
    }

    enum Gateway
    {
        Aberto,
        Fechado
    }
}