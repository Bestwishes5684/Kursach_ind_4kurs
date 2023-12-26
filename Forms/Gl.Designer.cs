namespace Kursach_ind_4kurs
{
    partial class Gl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DealButton = new System.Windows.Forms.Button();
            this.Kursbutton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.LoansButton = new System.Windows.Forms.Button();
            this.depositsButton = new System.Windows.Forms.Button();
            this.deposit_typeButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DealButton
            // 
            this.DealButton.Location = new System.Drawing.Point(55, 40);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(158, 100);
            this.DealButton.TabIndex = 0;
            this.DealButton.Text = "Договоры";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // Kursbutton
            // 
            this.Kursbutton.Location = new System.Drawing.Point(55, 161);
            this.Kursbutton.Name = "Kursbutton";
            this.Kursbutton.Size = new System.Drawing.Size(158, 100);
            this.Kursbutton.TabIndex = 1;
            this.Kursbutton.Text = "Курс";
            this.Kursbutton.UseVisualStyleBackColor = true;
            this.Kursbutton.Click += new System.EventHandler(this.Kursbutton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(261, 40);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(158, 100);
            this.ClientButton.TabIndex = 2;
            this.ClientButton.Text = "Клиенты";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click_1);
            // 
            // LoansButton
            // 
            this.LoansButton.Location = new System.Drawing.Point(485, 40);
            this.LoansButton.Name = "LoansButton";
            this.LoansButton.Size = new System.Drawing.Size(158, 100);
            this.LoansButton.TabIndex = 3;
            this.LoansButton.Text = "Кредиты";
            this.LoansButton.UseVisualStyleBackColor = true;
            this.LoansButton.Click += new System.EventHandler(this.LoansButton_Click);
            // 
            // depositsButton
            // 
            this.depositsButton.Location = new System.Drawing.Point(485, 161);
            this.depositsButton.Name = "depositsButton";
            this.depositsButton.Size = new System.Drawing.Size(158, 100);
            this.depositsButton.TabIndex = 4;
            this.depositsButton.Text = "Вклады";
            this.depositsButton.UseVisualStyleBackColor = true;
            this.depositsButton.Click += new System.EventHandler(this.depositsButton_Click);
            // 
            // deposit_typeButton
            // 
            this.deposit_typeButton.Location = new System.Drawing.Point(261, 161);
            this.deposit_typeButton.Name = "deposit_typeButton";
            this.deposit_typeButton.Size = new System.Drawing.Size(158, 100);
            this.deposit_typeButton.TabIndex = 5;
            this.deposit_typeButton.Text = "Типы Вкладов";
            this.deposit_typeButton.UseVisualStyleBackColor = true;
            this.deposit_typeButton.Click += new System.EventHandler(this.deposit_typeButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(55, 284);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(158, 100);
            this.EmployeeButton.TabIndex = 6;
            this.EmployeeButton.Text = "Сотруднки ";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(261, 284);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 100);
            this.button8.TabIndex = 7;
            this.button8.Text = "Руководство по использованию ";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(485, 284);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(158, 100);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // Gl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.deposit_typeButton);
            this.Controls.Add(this.depositsButton);
            this.Controls.Add(this.LoansButton);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.Kursbutton);
            this.Controls.Add(this.DealButton);
            this.Name = "Gl";
            this.Text = "Главная страница ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Button Kursbutton;
        private System.Windows.Forms.Button ClientButton;
        private System.Windows.Forms.Button LoansButton;
        private System.Windows.Forms.Button depositsButton;
        private System.Windows.Forms.Button deposit_typeButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Exit;
    }
}

