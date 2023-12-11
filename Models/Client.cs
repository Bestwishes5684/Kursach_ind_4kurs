﻿using System;
using System.Collections.Generic;



namespace Kursach_ind_4kurs.Models
{
    public  class Client
    {
        public Client()
        {
            Deal = new HashSet<Deal>();
        }

        public string FioClient { get; set; }
        public string AddressClient { get; set; }
        public string PhoneClient { get; set; }
        public string MailClient { get; set; }
        public string PassClient { get; set; }
        public int IdClient { get; set; }

        public virtual ICollection<Deal> Deal { get; set; }
    }
}
