namespace Kursach_ind_4kurs.Forms
{
    partial class dealF
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
            this.Addbutton = new System.Windows.Forms.Button();
            this.Change_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Fio_client = new System.Windows.Forms.TextBox();
            this.Id_valuta = new System.Windows.Forms.TextBox();
            this.date_deal = new System.Windows.Forms.TextBox();
            this.Id_client = new System.Windows.Forms.TextBox();
            this.Id_employe = new System.Windows.Forms.TextBox();
            this.Deal_desk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(12, 340);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(85, 40);
            this.Addbutton.TabIndex = 1;
            this.Addbutton.Text = "Добавить ";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Change_Btn
            // 
            this.Change_Btn.Location = new System.Drawing.Point(112, 340);
            this.Change_Btn.Name = "Change_Btn";
            this.Change_Btn.Size = new System.Drawing.Size(116, 40);
            this.Change_Btn.TabIndex = 2;
            this.Change_Btn.Text = "Редактировать";
            this.Change_Btn.UseVisualStyleBackColor = true;
            this.Change_Btn.Click += new System.EventHandler(this.Change_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(234, 340);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(83, 40);
            this.Delete_Btn.TabIndex = 3;
            this.Delete_Btn.Text = "Удалить";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Fio_client
            // 
            this.Fio_client.Location = new System.Drawing.Point(632, 355);
            this.Fio_client.Name = "Fio_client";
            this.Fio_client.Size = new System.Drawing.Size(100, 20);
            this.Fio_client.TabIndex = 4;
            // 
            // Id_valuta
            // 
            this.Id_valuta.Location = new System.Drawing.Point(632, 485);
            this.Id_valuta.Name = "Id_valuta";
            this.Id_valuta.Size = new System.Drawing.Size(100, 20);
            this.Id_valuta.TabIndex = 5;
            // 
            // date_deal
            // 
            this.date_deal.Location = new System.Drawing.Point(632, 459);
            this.date_deal.Name = "date_deal";
            this.date_deal.Size = new System.Drawing.Size(100, 20);
            this.date_deal.TabIndex = 6;
            // 
            // Id_client
            // 
            this.Id_client.Location = new System.Drawing.Point(632, 433);
            this.Id_client.Name = "Id_client";
            this.Id_client.Size = new System.Drawing.Size(100, 20);
            this.Id_client.TabIndex = 7;
            // 
            // Id_employe
            // 
            this.Id_employe.Location = new System.Drawing.Point(632, 407);
            this.Id_employe.Name = "Id_employe";
            this.Id_employe.Size = new System.Drawing.Size(100, 20);
            this.Id_employe.TabIndex = 8;
            // 
            // Deal_desk
            // 
            this.Deal_desk.Location = new System.Drawing.Point(632, 381);
            this.Deal_desk.Name = "Deal_desk";
            this.Deal_desk.Size = new System.Drawing.Size(100, 20);
            this.Deal_desk.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фио клиента ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Описание Договора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Номер клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата сделки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Номер валюты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Номер содрудника";
            // 
            // dealF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 650);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deal_desk);
            this.Controls.Add(this.Id_employe);
            this.Controls.Add(this.Id_client);
            this.Controls.Add(this.date_deal);
            this.Controls.Add(this.Id_valuta);
            this.Controls.Add(this.Fio_client);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Change_Btn);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dealF";
            this.Text = "deal";
            this.Load += new System.EventHandler(this.dealF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
 
        private System.Windows.Forms.DataGridViewTextBoxColumn iddealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dealdiscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idemployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valutaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Change_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.TextBox Fio_client;
        private System.Windows.Forms.TextBox Id_valuta;
        private System.Windows.Forms.TextBox date_deal;
        private System.Windows.Forms.TextBox Id_client;
        private System.Windows.Forms.TextBox Id_employe;
        private System.Windows.Forms.TextBox Deal_desk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}