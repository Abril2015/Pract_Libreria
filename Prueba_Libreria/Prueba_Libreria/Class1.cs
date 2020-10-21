using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Libreria
{
    public class Mates
    {
        private double a;
        private double b;
        private double c;

        public Mates(double pA, double pB)
        {
            a = pA;
            b = pB;
            c = 0;
        }
         public double C { get { return c; } }

        public double suma()
        {
            c = a + b;
            return c;
        }

        public double resta()
        {
            c = a - b;
            return c;
        }
    }
}
