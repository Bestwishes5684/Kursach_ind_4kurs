namespace Kursach_ind_4kurs.Forms
{
    partial class DepositF
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
            this.Type_deposit = new System.Windows.Forms.TextBox();
            this.Id_deal = new System.Windows.Forms.TextBox();
            this.Precent_depos = new System.Windows.Forms.TextBox();
            this.Term_depos = new System.Windows.Forms.TextBox();
            this.Name_depos = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AdBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sum_deposit = new System.Windows.Forms.TextBox();
            this.depositid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.named = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depostterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precentdep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dealid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depostype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumDepos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(886, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 30;
            this.button1.Text = "Очистить поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Тип деопозита";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Номер сделки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Процент депозита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Срок депозита";
            // 
            // Type_deposit
            // 
            this.Type_deposit.Location = new System.Drawing.Point(886, 157);
            this.Type_deposit.Name = "Type_deposit";
            this.Type_deposit.Size = new System.Drawing.Size(100, 20);
            this.Type_deposit.TabIndex = 25;
            // 
            // Id_deal
            // 
            this.Id_deal.Location = new System.Drawing.Point(886, 120);
            this.Id_deal.Name = "Id_deal";
            this.Id_deal.Size = new System.Drawing.Size(100, 20);
            this.Id_deal.TabIndex = 24;
            // 
            // Precent_depos
            // 
            this.Precent_depos.Location = new System.Drawing.Point(886, 82);
            this.Precent_depos.Name = "Precent_depos";
            this.Precent_depos.Size = new System.Drawing.Size(100, 20);
            this.Precent_depos.TabIndex = 23;
            // 
            // Term_depos
            // 
            this.Term_depos.Location = new System.Drawing.Point(886, 47);
            this.Term_depos.Name = "Term_depos";
            this.Term_depos.Size = new System.Drawing.Size(100, 20);
            this.Term_depos.TabIndex = 22;
            // 
            // Name_depos
            // 
            this.Name_depos.Location = new System.Drawing.Point(886, 16);
            this.Name_depos.Name = "Name_depos";
            this.Name_depos.Size = new System.Drawing.Size(100, 20);
            this.Name_depos.TabIndex = 21;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(658, 69);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(82, 48);
            this.DeleteBTN.TabIndex = 20;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 19;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdBtn
            // 
            this.AdBtn.Location = new System.Drawing.Point(658, 5);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(82, 48);
            this.AdBtn.TabIndex = 18;
            this.AdBtn.Text = "Добавит";
            this.AdBtn.UseVisualStyleBackColor = true;
            this.AdBtn.Click += new System.EventHandler(this.AdBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depositid,
            this.named,
            this.depostterm,
            this.Precentdep,
            this.Dealid,
            this.depostype,
            this.SumDepos});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(645, 449);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Название депозита";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(772, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Сумма депозита";
            // 
            // Sum_deposit
            // 
            this.Sum_deposit.Location = new System.Drawing.Point(886, 195);
            this.Sum_deposit.Name = "Sum_deposit";
            this.Sum_deposit.Size = new System.Drawing.Size(100, 20);
            this.Sum_deposit.TabIndex = 32;
            // 
            // depositid
            // 
            this.depositid.DataPropertyName = "DepositId";
            this.depositid.HeaderText = "Номер депозита";
            this.depositid.Name = "depositid";
            this.depositid.ReadOnly = true;
            this.depositid.Visible = false;
            // 
            // named
            // 
            this.named.DataPropertyName = "DepositName";
            this.named.HeaderText = "Название депозита";
            this.named.Name = "named";
            this.named.ReadOnly = true;
            // 
            // depostterm
            // 
            this.depostterm.DataPropertyName = "DepositTerm";
            this.depostterm.HeaderText = "Срок депозита в месяцах";
            this.depostterm.Name = "depostterm";
            this.depostterm.ReadOnly = true;
            // 
            // Precentdep
            // 
            this.Precentdep.DataPropertyName = "DepositPrecent";
            this.Precentdep.HeaderText = "Процентдепозита";
            this.Precentdep.Name = "Precentdep";
            this.Precentdep.ReadOnly = true;
            // 
            // Dealid
            // 
            this.Dealid.DataPropertyName = "DealId";
            this.Dealid.HeaderText = "Номер договора";
            this.Dealid.Name = "Dealid";
            this.Dealid.ReadOnly = true;
            // 
            // depostype
            // 
            this.depostype.DataPropertyName = "CodeDepositType";
            this.depostype.HeaderText = "Номер типа депозита";
            this.depostype.Name = "depostype";
            this.depostype.ReadOnly = true;
            // 
            // SumDepos
            // 
            this.SumDepos.DataPropertyName = "SumDeposits";
            this.SumDepos.HeaderText = "Сумма депозита";
            this.SumDepos.Name = "SumDepos";
            this.SumDepos.ReadOnly = true;
            // 
            // DepositF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Sum_deposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Type_deposit);
            this.Controls.Add(this.Id_deal);
            this.Controls.Add(this.Precent_depos);
            this.Controls.Add(this.Term_depos);
            this.Controls.Add(this.Name_depos);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepositF";
            this.Text = "Вклады";
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
        private System.Windows.Forms.TextBox Type_deposit;
        private System.Windows.Forms.TextBox Id_deal;
        private System.Windows.Forms.TextBox Precent_depos;
        private System.Windows.Forms.TextBox Term_depos;
        private System.Windows.Forms.TextBox Name_depos;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AdBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Sum_deposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositid;
        private System.Windows.Forms.DataGridViewTextBoxColumn named;
        private System.Windows.Forms.DataGridViewTextBoxColumn depostterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precentdep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dealid;
        private System.Windows.Forms.DataGridViewTextBoxColumn depostype;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumDepos;
    }
}