namespace Kursach_ind_4kurs.Forms
{
    partial class ClientF
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.Pass_client = new System.Windows.Forms.TextBox();
            this.Mail_client = new System.Windows.Forms.TextBox();
            this.Phone_client = new System.Windows.Forms.TextBox();
            this.Adress_Clietn = new System.Windows.Forms.TextBox();
            this.Fio_Client = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 449);
            this.dataGridView1.TabIndex = 0;

            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // AdBtn
            // 
            this.AdBtn.Location = new System.Drawing.Point(647, 12);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(82, 48);
            this.AdBtn.TabIndex = 1;
            this.AdBtn.Text = "Добавит";
            this.AdBtn.UseVisualStyleBackColor = true;
            this.AdBtn.Click += new System.EventHandler(this.AdBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(647, 76);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(82, 48);
            this.DeleteBTN.TabIndex = 3;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // Pass_client
            // 
            this.Pass_client.Location = new System.Drawing.Point(938, 176);
            this.Pass_client.Name = "Pass_client";
            this.Pass_client.Size = new System.Drawing.Size(100, 20);
            this.Pass_client.TabIndex = 10;
            // 
            // Mail_client
            // 
            this.Mail_client.Location = new System.Drawing.Point(938, 139);
            this.Mail_client.Name = "Mail_client";
            this.Mail_client.Size = new System.Drawing.Size(100, 20);
            this.Mail_client.TabIndex = 9;
            // 
            // Phone_client
            // 
            this.Phone_client.Location = new System.Drawing.Point(938, 101);
            this.Phone_client.Name = "Phone_client";
            this.Phone_client.Size = new System.Drawing.Size(100, 20);
            this.Phone_client.TabIndex = 8;
            // 
            // Adress_Clietn
            // 
            this.Adress_Clietn.Location = new System.Drawing.Point(938, 66);
            this.Adress_Clietn.Name = "Adress_Clietn";
            this.Adress_Clietn.Size = new System.Drawing.Size(100, 20);
            this.Adress_Clietn.TabIndex = 7;
            // 
            // Fio_Client
            // 
            this.Fio_Client.Location = new System.Drawing.Point(938, 31);
            this.Fio_Client.Name = "Fio_Client";
            this.Fio_Client.Size = new System.Drawing.Size(100, 20);
            this.Fio_Client.TabIndex = 6;
      
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО КЛИЕНТА";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Адрес Клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Телефон клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(824, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Электронная почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(824, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Паспорт клиента";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Очистить поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass_client);
            this.Controls.Add(this.Mail_client);
            this.Controls.Add(this.Phone_client);
            this.Controls.Add(this.Adress_Clietn);
            this.Controls.Add(this.Fio_Client);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientF";
            this.Text = "ClientF";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DataGridViewTextBoxColumn fIOclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AdBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DeleteBTN;

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox Pass_client;
        private System.Windows.Forms.TextBox Mail_client;
        private System.Windows.Forms.TextBox Phone_client;
        private System.Windows.Forms.TextBox Adress_Clietn;
        private System.Windows.Forms.TextBox Fio_Client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}