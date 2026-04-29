namespace Null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoreManager _score = new ScoreManager();

            _score.AddToList(null, 10);
            _score.AddToList(null, 20);

            var oi = _score?.ListaInterna?[0]?.Nome ?? "Nada encontrado";

            /*
             * _score?: "O gerente existe?"

               .ListaInterna?: "A lista (o objeto) existe?"

                ?[0]: "A lista tem pelo menos um item? (Se estiver vazia, me dê null em vez de erro)"

                ?.Nome: "O objeto que está no índice 0 tem um nome ou o nome é nulo?"

                ?? "Nada encontrado": "Se qualquer uma das perguntas acima deu 'Não/Null', use esse texto aqui. (Null Coalescing)
             *
             * Você pode usar o 
             */

            
        }
    }

    internal class ScoreVar
    {
        public string? Nome {  get; init; }
        public int Point {  get; init; }
    }

    internal class ScoreManager
    {
        public List<ScoreVar> ListaInterna { get; private set; }

        public ScoreManager()
        {
            ListaInterna = new List<ScoreVar>();
        }

        public void AddToList(string? name, int point) //não pode ser static pois depende da instancia.
        {
            ListaInterna.Add(new ScoreVar { Nome = name, Point = point });
        }
    }
}