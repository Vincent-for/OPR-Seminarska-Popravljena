using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPR_Seminarska_Popravljena
{

    internal class OsnovniPodatki
    {
        public static string modelVozila = "Avto";
        
        private string _znamka;
        private int _starost;
        private int _cena;

        public string znamka
        {
            get { return _znamka; }
            set
            {
                if (value != "")
                {
                    _znamka = value;
                }
            }
        }
        public int starost
        {
         get { return _starost; }
            set
            {
                if (value >= 0 )
                {
                    _starost = value;
                }
            }
        }
        public int cena
        {
            get { return _cena; }
            set
            {
                if (value >= 0)
                {
                    _cena = value;
                }
            }
        }
    }
}
