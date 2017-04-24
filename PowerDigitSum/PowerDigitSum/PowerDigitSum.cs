using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerDigitSum
{
    public class PowerDigitSum
    {
        public double power(int a,int b)
        {
            double powerr = 1;
            for (int i = 1; i <= b; i++)
            {
                powerr = powerr * a;
            }
            return powerr;
        }
        public double powerdigitsum(int x)
        {
            double sum = 0;
            string q = x.ToString();
            int p = q.Length;

            for (int i = 0; i < p; i++)
            {

               sum = sum + (q[i]);
                Console.WriteLine(q[i]);
            }


            return sum;
        }
    }
}
