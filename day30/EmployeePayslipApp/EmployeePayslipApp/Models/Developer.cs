using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    class Developer : Employee

    {
        private double _performanceAllowance;

        public Developer(double BasicSalary) : base(BasicSalary)
        {
            _performanceAllowance = 0.4 * BasicSalary;
        }

     

        public override string EmployeeType()
        {
            return "Developer";
        }

        public override string GetDetails()
        {
            return $"Performance Allowance: {PerformanceAllowance}";
        }

        public double PerformanceAllowance
        {
            get { return _performanceAllowance; }

        }
    }
}