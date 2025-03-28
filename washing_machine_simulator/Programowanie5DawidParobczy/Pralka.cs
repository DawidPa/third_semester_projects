using System;

namespace Programowanie5DawidParobczy
{
    class Pralka
    {
        //Atrybuty z róznymi modyfikatorami dostępu
        public int szerokosc;
        public double glebokosc;
        public int wysokosc;
        public int pojemnosc;
        public int zuzycieWody;
        internal string producent;
        protected bool czyWlaczona = false;
        protected bool czyOtwarta = true;
        protected bool czyUbrania = false;
        protected bool czyProszek = false;
        char wyborPralka; //bazowo ma private
        public int temperatura = 5;


        //2 konstruktory w tym kopiujący

        //Konstruktor domyślny
        public Pralka()
        {
        }

        //Własny konstruktor
        public Pralka(int szerokosc, double glebokosc, int wysokosc, int pojemnosc, int zuzycieWody, string producent)
        {
            this.szerokosc = szerokosc;
            this.glebokosc = glebokosc;
            this.wysokosc = wysokosc;
            this.pojemnosc = pojemnosc;
            this.zuzycieWody = zuzycieWody;
            this.producent = producent;

        }

        //konstruktor kopiujący 
        public Pralka(Pralka jakisObiekt)
        {
            this.szerokosc = jakisObiekt.szerokosc;
            this.glebokosc = jakisObiekt.glebokosc;
            this.wysokosc = jakisObiekt.wysokosc;
            this.pojemnosc = jakisObiekt.pojemnosc;
            this.zuzycieWody = jakisObiekt.zuzycieWody;
            this.producent = jakisObiekt.producent;


        }

        //1.
        private void Wlaczwylacz()
        {

         

            if (czyOtwarta == true)
            {

                Console.WriteLine("Lepiej zamknij pralke zanim ją włączysz (Kliknij dodwolny przycisk aby wrócić)");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }

            else if (czyUbrania == false && czyWlaczona == false)
            {
                do
                {
                    Console.WriteLine("Nie masz włożonych żadnych ubrań, czy chcesz uruchomić pustą pralkę? (t/n)");
                    wyborPralka = Console.ReadKey().KeyChar;

                } while (wyborPralka != 't' && wyborPralka != 'n');
                if (wyborPralka == 't')
                {
                    czyWlaczona = true;
                    Console.WriteLine("Włączyłeś pralkę ale bez ubrań w środku");
                    MenuPralka();
                }
                
                {
                    MenuPralka();
                }
            }

            else if (czyProszek == false && czyWlaczona == false)
            {
                do
                {
                    Console.WriteLine("Nie dałeś żadnego proszku, czy chcesz kontynować (t/n)");
                    wyborPralka = Console.ReadKey().KeyChar;
                } while (wyborPralka != 't' && wyborPralka != 'n');

                if (wyborPralka == 't')
                {
                    czyWlaczona = true;
                    Console.WriteLine("Włączyłeś pralkę ale bez proszku");
                    MenuPralka();
                }
                else
                {
                    MenuPralka();
                }
            }

            else if (czyWlaczona == true)
            {
                do
                {
                    Console.WriteLine("Czy chcesz wyłączyć pralke? (t/n)");
                    wyborPralka = Console.ReadKey().KeyChar;
                } while (wyborPralka != 't' && wyborPralka != 'n');

                if (wyborPralka == 't')
                {
                    czyWlaczona = false;
                    Console.WriteLine("Wyłączyłeś pralkę");
                    MenuPralka();
                }
                else
                {
                    czyWlaczona = true;
                    Console.WriteLine("Wyłączyłeś pralkę");
                    MenuPralka();
                }
            }

            


        }

        //2.
        private void DajProszek()
        {
            czyProszek = true;
            Console.WriteLine("Dałeś proszek do pralki (Kliknij dodwolny przycisk aby wrócić)");
            wyborPralka = Console.ReadKey().KeyChar;
            MenuPralka();
        }

