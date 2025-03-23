using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XAML_podstawy_sb1.Klasy
{

    [XmlRoot("uczestnicy")]
    public class Uczestnicy
    {

        [XmlElement("osoba")]
        public List<Osoba> listaOsob = new List<Osoba>();
    }
}
