using System;

namespace Programowanie3proba2
{
    

    class Program
    {
        public static void Main()
        {
            bool powrot;
            do //powrot
            {
            Console.Clear();
            Console.WriteLine("Wybierz przedmiot");
            Console.WriteLine("1.Monitor");
            Console.WriteLine("2.Lodowka");
            Console.WriteLine("3.Lampa");
            Console.WriteLine("4.Zakoncz program");
            char wybor = Console.ReadKey().KeyChar;
                Monitor monitor1 = new Monitor();
               


                powrot = true;

                switch (wybor)
                {
                    case '1':
                        Console.Clear();

                        bool powrot2;
                        monitor1.WykonajMonitor();
                        Console.Clear();
                        do //powrot2
                        {
                            powrot2 = true;
                            monitor1.NarysujMonitor("   ", " # ");
                            Console.WriteLine("Co zrobisz dalej");
                            Console.WriteLine("1.Włącz");
                            Console.WriteLine("2.Wróć do menu");
                            char wyborMon = Console.ReadKey().KeyChar;
                            Console.Clear();
                            switch (wyborMon)
                            {
                                case '1':
                                    bool powrot3;
                                    do //powrot3
                                    {
                                        powrot3 = true;
                                        monitor1.NarysujMonitor(" * ", " # ");
                                        Console.WriteLine("Co zrobisz dalej");
                                        Console.WriteLine("1.Wyłącz");
                                        Console.WriteLine("2.Wróć do menu");
                                        char wyborMon2 = Console.ReadKey().KeyChar;
                                        switch (wyborMon2)
                                        {
                                            case '1':
                                                Console.Clear();
                                                powrot2 = false;
                                                break;
                                            case '2':
                                                powrot = false;
                                                break;
                                            default:
                                                Console.Clear();
                                                powrot3 = false;
                                                break;
                                        }
                                    } while (powrot3 == false);
                                    break;
                                case '2':

                                    powrot = false;
                                    break;
                                default:
                                    Console.Clear();
                                    powrot2 = false;
                                    break;
                            }
                        } while (powrot2 == false);
                        break;

                    case '2':
                        Console.Clear();
                        Lodowka lodowka = new Lodowka();
                        lodowka.RysujLodowka();
                        break;

                    case '3':
                        Console.Clear();
                        Lampa lampa = new Lampa();
                        lampa.RysujLampa();
                        break;

                    case '4':
                        Console.Clear();
                        Environment.Exit(1);
                        break;

                    default:
                        
                        Console.WriteLine("Zła wartosc, spróbuj ponownie");
                        powrot = false;
                        break;
                }
            } while (powrot == false);

        }

    }

    public class Monitor
    {
        public int wysokosc;
        public int szerokosc;

        public void WykonajMonitor()
        {

            string input;
            do
            {
                Console.Clear();
                Console.WriteLine("Podaj wysokosc");
                input = Console.ReadLine();



            } while (int.TryParse(input, out wysokosc) == false);

            do
            {
                Console.Clear();
                Console.WriteLine("Podaj szerokosc");
                input = Console.ReadLine();


            } while (int.TryParse(input, out szerokosc) == false);


        }

