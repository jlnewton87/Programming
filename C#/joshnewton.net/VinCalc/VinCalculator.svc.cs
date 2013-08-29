using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VinCalc
{
    public class VinCalculator : IVinCalculator
    {
        public string DecodeVin(string p_Vin)
        {
            return string.Format("You entered: {0}", p_Vin);
        }
    }
}
