using Kursach_ind_4kurs.Models;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kursach_ind_4kurs.ModelsResponce
{
    public partial class DealResponce
    {

        public int IdDeal { get; set; }
        public string FioClient { get; set; }
        public string DealDiscription { get; set; }
        public int? IdEmployee { get; set; }
        public int? ClientId { get; set; }
        public DateTime? DateDeal { get; set; }
        public int? ValutaId { get; set; }

    }
}