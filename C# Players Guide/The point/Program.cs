namespace The_point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 3);
            Point point2 = new Point(3, 4);
            Console.WriteLine($"X: {point1.X}, Y: {point2.Y}");
            Console.WriteLine($"X: {point2.X}, Y: {point2.Y}");
        }
    }

    public class Point
    {
        public int X {  get; private set; }
        public int Y { get; private set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    //my answer
    //My properies arent immutable. I just use private set to use information hiding with that change it later 
}