using System;
using System.IO;
using System.Windows.Forms;
using Kursach_ind_4kurs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Kursach_ind_4kurs
{
    public  class Bank_indv_zdContext : DbContext
    {
        public Bank_indv_zdContext(DbContextOptions<Bank_indv_zdContext> options)
            : base(options)
        {

      
        }

        public  DbSet<Client> Client { get; set; }
        public  DbSet<Deal> Deal { get; set; }
        public  DbSet<DepositType> DepositType { get; set; }
        public DbSet<Deposits> Deposits { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        public DbSet<Loans> Loans { get; set; }
 

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(x => x.IdClient);
            modelBuilder.Entity<Deal>().HasKey(x => x.IdDeal);
            modelBuilder.Entity<DepositType>().HasKey(x => x.DepositType1);
            modelBuilder.Entity<Deposits>().HasKey(x => x.DepositId);
            modelBuilder.Entity<Employee>().HasKey(x => x.IdEmployee);
            modelBuilder.Entity<Kurs>().HasKey(x => x.IdValuta);
            modelBuilder.Entity<Loans>().HasKey(x => x.IdLoan);


            modelBuilder.Entity<Client>(x => 
            {
                //x.HasKey(y => y.IdClient);
                //x.HasMany(y => y.Deal).WithOne(y => y.Client).HasForeignKey(y => y.ClientId);
                


            });

        }


    }
}
