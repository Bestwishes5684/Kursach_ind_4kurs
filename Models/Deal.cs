using Kursach_ind_4kurs.Models;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kursach_ind_4kurs
{
    public partial class Deal
    {
        public Deal()
        {
            Deposits = new HashSet<Deposits>();
            Loans = new HashSet<Loans>();
        }

        public int IdDeal { get; set; }
        public string FioClient { get; set; }
        public string DealDiscription { get; set; }
        public int? IdEmployee { get; set; }
        public int? ClientId { get; set; }
        public DateTime? DateDeal { get; set; }
        public int? ValutaId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual Kurs Valuta { get; set; }
        public virtual ICollection<Deposits> Deposits { get; set; }
        public virtual ICollection<Loans> Loans { get; set; }
    }
}
