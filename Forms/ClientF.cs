using Kursach_ind_4kurs.BD;
using Kursach_ind_4kurs.Models;
using Kursach_ind_4kurs.ModelsResponce;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Kursach_ind_4kurs.Forms
{



    public partial class ClientF : Form
    {
       
    

        public ClientF()
        {

            InitializeComponent();

               Initdatagrid();

        }

        private void Initdatagrid()
        {
            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Client.Select(x => new ClientResponce
                {
                    IdClient = x.IdClient,
                    FioClient = x.FioClient,
                    AddressClient = x.AddressClient,
                    PhoneClient = x.PhoneClient,
                    MailClient = x.MailClient,
                    PassClient = x.PassClient
                    

                }).ToList();

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

                  db.Client.Add(client);
                    db.SaveChanges();
                Initdatagrid();

            }

        
        }




        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (ClientResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Client.FirstOrDefault(x => x.IdClient == id.IdClient);



                editclient.FioClient = Fio_Client.Text;
                editclient.AddressClient = Adress_Clietn.Text;
                editclient.PhoneClient = Phone_client.Text;
                editclient.MailClient = Mail_client.Text;
                editclient.PassClient = Pass_client.Text;
              

      
                db.Client.Remove(editclient);
                db.SaveChanges();

                Initdatagrid();




            }


        }

    
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            Fio_Client.Text = dr.Cells[1].Value.ToString();
            Adress_Clietn.Text = dr.Cells[2].Value.ToString();
            Phone_client.Text = dr.Cells[3].Value.ToString();
            Mail_client.Text = dr.Cells[4].Value.ToString();
            Pass_client.Text = dr.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (ClientResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Client.FirstOrDefault(x => x.IdClient == id.IdClient);



                editclient.FioClient = Fio_Client.Text;
                editclient.AddressClient = Adress_Clietn.Text;
                editclient.PhoneClient = Phone_client.Text;
                editclient.MailClient = Mail_client.Text;
                editclient.PassClient = Pass_client.Text;



                db.Client.Update(editclient);
                db.SaveChanges();

                Initdatagrid();



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