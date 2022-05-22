using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Calculations
    {
        public const double EpsilonD = 0.001;
        public static bool EqualTo(double value1, double value2)
        {
            return Math.Abs(value1 - value2) < EpsilonD;
        }
    }
}
