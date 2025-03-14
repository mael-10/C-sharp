using System.Net.Mail;

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
            Console.WriteLine("The " + b + " " + a + " " + c + "\n \n");

            string OiBebe = a;
            Console.WriteLine(OiBebe);
            a = "sem mais nem menos";
            Console.WriteLine(a);
            Console.WriteLine(OiBebe + "\n \n");


            int r, f, g;
            r = f = g = 10;
            Console.WriteLine(f);
        }

       
    }
}
