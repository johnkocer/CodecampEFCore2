using System;
using System.Collections.Generic;

namespace DatabaseFirstMany2Many.EfDbFirstMany2ManyModels
{
    public partial class Project
    {
        public Project()
        {
            EmployeeProject = new HashSet<EmployeeProject>();
        }

        public int ProlectId { get; set; }
        public decimal Budget { get; set; }
        public string Name { get; set; }

        public ICollection<EmployeeProject> EmployeeProject { get; set; }
    }
}
