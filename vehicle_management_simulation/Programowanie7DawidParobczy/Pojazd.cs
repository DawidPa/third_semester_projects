using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie7DawidParobczy
{
    //klasa bazowa Pojazd

    //przerobić klase bazową na abstrakcyjną, przez to nie mogę utworzyć instancji tej klasy gdziekoliwek indziej, musi być przynajmniej jedna metoda abstrakcyjna
    abstract class Pojazd
    {

        //zmienne w klasie bazowej
        public int predkosc { get; set;}
        public string kolor { get; set; }
        public string stan { get; set; }

        //metoda abstrakcyjna związana z przemieszczeniem się pojazdów
        public abstract void Jazda();
        
        
    }
    
    //interfejs naprawy pojazdu
    interface INaprawa
    {
        void Naprawa();
    }
}
