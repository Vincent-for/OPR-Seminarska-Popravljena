using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPR_Seminarska_Popravljena
{
    public class Kalkulator
    {
        public static double razlikaMoci = 0.73;
        public static int ProstorninaNaC(int stC, int prostornina)
        {
            return stC * prostornina;
        }

        public static int Letnik(int leto)
        {
            return DateTime.Now.Year - leto;
        }

        public static int kW(int Hp)
        {
            return (int)(Hp * razlikaMoci);
        }
    }
}