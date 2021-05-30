using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholungsaufgabe_Dreiertupel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            /*Dreiertupel d1 = new Dreiertupel();
            d1.Eingabe();
            d1.Ausgabe();
            Console.WriteLine(d1.SortierteAusgabe());
            */

            Dreiertupel d2 = new Dreiertupel();
            d2.X = 12;
            d2.Y = 5;
            d2.Z = 2.75;

            Console.WriteLine("Ausgabe als String: " +d2.ToString());
            Console.WriteLine("Sortierte Ausgabe: "+d2.SortierteAusgabe());
            Console.WriteLine("Mittelwert: "+d2.Mittelwert());
            Console.WriteLine("Minimum: "+d2.Minimum());
            Console.WriteLine("Maximum: "+d2.Maximum());
            Console.WriteLine("Ist der Wert 5 in d2 vorhanden? " +d2.IstWertVorhanden(5));

            Dreiertupel d3 = new Dreiertupel(5.5, 5676.456, 0.11);
            
            Console.WriteLine("Abstand: "+d2.Abstand(d3));
            Console.WriteLine("Differenz: " + d2.Differenz(d3));
            Console.WriteLine("Spannweite: " + d2.Spannweite());
            Console.WriteLine("Summe: "+ d2.Summe());
            Console.WriteLine("Vektorlänge: " +d2.Vektorlänge());



            Console.ReadKey();
        }
    }
}
