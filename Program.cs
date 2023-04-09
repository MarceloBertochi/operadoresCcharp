using System;

namespace operadores

{
    class Program
    {
        static void Main()

        {
            int soma01 = 100 + 50;
            int soma02 = soma01 + 250;
            int soma03 = soma02 + soma02;

            Console.Clear();

            int x = 10;
            x += 5; // a adição (+) com o igual adiciona um valor 5 na variável dando o valor final 15

            Console.WriteLine(x);
            Console.Clear();

            int y = 10;

            y += 5;  Console.WriteLine(y);
            y -= 5;  Console.WriteLine(y);
            y *= 5;  Console.WriteLine(y);
            y /= 5;  Console.WriteLine(y);
            y %= 5;  Console.WriteLine(y);
            y %= 5;  Console.WriteLine(y);
            y &= 5;  Console.WriteLine(y);
            y |= 5;  Console.WriteLine(y);
            y ^= 5;  Console.WriteLine(y);
            y >>= 5; Console.WriteLine(y);
            y <<= 5; Console.WriteLine(y);

            Console.Clear();

            int a = 10;
            int b = 15;
            int c = 10;

            Console.WriteLine(a < b && b > c); 
            //Retorna true se ambas as declarações forem verdadeiras

            Console.WriteLine(a > b || b > c);
            //Retorna True se uma das declarações for verdadeira

            Console.WriteLine(!(a > b || b > c));
            //Inverte o resultado, retorna False se o resultado for verdadeiro




            







        }
    }
}
