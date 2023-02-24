using System.Xml;

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

        }
    }
}