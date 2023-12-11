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
    public partial class KursF : Form
    {
        public KursF()
        {
            InitializeComponent();


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Kurs.ToList();

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

                dataGridView1.DataSource = db.Kurs.Add(client);
                db.SaveChanges();

            }


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Kurs.ToList();

            }




        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString());
                var editclient = db.Kurs.FirstOrDefault(x => x.IdValuta == id);




                dataGridView1.DataSource = db.Kurs.Remove(editclient);
                db.SaveChanges();




            }


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Kurs.ToList();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString());
                var editclient = db.Kurs.FirstOrDefault(x => x.IdValuta == id);


                editclient.ValutaName = Name_valuta.Text;
                editclient.Kurs1 = Convert.ToInt32(Kurs.Text);
            
                dataGridView1.DataSource = db.Kurs.Update(editclient);
                db.SaveChanges();



            }


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Kurs.ToList();

            }
        }

        private void Cleare_btn_Click(object sender, EventArgs e)
        {
            Kurs.Clear();
            Name_valuta.Clear();
          
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            Kurs.Text = dr.Cells[1].Value.ToString();
            Name_valuta.Text = dr.Cells[2].Value.ToString();
        }
    }
}
