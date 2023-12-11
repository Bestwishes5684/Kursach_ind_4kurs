namespace Kursach_ind_4kurs.Forms
{
    partial class EmployeeF
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pass_Empl = new System.Windows.Forms.TextBox();
            this.Phone_empl = new System.Windows.Forms.TextBox();
            this.adress_empl = new System.Windows.Forms.TextBox();
            this.Fio_Employe = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AdBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Post_empl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salary_empl = new System.Windows.Forms.TextBox();
            this.Age_empl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(959, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 31;
            this.button1.Text = "Очистить поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(957, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Паспорт Содрудника";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(957, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Телефон содрудника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(957, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Адресс содрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(957, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Возраст содрутника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(957, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ФИО Содрудника";
            // 
            // Pass_Empl
            // 
            this.Pass_Empl.Location = new System.Drawing.Point(1071, 167);
            this.Pass_Empl.Name = "Pass_Empl";
            this.Pass_Empl.Size = new System.Drawing.Size(100, 20);
            this.Pass_Empl.TabIndex = 25;
            this.Pass_Empl.TextChanged += new System.EventHandler(this.Pass_client_TextChanged);
            // 
            // Phone_empl
            // 
            this.Phone_empl.Location = new System.Drawing.Point(1071, 130);
            this.Phone_empl.Name = "Phone_empl";
            this.Phone_empl.Size = new System.Drawing.Size(100, 20);
            this.Phone_empl.TabIndex = 24;
            // 
            // adress_empl
            // 
            this.adress_empl.Location = new System.Drawing.Point(1071, 92);
            this.adress_empl.Name = "adress_empl";
            this.adress_empl.Size = new System.Drawing.Size(100, 20);
            this.adress_empl.TabIndex = 23;
            // 
            // Fio_Employe
            // 
            this.Fio_Employe.Location = new System.Drawing.Point(1071, 22);
            this.Fio_Employe.Name = "Fio_Employe";
            this.Fio_Employe.Size = new System.Drawing.Size(100, 20);
            this.Fio_Employe.TabIndex = 21;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(834, 76);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(82, 48);
            this.DeleteBTN.TabIndex = 20;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(834, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 19;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdBtn
            // 
            this.AdBtn.Location = new System.Drawing.Point(834, 12);
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
            this.dataGridView1.Location = new System.Drawing.Point(-4, -6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(832, 459);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(942, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Должность Содрудника";
            // 
            // Post_empl
            // 
            this.Post_empl.Location = new System.Drawing.Point(1071, 206);
            this.Post_empl.Name = "Post_empl";
            this.Post_empl.Size = new System.Drawing.Size(100, 20);
            this.Post_empl.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(942, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Зарплата Содрудника";
            // 
            // salary_empl
            // 
            this.salary_empl.Location = new System.Drawing.Point(1071, 247);
            this.salary_empl.Name = "salary_empl";
            this.salary_empl.Size = new System.Drawing.Size(100, 20);
            this.salary_empl.TabIndex = 34;
            // 
            // Age_empl
            // 
            this.Age_empl.Location = new System.Drawing.Point(1071, 57);
            this.Age_empl.Name = "Age_empl";
            this.Age_empl.Size = new System.Drawing.Size(100, 20);
            this.Age_empl.TabIndex = 36;
            // 
            // EmployeeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 454);
            this.Controls.Add(this.Age_empl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salary_empl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Post_empl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass_Empl);
            this.Controls.Add(this.Phone_empl);
            this.Controls.Add(this.adress_empl);
            this.Controls.Add(this.Fio_Employe);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeF";
            this.Text = "EmployeeF";
            this.Load += new System.EventHandler(this.EmployeeF_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass_Empl;
        private System.Windows.Forms.TextBox Phone_empl;
        private System.Windows.Forms.TextBox adress_empl;
        private System.Windows.Forms.TextBox Fio_Employe;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AdBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Post_empl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox salary_empl;
        private System.Windows.Forms.TextBox Age_empl;
    }
}