using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorForm
{
    class SalaryClass
    {
        
        public string Name { set; get; }
        public double BasicSalary { set; get; }
        public double HouseRent { set; get; }
        public double MedicalAllowance { set; get; }
        public double TotalSalary { set; get; }

        
        public double GetHouseRent()
        {
            HouseRent = (HouseRent * BasicSalary) / 100;
            return HouseRent;
        }
        public double GetMedialAllowance()
        {
            MedicalAllowance = (MedicalAllowance * BasicSalary) / 100;
            return MedicalAllowance;
        }
        public double GetTotalSalary()
        {
            TotalSalary = BasicSalary + GetHouseRent() + GetMedialAllowance();
            return TotalSalary;
        }
    }
}
