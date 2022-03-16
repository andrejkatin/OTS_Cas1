using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Cas1
{
    public interface IConvert
    {
        double Convert(double value);

        double ConvertArray(string array);
    }
}
