using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizza
{
    class Fråga
    {
        public string Frågan;
        public string svar1;
        public string svar2;
        public string svar3;
        public string svar4;
        public int rättsvar;

        public Fråga(string _frågan, string _svar1, string _svar2, string _svar3, string _svar4, int _rättsvar)
        {
            Frågan = _frågan;
            svar1 = _svar1;
            svar2 = _svar2;
            svar3 = _svar3;
            svar4 = _svar4;
            rättsvar = _rättsvar;
        }
        public Fråga()
        {

        }
        
    

        public string ToFile()
        {
            return Frågan + "#" + svar1 + "#" + svar2 + "#" + svar3 + "#" + svar4 + "#" + rättsvar;
        }

    }
}
