using System;
using System.Collections.Generic;
using System.IO;

namespace Feladat_03
{
    class Program
    {
        static List<csoport> csoportlisat = new List<csoport>();
        static void Main(string[] args)
        {
            Beolvasas();
            Megoldasok();
            
        }

        static void Beolvasas()
        {
            string gyujto = "";
            int fo = 0;
            using (StreamReader sr = new StreamReader("feladat3.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine();
                    if (str.Equals(""))
                    {
                        csoport cs = new csoport(gyujto, fo);
                        csoportlisat.Add(cs);
                        gyujto = "";
                        fo = 0;
                    }
                    else if(sr.Peek() == -1)
                    {
                        csoport cs = new csoport(gyujto, fo);
                        csoportlisat.Add(cs);
                    }
                    else
                    {
                        gyujto += str;
                        fo++;
                    }

                }
            }
        }

        static void Megoldasok()
        {
            int db = 0;
            int mindigen = 0;
            foreach (csoport item in csoportlisat)
            {
                mindigen = 0;
                db = 0;
                for (int i = 0; i < item.Pontok.Length; i++)
                {
                    if (item.Pontok[i] > 0)
                        db++;
                    if (item.Pontok[i] == item.fo)
                        mindigen++;
                    ;
                }
                Console.WriteLine(item.csoportszam + ". csoportban ennyien kérdésre válaszolt legalább egyvalaki: " + db);

                Console.WriteLine("Továbbá a csoporton belül enyi válaszra adott mindenki igen válast: " + mindigen + "\n");


            }
        }
    }
}
