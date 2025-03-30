namespace Challenge_Variables_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte cannedBens = 1;
            sbyte rice = -20;

            ushort steak = 10_000;
            short grape = 6000;

            uint pineapple = 10_000;
            int candy = cannedBens + rice;
            ulong corn = 900000000;
            long cabbage = 10_000_000;

            char letter = 'c';
            string cleaningProduct = "Washer";

            float priceSteak = 2e-4F;
            double priceCandy = 1556e3;
            //it's imposible to add 
            decimal all = cannedBens + rice + steak - grape + pineapple * candy + cabbage + (decimal)corn + (decimal)priceSteak + (decimal)priceCandy;
            bool tOf = true;

            Console.WriteLine(cannedBens);
            Console.WriteLine(rice);
            Console.WriteLine(steak);
            Console.WriteLine(grape); 
            Console.WriteLine(pineapple);
            Console.WriteLine(candy);
            Console.WriteLine(corn);
            Console.WriteLine(cleaningProduct);
            Console.WriteLine(letter);
            Console.WriteLine(priceSteak);
            Console.WriteLine(priceCandy);
            Console.WriteLine(all);
            Console.WriteLine($"{tOf} \n \n");

            cannedBens = 20;
            rice = 20;

            steak = 1000;
            grape = 600;

            pineapple = 10_001;
            candy = cannedBens + rice;
            corn = 924000000;
            cabbage = 10_000_100;

            letter = 'z';
            cleaningProduct = "Floor Washed";

            priceSteak = 2.5e-4f;
            priceCandy = 1556e5;
            //it's imposible to add 
            all = 19378476.6e-3m;
            tOf = false;

            Console.WriteLine(cannedBens);
            Console.WriteLine(rice);
            Console.WriteLine(steak);
            Console.WriteLine(grape);
            Console.WriteLine(pineapple);
            Console.WriteLine(candy);
            Console.WriteLine(corn);
            Console.WriteLine(cleaningProduct);
            Console.WriteLine(letter);
            Console.WriteLine(priceSteak);
            Console.WriteLine(priceCandy);
            Console.WriteLine(all);
            Console.WriteLine($"{tOf} \n \n");

            //floting point doesnt support cast at least it doesnt pass the maxValue or MinValue when aplaying cast
            double x = double.MaxValue;
            float abcww = (float)x;
            Console.WriteLine(abcww);

            x = 1.67854e5;
            abcww = (float)x;
            Console.WriteLine(abcww);

            //byte semSentido = 20;
            //byte semHistoria = 40;

            //Não pode converter int para short sem cast, pois os valores são convetidos para int para fazer a soma.
            //Por isso que int e long consegue armazenar sem cast, pois podem armazenas literals menores
            //short resultAbcx = semHistoria + semSentido;

            //Quando se adiciona ponto nos numeros, ele é automaticamente double.
            //Se não colocar ponto, ele considera com inteiro. Aí não tem com fazer uma divisão de inteiros.
            //Mas posso dividir um número inteiro pelo um floting point
            float testeNumber = (float)(7 / 29.0 * 2);
            Console.WriteLine(testeNumber);

            var small = 100;
        }
    }
}
