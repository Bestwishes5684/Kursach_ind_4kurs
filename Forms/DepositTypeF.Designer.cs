namespace Kursach_ind_4kurs.Forms
{
    partial class DepositTypeF
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
            this.Desk_depositT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Prec_depositT = new System.Windows.Forms.TextBox();
            this.Min_Sum_DepositT = new System.Windows.Forms.TextBox();
            this.Min_term_depositT = new System.Windows.Forms.TextBox();
            this.Name_depositT = new System.Windows.Forms.TextBox();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AdBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.num_depositT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Desk_depositT
            // 
            this.Desk_depositT.Location = new System.Drawing.Point(1001, 96);
            this.Desk_depositT.Name = "Desk_depositT";
            this.Desk_depositT.Size = new System.Drawing.Size(100, 20);
            this.Desk_depositT.TabIndex = 55;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 50;
            this.button1.Text = "Очистить поля";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(838, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Процент депозита";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(828, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Минимальный Сумма депозита";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(828, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Минимальный срок депозита";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(838, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Описание депозита";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(838, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Название Депозита";
            // 
            // Prec_depositT
            // 
            this.Prec_depositT.Location = new System.Drawing.Point(1001, 206);
            this.Prec_depositT.Name = "Prec_depositT";
            this.Prec_depositT.Size = new System.Drawing.Size(100, 20);
            this.Prec_depositT.TabIndex = 44;
            // 
            // Min_Sum_DepositT
            // 
            this.Min_Sum_DepositT.Location = new System.Drawing.Point(1001, 169);
            this.Min_Sum_DepositT.Name = "Min_Sum_DepositT";
            this.Min_Sum_DepositT.Size = new System.Drawing.Size(100, 20);
            this.Min_Sum_DepositT.TabIndex = 43;
            // 
            // Min_term_depositT
            // 
            this.Min_term_depositT.Location = new System.Drawing.Point(1001, 131);
            this.Min_term_depositT.Name = "Min_term_depositT";
            this.Min_term_depositT.Size = new System.Drawing.Size(100, 20);
            this.Min_term_depositT.TabIndex = 42;
            // 
            // Name_depositT
            // 
            this.Name_depositT.Location = new System.Drawing.Point(1001, 61);
            this.Name_depositT.Name = "Name_depositT";
            this.Name_depositT.Size = new System.Drawing.Size(100, 20);
            this.Name_depositT.TabIndex = 41;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(651, 78);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(82, 48);
            this.DeleteBTN.TabIndex = 40;
            this.DeleteBTN.Text = "Удалить";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(651, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 39;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdBtn
            // 
            this.AdBtn.Location = new System.Drawing.Point(651, 14);
            this.AdBtn.Name = "AdBtn";
            this.AdBtn.Size = new System.Drawing.Size(82, 48);
            this.AdBtn.TabIndex = 38;
            this.AdBtn.Text = "Добавит";
            this.AdBtn.UseVisualStyleBackColor = true;
            this.AdBtn.Click += new System.EventHandler(this.AdBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(645, 459);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(838, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Номер депозита";
            // 
            // num_depositT
            // 
            this.num_depositT.Location = new System.Drawing.Point(1001, 29);
            this.num_depositT.Name = "num_depositT";
            this.num_depositT.Size = new System.Drawing.Size(100, 20);
            this.num_depositT.TabIndex = 56;
            // 
            // DepositTypeF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_depositT);
            this.Controls.Add(this.Desk_depositT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prec_depositT);
            this.Controls.Add(this.Min_Sum_DepositT);
            this.Controls.Add(this.Min_term_depositT);
            this.Controls.Add(this.Name_depositT);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AdBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepositTypeF";
            this.Text = "DepositTypeF";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Desk_depositT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Prec_depositT;
        private System.Windows.Forms.TextBox Min_Sum_DepositT;
        private System.Windows.Forms.TextBox Min_term_depositT;
        private System.Windows.Forms.TextBox Name_depositT;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AdBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox num_depositT;
    }
}