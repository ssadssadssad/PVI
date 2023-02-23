
namespace WinForm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listPhones = new System.Windows.Forms.RichTextBox();
            this.addName = new System.Windows.Forms.TextBox();
            this.addPhone = new System.Windows.Forms.TextBox();
            this.updateName = new System.Windows.Forms.TextBox();
            this.updatePhone = new System.Windows.Forms.TextBox();
            this.deletePhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Получить всех";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 256);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(857, 256);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listPhones
            // 
            this.listPhones.Location = new System.Drawing.Point(85, 38);
            this.listPhones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listPhones.Name = "listPhones";
            this.listPhones.ReadOnly = true;
            this.listPhones.Size = new System.Drawing.Size(313, 197);
            this.listPhones.TabIndex = 4;
            this.listPhones.Text = "";
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(479, 161);
            this.addName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(132, 22);
            this.addName.TabIndex = 5;
            // 
            // addPhone
            // 
            this.addPhone.Location = new System.Drawing.Point(479, 213);
            this.addPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPhone.Name = "addPhone";
            this.addPhone.Size = new System.Drawing.Size(132, 22);
            this.addPhone.TabIndex = 6;
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(659, 161);
            this.updateName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(132, 22);
            this.updateName.TabIndex = 7;
            // 
            // updatePhone
            // 
            this.updatePhone.Location = new System.Drawing.Point(659, 213);
            this.updatePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updatePhone.Name = "updatePhone";
            this.updatePhone.Size = new System.Drawing.Size(132, 22);
            this.updatePhone.TabIndex = 8;
            // 
            // deletePhone
            // 
            this.deletePhone.Location = new System.Drawing.Point(857, 213);
            this.deletePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletePhone.Name = "deletePhone";
            this.deletePhone.Size = new System.Drawing.Size(132, 22);
            this.deletePhone.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Имя существующего";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Телефон существующего";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(854, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Телефон существующего";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletePhone);
            this.Controls.Add(this.updatePhone);
            this.Controls.Add(this.updateName);
            this.Controls.Add(this.addPhone);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.listPhones);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox listPhones;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.TextBox addPhone;
        private System.Windows.Forms.TextBox updateName;
        private System.Windows.Forms.TextBox updatePhone;
        private System.Windows.Forms.TextBox deletePhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

