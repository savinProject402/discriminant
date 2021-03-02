using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_1_modul_1_WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                double number_A, number_B, number_C;

                if (this.number_A.Text == "")
                {
                    number_A = 1;
                }
                else
                {
                    number_A = Convert.ToDouble(this.number_A.Text);
                }

                if (this.number_B.Text == "")
                {
                    number_B = 1;
                }
                else
                {
                    number_B = Convert.ToDouble(this.number_B.Text);
                }
                if (this.number_C.Text == "")
                {
                    number_C = 0;
                }
                else
                {
                    number_C = Convert.ToDouble(this.number_C.Text);
                }

                double Discriminant = number_B * number_B - 4 * number_A * number_C;

                if (Discriminant < 0)
                {
                    MessageBox.Show("Дискриминант меньше нуля. Корней нет.");
                }
                while (Discriminant == 0)
                {
                    double x = (-number_B / (2 * number_A));
                    MessageBox.Show("Дискриминант равен нулю. Корень равен " + x + "."); ;

                }
                if (Discriminant > 0)
                {

                    double x1 = Math.Round((-number_B - Math.Sqrt(Discriminant)) / (2 * number_A), 2);
                    double x2 = Math.Round((-number_B + Math.Sqrt(Discriminant)) / (2 * number_A), 2);
                    MessageBox.Show("Дискриминант равен " + Discriminant + ". Первый корень равен " + x1 + ". Второй корень равен " + x2 + ".");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input error, please try again (numbers only).  -----> \t Сlick OK and click button Refresh  on first form ");

            }
        }

            private void button2_Click(object sender, EventArgs e)
            {

                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(GroupBox))
                        foreach (Control d in c.Controls)
                            if (d.GetType() == typeof(TextBox))
                                d.Text = string.Empty;

                    if (c.GetType() == typeof(TextBox))
                        c.Text = string.Empty;
                }



            }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

       
        }
    }

