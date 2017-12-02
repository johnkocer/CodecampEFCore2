using DatabaseFirstOne2One.EfDbFirstOne2OneModels;
using SharedClassLibrary;
using System;
using System.Linq;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
         EmployeeEfCodeFirstOne2OneDBContext context = new EmployeeEfCodeFirstOne2OneDBContext();
         var employees = context.Employee.ToList();
         DDebug.LogDirConsole("Employee List: ", employees);
      }
    }
}
