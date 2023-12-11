using Kursach_ind_4kurs.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_ind_4kurs
{
    public partial class Gl : Form
    {

      
        public Gl()
        {
            InitializeComponent();

       
        }

        private void Exit_Click(object sender, EventArgs e)
        {
          this.Close();
        }

     

        private void DealButton_Click(object sender, EventArgs e)
        {
            dealF dealF = new dealF();
            dealF.ShowDialog();    
        }

        private void ClientButton_Click_1(object sender, EventArgs e)
        {
            ClientF clientF = new ClientF();    
            clientF.ShowDialog();   
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeF employeeF = new EmployeeF();
            employeeF.ShowDialog();
        }

        private void Kursbutton_Click(object sender, EventArgs e)
        {
            KursF kurs = new KursF();
            kurs.ShowDialog();
        }

        private void deposit_typeButton_Click(object sender, EventArgs e)
        {   
            DepositTypeF depositTypeF = new DepositTypeF(); 
            depositTypeF.ShowDialog();

        }

        private void depositsButton_Click(object sender, EventArgs e)
        {
            DepositF depositF = new DepositF(); 
            depositF.ShowDialog();
        }

        private void LoansButton_Click(object sender, EventArgs e)
        {
            LoansF loansF = new LoansF();   
            loansF.ShowDialog();
        }
    }
}
