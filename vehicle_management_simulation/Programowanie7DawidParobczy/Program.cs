using System;

namespace Programowanie7DawidParobczy
{   

    internal class Program
    {
        
        static Rower rower = new();
        static Deskorolka deskorolka = new();
        static void Main()
        {
            
            Menu();
            
        }
      
        public static void Menu()
        {
            Console.Clear();
                   
            Console.WriteLine("Wybierz pojazd:");
            Console.WriteLine("1.Rower");
            Console.WriteLine("2.Deskorolka");
            char wybor;

            do
            {
                wybor = Console.ReadKey().KeyChar;
                Console.WriteLine("Wybierz nr:");
            }
            while (wybor != '1' && wybor != '2');
            switch (wybor)
            {
                case '1':
                
                    rower.MenuRower();
                    break;
                case '2':
               
                    deskorolka.MenuDeskorolka();
                    break;
                case '3':
                    break;
            }
        }
    }

  
}
