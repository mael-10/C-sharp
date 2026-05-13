namespace The_card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Card instance = new(CardColor.Blue, CardRank.Num9);
            instance.log();
        }
    }

    public class Card
    {
        private CardColor _cardColor;
        private CardRank _cardRank;
        private string cardColorString = string.Empty;
        private string cardRankString = string.Empty;

        public CardColor CardColor
        {
            get => _cardColor;
            init
            {
                _cardColor = value;
                cardColorString = _cardColor switch
                {
                    CardColor.Red => "Red",
                    CardColor.Blue => "Blue",
                    CardColor.Yellow => "Yellow",
                    CardColor.Green => "Green",
                    _ => "Nada encontrado",
                };
            }
        }

        public CardRank CardRank
        {
            get => _cardRank;
            init
            {
                _cardRank = value;
                cardRankString = _cardRank switch
                {
                    CardRank.Num1 => "One",
                    CardRank.Num2 => "Two",
                    CardRank.Num3 => "Three",
                    CardRank.Num4 => "Four",
                    CardRank.Num5 => "Five",
                    CardRank.Num6 => "Six",
                    CardRank.Num7 => "Seven",
                    CardRank.Num8 => "Eight",
                    CardRank.Num9 => "Nine",
                    CardRank.Num10 => "Ten",
                    CardRank.Dollasign => "Dollar Sign",
                    CardRank.Porcent => "Pocentege",
                    CardRank.Circumflex => "Circumflex",
                    CardRank.Ampersand => "Ampersand",
                    _ => "Nada encontrado"
                };

            }
        }

        
        public Card(CardColor cardColor, CardRank cardRank)
        {
            CardColor = cardColor;
            CardRank = cardRank;
        }

        public void log()
        {
            Console.WriteLine($"The {cardColorString} {cardRankString}");
        }
    }

    public enum CardColor { Red, Green, Blue, Yellow }
    public enum CardRank 
    { 
        Num1 = 1, 
        Num2 = 2, 
        Num3 = 3, 
        Num4 = 4, 
        Num5 = 5, 
        Num6 = 6, 
        Num7 = 7, 
        Num8 = 8, 
        Num9 = 9, 
        Num10 = 10, 
        Dollasign,
        Porcent,
        Circumflex,
        Ampersand
    }
}