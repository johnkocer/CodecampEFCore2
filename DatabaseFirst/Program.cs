using DatabaseFirst.EfDbFirstModels;
using SharedClassLibrary;
using System;
using System.Linq;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
         EfDbFirstModels.EmployeeEfCodeFirstDBContext context = new EmployeeEfCodeFirstDBContext();
         var employees = context.Employee.ToList();
         DDebug.LogDirConsole("Employee List: ", employees);
      }
    }
}
