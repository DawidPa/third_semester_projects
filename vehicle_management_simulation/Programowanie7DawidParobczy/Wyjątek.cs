using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie7DawidParobczy
{
    public class Wyjatek : Exception
    {
        public Wyjatek(string wiadomosc) :base(wiadomosc)
        {

        }
    }
}
