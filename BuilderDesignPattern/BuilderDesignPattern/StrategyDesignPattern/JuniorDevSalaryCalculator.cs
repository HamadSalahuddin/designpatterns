using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    public class JuniorDevSalaryCalculator: ISalaryCalculator
    {
        public double CalculateTotalSalary(IEnumerable<DeveloperReport> reports)
            =>
                reports
                    .Where(report => report.Level == DeveloperLevel.Junior)
                    .Select(report => report.CalculateSalary())
                    .Sum();
    }
}
