using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_03
{
    class csoport
    {
        private static int szamozas = 1;
        
        public int csoportszam { get; private set; }
        public int fo { get; private  set; }
        private int[] pontok = new int[26];
        public int[] Pontok { get => pontok; }

        public csoport(string s,int f)
        {
            char[] charArr = s.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                char a = charArr[i];
                if((int)a >= 97 && (int)a <= 122)
                {
                    pontok[((int)a - 97)]++;
                }
            }
            csoportszam = szamozas;
            szamozas++;
            fo = f;
        }
    }
}
