using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPR_Seminarska_Popravljena
{
    internal class Avto
    {
        public string znamka { get; set; }
        public int starost { get; set; }
        public int cena { get; set; }

        public Avto()
        {
            znamka = "Neznano";
            starost = 0;
            cena = 0;
        }
        public Avto(string _znamka, int _letnik, int _cena)
        {
            znamka = _znamka;
            starost = _letnik;
            cena = _cena;
        }

        ~Avto() { }
    }
}