        public void NarysujMonitor(string wew, string zew)
        {


            for (int i = 0; i < wysokosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    if (i == 0 || j == 0 || j == szerokosc - 1 || i == wysokosc - 1)
                    {
                        Console.Write(zew);
                    }
                    else
                    {
                        Console.Write(wew);
                    }

                }
                Console.WriteLine();
            }
        }

    }

    public class Lodowka
    {
        public void RysujLodowka()
        {
            bool powrot2 = false;
            do
            {
                powrot2 = true;
                Console.Clear();
                Console.WriteLine("[--------------------]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[  o                 ]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[--------------------]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[  o                 ]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[                    ]");
                Console.WriteLine("[--------------------]");
                Console.WriteLine("Co chcesz zrobić z lodówką?");
                Console.WriteLine("1.Otworzyc lodowke");
                Console.WriteLine("2.Otworzyc zamrazarke");
                Console.WriteLine("3.Otworzyc oba");
                Console.WriteLine("4.Zamknac wszystko");
                Console.WriteLine("5.Wrocic do okna wyboru przedmiotu");
                char wyborLod = Console.ReadKey().KeyChar;

                switch (wyborLod)
                {
                    case '1':
                        OtworzLodowke();
                        break;
                    case '2':
                        OtworzZamrazarke();
                        break;
                    case '3':
                        OtworzOba();
                        break;
                    case '4':
                        RysujLodowka();
                        break;
                    case '5':                      
                        Program.Main();
                        break;
                    default:
                        Console.Clear();
                        powrot2 = false;
                        break;
                }
            } while (powrot2 == false);
        }
        public void OtworzLodowke()
        {
            bool powrot2 = false;
            do 
            {
            powrot2 = true;
            Console.Clear();
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[  ________	 /   ]");
            Console.WriteLine("[  [szynka]	[]   ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[	_____/_	     ]");
            Console.WriteLine("[	|_____|	     ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[ o|       |o	     ]");
            Console.WriteLine("[  |_______|	     ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[  o                 ]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("Co chcesz zrobić z lodówką?");
            Console.WriteLine("2.Otworzyc zamrazarke");
            Console.WriteLine("3.Otworzyc oba");
            Console.WriteLine("4.Zamknac wszystko");
            Console.WriteLine("5.Wrocic do okna wyboru przedmiotu");
            char wyborLod = Console.ReadKey().KeyChar;

                switch (wyborLod)
            {
                case '2':
                    OtworzZamrazarke();
                    break;
                case '3':
                    OtworzOba();
                    break;
                case '4':
                    RysujLodowka();
                    break;
                    case '5':
                        Program.Main();
                        break;
                    default:
                    Console.Clear();
                    powrot2 = false;
                    break;
            }
        } while (powrot2 == false);
        }
        public void OtworzZamrazarke()
        {
            bool powrot2 = false;
            do
            {
                powrot2 = true;
            Console.Clear();
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[  o                 ]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[                    ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[  ==	  ==         ]");
            Console.WriteLine("[ |  |	 |  |	     ]");
            Console.WriteLine("[ |  |	 |  | 	     ]");
            Console.WriteLine("[ |__|	 |__|        ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("Co chcesz zrobić z lodówką?");
            Console.WriteLine("1.Otworzyc lodowke");
            Console.WriteLine("3.Otworzyc oba");
            Console.WriteLine("4.Zamknac wszystko");
            Console.WriteLine("5.Wrocic do okna wyboru przedmiotu");
            char wyborLod = Console.ReadKey().KeyChar;

                switch (wyborLod)
            {
                case '1':
                    OtworzLodowke();
                    break;
                case '3':
                    OtworzOba();
                    break;
                case '4':
                    RysujLodowka();
                    break;
                    case '5':
                        Program.Main();
                        break;
                    default:
                    Console.Clear();
                    powrot2 = false;
                    break;
            }
        } while (powrot2 == false);
        }
        public void OtworzOba()
        {
            bool powrot2 = false;
            do
            {
                powrot2 = true;
            Console.Clear();
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[  ________	 /   ]");
            Console.WriteLine("[  [szynka]	[]   ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[	_____/_	     ]");
            Console.WriteLine("[	|_____|	     ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[ o|       |o	     ]");
            Console.WriteLine("[  |_______|	     ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("[  ==	  ==         ]");
            Console.WriteLine("[ |  |	 |  |	     ]");
            Console.WriteLine("[ |  |	 |  | 	     ]");
            Console.WriteLine("[ |__|	 |__|        ]");
            Console.WriteLine("[--------------------]");
            Console.WriteLine("Co chcesz zrobić z lodówką?");
            Console.WriteLine("4.Zamknac wszystko");
            Console.WriteLine("5.Wrocic do okna wyboru przedmiotu");
            char wyborLod = Console.ReadKey().KeyChar;

                switch (wyborLod)
            {
              
                case '4':
                    RysujLodowka();
                    break;
                        case '5':                      
                        Program.Main();
                        break;
                default:
                    Console.Clear();
                    powrot2 = false;
                    break;
            }
        } while (powrot2 == false);
        }

    }

    class Lampa
    {
        public void RysujLampa()
        {
            Console.Clear();
            Console.WriteLine(@"                                                      : ");
            Console.WriteLine(@"                                                     _:_");
            Console.WriteLine(@"                                                    /   \");
            Console.WriteLine(@"                                                   /_____\");
            Console.WriteLine(@"                                                     (_)");
            Console.WriteLine(@"                    ");
            Console.WriteLine("");
            Console.WriteLine("1.Włącz");
            Console.WriteLine("2.Wróć do menu");
            char wyborLam = Console.ReadKey().KeyChar;
            switch (wyborLam)
            {
                case '1':
                    LampaWlacz();
                    break;
                case '2':
                    Program.Main();
                    break;
                default:
                    RysujLampa();
                    break;
            }
        }
        public void LampaWlacz()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine(@"                                                      : ");
            Console.WriteLine(@"                                                     _:_");
            Console.WriteLine(@"                                                    /   \");
            Console.WriteLine(@"                                                   /_____\");
            Console.WriteLine(@"                                                     (_)");
            Console.WriteLine(@"                                                        ");
            Console.WriteLine(@"                                                /     |     \  ");
            Console.WriteLine("");
            Console.WriteLine("1.Wyłącz");
            Console.WriteLine("2.Wróć do menu");
            Console.WriteLine("3.Zmień kolor");
            char wyborLam = Console.ReadKey().KeyChar;
            switch (wyborLam)
            {
                case '1':
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    RysujLampa();
                    break;
                case '2':
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Program.Main();
                    break;
                case '3':
                    ZamianaKoloru();
                    break;
                default:
                    LampaWlacz();
                    break;
            }
        }
        public void ZamianaKoloru()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            bool powrot = false;
            do
            {
                powrot = true;
                Console.WriteLine(@"                                                      : ");
                Console.WriteLine(@"                                                     _:_");
                Console.WriteLine(@"                                                    /   \");
                Console.WriteLine(@"                                                   /_____\");
                Console.WriteLine(@"                                                     (_)");
                Console.WriteLine(@"                                                        ");
                Console.WriteLine(@"                                                /     |     \  ");
                Console.WriteLine("");
                Console.WriteLine("1.Wyłącz");
                Console.WriteLine("2.Wróć do menu");
                Console.WriteLine("3.Czerwony");
                Console.WriteLine("4.Niebieski");
                Console.WriteLine("5.Różowy");
                char wyborLam = Console.ReadKey().KeyChar;
                switch (wyborLam)
                {
                    case '1':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        RysujLampa();
                        break;
                    case '2':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Clear();
                        Program.Main();
                        break;
                    case '3':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        powrot = false;
                        break;
                    case '4':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                        powrot = false;
                        break;
                    case '5':
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Clear();
                        powrot = false;
                        break;
                    default:
                        Console.Clear();
                        powrot = false;
                        break;
                }
            } while (powrot == false);
        }
    }

}
