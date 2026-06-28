using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPR_Seminarska_Popravljena
{
    internal class MotorVozila
    {

        private string _postavitev;
        private int _cenaOkvirja;
        private int _stCelindrov;
        private int _prostornina;
        private int _cenaCilindrov;

        public string postavitev
        {
            get { return _postavitev; }
            set
            {
                if (value == "V" || value == "I" || value == "Boxer" || value == "X" || value == "W")
                {
                    _postavitev = value;
                }
            }
        }
        public int cenaOkvirja
        {
            get { return _cenaOkvirja; }
            set
            {
                if ( value >= 0 )
                {
                    _cenaOkvirja = value;
                }
                else
                {
                    _cenaOkvirja = 0;
                }
            }
        }
        public int stCelindrov
        {
            get { return _stCelindrov; }
            set
            {
                if ( value >= 0 )
                {
                    _stCelindrov = value;
                }
                else
                {
                    _stCelindrov = 0;
                }
            }
        }
        public int prostornina
        {
            get { return _prostornina; }
            set
            {
                if (value >= 0)
                {
                    _prostornina = value;
                }
                else
                {
                    _prostornina = 0;
                }
            }
        }
        public int cenaCilindrov
        {
            get { return _cenaCilindrov; }
            set
            {
                if (value >= 0)
                {
                    _cenaCilindrov = value;
                }
                else
                {
                    _cenaCilindrov = 0;
                }
            }
        }

    }
}
