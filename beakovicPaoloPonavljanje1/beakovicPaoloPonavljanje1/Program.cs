using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaoloPonavljanje1
{
    class Program
    {
        static void Main(string[] args)
        {
            string niz;
            string sVelika;
            string sMala;
            string sPrvaTri;
            string sZadnjihPet = "";
            Console.WriteLine("Upisi niz znakova");
            niz = Console.ReadLine();
            sVelika = niz.ToUpper();
            sMala = niz.ToLower();
            sPrvaTri = niz.Substring(0, 2);

            int duzina = (int)niz.Length - 1;
            if (niz.Length >= 5)
            {
                int poc = (int)niz.Length - 5 - 1;
                sZadnjihPet = niz.Substring(poc, duzina);
            }
            else
            {
                sZadnjihPet = "";
            }
            string s8_11;
            if (niz.Length >= 11)
            {
                s8_11 = niz.Substring(8, 11);
            }
            else
            {
                s8_11 = "";
            }
            string zavrsno = sVelika + "\n" + sMala + "\n" + sPrvaTri + "\n" + sZadnjihPet + "\n" + s8_11;
            Console.WriteLine(zavrsno);
            Console.ReadKey();
        }
    }
}