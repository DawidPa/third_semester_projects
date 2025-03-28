using System;
using System.Text;
namespace Zadanie9ProgramowanieSem3
{
    class Program
    {
        //3. funckja argument to tablica
        static void ArrayFunction(int[] argArray)
        {
            Console.WriteLine(string.Join(" ", argArray));
            Array.Reverse(argArray);
            Console.WriteLine(string.Join(" ", argArray));
        }



        static void Main(string[] args)
        {
           

            //1.lista inicjacyjna

            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };  //tworzenie + wypełnij liste
            Console.WriteLine("Elementy tablicy:");
            for (int i = 0; i < array1.Length; i++) // wyswietlanie tablicy
            {
                Console.WriteLine(array1[i]);
            }
            Console.ReadKey(true);


            //2.Utwórz tablice obiektów do utworzonej klasy
            Console.WriteLine("Podpunkt 2");

            Home[] arrayHome = new Home[2]; // Tablica
            arrayHome[0] = new Home();// Tworzenie obiektów klasy
            arrayHome[1] = new Home();


            //2.zaprezentować dowolne operacje na elementach tablicy
            Console.WriteLine("Wartości atrybutów przed zmianą:");
            Console.WriteLine(String.Join("", arrayHome[1].attribute1));
            Console.WriteLine(String.Join("", arrayHome[1].attribute2));
            Console.ReadKey(true);

            Console.WriteLine("Wartości atrybutów po zmianie:");
            arrayHome[1].attribute1 = 1; //odwołanie do zmiennych obiektu bedącymy elementami tablicy
            arrayHome[1].attribute2 = 2;
            Console.WriteLine(String.Join("", arrayHome[1].attribute1));
            Console.WriteLine(String.Join("", arrayHome[1].attribute2));
            Console.ReadKey(true);


            //3. 

            Console.WriteLine("Podpunkt 3");
            int[] argArray = { 1, 2, 3 }; // tablica
            ArrayFunction(argArray); //wywołanie funkcji

            Console.ReadKey(true);


            //4. przykład zmiennej typu string, utworzonej po dodaniu dwóch tekstów + usunięcie
            Console.WriteLine("Podpunkt 4");
      
            string text1 = "kuchnia";
            string text2 = "salon";
            string text3 = text1 + text2; //typ string po dodaniu dwóch tekstów
            Console.WriteLine(text3);//przykład po  dodaniu dwóch tekstów


          
            string text4 = text3.Replace("sal", "");    
            Console.WriteLine(text4);//przykład po usunięciu fragmentu textu
            Console.ReadKey(true);


            //5.StringBuilder
            Console.WriteLine("Podpunkt 5");
   

            StringBuilder sb = new StringBuilder("Nazywam się string builder"); //obiekt stringbuilder

            Console.WriteLine();
            //5.1
            sb.Append('-', 6);
            Console.WriteLine(sb);

            //5.2
            sb.Insert(0,"------");       
            Console.WriteLine(sb);

            //5.3
            sb.Replace("-","*");
            Console.WriteLine(sb);

            //5.4
            sb.Remove(0,6);
            sb.Remove(26, 6);
            Console.WriteLine(sb);

            
        }
    }
}
