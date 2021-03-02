namespace DZ_1_modul_1_WindowsFormsApp1
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
            this.Reshit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.number_A = new System.Windows.Forms.TextBox();
            this.number_B = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.number_C = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reshit
            // 
            this.Reshit.Location = new System.Drawing.Point(59, 166);
            this.Reshit.Name = "Reshit";
            this.Reshit.Size = new System.Drawing.Size(75, 23);
            this.Reshit.TabIndex = 0;
            this.Reshit.Text = "count up";
            this.Reshit.UseVisualStyleBackColor = true;
            this.Reshit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X^2 +";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X +";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // number_A
            // 
            this.number_A.Location = new System.Drawing.Point(34, 40);
            this.number_A.Name = "number_A";
            this.number_A.Size = new System.Drawing.Size(50, 20);
            this.number_A.TabIndex = 4;
            this.number_A.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number_B
            // 
            this.number_B.Location = new System.Drawing.Point(140, 40);
            this.number_B.Name = "number_B";
            this.number_B.Size = new System.Drawing.Size(48, 20);
            this.number_B.TabIndex = 5;
            this.number_B.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "= 0";
            // 
            // number_C
            // 
            this.number_C.Location = new System.Drawing.Point(247, 40);
            this.number_C.Name = "number_C";
            this.number_C.Size = new System.Drawing.Size(42, 20);
            this.number_C.TabIndex = 7;
            this.number_C.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 218);
            this.Controls.Add(this.number_C);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.number_B);
            this.Controls.Add(this.number_A);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reshit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Reshit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox number_A;
        private System.Windows.Forms.TextBox number_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number_C;
        private System.Diagnostics.EventLog eventLog1;
    }
}

