using System;

namespace Programowanie7DawidParobczy
{
    class Deskorolka : Pojazd, INaprawa
    {
        static Rower rower = new Rower() { predkosc = 50, kolor = "czerwony", stan = "dobry" };
        static Deskorolka deskorolka = new Deskorolka() {predkosc = 25, kolor = "niebieski", stan = "średni"};
        //2klasy w klasie publisher tworzymy event delegate i metode co wywołuje zdarzenie, dodac do zdarzenia, metode, która będzie wywołania gdy zdarzenie uruchomione

        //delegata pojazdu
        public delegate void WypadekInfoHandler();

        public event WypadekInfoHandler Wih;

   

        public Deskorolka() 
        {
        
           
        }
        public void Info()
        {
            
            predkosc = 0;
            deskorolka.stan = "zniszczony";
            Console.WriteLine("Wypadek deskorolka");
            Console.ReadKey();         
            Program.Menu();

        }
        
        public void OnWypadekInfo()
        {
            
            Wih?.Invoke();
           
        }
        public void MenuDeskorolka()
        {
           

            Console.Clear();
            Console.WriteLine("Jesteś w menu DESKOROLKA");
            Console.WriteLine("1.Wyświetl dane");
            Console.WriteLine("2.Spowoduj wypadek");
            Console.WriteLine("3.Jedź");
            Console.WriteLine("4.Punkt naprawy pojazdów");
            Console.WriteLine("5.Wróć do menu głównego");
            char wyborDeskorolka;

            do
            {
                wyborDeskorolka = Console.ReadKey().KeyChar;
                Console.WriteLine("Wybierz nr:");
            }
            while (wyborDeskorolka != '1' && wyborDeskorolka != '2' && wyborDeskorolka != '3' && wyborDeskorolka != '4' && wyborDeskorolka != '5');
            switch (wyborDeskorolka)
            {
                case '1':

                    Console.Clear();
                    Console.WriteLine("kolor: {0}", deskorolka.kolor);
                    Console.WriteLine("stan: {0}", deskorolka.stan);
                    Console.WriteLine("prędkość maksymalna: {0}", deskorolka.predkosc);
                    Console.ReadKey();
                    Program.Menu();

                    break;
                case '2':
                    deskorolka.Wih += rower.InfoRower;
                    deskorolka.Wih += deskorolka.Info;
                    deskorolka.OnWypadekInfo();
                    break;
                case '3':
                    Console.Clear();
                    Jazda();
                    break;
                case '4':
                    Console.Clear();
                    Naprawa();
                    break;
                case '5':
                    Program.Menu();
                    break;
            }
        }

        //metoda z metody abstrakcyjnej?
        public override void Jazda()
        {
            if(deskorolka.stan == "zniszczony")
            {
                Console.WriteLine("Nie pojedziesz, pojazd zniszczony");
                Console.ReadKey();
                MenuDeskorolka();
            }
            else
            {
                Console.WriteLine("Jedziesz");
                Console.ReadKey();
                MenuDeskorolka();
            }
        }

        //metoda interfejsu naprawy
        public void Naprawa()
        {
            if (deskorolka.stan == "zniszczony")
            {
                deskorolka.stan = "średni";
                deskorolka.predkosc = 25;
                Console.WriteLine("Pojazd został naprawiony");
                Console.ReadKey();
                MenuDeskorolka();
            }
            else
            {
                Console.WriteLine("Pojazd jest w dobrym stanie, nie trzeba nic naprawiać");
                Console.ReadKey();
                MenuDeskorolka();

            }
        }
    }
}
