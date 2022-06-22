using System;

namespace lab1_Pim
{
    public static class Formuly
    {
        public static double Form1(double m)
        {
            double chis = Math.Sqrt(Math.Pow(3 * m + 2, 2) - 24 * m);
            double znam = (3 * Math.Sqrt(m)) - (2 / Math.Sqrt(m));
            double z = chis / znam;
            return z;
        }

        public static double Form2(double m)
        {
            double z = Math.Sqrt(m) * -1;
            return z;
        }
    }
}
