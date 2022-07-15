using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPFCalculator.Services.Interfaces
{
    public interface IDetailedCalculator
    {
        public string DetailedTaxCalculation(decimal revenue);
    }
}
