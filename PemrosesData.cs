using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal5_103022300035
{
    class PemrosesData
    {
    public PemrosesData() { }
        public T DapatkanNilaiTerbesar<T>(T a, T b, T c)
        {
            dynamic tempA = a;
            dynamic tempB = b;
            dynamic tempC = c;
            dynamic high = tempA;
            if (tempA < tempB)
            {
                high = tempB;
            }
            if (tempB < tempC)
            {
                high = tempC;
            }
            return high;
        }
    }
}
