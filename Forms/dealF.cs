using Kursach_ind_4kurs.BD;
using Kursach_ind_4kurs.Forms;
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
    public partial class dealF : Form
    {
        public dealF()
        {
            InitializeComponent();
            Initdatagrid();
        }

        private void Initdatagrid()
        {
            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Deal.Select(x => new DealResponce
                {
                    IdDeal = x.IdDeal,
                    FioClient = x.FioClient,
                    DealDiscription = x.DealDiscription,
                    IdEmployee = x.IdEmployee,
                    ClientId = x.ClientId,
                    DateDeal = x.DateDeal,
                    ValutaId = x.ValutaId,


                }).ToList();

            }
        }

        private void dealF_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {

                Deal deal = new Deal()
                {
                    FioClient = Fio_client.Text,
                    DealDiscription = Deal_desk.Text,
                    IdEmployee =Convert.ToInt32( Id_employe.Text),
                    ClientId = Convert.ToInt32(Id_client.Text),
                    DateDeal = Convert.ToDateTime( date_deal.Text),
                    ValutaId=Convert.ToInt32(Id_valuta.Text)
                    
                };

               db.Deal.Add(deal);
                db.SaveChanges();
                Initdatagrid();
            }


        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (DealResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Deal.FirstOrDefault(x => x.IdDeal == id.IdDeal);




                db.Deal.Remove(editclient);
                db.SaveChanges();

                Initdatagrid();


            }


        }

        private void Change_Btn_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (DealResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Deal.FirstOrDefault(x => x.IdDeal == id.IdDeal);



                editclient.FioClient = Fio_client.Text;
                editclient.DealDiscription = Deal_desk.Text;
                editclient.IdEmployee = Convert.ToInt32(Id_employe.Text);
                editclient.ClientId = Convert.ToInt32(Id_client.Text);
                editclient.DateDeal = Convert.ToDateTime(date_deal.Text);
                editclient.ValutaId =Convert.ToInt32( Id_valuta.Text);
              db.Deal.Update(editclient);
                db.SaveChanges();

                Initdatagrid();

            }


       
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            Fio_client.Text = dr.Cells[1].Value.ToString();
            Deal_desk.Text = dr.Cells[2].Value.ToString();
            Id_employe.Text = dr.Cells[3].Value.ToString();
            Id_client.Text = dr.Cells[4].Value.ToString();
            date_deal.Text = dr.Cells[5].Value.ToString();
            Id_valuta.Text = dr.Cells[6].Value.ToString();
        }
    }
}
