namespace Task5
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.btnDisplayStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(214, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 38);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(214, 20);
            this.txtAge.TabIndex = 1;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(12, 64);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(214, 20);
            this.txtAverageScore.TabIndex = 2;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 90);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(214, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "button1";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click_1);
            // 
            // consoleBox
            // 
            this.consoleBox.Location = new System.Drawing.Point(12, 184);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.Size = new System.Drawing.Size(776, 254);
            this.consoleBox.TabIndex = 5;
            // 
            // btnDisplayStudents
            // 
            this.btnDisplayStudents.Location = new System.Drawing.Point(12, 119);
            this.btnDisplayStudents.Name = "btnDisplayStudents";
            this.btnDisplayStudents.Size = new System.Drawing.Size(214, 23);
            this.btnDisplayStudents.TabIndex = 6;
            this.btnDisplayStudents.Text = "button1";
            this.btnDisplayStudents.UseVisualStyleBackColor = true;
            this.btnDisplayStudents.Click += new System.EventHandler(this.btnDisplayStudents_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayStudents);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Кейс-задача 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.Button btnDisplayStudents;
    }
}

