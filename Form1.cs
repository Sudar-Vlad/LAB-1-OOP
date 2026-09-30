using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            double xn, xk, h, a, x, y;
            try
            {

                xn = Convert.ToDouble(textBox1.Text, CultureInfo.InvariantCulture);
                xk = Convert.ToDouble(textBox2.Text, CultureInfo.InvariantCulture);
                h = Convert.ToDouble(textBox3.Text, CultureInfo.InvariantCulture);
                a = Convert.ToDouble(textBox4.Text, CultureInfo.InvariantCulture);

                x = xn;

                dataGridView1.Rows.Clear();
                chart1.Series[0].Points.Clear();

                while (x <= xk)
                {

                    if (x <= 0)
                    {
                        if (x == 0) 
                        continue;
                        y = Math.Pow(3 * x - 1, 2) / Math.Pow(x, 5);
                    }
                    else if ((x > 0) && (x <= a))
                    {
                        y = Math.Pow(Math.Log(Math.Abs(Math.Sqrt(x + 5))), 2);
                    }
                    else
                    {
                        y = Math.Cos(Math.Sqrt(1 + x * x));
                    }

                    dataGridView1.Rows.Add(x.ToString(), y.ToString());
                    chart1.Series[0].Points.AddXY(x, y);

                    x += h;
                }
            }
            catch
            {
                MessageBox.Show("Виникла помилка, спробуйте знову.");
            }
        
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
