using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPR_Seminarska_Popravljena
{
    internal class Enote
    {
        private readonly string _defaultDolzina = "km";
        private readonly string _defaultCena = "€";
        private readonly string _defaultMoc = "kW";

        private string _enotaDolzine;
        private string _enotaMoci;
        private string _enotaCene;

        public string enotaDolzine
        {
            get { return _enotaDolzine; }
            set
            {
                if (value == "km" || value == "mile")
                {
                    _enotaDolzine = value;
                }
                else
                {
                    _enotaDolzine = _defaultDolzina;
                }
            }
        }
        public string enotaMoci
        {
            get { return _enotaMoci; }
            set
            {
                if (value == "kW" || value == "Hp")
                {
                    _enotaMoci = value;
                }
                else
                {
                    _enotaMoci = _defaultMoc;
                }
            }
        }
        public string enotaCene
        {
            get { return _enotaCene; }
            set
            {
                if (value == "€" || value == "$")
                {
                    _enotaCene = value;
                }
                else
                {
                    _enotaCene = _defaultCena;
                }
            }
        }
    }
}
