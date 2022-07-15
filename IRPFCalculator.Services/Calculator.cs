using IRPFCalculator.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPFCalculator.Services
{
    public class Calculator : ICalculator
    {
        public decimal TaxCalculation(decimal revenue)
        {
            decimal aliquot = 0;
            decimal deduction = 0;

            if (revenue <= 22847.76m)
            {
                aliquot = 0;
                deduction = 0;
            }
            else if (revenue > 22847.76m && revenue <= 33919.80m)
            {
                aliquot = 0.075m;
                deduction = 1713.58m;
            }
            else if (revenue > 33919.8m && revenue <= 45012.6m)
            {
                aliquot = 0.15m;
                deduction = 4257.57m;
            }
            else if (revenue > 45012.60m && revenue <= 55976.16m)
            {
                aliquot = 0.225m;
                deduction = 7633.51m;
            }
            else if (revenue > 55976.16m)
            {
                aliquot = 0.275m;
                deduction = 10432.32m;
            }

            return revenue * aliquot - deduction;
        }
    }
}
