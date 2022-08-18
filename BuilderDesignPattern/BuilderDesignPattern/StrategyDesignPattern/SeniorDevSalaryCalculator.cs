using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class SeniorDevSalaryCalculator: ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports)
            =>
                reports
                    .Where(report => report.Level == DeveloperLevel.Senior)
                    .Select(report => report.CalculateSalary() * 1.2)
                    .Sum();
    }
}
