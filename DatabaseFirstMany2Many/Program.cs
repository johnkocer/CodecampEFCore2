using DatabaseFirstMany2Many.EfDbFirstMany2ManyModels;
using SharedClassLibrary;
using System;
using System.Linq;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
         EmployeeEfCodeFirstMany2ManyDBContext context = new EmployeeEfCodeFirstMany2ManyDBContext();
         var employees = context.Employee.ToList();
         DDebug.LogDirConsole("Employee List: ", employees);
      }
    }
}
