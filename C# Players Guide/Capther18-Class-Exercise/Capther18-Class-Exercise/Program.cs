namespace Capther18_Class_Exercise
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Arrow teste = new Arrow(ArrowHead.Wood, Fletching.Plastic, 64);
            float finalcost = teste.GetCost();

            Console.WriteLine($"Final cost thats it {finalcost}");

        }
    }

    class Arrow
    {
        ArrowHead _arrowHead;
        Fletching _fletching;
        int _shaftLenght;

        public Arrow() : this(default, default, 0)
        {
        }

        public Arrow(ArrowHead arrowHead, Fletching fletching, int shaftLenght)
        {
            _arrowHead = arrowHead;
            _fletching = fletching;
            _shaftLenght = shaftLenght;
        }

        public float GetCost()
        {
            return (int)_arrowHead + (int)_fletching + _shaftLenght * 0.05f;
        }
    }

    enum ArrowHead
    {
        Steel = 10,
        Wood = 3,
        Obsidian = 5
    }

    enum Fletching
    {
        Plastic = 10,
        TurkeyFeathers = 5,
        GooseFeathers = 3
    }
}
