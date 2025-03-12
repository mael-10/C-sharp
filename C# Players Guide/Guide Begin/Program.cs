namespace Guide_Begin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            //Necessary target the subject
            string a = Console.ReadLine();
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            //Target how biggest is that problem
            string b = Console.ReadLine();
            //Object name program
            string c = "of Doom 3000!";
            Console.WriteLine("The " + b + " " + a + " " + c);
        }
    }
}
