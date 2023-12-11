using Kursach_ind_4kurs.BD;
using Kursach_ind_4kurs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach_ind_4kurs.Forms
{



    public partial class ClientF : Form
    {
        public DbContextOptions<Bank_indv_zdContext> options;
    

        public ClientF()
        {

            InitializeComponent();

            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Client.ToList();

            }

        }



        private void AdBtn_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
               
                    Client client = new Client 
                    {
                        FioClient = Fio_Client.Text,
                         AddressClient = Adress_Clietn.Text, 
                        PhoneClient = Phone_client.Text,
                        MailClient = Mail_client.Text, 
                        PassClient = Pass_client.Text
                    };

                  dataGridView1.DataSource= db.Client.Add(client);
                    db.SaveChanges();
                
            }


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Client.ToList();

            }
        }




        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString());
                var editclient = db.Client.FirstOrDefault(x => x.IdClient == id);



                
                dataGridView1.DataSource = db.Client.Remove(editclient);
                db.SaveChanges();




            }


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Client.ToList();

            }







        }

    
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            Fio_Client.Text = dr.Cells[0].Value.ToString();
            Adress_Clietn.Text = dr.Cells[1].Value.ToString();
            Phone_client.Text = dr.Cells[2].Value.ToString();
            Mail_client.Text = dr.Cells[3].Value.ToString();
            Pass_client.Text = dr.Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var  id = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString());
                var editclient = db.Client.FirstOrDefault(x => x.IdClient==id);


                editclient.FioClient = Fio_Client.Text;
                editclient.AddressClient = Adress_Clietn.Text;
                editclient.PhoneClient = Phone_client.Text;
                editclient.MailClient = Mail_client.Text;
                editclient.PassClient = Pass_client.Text;
                dataGridView1.DataSource = db.Client.Update(editclient);
                db.SaveChanges();
             


            }


            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Client.ToList();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Fio_Client.Clear();
            Adress_Clietn.Clear();
            Phone_client.Clear();
            Mail_client.Clear();
            Pass_client.Clear();


        }
    }
    } 