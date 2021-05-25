using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TSphere:TCone
    {

        private double R1 { get; set; }
        private double R2 { get; set; }
        public TSphere(string s1, string s2)
        {
            if (s1 == "")
            {
                R1 = 0;
            }
            else R1 = Convert.ToDouble(s1);

            if (s2 == "")
            {
                R2 = 0;
            }
            else R2 = Convert.ToDouble(s2);
        }
        public double[] Square()
        {
            double[] arr = new double[2];
            arr[0] = 4 * Math.PI * Math.Pow(R1, 3);
            arr[1] = 4 * Math.PI * Math.Pow(R2, 3);

            return arr;
        }
        public double[] Volume()
        {
            double[] arr = new double[2];
            arr[0] = 4/3 * Math.PI * Math.Pow(R1, 2);
            arr[1] = 4/3 * Math.PI * Math.Pow(R2, 2);

            return arr;
        }
    }
}
