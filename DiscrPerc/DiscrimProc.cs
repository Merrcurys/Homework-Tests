using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscrPerc
{
    public class DiscrimProc
    {
        public static double[] GetQuadEquat(double a, double b, double c)
        {
            var discriminant = b*b - 4 * a * c;

            if (discriminant < 0)
                return new double[] { double.NaN, double.NaN };

            var root = (-b + Math.Sqrt(discriminant)) / (2 * a);

            return discriminant == 0
                ? new double[] { root, root }
                : new double[] { root, (-b - Math.Sqrt(discriminant)) / (2 * a) };
        }

        public static double CalculPercent(double num, double perc) => (num * perc) / 100;
    }
}
