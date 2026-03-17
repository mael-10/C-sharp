namespace Infomation_Hinding_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Como não podemos acessar as fields 
            Rectangle rectangle = new Rectangle(10, 3);

            //Como a nossa field é privada nos apenas definimos formas de get e set de maneira que escolhemos o caminho. Ou seja, ir a um caminho definido
            float numWidth = rectangle.GetWidth();

            rectangle.SetHeight(5);
            rectangle.SetWidth(7);

            numWidth = rectangle.GetArea();

            Console.WriteLine(numWidth);

            //Se quisermos modificar o valor (como pre definimos)
        }
    }

    internal class Rectangle
    {
        private float _width;
        private float _height;

        public Rectangle(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public float GetWidth() => _width;
        public float GetHeight() => _height;
        public float GetArea() => _width * _height;   

        public void SetWidth(float value)
        {
            _width = value;
        }

        public void SetHeight(float value)
        {
            _height = value;
        }
    }
}