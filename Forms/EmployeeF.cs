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
    public partial class EmployeeF : Form
    {
        public EmployeeF()  
        {
            InitializeComponent();



            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Employee.ToList();

            }


        }

        private void Pass_client_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeF_Load(object sender, EventArgs e)
        {

        }

        private void AdBtn_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {

                Employee employee = new Employee 
                {
                    
                    FioEmployee = Fio_Employe.Text,
                    AgeEmployee = Convert.ToInt32(Age_empl.Text), 
                    AddressEmployee = adress_empl.Text, 
                    TelephoneEmployee = Phone_empl.Text ,
                    PassportEmployee=Pass_Empl.Text,
                    PostEmployee=Post_empl.Text,
                    SalaryEmploee= Convert.ToInt32(salary_empl.Text)


                };

                dataGridView1.DataSource = db.Employee.Add(employee);
                db.SaveChanges();
                using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
                {


                    dataGridView1.DataSource = dbContext.Employee.ToList();

                }
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                var employee = db.Employee.FirstOrDefault(x => x.IdEmployee == id);




                dataGridView1.DataSource = db.Employee.Remove(employee);
                db.SaveChanges();
                using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
                {


                    dataGridView1.DataSource = dbContext.Employee.ToList();

                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fio_Employe.Clear();
            adress_empl.Clear();
            Phone_empl.Clear();
            Age_empl.Clear();
            Pass_Empl.Clear();
            salary_empl.Clear();
            Post_empl.Clear();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            Fio_Employe.Text = dr.Cells[1].Value.ToString();
            Age_empl.Text = dr.Cells[2].Value.ToString();
            adress_empl.Text = dr.Cells[3].Value.ToString();
            Phone_empl.Text = dr.Cells[4].Value.ToString();
            Pass_Empl.Text = dr.Cells[5].Value.ToString();
            Post_empl.Text = dr.Cells[6].Value.ToString();
            salary_empl.Text = dr.Cells[7].Value.ToString();
       
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = int.Parse(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString());
                var editclient = db.Employee.FirstOrDefault(x => x.IdEmployee == id);


                editclient.FioEmployee = Fio_Employe.Text;
                editclient.AgeEmployee = Convert.ToInt32(Age_empl.Text);
                editclient.AddressEmployee = adress_empl.Text;
                editclient.TelephoneEmployee = Phone_empl.Text;
                editclient.PassportEmployee = Pass_Empl.Text;
                editclient.PostEmployee = Post_empl.Text;
                editclient.SalaryEmploee = Convert.ToDecimal(salary_empl.Text);



                dataGridView1.DataSource = db.Employee.Update(editclient);
                db.SaveChanges();
                using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
                {


                    dataGridView1.DataSource = dbContext.Employee.ToList();

                }


            }
        }
    }
}
