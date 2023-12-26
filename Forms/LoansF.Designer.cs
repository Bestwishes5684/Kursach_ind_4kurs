namespace Kursach_ind_4kurs.Forms
{
    partial class LoansF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Id_valuta = new System.Windows.Forms.TextBox();
            this.Id_deal = new System.Windows.Forms.TextBox();
            this.Precent_Loan = new System.Windows.Forms.TextBox();
            this.Term_Loan = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdBtn = new System.Windows.Forms.Button();
            this.idLoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanTerms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loansprecent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvaluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 28;
            this.button1.Text = "Очистить поля";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Номер Валюты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Номер договора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Процент по кредиту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Срок Кредита";
            // 
            // Id_valuta
            // 
            this.Id_valuta.Location = new System.Drawing.Point(700, 155);
            this.Id_valuta.Name = "Id_valuta";
            this.Id_valuta.Size = new System.Drawing.Size(100, 20);
            this.Id_valuta.TabIndex = 23;
            // 
            // Id_deal
            // 
            this.Id_deal.Location = new System.Drawing.Point(700, 111);
            this.Id_deal.Name = "Id_deal";
            this.Id_deal.Size = new System.Drawing.Size(100, 20);
            this.Id_deal.TabIndex = 22;
            // 
            // Precent_Loan
            // 
            this.Precent_Loan.Location = new System.Drawing.Point(700, 77);
            this.Precent_Loan.Name = "Precent_Loan";
            this.Precent_Loan.Size = new System.Drawing.Size(100, 20);
            this.Precent_Loan.TabIndex = 21;
            // 
            // Term_Loan
            // 
            this.Term_Loan.Location = new System.Drawing.Point(700, 38);
            this.Term_Loan.Name = "Term_Loan";
            this.Term_Loan.Size = new System.Drawing.Size(100, 20);
            this.Term_Loan.TabIndex = 20;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(450, 52);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(82, 48);
            this.DeleteBTN.TabIndex = 19;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 18;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLoan,
            this.LoanTerms,
            this.Loansprecent,
            this.iddeal,
            this.idvaluta});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 449);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // AdBtn
            // 
            this.AdBtn.Location = new System.Drawing.Point(450, -2);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(82, 48);
            this.AdBtn.TabIndex = 29;
            this.AdBtn.Text = "Добавит";
            this.AdBtn.UseVisualStyleBackColor = true;
            this.AdBtn.Click += new System.EventHandler(this.AdBtn_Click);
            // 
            // idLoan
            // 
            this.idLoan.DataPropertyName = "IdLoan";
            this.idLoan.HeaderText = "Номер кредита";
            this.idLoan.Name = "idLoan";
            this.idLoan.ReadOnly = true;
            this.idLoan.Visible = false;
            // 
            // LoanTerms
            // 
            this.LoanTerms.DataPropertyName = "LoanTerms";
            this.LoanTerms.HeaderText = "Время кредита";
            this.LoanTerms.Name = "LoanTerms";
            this.LoanTerms.ReadOnly = true;
            // 
            // Loansprecent
            // 
            this.Loansprecent.DataPropertyName = "LoanPerecent";
            this.Loansprecent.HeaderText = "процент по кредиту";
            this.Loansprecent.Name = "Loansprecent";
            this.Loansprecent.ReadOnly = true;
            // 
            // iddeal
            // 
            this.iddeal.DataPropertyName = "IdDeal";
            this.iddeal.HeaderText = "Номер договра";
            this.iddeal.Name = "iddeal";
            this.iddeal.ReadOnly = true;
            // 
            // idvaluta
            // 
            this.idvaluta.DataPropertyName = "IdValuta";
            this.idvaluta.HeaderText = "Номер валюты";
            this.idvaluta.Name = "idvaluta";
            this.idvaluta.ReadOnly = true;
            // 
            // LoansF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_valuta);
            this.Controls.Add(this.Id_deal);
            this.Controls.Add(this.Precent_Loan);
            this.Controls.Add(this.Term_Loan);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LoansF";
            this.Text = "LoansF";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Id_valuta;
        private System.Windows.Forms.TextBox Id_deal;
        private System.Windows.Forms.TextBox Precent_Loan;
        private System.Windows.Forms.TextBox Term_Loan;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanTerms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loansprecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvaluta;
    }
}