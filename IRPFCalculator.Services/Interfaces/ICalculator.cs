using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPFCalculator.Services.Interfaces
{
    public interface ICalculator
    {
        public decimal TaxCalculation(decimal revenue);
    }
}
