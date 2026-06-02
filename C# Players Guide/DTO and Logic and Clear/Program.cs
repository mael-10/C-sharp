using Crypt = BCrypt.Net.BCrypt; //coloca desse jeito pq .Net não sabe quem chamar

namespace DTO_and_Logic_and_Clear
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DTO? myDTO = new("1234"); //usuário colocando sua senha no formulário
            myDTO.Ler();
            LogicClass minha = new(myDTO);
            
            myDTO = null; //mata o ponteiro aqui para não ter bisbilhoteiro
        }
    }


    public class LogicClass
    {
        private DTO? _dtoValue; //Privado não quero que ninguem, absolutamente ninguem acesse de fora para máxima proteção isso aqui
        public LogicClass(DTO? refDTO)
        {
            if (refDTO is not null)
                _dtoValue = refDTO;

            //Se eu soubesse poderia limpar a referência aqui do myDTO com linguagem C
        }

        public void teste()
        {
            //aqui acontece a validação do primeiro ponto de acesso o resto é private
        }

        private void testf()
        {
            //teste() vai chamando os voids privates

            //... dps de muito uso


            _dtoValue = null;

        }
    }

    public class DTO(string? password)
    {
        private string? _hash = Hash(password);

        private static string? Hash(string? input)
        {
            if(input is null) return null;

            return Crypt.HashPassword(input);
        }

        public bool Validate(string input) => Crypt.Verify(input, _hash);

        public void Ler()
        {
            Console.WriteLine(_hash);
        }
    }
}