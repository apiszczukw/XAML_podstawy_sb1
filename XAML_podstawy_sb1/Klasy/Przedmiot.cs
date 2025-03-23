using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XAML_podstawy_sb1.Klasy
{
    public class Przedmiot
    {
        [XmlAttribute("nazwa")]
        public string Nazwa;

        [XmlAttribute("liczbaGodzin")]
        public int LiczbaGodzin;
    }
}