        //3.
        private void OtworzPralke()
        {
            if (czyOtwarta == false && czyWlaczona == false)
            {

                Console.WriteLine("Otworzyłeś pralke (Kliknij dodwolny przycisk aby wrócić)");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyWlaczona == true)
            {
                Console.WriteLine("Pralka dalej jest włączona, lepiej jej takiej nie otwierać (Kliknij dodwolny przycisk aby wrócić)");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else
            {
                Console.WriteLine("Pralka jest aktualnie otwarta (Kliknij dodwolny przycisk aby wrócić)");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
        }

        //4
        private void ZamknijPralke()
        {
            if (czyOtwarta == true)
            {
                czyOtwarta = false;
                Console.WriteLine("Zamknąłeś pralke (Kliknij dodwolny przycisk aby wrócić)");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyWlaczona == true)
            {
                Console.WriteLine("Pralka aktualnie pracuje, nie możesz jej drugi raz zamknąć (Kliknij dodwolny przycisk aby wrócić)");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyOtwarta == false)
            {
                Console.WriteLine("Pralka jest aktualnie zamknięta (Kliknij dodwolny przycisk aby wrócić)");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
        }

        //5
        private void WlozUbrania()
        {
            if (czyOtwarta == false)
            {
                Console.WriteLine("Nie możesz włożyć ubrań do zamkniętej pralki! (Kliknij dodwolny przycisk aby wrócić) ");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyOtwarta == true)
            {
                czyUbrania = true;
                Console.WriteLine("Włożyłeś ubrania do pralki (Kliknij dodwolny przycisk aby wrócić) ");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }

        }

        //6 

        private void WyciagnijUbrania()
        {
            if (czyWlaczona == true)
            {
                Console.WriteLine("Nie możesz wyciągnąć ubrań, pralka nadal chodzi (Kliknij dodwolny przycisk aby wrócić) ");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyWlaczona == false && czyUbrania == false && czyOtwarta == true)
            {
                Console.WriteLine("Próbowałeś zabrać ubrania, jednak nic nie znalazłeś w środku (Kliknij dodwolny przycisk aby wrócić) ");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyWlaczona == false && czyUbrania == true && czyOtwarta == true && czyProszek == false)
            {
                Console.WriteLine("Udało ci się wyciągnąć ubrania, jednak są nadal troche brudne (Kliknij dodwolny przycisk aby wrócić) ");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyWlaczona == false && czyUbrania == true && czyOtwarta == false)
            {
                Console.WriteLine("Musisz najpierw otworzyć pralkę (Kliknij dodwolny przycisk aby wrócić) ");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyWlaczona == false && czyUbrania == false && czyOtwarta == false)
            {
                Console.WriteLine("Musisz najpierw otworzyć pralkę (Kliknij dodwolny przycisk aby wrócić) ");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyWlaczona == false && czyUbrania == true && czyOtwarta == false)
            {
                Console.WriteLine("Musisz najpierw otworzyć pralkę (Kliknij dodwolny przycisk aby wrócić) ");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else if (czyWlaczona == false && czyUbrania == true && czyOtwarta == true && czyProszek == true)
            {
                Console.WriteLine("Udało ci się wyciągnąć ubrania i są czyściutkie (Kliknij dodwolny przycisk aby wrócić) ");
                wyborPralka = Console.ReadKey().KeyChar;
                MenuPralka();
            }
            else
            {
                MenuPralka();
            }

        }

        //7

        private void WyswietlDane()
        {
            Console.Clear();

            Console.WriteLine("Szerokosc: {0}", szerokosc);
            Console.WriteLine("Glebokosc: {0}", glebokosc);
            Console.WriteLine("Wysokosc: {0}", wysokosc);
            Console.WriteLine("Pojemnosc: {0}", pojemnosc);
            Console.WriteLine("Zuzycie Wody: {0}", zuzycieWody);
            Console.WriteLine("Producent: {0}", producent);

            Console.WriteLine("");
            Console.WriteLine("INFORMACJE O STANIE PRALKI:");
            Console.WriteLine("");
            Console.WriteLine("Czy pralka jest włączona?: ");
            if (czyWlaczona == true)
            {
                Console.WriteLine("Pralka jest włączona");
            }
            else if (czyWlaczona == false)
            {
                Console.WriteLine("Pralka jest wyłączona\n");
            }

            Console.WriteLine("Czy pralka jest otwarta?: ");
            if (czyOtwarta == true)
            {
                Console.WriteLine("Pralka jest otwarta\n");
            }
            else if (czyOtwarta == false)
            {
                Console.WriteLine("Pralka jest zamknięta\n");
            }

            Console.WriteLine("Czy ubrania są w pralce?: ");
            if (czyUbrania == true)
            {
                Console.WriteLine("Ubrania są w pralce\n");
            }
            else if (czyUbrania == false)
            {
                Console.WriteLine("Nie ma ubrań w pralcea\n");
            }

            Console.WriteLine("Czy proszek został wsypany do pralki?: ");
            if (czyProszek == true)
            {
                Console.WriteLine("Proszek został wsypany\n");
            }
            else if (czyProszek == false)
            {
                Console.WriteLine("Proszek nie został wsypany\n");
            }
            Console.WriteLine("(Kliknij dodwolny przycisk aby wrócić) ");
            wyborPralka = Console.ReadKey().KeyChar;
            MenuPralka();


        }

        public void MenuPralka()
        {

            do
            {
                Console.Clear();
                Console.WriteLine("Co zrobisz?");
                Console.WriteLine("1.Włącz/Wyłącz Pralke");
                Console.WriteLine("2.Daj proszek do prania");
                Console.WriteLine("3.Otwórz pralke");
                Console.WriteLine("4.Zamknij pralke");
                Console.WriteLine("5.Włóż ubrania");
                Console.WriteLine("6.Wyciągnij ubrania");
                Console.WriteLine("7.Wyświetl dane");
                Console.WriteLine("8.Wróć do okna wyboru");
                Console.WriteLine("9.Wyłącz program");
                Console.WriteLine("Podaj nr: ");
                wyborPralka = Console.ReadKey().KeyChar;

            }
            while (wyborPralka != '1' && wyborPralka != '2' && wyborPralka != '3' && wyborPralka != '4' && wyborPralka != '5' && wyborPralka != '6' && wyborPralka != '7' && wyborPralka != '8' && wyborPralka != '9');

            switch (wyborPralka)
            {
                case '1':
                    Console.Clear();
                    Wlaczwylacz();
                    break;
                case '2':
                    Console.Clear();
                    DajProszek();
                    break;
                case '3':
                    Console.Clear();
                    OtworzPralke();
                    break;
                case '4':
                    Console.Clear();
                    ZamknijPralke();
                    break;
                case '5':
                    Console.Clear();
                    WlozUbrania();
                    break;
                case '6':
                    Console.Clear();
                    WyciagnijUbrania();
                    break;
                case '7':
                    Console.Clear();
                    WyswietlDane();
                    break;
                case '8':
                    Console.Clear();
                    Program.Menu();
                    break;
                case '9':
                    Console.Clear();
                    break;

            }


        }
    }
}
