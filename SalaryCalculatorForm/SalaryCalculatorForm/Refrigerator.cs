using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorForm
{
    class Refrigerator
    {
        public double MaximumWeight { set; get; }
        public List<double> TotalWeights { set; get; }

        public Refrigerator()
        {
            TotalWeights = new List<double>();            
        }

        public double GetCurrentWeight(double totalWeight)
        {
            TotalWeights.Add(totalWeight);
            return TotalWeights.Sum();
        }

        public double GetRemainingWeight()
        {
            return MaximumWeight - TotalWeights.Sum();
        }
    }
}
