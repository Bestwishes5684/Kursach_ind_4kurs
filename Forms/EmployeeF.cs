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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach_ind_4kurs.Forms
{
    public partial class EmployeeF : Form
    {
        public EmployeeF()
        {
            InitializeComponent();

            Initdatagrid();

        }

        private void Initdatagrid()
        {
            using (var dbContext = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {


                dataGridView1.DataSource = dbContext.Employee.Select(x => new EmployeeResponce
                {
                    IdEmployee  = x.IdEmployee,
                    FioEmployee = x.FioEmployee,
                    AgeEmployee = x.AgeEmployee,
                    AddressEmployee  = x.AddressEmployee,
                    TelephoneEmployee  = x.TelephoneEmployee,
                    PassportEmployee = x.PassportEmployee,
                    PostEmployee = x.PostEmployee,
                    SalaryEmploee = x.SalaryEmploee,

                }).ToList();

            }
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

                 db.Employee.Add(employee);
                db.SaveChanges();
                Initdatagrid();

            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            using (Bank_indv_zdContext db = new Bank_indv_zdContext(DataBaseHelper.Option()))
            {
                var id = (EmployeeResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Employee.FirstOrDefault(x => x.IdEmployee == id.IdEmployee);



               editclient.FioEmployee = Fio_Employe.Text;
                editclient.AgeEmployee = Convert.ToInt32(Age_empl.Text);
                editclient.AddressEmployee = adress_empl.Text;
                editclient.TelephoneEmployee = Phone_empl.Text;
                editclient.PassportEmployee = Pass_Empl.Text;
                editclient.PostEmployee = Post_empl.Text;

                editclient.SalaryEmploee = Convert.ToDecimal(salary_empl.Text);
                db.Employee.Remove(editclient);
                db.SaveChanges();

                Initdatagrid();
                                             
                                 

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
                var id = (EmployeeResponce)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].DataBoundItem;
                var editclient = db.Employee.FirstOrDefault(x => x.IdEmployee == id.IdEmployee);



                editclient.FioEmployee = Fio_Employe.Text;
                editclient.AgeEmployee = Convert.ToInt32(Age_empl.Text);
                editclient.AddressEmployee = adress_empl.Text;
                editclient.TelephoneEmployee = Phone_empl.Text;
                editclient.PassportEmployee = Pass_Empl.Text;
                editclient.PostEmployee = Post_empl.Text;

                editclient.SalaryEmploee = Convert.ToInt32(salary_empl.Text);
                db.Employee.Update(editclient);
                db.SaveChanges();

                Initdatagrid();


            }
        }
    }
}
