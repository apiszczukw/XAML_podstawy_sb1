using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAML_podstawy_sb1.Klasy
{
    public class Osoba
    {
        public string Imie;

        public string Nazwisko;

        public override string ToString()
        {
            return $"Cześć {Imie} {Nazwisko}! 😊🥑";
        }
    }
}
