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
    public partial class KursF : Form
    {
        public KursF()
        {
            InitializeComponent();
            Initdatagrid(); 
        }

        private void Initdatagrid()
        {
            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView2.DataSource = dbContext.Kurs.Select(x => new KursResponce
                {
                    IdValuta = x.IdValuta,
                    ValutaName = x.ValutaName,
                    Kurs1 = x.Kurs1,
                  

                }).ToList();

            }
        }

        private void AdBnt_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {

                Kurs client = new Kurs
                {
                    Kurs1 = Convert.ToInt32(Kurs.Text),
                    ValutaName = Name_valuta.Text,


                 };

                dataGridView2.DataSource = db.Kurs.Add(client);
                db.SaveChanges();
                Initdatagrid();

            }


          




        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (KursResponce)dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Kurs.FirstOrDefault(x => x.IdValuta == id.IdValuta);



                editclient.ValutaName = Name_valuta.Text;
                editclient.Kurs1 = Convert.ToInt32(Kurs.Text);
              
                

              
                db.Kurs.Remove(editclient);
                db.SaveChanges();

                Initdatagrid();




            }


         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = int.Parse(dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[2].Value.ToString());
                var editclient = db.Kurs.FirstOrDefault(x => x.IdValuta == id);


                editclient.ValutaName = Name_valuta.Text;
                editclient.Kurs1 = Convert.ToInt32(Kurs.Text);
            
                dataGridView2.DataSource = db.Kurs.Update(editclient);
                db.SaveChanges();

                Initdatagrid();

            }


        
        }

        private void Cleare_btn_Click(object sender, EventArgs e)
        {
            Kurs.Clear();
            Name_valuta.Clear();
          
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView2.SelectedRows[0];
            Kurs.Text = dr.Cells[1].Value.ToString();
            Name_valuta.Text = dr.Cells[0].Value.ToString();
        }
    }
}
