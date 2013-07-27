using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinCalc
{
    public static class VinCalcService
    {
        public static string CheckDigit(string p_Vin)
        {
            foreach (char digit in p_Vin.ToCharArray())
            {
                if (digit == p_Vin.ToCharArray()[9] || IsNumeric(digit)) { } //Ignore these cases
                

            }
            return "true";
        }

        private static bool IsNumeric(char digit)
        {
            bool output = true;
            try
            {
                int.Parse(digit);
            }
            catch 
            {
                output = false;
            }
            return output;
        }
    }
}