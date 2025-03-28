using System;

namespace Programowanie5DawidParobczy
{
    class Program
    {
        static public void ZmianaTemperatury(ref int temp)
        {
            Console.WriteLine("Przed zmianą: {0}", temp);
            Console.WriteLine("Podaj nową temperatura");
            temp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Po zmianą: {0}", temp);
            
        }
        static void Main()
        {
            
            
            Menu();
        }
        static public void Menu()
        {
            
            char wybor;
            do
            {

                Console.Clear();
                Console.WriteLine("Wybierz przedmiot");
                Console.WriteLine("1.Pralka");
                Console.WriteLine("2.Suszarka");
                Console.WriteLine("3.Zakoncz program");
                Console.WriteLine("Podaj nr: ");
                wybor = Console.ReadKey().KeyChar;

            }
            while (wybor != '1' && wybor != '2' && wybor != '3');

            if (wybor == '1')
            {
                Pralka pralka = new(45, 59.5, 84, 7, 44, "Beko");
                ZmianaTemperatury(ref pralka.temperatura);
               Console.WriteLine($"Temperatura: {pralka.temperatura}");
                //pralka.MenuPralka();
            }
            else if (wybor == '2')
            {

                Console.WriteLine("\njeszcze nie zrobione");
            }
            else
            {

            }
        }


    }
}