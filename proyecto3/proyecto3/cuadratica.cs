using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public partial class cuadratica : Form
    {
        public cuadratica()
        {
            InitializeComponent();
        }
        public double a = 0;
        public double b = 0;
        public double c = 0;
        private void button2_Click_1(object sender, EventArgs e)
        {
            try {
                label4.Visible = false;
                textBox5.Visible = false;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                textBox4.Text = Convert.ToString(a + b + c);
            }catch(Exception)
            {
                MessageBox.Show("ocurrio un error inesperado");
                button7_Click_1(null, e);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try {
                label4.Visible = false;
                textBox5.Visible = false;
                a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            textBox4.Text = Convert.ToString(a - b - c);
            }
            catch (Exception)
            {
                MessageBox.Show("ocurrio un error inesperado");
                button7_Click_1(null, e);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try {
                label4.Visible = false;
                textBox5.Visible = false;
                a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            textBox4.Text = Convert.ToString(a * b * c);
            }
            catch (Exception)
            {
                MessageBox.Show("ocurrio un error inesperado");
                button7_Click_1(null, e);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try {
                label4.Visible = false;
                textBox5.Visible = false;
                a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            textBox4.Text = Convert.ToString(a / b / c);

            }
            catch (Exception)
            {
                MessageBox.Show("ocurrio un error inesperado");
                button7_Click_1(null, e);
            }

        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            try { 
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            textBox4.Text = Convert.ToString((-b + (Math.Sqrt(b*b - 4 * a * c))) / (2 * a));
            textBox5.Text = Convert.ToString((-b - (Math.Sqrt(b*b - 4 * a * c))) / (2 * a));
                label4.Visible = true;
                textBox5.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("ocurrio un error inesperado");
                button7_Click_1(null, e);
            }
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            label4.Visible = false;
            textBox5.Visible = false;
            textBox1.Text = "ingrese el valor de a";
            textBox2.Text = "ingrese el valor de b";
            textBox3.Text = "ingrese el valor de c";

        }

        private void borrar(object sender, EventArgs e)
        {
            if (textBox1.Text == "ingrese el valor de a")
            {
                textBox1.Clear();
            }
            else
            {
                textBox1.Focus();
            }

        }

        private void borrar1(object sender, EventArgs e)
        {
            if (textBox2.Text == "ingrese el valor de b")
            {
                textBox2.Clear();
            }
            else
            {
                textBox2.Focus();
            }

        }

        private void borrar3(object sender, EventArgs e)
        {
            if (textBox3.Text == "ingrese el valor de c")
            {
                textBox3.Clear();
            }
            else
            {
                textBox3.Focus();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
