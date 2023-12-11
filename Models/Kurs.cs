﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kursach_ind_4kurs
{
    public partial class Kurs
    {
        public Kurs()
        {
            Deal = new HashSet<Deal>();
        }

        public string ValutaName { get; set; }
        public int Kurs1 { get; set; }
        public int IdValuta { get; set; }

        public virtual ICollection<Deal> Deal { get; set; }
    }
}
