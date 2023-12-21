using Kursach_ind_4kurs.BD;
using Kursach_ind_4kurs.Models;
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
    public partial class DepositF : Form
    {
        public DepositF()
        {
            InitializeComponent();
            Initdatagrid();

        }

        private void Initdatagrid()
        {
            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Deposits.Select(x => new DepositsResponce
                {
                    DepositId = x.DepositId,
                    DepositName = x.DepositName,
                    DepositTerm = x.DepositTerm,
                    DepositPrecent = x.DepositPrecent,
                    DealId = x.DealId,
                    CodeDepositType = x.CodeDepositType,
                    SumDeposits = x.SumDeposits,


                }).ToList();

            }
        }

        private void AdBtn_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {

                Deposits deposits = new Deposits
                {
                    DepositName = Name_depos.Text,
                    DepositTerm = Convert.ToInt32( Term_depos.Text),
                   DepositPrecent =Convert.ToDouble( Precent_depos.Text),
                    DealId =Convert.ToInt32( Id_deal.Text), 
                    CodeDepositType = Type_deposit.Text ,
                    SumDeposits=Convert.ToDecimal(Sum_deposit.Text)
                
                };

                db.Deposits.Add(deposits);
                db.SaveChanges();
                Initdatagrid();

            }


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name_depos.Clear();
            Term_depos.Clear();
            Precent_depos.Clear();
            Id_deal.Clear();    
            Type_deposit.Clear ();
            Sum_deposit.Clear();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            Name_depos.Text = dr.Cells[1].Value.ToString();
            Term_depos.Text = dr.Cells[2].Value.ToString();
            Precent_depos.Text = dr.Cells[3].Value.ToString();
            Id_deal.Text = dr.Cells[4].Value.ToString();
            Type_deposit.Text = dr.Cells[5].Value.ToString();
            Sum_deposit.Text = dr.Cells[6].Value.ToString();

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (DepositsResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Deposits.FirstOrDefault(x => x.DepositId == id.DepositId);



                editclient.DepositName = Name_depos.Text;
                editclient.DepositTerm = Convert.ToInt32(Term_depos.Text);
                editclient.DepositPrecent = Convert.ToInt32(Precent_depos.Text); 
                editclient.DealId = Convert.ToInt32(Id_deal.Text); 
                editclient.CodeDepositType = Type_deposit.Text;
                editclient.SumDeposits = Convert.ToInt32(Sum_deposit.Text);

              
                db.Deposits.Remove(editclient);
                db.SaveChanges();

                Initdatagrid();



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (DepositsResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Deposits.FirstOrDefault(x => x.DepositId == id.DepositId);



                editclient.DepositName = Name_depos.Text;
                editclient.DepositTerm = Convert.ToInt32(Term_depos.Text);
                editclient.DepositPrecent = Convert.ToInt32(Precent_depos.Text);
                editclient.DealId = Convert.ToInt32(Id_deal.Text);
                editclient.CodeDepositType = Type_deposit.Text;
                editclient.SumDeposits = Convert.ToDecimal(Sum_deposit.Text);


                db.Deposits.Update(editclient);
                db.SaveChanges();

                Initdatagrid();



            }

        }
    }
}
