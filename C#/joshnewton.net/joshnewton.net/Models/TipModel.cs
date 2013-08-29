using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace joshnewton.net.Models
{
    public class TipMatrix
    {
        public double Tip1 { get; set; }
        public double Total1 { get; set; }
        public double Tip2 { get; set; }
        public double Total2 { get; set; }
        public double Tip3 { get; set; }
        public double Total3 { get; set; }
        public double Tip4 { get; set; }
        public double Total4 { get; set; }
        public double BillAmount
        {
            get;
            set;
        }

        public TipMatrix(double p)
        {
            // TODO: Complete member initialization
            BillAmount = p;
            Tip1 = p * .1;
            Tip2 = p * .15;
            Tip3 = p * .2;
            Tip4 = p * .25;
            Total1 = p * 1.1;
            Total2 = p * 1.15;
            Total3 = p * 1.2;
            Total4 = p * 1.25;
        }
        public TipMatrix()
        {

        }
    }
}