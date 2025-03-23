using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XAML_podstawy_sb1
{
    public class XmlHelper
    {
        public static void SerializeToXml<T>(T obj, string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));

            using(var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }
    }
}
