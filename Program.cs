using System.Xml;
using static System.Console;

namespace IDP_assg_3
{
    internal class Program
    {
        public class Element
        {
            public string namn = "";
            public double Z = 0, smältpunkt = 0, kokpunkt = 0;
            public bool typ;
            public Element(string namn, double atomnummer, bool isMetall, double smältpunkt, double kokpunkt) 
            { 
                this.namn = namn;
                this.Z = atomnummer;
                this.typ = isMetall;
                this.smältpunkt = smältpunkt;
                this.kokpunkt=kokpunkt;
            }
        }
        static void Main(string[] args)
        {
            Element syre = new Element("syre", 8, false, 54.36, 90.188);
            Element järn = new Element("järn", 26, true, 1811.0, 3134.0);
            Element guld = new Element("guld", 79, true, 1137.33, 3243.0);
        }
    }
}