// ------------------------------------------------------
// Autor: Paul A.
// Erstellung: 18.05.2021
// letzte Aenderung: 18.05.2021
// Beschreibung: Dreiertupel als Wiederholung 
// Datei: auf_wiederholung 17052021
// ------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholungsaufgabe_Dreiertupel
{
    class Dreiertupel
    {
        private double x;
        private double y;
        private double z;

        //Standard-Konstruktor
        public Dreiertupel()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        //Bei der Übergabe von 3 double-Werten werden diese direkt als Attribute gesetzt
        public Dreiertupel(double x1, double x2, double x3)
        {
            x = x1;
            y = x2;
            z = x3;
        }

        //bei der Übergabe von zwei Integer-Werten als untere und obere Grenze werden drei Zufallszahlen aus diesem Intervall gesetzt
        public Dreiertupel(int x1, int x2)
        {
            Random r1 = new Random();
            x = r1.Next(x1, x2);
            y = r1.Next(x1, x2);
            z = r1.Next(x1, x2);
        }

        //bei der Übergabe eines double Wertes werden alle Tupelwerte auf diesen Wert gesetzt
        public Dreiertupel(double x1)
        {
           x = x1;
           y = x1;
           z = x1;
        }
        //Eingabe-Methode
        public void Eingabe()
        {
            Console.Write("Bitte geben Sie den ersten Wert ein: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie den zweiten Wert ein: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Bitte geben Sie den dritten Wert ein: ");
            z = Convert.ToDouble(Console.ReadLine());
        }

        //Ausgabemethode
        public override string ToString()
        {
            string Ausgabe;
            Ausgabe = Convert.ToString(x + " ; " + y + " ; " + z);
            return Ausgabe;

        }

        //Sortierte Ausgabe -Methode
        public String SortierteAusgabe()
        {
            //lokale Variablen
            string Ausgabe = " ";
            //double s1;
            //double s2;
            //double s3;

            if (X > Y)
            {
                if (X > Z)
                {
                    if (Y > Z)
                    {
                        //s1 = z;
                        //s2 = y;
                        //s3 = x;
                        Ausgabe = Convert.ToString(Z + " ; " + Y + " ; " + X);
                    }
                    else
                    {
                        //s1 = y;
                        //s2 = z;
                        //s3 = x;
                        Ausgabe = Convert.ToString(Y + " ; " + Z + " ; " + X);
                        
                    }
                }
                else
                {
                    //s1 = y;
                    //s2 = x;
                    //s3 = z; 
                    Ausgabe = Convert.ToString(Y + " ; " + X + " ; " + Z);
                }
            }
            else
            {
                if (Y > Z)
                {
                    if (X > Z)
                    {
                        //s1 = z;
                        //s2 = x;
                        //s3 = y;
                        Ausgabe = Convert.ToString(Z + " ;" + X + " ; " + Y);
                    }
                    else
                    {
                        //s1 = x;
                        //s2 = z;
                        //s3 = y;
                        Ausgabe = Convert.ToString(X + " ; " + Z + " ; " + Y);
                    }
                }
                else
                {
                    //s1 = x;
                    //s2 = y;
                    //s3 = z;
                    Ausgabe = Convert.ToString(X + " ; " + Y + " ; " + Z);
                }
            }
            return Ausgabe;
        }

        public double Summe()
        {
            double summe;
            summe = (x+y+z) ;
            return summe;
        }

        public double Mittelwert()
        {
            double median;
            median = Summe() / 3;
            return median;
        }

        public double Minimum()
        {
            double min = this.X;
            
            if(this.Y < min)
            {
                min = this.Y;
            }

            if (this.Z < min) ;
            {
                min = this.Z;
            }
            return min;
        }

        public double Maximum()
        {
            double max = this.X;

            if (this.Y > max)
            {
                max = this.Y;
            }

            if (this.Z > max)
            {
                max = this.Z;
            }
            return max;
        }

        public double Spannweite()
        {
            double spannweite;
            spannweite = Maximum() - Minimum();
            return spannweite;
        }

        public double Vektorlänge()
        {
           double vl = Math.Sqrt((x * x) + (y * y) + (z * z));
           return vl;
        }

        

        public Dreiertupel Differenz(Dreiertupel sub)
        {
            Dreiertupel diff = new Dreiertupel(0, 0, 0);
            diff.x = this.x - sub.x;
            diff.y = this.y - sub.y;
            diff.z = this.z - sub.z;
            return diff;
        }

        public double Abstand(Dreiertupel TupelZwei)
        {
            double abstand = Differenz(TupelZwei).Vektorlänge();
            return abstand;
        }

        public bool IstWertVorhanden(double x1)
        {
            bool vorhanden = false;
            if (x1 == x || x1 == y || x1 == z)
            {
                vorhanden = true;
            }
            return vorhanden;

        }

        //Hilfsmethoden get und set
        /*public double getx()
        {
            return x;
        }
        public void setx(double x)
        {
            this.x = x;
        }
        public double gety()
        {
            return y;
        }
        public void sety(double y)
        {
            this.y = y;
        }
        public double getz()
        {
            return z;
        }
        public void setz(double z)
        {
            this.z = z;
        }
     }*/

        //Property-Methoden
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
            }
        }
        
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                this.y = value;
            }
        }

        public  double Z
        {
            get
            {
                return z;
            }
            set
            {
                this.z = value;
            }
        }
}
   
}