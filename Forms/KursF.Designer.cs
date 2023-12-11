namespace Kursach_ind_4kurs.Forms
{
    partial class KursF
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
            this.Cleare_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kurs = new System.Windows.Forms.TextBox();
            this.Name_valuta = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdBnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cleare_btn
            // 
            this.Cleare_btn.Location = new System.Drawing.Point(478, 160);
            this.Cleare_btn.Name = "Cleare_btn";
            this.Cleare_btn.Size = new System.Drawing.Size(108, 48);
            this.Cleare_btn.TabIndex = 28;
            this.Cleare_btn.Text = "Очистить поля";
            this.Cleare_btn.UseVisualStyleBackColor = true;
            this.Cleare_btn.Click += new System.EventHandler(this.Cleare_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Курс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Название валюты";
            // 
            // Kurs
            // 
            this.Kurs.Location = new System.Drawing.Point(589, 78);
            this.Kurs.Name = "Kurs";
            this.Kurs.Size = new System.Drawing.Size(100, 20);
            this.Kurs.TabIndex = 21;
            // 
            // Name_valuta
            // 
            this.Name_valuta.Location = new System.Drawing.Point(589, 43);
            this.Name_valuta.Name = "Name_valuta";
            this.Name_valuta.Size = new System.Drawing.Size(100, 20);
            this.Name_valuta.TabIndex = 20;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(364, 60);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(82, 48);
            this.DeleteBTN.TabIndex = 19;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 114);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(342, 449);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // AdBnt
            // 
            this.AdBnt.Location = new System.Drawing.Point(364, 6);
            this.AdBnt.Name = "AdBnt";
            this.AdBnt.Size = new System.Drawing.Size(82, 48);
            this.AdBnt.TabIndex = 29;
            this.AdBnt.Text = "Добавить";
            this.AdBnt.UseVisualStyleBackColor = true;
            this.AdBnt.Click += new System.EventHandler(this.AdBnt_Click);
            // 
            // KursF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.AdBnt);
            this.Controls.Add(this.Cleare_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kurs);
            this.Controls.Add(this.Name_valuta);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KursF";
            this.Text = "KursF";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cleare_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Kurs;
        private System.Windows.Forms.TextBox Name_valuta;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdBnt;
    }
}