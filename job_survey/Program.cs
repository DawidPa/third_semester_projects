using System;

namespace ConsoleApp4
{
    class Program
    {



        static void Main(string[] args)
        {
            bool poprawne = false;
            int stra = 0;
            int akt = 0;
            int inf = 0;
            int nau = 0;
            int lek = 0;

            
            Console.WriteLine("Witaj w ankieterze umiejętności. (kliknij dowolny klawisz aby przejść dalej)");
            Console.ReadKey(true);
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("Podamy ci teraz 10 pytań by odnaleść odpowiednią prace przystosowaną do twoich kwalifikacji. (kliknij dowolny klawisz aby przejść dalej)");
            Console.ReadKey(true);
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("Pytania odpowiadamy używając jednej z 5 opcji lub tak/nie(kliknij dowolny klawisz aby rozpocząć) ");
            Console.ReadKey(true);
            Console.WriteLine("");
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Pytanie pierwsze, jak dobrze radzisz sobie z komputerami?");
                Opcje();
                Papa(1, 1, 5, 3, 2);
            } while (poprawne == false);
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Pytanie drugie, jak dobrze radzisz sobie w stresujacych momentach?");
            Opcje();
            Papa(4, 3, 1, 1, 2);
            } while (poprawne == false);
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Pytanie trzecie, jak oceniasz swój stan fizyczny? (sporty, sylwetka, kardio) ");
            Opcje();
            Papa(3, 4, 1, 1, 2);
            } while (poprawne == false);
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Pytanie czwarte, jak oceniasz swoją wiedze w dziedzinie nauki?");
            Opcje();
            Papa(1, 1, 2, 4, 3);
            } while (poprawne == false);
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Czy jesteś kreatywny?");
                Opcje2();
                Papa2(1, 4, 3, 1, 1);
                
            } while (poprawne == false);
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Czy radzisz sobie z dziećmi?");
            Opcje2();
            Papa2(2, 1, 1, 4, 3);
            } while (poprawne == false);
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Czy potrafisz jeździć pojazdami?");
            Opcje2();
            Papa2(4, 2, 1, 1, 3);
            } while (poprawne == false);
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Pytanie ósme, jak dobrze przychodzi ci nawiązywanie kontaktu z drugą osobą?");
            Opcje();
            Papa(1, 2, 1, 3, 3);
            } while (poprawne == false);
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Pytanie dziewiąte, jak czujesz się przed dużą ilością osób?");
            Opcje();
            Papa(2, 4, 1, 3, 1);
            } while (poprawne == false);
            Console.Clear();
            do
            {
                poprawne = true;
                Console.WriteLine("Pytanie dziesiąte, jak dobrze odnajdujesz się w nowych technologiach?");
            Opcje();
            Papa(2, 1, 4, 1, 3);
            } while (poprawne == false);
            Console.Clear();

            if (stra > akt && stra > inf && stra > nau && stra > lek)
            {
                Console.WriteLine("Twój zawód to strażak");
            }
            else if (akt > stra && akt > inf && akt > nau && akt > lek)
            {
                Console.WriteLine("Twój zawód to aktor");
            }
            else if (inf > stra && inf > akt && inf > nau && inf > lek)
            {
                Console.WriteLine("Twój zawód to informatyk");
            }
            else if (nau > stra && nau > akt && nau > inf && nau > lek)
            {
                Console.WriteLine("Twój zawód to nauczyciel");
            }
            else if (lek > stra && lek > akt && lek > inf && nau < lek)
            {
                Console.WriteLine("Twój zawód to lekarz");
            }
            else
            {
                Console.WriteLine("Kwalifikuje się pan/pani na wiele zawodów");
            }

            void Papa(int lakt, int lstra, int linf, int lnau, int llek)
            {


                string liczba;
                liczba = Console.ReadLine();

                switch (liczba)
                {
                    case "1":
                        akt += 5 * lakt;
                        stra += 5 * lstra;
                        inf += 5 * linf;
                        nau += 5 * lnau;
                        lek += 5 * llek;
                        break;

                    case "2":
                        akt += 4 * lakt;
                        stra += 4 * lstra;
                        inf += 4 * linf;
                        nau += 4 * lnau;
                        lek += 4 * llek;
                        break;

                    case "3":
                        akt += 3 * lakt;
                        stra += 3 * lstra;
                        inf += 3 * linf;
                        nau += 3 * lnau;
                        lek += 3 * llek;
                        break;

                    case "4":
                        akt += 2 * lakt;
                        stra += 2 * lstra;
                        inf += 2 * linf;
                        nau += 2 * lnau;
                        lek += 2 * llek;
                        break;

                    case "5":
                        akt += lakt;
                        stra += lstra;
                        inf += linf;
                        nau += lnau;
                        lek += llek;
                        break;

                    default:
                        Console.Clear();
                        poprawne = false;
                        Console.WriteLine("Błąd");
                        
                        break;


                }



            }

            void Papa2(int lakt2, int lstra2, int linf2, int lnau2, int llek2)
            {
                

                    string napis;
                    napis = Console.ReadLine();

                    switch (napis)
                    {
                        case "tak":
                            akt += 3 * lakt2;
                            stra += 3 * lstra2;
                            inf += 3 * linf2;
                            nau += 3 * lnau2;
                            lek += 3 * llek2;
                       
                        break;

                        case "TAK":
                            akt += 3 * lakt2;
                            stra += 3 * lstra2;
                            inf += 3 * linf2;
                            nau += 3 * lnau2;
                            lek += 3 * llek2;
                        
                        break;

                        case "nie":
                            akt += lakt2;
                            stra += lstra2;
                            inf += linf2;
                            nau += lnau2;
                            lek += llek2;
                        
                        break;

                        case "NIE":
                            akt += lakt2;
                            stra += lstra2;
                            inf += linf2;
                            nau += lnau2;
                            lek += llek2;
                        
                        break;
                        default:
                            {
                            Console.Clear();
                            poprawne = false;
                            Console.WriteLine("Błąd");
                            
                            break;
                            }


                    }
               
                
            }

            void Opcje()
            {
                Console.WriteLine("1.Bardzo dobrze");
                Console.WriteLine("2.Dobrze");
                Console.WriteLine("3.Okej");
                Console.WriteLine("4.Średnio");
                Console.WriteLine("5.Słabo");
            }
            void Opcje2()
            {
                Console.WriteLine("tak");
                Console.WriteLine("nie");

            }



            Console.WriteLine("Punkty strażaka: " + stra);
            Console.WriteLine("Punkty aktora: " + akt);
            Console.WriteLine("Punkty informatyka: " + inf);
            Console.WriteLine("Punkty nauczyciela: " + nau);
            Console.WriteLine("Punkty lekarza: " + lek);
            Console.ReadLine();

        }


    }
}
