using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XAML_podstawy_sb1.Klasy
{
    public class Osoba
    {

        [XmlAttribute("imię")]
        public string Imie;

        [XmlAttribute("nazwisko")]
        public string Nazwisko;

        [XmlElement("przedmioty")]
        public List<Przedmiot> Przedmioty;

        public override string ToString()
        {
            return $"Cześć {Imie} {Nazwisko}! 😊🥑";
        }
    }
}
