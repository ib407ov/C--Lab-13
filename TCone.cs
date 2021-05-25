using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class TCone
    {
        private double R1;
        public double r1
        {
            get { return R1; }
            set
            {
                if (value >= 0) R1 = value;
            }
        }

        private double R2;
        public double r2
        {
            get { return R2; }
            set
            {
                if (value > 0) R2 = value;
            }
        }
        public TCone(double r1, double r2)
        {
            R1 = r1;
            R2 = r2;
        }
        public TCone(double s):this(s,0)
        {
        }

        public TCone():this(0,0)
        { 
        }

        public TCone(string s1, string s2)
        {
            if(s1 == "")
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

        public TCone(TCone m)
        {
            this.R1 = m.R1;
            this.R2 = m.R2;
        }

        public double[] lenght()
        {
            double[] arr = new double[2];
            arr[0] = 2 * Math.PI * R1;
            arr[1] = 2 * Math.PI * R2;

            return arr;
        }

        public double[] Radius()
        {
            double[] arr = new double[2];
            arr[0] = Math.Pow(R1, 2) * Math.PI;
            arr[1] = Math.Pow(R2, 2) * Math.PI;

            return arr;
        }

        public double comprasion()
        {
            double[] arr = new double[2];
            arr = Radius();
            double result = Math.Abs(arr[0] - arr[1]);

            return result;
        }

        public static TCone operator +(TCone fr, TCone sc)
        {
            return new TCone(fr.R1 + sc.R2); 
        }
        public static TCone operator -(TCone fr, TCone sc)
        {
            return new TCone(fr.R1 - sc.R2);
        }
        public static TCone operator *(TCone fr, TCone sc)
        {
            return new TCone(fr.R1 * sc.R2);
        }
    }
}
