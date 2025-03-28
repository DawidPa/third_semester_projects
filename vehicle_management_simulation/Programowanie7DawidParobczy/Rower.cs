using System;

namespace Programowanie7DawidParobczy
{
    class Rower : Pojazd, INaprawa
    {
        static Rower rower = new Rower() { predkosc = 50, kolor = "czerwony", stan = "dobry" };
        public void InfoRower()
        {
            Console.Clear();
            rower.predkosc = 0;
            rower.stan = "zniszczony";
            Console.WriteLine("Rower zrobił boom");

        }


        public void MenuRower()
        {

            Console.Clear();
            Console.WriteLine("Jesteś w menu ROWER");
            Console.WriteLine("1.Wyświetl dane");
            Console.WriteLine("2.Jedź");
            Console.WriteLine("3.Punkt naprawy pojazdów");
            Console.WriteLine("4.Wróć do menu głównego");
            int wyborRower;

            try
            {
                wyborRower = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wybierz nr:");
            
                switch (wyborRower)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("kolor: {0}", rower.kolor);
                        Console.WriteLine("stan: {0}", rower.stan);
                        Console.WriteLine("prędkość maksymalna: {0}", rower.predkosc);
                        Console.ReadKey();
                        Program.Menu();
                        break;
                    case 2:
                        Console.Clear();
                        Jazda();
                        break;
                    case 3:
                        Console.Clear();
                        Naprawa();
                        break;
                    case 4:
                        Program.Menu();
                        break;
                    default:
                        throw new Wyjatek("Proszę podać liczbę od 1 do 4");
                        break;
                }
            }
            catch (Exception ex)
            {

                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    MenuRower();
             
                
            }


        }


        public override void Jazda()
        {
            if (rower.stan == "zniszczony")
            {
                Console.WriteLine("Nie pojedziesz, pojazd zniszczony");
                Console.ReadKey();
                MenuRower();
            }
            else
            {
                Console.WriteLine("Jedziesz");
                Console.ReadKey();
                MenuRower();
            }
        }

        public void Naprawa()
        {
            if (rower.stan == "zniszczony")
            {
                rower.stan = "średni";
                rower.predkosc = 50;
                Console.WriteLine("Pojazd został naprawiony");
                Console.ReadKey();
                MenuRower();
            }
            else
            {
                Console.WriteLine("Pojazd jest w dobrym stanie, nie trzeba nic naprawiać");
                Console.ReadKey();
                MenuRower();

            }
        }
    }
}
