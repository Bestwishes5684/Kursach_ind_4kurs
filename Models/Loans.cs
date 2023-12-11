using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kursach_ind_4kurs
{
    public partial class Loans
    {
        public int IdLoan { get; set; }
        public DateTime LoanTerms { get; set; }
        public double LoanPerecent { get; set; }
        public int IdDeal { get; set; }
        public int IdValuta { get; set; }

        public virtual Deal IdDealNavigation { get; set; }
    }
}
