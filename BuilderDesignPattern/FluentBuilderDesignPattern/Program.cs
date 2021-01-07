using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = EmployeeBuilderDirector
                .NewEmployee
                .SetName("Hamad")
                .AtPosition("Software Developer")
                .WithSalary(1000)
                .Build();

            Console.WriteLine(employee);
            Console.ReadKey();
        }
    }
}
