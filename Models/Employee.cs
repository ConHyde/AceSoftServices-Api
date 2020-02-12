using System;
using System.Collections.Generic;

namespace AceSoftServices_Api.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Driver = new HashSet<Driver>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Disabled { get; set; }
        public int? LoginId { get; set; }

        public virtual ICollection<Driver> Driver { get; set; }
    }
}
