namespace Tik_tak_toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

    }


    // O "Especialista em Dados" (Não tem colaboradores)
    public class Account
    {
        public decimal Balance { get; private set; }

        public Account(decimal initialBalance)
        {
            if (initialBalance < 0) //não pode ter saldo negativo logo na entrada
                throw new ArgumentException("O saldo inicial não pode ser negativo");

            Balance = initialBalance;
        }

        public bool CanWithdraw(decimal amount) => amount > 0 && Balance >= amount;

        public void Debit(decimal amount)
        {
            if (!CanWithdraw(amount)) throw new InvalidOperationException("Saldo insuficiente.");
            Balance -= amount;
        }
    }

    
}