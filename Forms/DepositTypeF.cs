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
    public partial class DepositTypeF : Form
    {
        public DepositTypeF()
        {
            InitializeComponent();
            Initdatagrid();
        }

        private void Initdatagrid()
        {
            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {



                dataGridView1.DataSource = dbContext.DepositType.Select(x => new DepositTypeResponce
                {
                    DepositType1 = x.DepositType1,
                    NameDeposit = x.NameDeposit,
                    DescriptionDeposit = x.DescriptionDeposit,
                    MinTermDeposit = x.MinTermDeposit,
                    MinSumDeposit = x.MinSumDeposit,
                    PercentDeposit = x.PercentDeposit


                }).ToList();

            }
        }

        private void AdBtn_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {

                DepositType deposit = new DepositType
                { 
                    DepositType1=num_depositT.Text,
                    NameDeposit = Name_depositT.Text,
                    DescriptionDeposit = Desk_depositT.Text,
                    MinTermDeposit = Convert.ToInt32( Min_term_depositT.Text),
                    MinSumDeposit = Convert.ToDecimal(Min_Sum_DepositT.Text),
                    PercentDeposit = Convert.ToDouble(Prec_depositT.Text) 
                };

                dataGridView1.DataSource = db.DepositType.Add(deposit);
                db.SaveChanges();
                Initdatagrid();
            }


       
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (DepositTypeResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.DepositType.FirstOrDefault(x => x.DepositType1 == id.DepositType1);




                dataGridView1.DataSource = db.DepositType.Remove(editclient);
                db.SaveChanges();

                Initdatagrid();


            }


         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (DepositTypeResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.DepositType.FirstOrDefault(x => x.DepositType1 == id.DepositType1);


                editclient.DepositType1 = num_depositT.Text;
                editclient.NameDeposit = Name_depositT.Text;
                editclient.DescriptionDeposit = Desk_depositT.Text;
                editclient.MinTermDeposit = Convert.ToInt32(Min_term_depositT.Text);
                editclient.MinSumDeposit =Convert.ToDecimal(Min_Sum_DepositT.Text);
                editclient.PercentDeposit = Convert.ToDouble(Prec_depositT.Text);

                dataGridView1.DataSource = db.DepositType.Update(editclient);
                db.SaveChanges();



                Initdatagrid();
            }


         
    }

    private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            num_depositT.Text = dr.Cells[0].Value.ToString();
            Name_depositT.Text = dr.Cells[1].Value.ToString();
            Desk_depositT.Text = dr.Cells[2].Value.ToString();
            Min_term_depositT.Text = dr.Cells[3].Value.ToString();
            Min_Sum_DepositT.Text = dr.Cells[4].Value.ToString();
            Prec_depositT.Text = dr.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num_depositT.Clear();
            Name_depositT.Clear();
           Desk_depositT.Clear();
            Min_term_depositT.Clear();
            Min_Sum_DepositT.Clear();
            Prec_depositT.Clear();



        }
    }
}
