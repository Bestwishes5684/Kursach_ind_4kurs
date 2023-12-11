using Kursach_ind_4kurs.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_ind_4kurs.Forms
{
    public partial class LoansF : Form
    {
        public LoansF()
        {
            InitializeComponent();
            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Loans.ToList();

            }
        }

        private void AdBtn_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {

                Loans client = new Loans
                {
                    LoanTerms =Convert.ToDateTime( Term_Loan.Text),
                    LoanPerecent =Convert.ToDouble( Precent_Loan.Text),
                    IdDeal = Convert.ToInt32(Id_deal.Text),
                    IdValuta = Convert.ToInt32(Id_valuta.Text),
                  
                };

                dataGridView1.DataSource = db.Loans.Add(client);
                db.SaveChanges();

            }


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Loans.ToList();

            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                var editclient = db.Loans.FirstOrDefault(x => x.IdLoan == id);




                dataGridView1.DataSource = db.Loans.Remove(editclient);
                db.SaveChanges();




            }


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Loans.ToList();

            }

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            Term_Loan.Text = dr.Cells[1].Value.ToString();
            Precent_Loan.Text = dr.Cells[2].Value.ToString();
            Id_deal.Text = dr.Cells[3].Value.ToString();
            Id_valuta.Text = dr.Cells[4].Value.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                var editclient = db.Loans.FirstOrDefault(x => x.IdLoan == id);


                editclient.LoanTerms = Convert.ToDateTime(Term_Loan.Text);
                editclient.LoanPerecent = Convert.ToDouble(Precent_Loan.Text);
                editclient.IdDeal =Convert.ToInt32( Id_deal.Text);
                editclient.IdValuta = Convert.ToInt32(Id_valuta.Text);       
                dataGridView1.DataSource = db.Loans.Update(editclient);
                db.SaveChanges();



            }


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Loans.ToList();

            }
        }
    }
}
