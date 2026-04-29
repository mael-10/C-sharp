namespace All_In_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessarPedido.Processo();
        }
    }

    public static class ProcessarPedido
    {
        internal static void Processo()
        {
            Cliente? cliente = Cliente.Criar("João", 700.9m); //Não se cria static com new

            if (cliente is null)
            {
                Console.WriteLine("Cliente não tem nada, partindo para outro cliente válido");
                return;
            }

            var valoresDoPedido = ChooseProduct();

            if(valoresDoPedido.Preco is not null)
            {
                decimal valueTotalQte = ChooseQte(valoresDoPedido.Preco); //como já tinha colocado ? na variável, o compilador acha que vai ser nulo, mas como é value type, tem um comportamento diferent

                bool restMoney = cliente!.DescontarSaldo(valueTotalQte); //pode ficar tranquilo que aqui não vai dar nulo

                Console.WriteLine("Pago com sucesso!");

                Console.WriteLine($"Nome do cliente: {cliente.Nome}\n" +
                    $"Saldo bancário restante do cliente após compra {cliente.SaldoBancario}\n" +
                    $"Produto comprado: {valoresDoPedido.Nome}\n" +
                    $"Quantidade produto comprado total: {valueTotalQte}");

                cliente = null; //limpa a memoria a cada processamento de pedido

                return;
            }
        }

        private static (ProdutosAutomotivos? Nome, decimal? Preco) ChooseProduct()
        {
            Console.WriteLine("Qual o produto que você deseja?");
            string? product = Console.ReadLine();

            return product switch
            {
                "0" => (ProdutosAutomotivos.Pneu, 100m),
                "1" => (ProdutosAutomotivos.Painel, 120m),
                "2" => (ProdutosAutomotivos.PortaDianteira, 80m),
                "3" => (ProdutosAutomotivos.PortaTraseira, 100m),
                "4" => (ProdutosAutomotivos.Catalisador, 150),
                _ => (null, null)
            };
        }

        private static decimal ChooseQte(decimal? valueProduct) //temos que colocar o ? pq o compilador entende que ele poder ser um nulo (e o valor de retorno também)
        {
            Console.WriteLine("Qual a quantidade que você quer?");
            string? numberQte = Console.ReadLine();

            while(!int.TryParse(numberQte, out int result)) //se converter vai ser verdadeiro (falso para sair do looping)
            {
               Console.Clear();
               Console.Write("Dado incorreto! Tente novamente: ");
               numberQte = Console.ReadLine();
            }
          
            return valueProduct * int.Parse(numberQte) ?? 0; //Compilador "A qualauqer momento pode ser um Nullable, então caso seja, retorne 0 para o compilador entender que em nenhum momento vai retornar um null able"
        }
    }

    public class Cliente
    {
        public string? Nome { get; } //não tem set pq pode chamar direto do object ini cializer e eu quero que chame apenas apartir do meu método
        public decimal SaldoBancario { get; private set; }

        private Cliente(string? nome, decimal saldoBancario) //Não pode criar uma instância vazia pq já existe esse construtor (alem disso ele é private)
        {
            Nome = nome;
            SaldoBancario = saldoBancario;
        }

        public static Cliente? Criar(string? nome, decimal saldoBancario) //factory method
        {
            if (saldoBancario <= 0 || nome is null)
            {
                return null;
            }

            return new Cliente(nome, saldoBancario);
        }

        public bool DescontarSaldo(decimal valorDescontar) // tirar saldo, validação de saldo restante
        {
            if (valorDescontar > SaldoBancario)
            {
                return true;
            }

            SaldoBancario -= valorDescontar;
            return false;
        }
    }

    internal enum ProdutosAutomotivos { Pneu, Painel, PortaDianteira, PortaTraseira, Catalisador }
    internal enum StatusPedido { Pendente, Pago, NaoConfirmado }
}