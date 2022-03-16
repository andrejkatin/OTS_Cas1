using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Cas1
{
    public class TimeConventer : ITimeConvert
    {
        public double ConvertHours(double days)
        {
            return days * 24;
        }

        public double ConvertMinutes(double days)
        {
            return days * 24 * 60;
        }

        public double ConvertSeconds(double days)
        {
            double temp = 1;
            for (int i = 0; i < 2; i++)
            {
                temp = temp * 60;
            }
            return days * 24 * temp;
        }
    }
}
