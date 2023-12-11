﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kursach_ind_4kurs
{
    public partial class Deposits
    {
        public int DepositId { get; set; }
        public string DepositName { get; set; }
        public int DepositTerm { get; set; }
        public double DepositPrecent { get; set; }
        public int DealId { get; set; }
        public string CodeDepositType { get; set; }
        public decimal? SumDeposits { get; set; }

        public virtual DepositType CodeDepositTypeNavigation { get; set; }
        public virtual Deal Deal { get; set; }
    }
}
