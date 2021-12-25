using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 10;

            Console.Write("Merry Christmas! This is a undecorated christmas tree\n");

            for (int l = 0; l <= 1; l++)
            {
                for (int i = 1; i < 10; i++)     //height
                {
                    for (int j = 0; j < v; j++)    //print space, get lesser
                        Console.Write(" ");

                    v -= 1;

                    for (int t = 1; t < i * 2; t++)    //print stars in odd numbers
                        Console.Write("*");

                    Console.WriteLine();    //next line
                }
                v = 10;
            }

            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)    //print space, get lesser
                    Console.Write(" ");

                for (int t = 0; t < 3; t++)    //print stars in odd numbers
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
