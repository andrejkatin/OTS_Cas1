using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OTS_Cas1
{
    public class CustomMoneyConventer : ICustomMoneyConvert
    {
        public string ConvertCustomMoney(string value)
        {
            try
            {
                string[] temp = Regex.Split(value, @"\s+");
                string[] temp1 = Regex.Split(temp[0], @"\d+");
                string[] temp2 = Regex.Split(temp[0], @"\D");

                string num = temp2[0];
                string curr1 = temp1[1];
                string curr2 = temp[2];

                if (curr1 == "$")
                {
                    return (Double.Parse(num) * 0.77).ToString();
                }
                else if (curr1 == "€" && curr2 == "£")
                {
                    return (Double.Parse(num) * 0.86).ToString();
                }
                else if (curr1 == "€" && curr2 == "€")
                {

                    return (Double.Parse(num) * 1.13).ToString();
                }
                else if (curr1 == "£")
                {
                    return (Double.Parse(num) * 1.16).ToString();
                }
                else
                {
                    return "Bad input!";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
