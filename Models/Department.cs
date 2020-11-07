using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace EmployeesCh12.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Department")]
        public string Name { get; set; }

        // nav property 
        public virtual ICollection<Employee> Employees { get; set; }

        // nav property
        public ICollection<DepartmentLocation> DepartmentLocation { get; set; }
    }
}
