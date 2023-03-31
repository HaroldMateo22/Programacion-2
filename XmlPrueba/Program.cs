using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace WorkingWithXL
{
    class Program
    {

        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"C:\Users\epsi.ESTUDIANTE\Documents\FuryProyects\XmlPrueba\bin\Debug\net6.0\Resources\Read.xml");
            UsingXmlReader(path);
        }

        private static void UsingXmlReader(string path)
        {
            XmlReader xmlReader = XmlReader.Create(path);

            while(xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "project"))
                {
                    if(xmlReader.HasAttributes)
                    {
                        Console.WriteLine(xmlReader.GetAttribute("name") + " : " + xmlReader.GetAttribute("launch"));
                    }
                }
                else if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "edition"))
                {
                    if(xmlReader.HasAttributes)
                    {
                        Console.WriteLine(xmlReader.GetAttribute("language"));
                    }
                }
            }
            Console.ReadKey();
        }
    }

}