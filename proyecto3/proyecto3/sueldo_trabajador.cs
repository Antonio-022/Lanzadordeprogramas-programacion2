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
    public partial class sueldo_trabajador : Form
    {
        public sueldo_trabajador()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        public string nom = " ", n = " ", m = " ", b = " ", v = " ", t = " ", i = " ", f = " ";
        public double c = 0, q = 0, w = 0, calcula1 = 0;

        private void sueldo_trabajador_Load(object sender, EventArgs e)
        {

        }

        private void borrar4(object sender, EventArgs e)
        {
            if (textBox2.Text == "ingrese el numero de carné de identidad")
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
           if (textBox3.Text == "ingrese aquí el sueldo por día")
            {
                textBox3.Clear();
            }
            else
            {
                textBox3.Focus();
            }
        }

        private void borrar2(object sender, EventArgs e)
        {
            if (textBox4.Text == "ingrese aquí los días trabajados")
            {
                textBox4.Clear();
            }
            else
            {
                textBox4.Focus();
            }
        }

        private void borrar(object sender, EventArgs e)
        {
            if (textBox1.Text == "ingrese aquí el nombre de usuario")
            {
                textBox1.Clear();
            }
            else
            {
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            label5.Text = "";
            textBox1.Text = "ingrese aquí el nombre de usuario";
            textBox2.Text = "ingrese el numero de carné de identidad";
            textBox3.Text = "ingrese aquí el sueldo por día";
            textBox4.Text = "ingrese aquí los días trabajados";
            label2.Text = "";
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try {
                c = Convert.ToDouble(textBox3.Text);
                i = Convert.ToString(textBox3.Text);
                b = textBox2.Text;
                q = Convert.ToDouble(textBox4.Text);
                t = Convert.ToString(textBox4.Text);
                calcula1 = c * q;
                w = c * q * 0.135;
                nom = textBox1.Text;
                for (int r = 0; r < textBox1.TextLength; r++)
                {
                    switch (nom.Substring(r, 1))
                    {
                        case "0":
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            label5.Visible = false;
                            label5.ForeColor = Color.Red;
                            label5.Text = "caracter invalido";
                      
                            break;
                    }
                }
                if (label5.Text == "caracter invalido")
                {
                    MessageBox.Show("oops..\n caracter invalido en casilla del nombre");
                    button3_Click(null, e);

                }
                else if (nom == " " || b == " " || i == " " || t == " ")
                {
                    MessageBox.Show("datos invalidos");
                    button3_Click(null, e);
                }
                else
                {
                    if (calcula1 >= 4120)
                    {
                        calcula1 = c * q - w;
                        label2.ForeColor = Color.White;
                        label2.Text = "nombre : " + nom + Environment.NewLine + "c.i. : " + b + Environment.NewLine + "sueldo : " + calcula1+Environment.NewLine+"monto decontado : "+w;
                    }
                    else
                    {
                        label2.ForeColor = Color.White;
                        label2.Text = "nombre : " + nom + Environment.NewLine + "c.i. : " + b + Environment.NewLine + "sueldo : " + calcula1 + Environment.NewLine + "sin descuento";
                    }
                }
            }catch(Exception)
            {
                MessageBox.Show("ocurrio un error en el proceso");
                button3_Click(null,e);
            }
    }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
