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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(989, 286);
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
            this.label5.Location = new System.Drawing.Point(875, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Тип деопозита";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(875, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Номер сделки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Процент депозита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Срок депозита";
            // 
            // Type_deposit
            // 
            this.Type_deposit.Location = new System.Drawing.Point(989, 162);
            this.Type_deposit.Name = "Type_deposit";
            this.Type_deposit.Size = new System.Drawing.Size(100, 20);
            this.Type_deposit.TabIndex = 25;
            // 
            // Id_deal
            // 
            this.Id_deal.Location = new System.Drawing.Point(989, 125);
            this.Id_deal.Name = "Id_deal";
            this.Id_deal.Size = new System.Drawing.Size(100, 20);
            this.Id_deal.TabIndex = 24;
            // 
            // Precent_depos
            // 
            this.Precent_depos.Location = new System.Drawing.Point(989, 87);
            this.Precent_depos.Name = "Precent_depos";
            this.Precent_depos.Size = new System.Drawing.Size(100, 20);
            this.Precent_depos.TabIndex = 23;
            // 
            // Term_depos
            // 
            this.Term_depos.Location = new System.Drawing.Point(989, 52);
            this.Term_depos.Name = "Term_depos";
            this.Term_depos.Size = new System.Drawing.Size(100, 20);
            this.Term_depos.TabIndex = 22;
            // 
            // Name_depos
            // 
            this.Name_depos.Location = new System.Drawing.Point(989, 21);
            this.Name_depos.Name = "Name_depos";
            this.Name_depos.Size = new System.Drawing.Size(100, 20);
            this.Name_depos.TabIndex = 21;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(761, 74);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(82, 48);
            this.DeleteBTN.TabIndex = 20;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(761, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 19;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AdBtn
            // 
            this.AdBtn.Location = new System.Drawing.Point(761, 10);
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 449);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(875, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Название депозита";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(875, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Сумма депозита";
            // 
            // Sum_deposit
            // 
            this.Sum_deposit.Location = new System.Drawing.Point(989, 200);
            this.Sum_deposit.Name = "Sum_deposit";
            this.Sum_deposit.Size = new System.Drawing.Size(100, 20);
            this.Sum_deposit.TabIndex = 32;
            // 
            // DepositF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
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
            this.Text = "DepositF";
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
    }
}