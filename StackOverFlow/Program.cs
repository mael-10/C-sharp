using System;

public class Program
{
    // Método recursivo que se chama infinitamente
    public static void CausaStackOverflow()
    {
        Console.WriteLine("Chamando a função novamente...");
        // Esta linha faz com que a função se chame novamente
        // sem uma condição de parada.
        CausaStackOverflow();
    }

    public static void Main(string[] args)
    {
         Console.WriteLine("Tentando causar um Stack Overflow...");
        //CausaStackOverflow();

        string a = "oi";
        string b =  a;
        a = "Para";

        Console.WriteLine($"Aqui é o B {b} e aqui é o A {a}");

        string[] c;
        string[] teste =  { "oiiii", "para" };
       
        c = teste;
        c[0] = "muda"; // c  is a copy of the reference teste. If I chance c teste is changed too

        Console.WriteLine($"{teste[0]}");
    }
}
