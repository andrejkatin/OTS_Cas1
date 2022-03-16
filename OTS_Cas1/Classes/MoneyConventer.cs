using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Cas1
{
    public class MoneyConventer : IConvert
    {
        public double Convert(double value)
        {
            return value * 117.55;
        }

        public double ConvertArray(string array)
        {
            string[] values = array.Split(',');

            double number = 0;
            for (int i = 0; i < values.Length - 1; i++)
            {
                number += Double.Parse(values[i]);
            }

            return Convert(number);
        }
    }
}
