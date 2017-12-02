using System;
using System.Collections.Generic;

namespace DatabaseFirstMany2Many.EfDbFirstMany2ManyModels
{
    public partial class EmployeeProject
    {
        public int EmployeeId { get; set; }
        public int ProlectId { get; set; }

        public Employee Employee { get; set; }
        public Project Prolect { get; set; }
    }
}
