using System;

namespace Cwiczenia1Programowanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j=0; j < 40; j++)
                {
                    if(i < 20 && j < 20)
                    {
                        Console.Write(" * ");
                    }

                    if (i >= 20 && j < 20)
                    {
                        if (j % 2 == 0)
                            Console.Write(" # ");
                        else
                            Console.Write(" @ ");
                    }

                    if (i < 20 && j >= 20)
                    {
                        if (j % 2 == 0)
                            Console.Write(" # ");
                        else
                            Console.Write(" @ ");
                    }

                    if (i >= 20 && j >= 20)
                    {
                        Console.Write(" + ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
