using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kursach_ind_4kurs.ModelsResponce
{
    public partial class DepositTypeResponce
    {
      

        public string DepositType1 { get; set; }
        public string NameDeposit { get; set; }
        public string DescriptionDeposit { get; set; }
        public int MinTermDeposit { get; set; }
        public decimal MinSumDeposit { get; set; }
        public double PercentDeposit { get; set; }


    }
}
