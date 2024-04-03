using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ome_work
{
    internal class Square1
    {
        public double calculteSquareArea(double A)
        {
            double result = Math.Pow(A, 2);
            return result;
        }
        public double calculateSquarePerimetr(double A)
        {
            double result = 4 * A;
            return result;
        }

    }
}
