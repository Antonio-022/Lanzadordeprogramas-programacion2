using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto3;

namespace proyecto3
{ 
    public partial class Form3 : Form 
    {

        public int angulo_a = 0;
        public int angulo_b = 0;
        public int angulo_c = 0;
        public int contador = 0;
        public Form3()
        {
            
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                angulo_a = Convert.ToInt32(textBox1.Text);
                angulo_b = Convert.ToInt32(textBox2.Text);
                angulo_c = 180 - angulo_a - angulo_b;
                if (angulo_a < 0 || angulo_b < 0)
                {
                    MessageBox.Show("oops...\n ocurrio un error al cargar datos");
                    button3_Click(null, e);
                }
                else
                {
                    contador = angulo_a + angulo_b + angulo_c;
                    if (contador == 180)
                    {
                        if (angulo_a == 90 || angulo_b == 90 || angulo_c == 90)
                        {

                            label4.Text = "es triángulo rectángulo";
                            label4.ForeColor = Color.White;
                        }
                        else if (angulo_a < 90 && angulo_b < 90 && angulo_c < 90)
                        {
                            label4.Text = "es triángulo acutángulo";
                            label4.ForeColor = Color.Green;
                        }
                        else if (angulo_a > 90 && angulo_a < 180 || angulo_b > 90 && angulo_b < 180 || angulo_c > 90 && angulo_c < 180)
                        {
                            label4.Text = "es triángulo obtusángulo";
                            label4.ForeColor = Color.Yellow;
                        }
                        else if (angulo_a >= 180 || angulo_b >= 180)
                        {
                            label4.Text = "no es triángulo";
                            label4.ForeColor = Color.Red;
                        }
                    }
                }
              }catch(Exception)
            {
                MessageBox.Show("oops...\n ocurrio un error al cargar datos");
                button3_Click(null, e);
            }
            }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            contador = 0;
            angulo_c = 0;
            label4.Text = "";
            textBox1.Text = "ingrese el valor de a";
            textBox2.Text = "ingrese el valor de b";
        }

        private void click_borrar(object sender, EventArgs e)
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

        private void borrar0(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
