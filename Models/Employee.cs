using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kursach_ind_4kurs
{
    public partial class Employee
    {
        public Employee()
        {
            Deal = new HashSet<Deal>();
        }

        public int IdEmployee { get; set; }
        public string FioEmployee { get; set; }
        public int AgeEmployee { get; set; }
        public string AddressEmployee { get; set; }
        public string TelephoneEmployee { get; set; }
        public string PassportEmployee { get; set; }
        public string PostEmployee { get; set; }
        public decimal SalaryEmploee { get; set; }

        public virtual ICollection<Deal> Deal { get; set; }
    }
}
