using System.Xml;
using static System.Console;

namespace IDP_assg_3
{
    internal class Program
    {
        public class Grundämne
        {
            public string namn = "";
            public double Z = 0, smältpunkt = 0, kokpunkt = 0;
            public bool typ;
            public Grundämne(string namn, double atomnummer, bool isMetall, double smältpunkt, double kokpunkt) 
            { 
                this.namn = namn;
                this.Z = atomnummer;
                this.typ = isMetall;
                this.smältpunkt = smältpunkt;
                this.kokpunkt=kokpunkt;
            }
            public static void Print(Grundämne e)
            {
                string typ = "okänt";
                if (e.typ == true)
                    typ = "metall";
                else if (e.typ == false)
                    typ = "ickemetall";

                WriteLine($"Grundämne: {e.namn} \n  Typ: {typ} \n  Smältpunkt: {e.smältpunkt} K \n  Kokpunkt: {e.kokpunkt} K\n");
            }
        }
        static void Main(string[] args)
        {
            Grundämne syre = new Grundämne("syre", 8, false, 54.36, 90.188);
            Grundämne järn = new Grundämne("järn", 26, true, 1811.0, 3134.0);
            Grundämne guld = new Grundämne("guld", 79, true, 1337.33, 3243.0);

            Grundämne.Print(syre);
            Grundämne.Print(järn);
            Grundämne.Print(guld);

            Grundämne[] grundämnen = { syre, järn, guld, new Grundämne("väte", 1, false, 13.99, 20.271), new Grundämne("brom", 35, false, 265.8, 332.0), new Grundämne("kvicksilver", 80, true, 234.3210, 629.88) };

    //skriver ut grundämnen med namn
            WriteLine("Alla listade grundämnen:");
            foreach (Grundämne g in grundämnen) { WriteLine(g.namn); }

        }
    }
}