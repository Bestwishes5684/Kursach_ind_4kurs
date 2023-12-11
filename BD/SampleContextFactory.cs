using Microsoft.EntityFrameworkCore.Design;

using System.Windows.Forms;

namespace Kursach_ind_4kurs.BD
{
    internal class SampleContextFactory: IDesignTimeDbContextFactory<Bank_indv_zdContext>
    {
        public Bank_indv_zdContext CreateDbContext(string[] args)
     => new Bank_indv_zdContext(DataBaseHelper.Option());
    }
}
