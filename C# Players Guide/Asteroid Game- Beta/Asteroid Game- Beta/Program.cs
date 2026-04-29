namespace Asteroid_Game__Beta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Asteroid
    {
        public AsteroidGeneratorPosition Position { get; private set; }

        public AsteroidGeneratorVelocity Velocity { get; private set; }

        public Asteroid()
        {
            Position = AsteroidGeneratorPosition.StartPosition(100, 200);
            Velocity = AsteroidGeneratorVelocity.StartVelocity(5, 4.7f);
        }

        public void UpdatePosition()
        {
            Position.AddX(Velocity.X);
            Position.AddY(Velocity.Y);
        }
    }

    public class AsteroidGeneratorPosition
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public static AsteroidGeneratorPosition StartPosition(float positionX, float postionY)
        {
            return new AsteroidGeneratorPosition { X = positionX, Y = postionY };
        }

        public void ChangePositionXY(float newX, float newY)
        {
            X = newX;
            Y = newY;
        }

        public void ChangePositionX(float newX)
        {
            X = newX;
        }

        public void ChangePositionY(float newY)
        {
            Y = newY;
        }

        public void AddX(float x)
        {
            X += x;
        }

        public void AddY(float y)
        {
            Y += y;
        }

    }

    public class AsteroidGeneratorVelocity
    {
        private float _velocityX;
        private float _VelocityY;

        private AsteroidGeneratorVelocity(float velocityX, float velocityY)
        {
            X = velocityX;
            Y = velocityY;
        }

        public float X
        {
            get => _velocityX;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Não existe velocidade 0 ou negativo");
                }

                _velocityX = value;
            }
        }

        public float Y
        {
            get => _VelocityY;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Não existe velocidade 0 ou negativo");
                }

                _VelocityY = value;
            }
        }

        public static AsteroidGeneratorVelocity StartVelocity(float velocityX, float velocityY)
        {
            return new AsteroidGeneratorVelocity(velocityX, velocityY);
        }

        public void ChangeVelocityXY(float newX, float newY)
        {
            X = newX;
            Y = newY;

        }

        public void ChangeVelocityX(float newX)
        {
            X = newX;
        }

        public void ChangeVelocityY(float newY)
        {
            Y = newY;
        }
    }
}