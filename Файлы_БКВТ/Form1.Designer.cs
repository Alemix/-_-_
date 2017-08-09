namespace Файлы_БКВТ
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
            this.button_Выполнить = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox_Где = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Куда = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Всего = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Обработано = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Выполнить
            // 
            this.button_Выполнить.Location = new System.Drawing.Point(37, 133);
            this.button_Выполнить.Name = "button_Выполнить";
            this.button_Выполнить.Size = new System.Drawing.Size(175, 23);
            this.button_Выполнить.TabIndex = 0;
            this.button_Выполнить.Text = "Выполнить";
            this.button_Выполнить.UseVisualStyleBackColor = true;
            this.button_Выполнить.Click += new System.EventHandler(this.button_Выполнить_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(37, 186);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(403, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // textBox_Где
            // 
            this.textBox_Где.Location = new System.Drawing.Point(37, 35);
            this.textBox_Где.Name = "textBox_Где";
            this.textBox_Где.Size = new System.Drawing.Size(403, 20);
            this.textBox_Где.TabIndex = 2;
            this.textBox_Где.TextChanged += new System.EventHandler(this.textBox_Где_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Укажите папку где лежат файлы для сортирови";
            // 
            // textBox_Куда
            // 
            this.textBox_Куда.Location = new System.Drawing.Point(37, 92);
            this.textBox_Куда.Name = "textBox_Куда";
            this.textBox_Куда.Size = new System.Drawing.Size(403, 20);
            this.textBox_Куда.TabIndex = 2;
            this.textBox_Куда.TextChanged += new System.EventHandler(this.textBox_Куда_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите папку куда создать папки с датами и положить файлы.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Всего
            // 
            this.label_Всего.AutoSize = true;
            this.label_Всего.Location = new System.Drawing.Point(124, 216);
            this.label_Всего.Name = "label_Всего";
            this.label_Всего.Size = new System.Drawing.Size(35, 13);
            this.label_Всего.TabIndex = 4;
            this.label_Всего.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Обработано :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Всего файлов :";
            // 
            // label_Обработано
            // 
            this.label_Обработано.AutoSize = true;
            this.label_Обработано.Location = new System.Drawing.Point(348, 216);
            this.label_Обработано.Name = "label_Обработано";
            this.label_Обработано.Size = new System.Drawing.Size(35, 13);
            this.label_Обработано.TabIndex = 5;
            this.label_Обработано.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 255);
            this.Controls.Add(this.label_Обработано);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Всего);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Куда);
            this.Controls.Add(this.textBox_Где);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_Выполнить);
            this.Name = "Form1";
            this.Text = "Обработка файлов БКВТ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Выполнить;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox_Где;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Куда;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Всего;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Обработано;
    }
}

