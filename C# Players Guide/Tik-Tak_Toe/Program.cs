using System.Runtime.CompilerServices;

namespace Tik_Tak_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Counter = 0;
            Board Game = Board.CreatGame();
            BoardUser.WritesBoard(Game);
            
            do
            {
                BoardUser.WritesTurn(PieceUser.State); //--> Escreve de qual vez é o usuário
                int Choice = BoardUser.GetPositionNumber(); //--> Pega a posição
                Console.Clear(); // Limpa

                if (!Game.ChoosePosition(PieceUser.State, Choice))
                {
                    Thread.Sleep(1500);
                    Console.Clear();
                    BoardUser.WritesBoard(Game);
                    continue;
                }

                PieceUser.Change();
                BoardUser.WritesBoard(Game);

                if (Validar.WinOrDraw(Game.BoardGameState)) //--> validação aqui
                    break; 

                Counter++;

                if (Counter == 9) //--> Conta a quantidade de tentativas
                {
                    if (Validar.Empate()) { Counter = 0; Game = Board.CreatGame(); continue; }
                  
                    break;
                }
            } while (true);
        }

        public class Board
        {
            public string[,] BoardGameState { get; private set; } = new string[3, 3]; //matriz 3 * 3

            private Board() //Inicializa com vazios para montar a formatação
            {
                for (int i = 0; i < BoardGameState.GetLength(0); i++) //GetLenth --> 3 Elementos rows
                {
                    for (int j = 0; j < BoardGameState.GetLength(1); j++) //GetLenth --> 3 Elementos colums
                    {
                        BoardGameState[i, j] = " ";
                    }
                }
            }

            public static Board CreatGame()
            {
                return new Board();
            }

            public bool ChoosePosition(XorO letter, int ChoosePosition)
            {
                switch (ChoosePosition)
                {
                    case 1:
                        if (string.IsNullOrWhiteSpace(BoardGameState[0, 0])) { BoardGameState[0, 0] = letter.ToString(); return true; }
                        break;
                    case 2:
                        if (string.IsNullOrWhiteSpace(BoardGameState[0, 1])) { BoardGameState[0, 1] = letter.ToString(); return true; }
                        break;
                    case 3:
                        if (string.IsNullOrWhiteSpace(BoardGameState[0, 2])) { BoardGameState[0, 2] = letter.ToString(); return true; }
                        break;
                    case 4:
                        if (string.IsNullOrWhiteSpace(BoardGameState[1, 0])) { BoardGameState[1, 0] = letter.ToString(); return true; }
                        break;
                    case 5:
                        if (string.IsNullOrWhiteSpace(BoardGameState[1, 1])) { BoardGameState[1, 1] = letter.ToString(); return true; }
                        break;
                    case 6:
                        if (string.IsNullOrWhiteSpace(BoardGameState[1, 2])) { BoardGameState[1, 2] = letter.ToString(); return true; }
                        break;
                    case 7:
                        if (string.IsNullOrWhiteSpace(BoardGameState[2, 0])) { BoardGameState[2, 0] = letter.ToString(); return true; }
                        break;
                    case 8:
                        if (string.IsNullOrWhiteSpace(BoardGameState[2, 1])) { BoardGameState[2, 1] = letter.ToString(); return true; }
                        break;
                    case 9:
                        if (string.IsNullOrWhiteSpace(BoardGameState[2, 2])) { BoardGameState[2, 2] = letter.ToString(); return true; }
                        break;
                    default:
                        Console.WriteLine("Padrão não encontrado nas teclas");
                        return false;
                }

                Console.WriteLine("Já existe um valor na posição");
                return false;
            }
        }

        public static class BoardUser //Classe para mostrar o resultado
        {
            public static void WritesTurn(XorO turnUser)
            {
                Console.WriteLine($"Its {turnUser}'s turn.");

            }

            public static void WritesBoard(Board cordinates)
            {
                Console.WriteLine(
                    $" {cordinates.BoardGameState[0, 0]} | {cordinates.BoardGameState[0, 1]} | {cordinates.BoardGameState[0, 2]} \n" +
                    $"---+---+--- \n" +
                    $" {cordinates.BoardGameState[1, 0]} | {cordinates.BoardGameState[1, 1]} | {cordinates.BoardGameState[1, 2]} \n" +
                    $"---+---+--- \n" +
                    $" {cordinates.BoardGameState[2, 0]} | {cordinates.BoardGameState[2, 1]} | {cordinates.BoardGameState[2, 2]} \n"
                    );
            }

            public static int GetPositionNumber()
            {
                Console.WriteLine("What square do you want play?");
                int choice = Convert.ToInt32(Console.ReadLine());
                return choice;
            }
        }

        public static class PieceUser
        {
            public static XorO State { get; private set; } = XorO.X;

            public static void Change()
            {
                if (State == XorO.X)
                    State = XorO.O;
                else
                    State = XorO.X;

            }
        }

        public static class Validar
        {
            public static bool WinOrDraw(string[,] BoardGameState) //Diagonal Principal
            {
                if (BoardGameState[0, 0] == BoardGameState[1, 1] &&
                    BoardGameState[1, 1] == BoardGameState[2, 2] &&
                    !string.IsNullOrWhiteSpace(BoardGameState[0, 0]))
                {
                    return HowWin(BoardGameState[0, 0]);
                }

                if (BoardGameState[0, 2] == BoardGameState[1, 1] && //Diagonal Secundaria
                    BoardGameState[1, 1] == BoardGameState[2, 2] &&
                    !string.IsNullOrWhiteSpace(BoardGameState[0, 2]))
                {
                    return HowWin(BoardGameState[0, 2]);
                }

                if (BoardGameState[0, 0] == BoardGameState[1, 0] && //Coluna 1
                    BoardGameState[1, 0] == BoardGameState[2, 0] &&
                    !string.IsNullOrWhiteSpace(BoardGameState[0, 0]))
                {
                    return HowWin(BoardGameState[0, 0]);
                }

                if (BoardGameState[0, 1] == BoardGameState[1, 1] && //Coluna 2
                    BoardGameState[1, 1] == BoardGameState[2, 1] &&
                    !string.IsNullOrWhiteSpace(BoardGameState[0, 1]))
                {
                    return HowWin(BoardGameState[0, 1]);
                }

                if (BoardGameState[0, 2] == BoardGameState[1, 2] && //Coluna 3
                    BoardGameState[1, 2] == BoardGameState[2, 2] &&
                    !string.IsNullOrWhiteSpace(BoardGameState[0, 2]))
                {
                    return HowWin(BoardGameState[0, 1]);
                }

                if (BoardGameState[0, 0] == BoardGameState[0, 1] && // Horizontal 1
                    BoardGameState[0, 1] == BoardGameState[0, 2] &&
                    !string.IsNullOrWhiteSpace(BoardGameState[0, 0]))
                {
                    return HowWin(BoardGameState[0, 0]);
                }

                if (BoardGameState[1, 0] == BoardGameState[1, 1] && // Horizontal 2
                    BoardGameState[1, 1] == BoardGameState[1, 2] &&
                    !string.IsNullOrWhiteSpace(BoardGameState[1, 0]))
                {
                    return HowWin(BoardGameState[1, 0]);
                }

                if (BoardGameState[2, 0] == BoardGameState[2, 1] && // Horizontal 3
                    BoardGameState[2, 1] == BoardGameState[2, 2] &&
                    !string.IsNullOrWhiteSpace(BoardGameState[2, 0]))
                {
                    return HowWin(BoardGameState[2, 0]);
                }

                return false;
            }

            public static bool HowWin(string Positon)
            {
                if (Positon.Contains(XorO.X.ToString()))
                {
                    Console.Clear();
                    Console.WriteLine($"Jogador {XorO.X} é ganhador");

                    return true;
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine($"Jogador {XorO.O} é ganhador");

                    return true;
                }
            }

            public static bool Empate()
            {
                Console.WriteLine("Nenhum dos jogadores ganhou, querem jogar novamente? S/N");
                if (Console.ReadLine() == "s")
                    return true;
                else
                    return false;
            }    
        }

        public enum XorO
        {
            X = 1,
            O = 2
        }
    }
}