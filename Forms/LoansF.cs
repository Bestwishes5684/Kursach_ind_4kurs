using Kursach_ind_4kurs.BD;
using Kursach_ind_4kurs.ModelsResponce;
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
            Initdatagrid(); 
        }

        private void Initdatagrid()
        {
            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Loans.Select(x => new LoansResponce
                {
                    IdLoan = x.IdLoan,
                    LoanTerms = x.LoanTerms,
                    LoanPerecent = x.LoanPerecent,
                    IdDeal = x.IdDeal,
                    IdValuta = x.IdValuta,



                }).ToList();

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
            Initdatagrid();


        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
              
                    var id = (LoansResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                    var editclient = db.Loans.FirstOrDefault(x => x.IdLoan == id.IdLoan);

                editclient.LoanTerms = Convert.ToDateTime(Term_Loan.Text);
                editclient.LoanPerecent = Convert.ToDouble(Precent_Loan.Text);
                editclient.IdDeal = Convert.ToInt32(Id_deal.Text);
                editclient.IdValuta = Convert.ToInt32(Id_valuta.Text);


                db.Loans.Remove(editclient);
                    db.SaveChanges();

                    Initdatagrid();


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
                var id = (LoansResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Loans.FirstOrDefault(x => x.IdLoan == id.IdLoan);


                editclient.LoanTerms = Convert.ToDateTime(Term_Loan.Text);
                editclient.LoanPerecent = Convert.ToDouble(Precent_Loan.Text);
                editclient.IdDeal =Convert.ToInt32( Id_deal.Text);
                editclient.IdValuta = Convert.ToInt32(Id_valuta.Text);

                db.Loans.Update(editclient);
                db.SaveChanges();

                Initdatagrid();



            }


         
        }
    }
}
