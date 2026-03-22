
namespace Pivate_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria() { IdUsuario = "0_000_000_001", Nome = "Tadeu"};
            Console.WriteLine($"Nome: {conta.Nome}, {conta.IdUsuario}, {conta.Saldo}");
            conta.Deposit(20);
            Console.WriteLine($"Nome: {conta.Nome}, {conta.IdUsuario}, {conta.Saldo}");
        }
    }

    internal class ContaBancaria //private set só pode mudar valor dentro da propia class (seja inline, method, ou dentro da construção de um construtor "não fora", 
    {
        public string IdUsuario { get; init; }
        public string Nome {  get; init; }

        private decimal _saldo;

        public ContaBancaria()
        {
            _saldo = 0; 
        }

        public decimal Saldo
        {
            get => _saldo;
            private set //validar no set é melhor pois é obrigado a respeita o information hiding (valida os  valores e depis atribui)
            {
                _saldo = value <= 0 ? 0 : value; //da um valor de retorno (atribui o novo valor)
            }

        }

        public void Deposit(decimal valor) //Como ele é private set, o valor
        {
            Saldo += valor;

            /*
             * 1- Chama o get (que é o valor atual
             * 2- Soma o valor Saldo + valor e anexa no Saldo (aqui que pega o get)
             * 3- Chama o Saldo (com o valor já somado)
             * 4- Depois valida
             * set garante que _saldo não vai receber o valor errado
             * metodo trata a regra de negócio
             */
        }
    }
}