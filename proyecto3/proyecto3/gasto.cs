using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace proyecto3
{
    public partial class gasto : Form
    {
        public gasto()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        public int[] ajuste;
        public int suma = 0;
        public int gasto1 = 0;
        public int total = 0;
        public int dias = 0;
        public int r = 0;
        public int pos = 1;
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                dias = Convert.ToInt32(diasfd.Text);
                if (dias <= 0)
                {
                    button3.Enabled =true;
                    MessageBox.Show("\a caracter en la casilla de días no valído ");

                }
                else
                {
                    button3.Enabled = false;
                        comboBox1.Text = "click para ver todos los gastos >>";
                        ajuste = new int[dias];
                    for (int i = 0; i < ajuste.Length; i++)
                    {
                        try
                        {
                            ajuste[i] = Convert.ToInt32(Interaction.InputBox("ingese el gasto del día " + (i + 1)));

                            if (ajuste[i] < 0)
                            {
                                i = dias;
                                button2_Click_1(null, e);
                                MessageBox.Show("\a error al ingresar datos de gasto");
                                button3.Enabled = true;
                            }
                            else
                            {
                                suma = suma + ajuste[i];
                                comboBox1.Items.Add("día " + (i + 1) + " : " + ajuste[i]);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("\a error al ingresa datos del gasto");
                            button2_Click_1(null, e);
                            button3.Enabled = true;
                            break;
                        }
                }
                    for (int i = 0; i < ajuste.Length; i++)
                    {
                        if ((ajuste[i] > r))
                        {
                            r = ajuste[i];
                            pos = i;
                        }
                        if (ajuste[i] > 0)
                        {
                            textBox1.Text = Convert.ToString(suma);
                            textBox3.Text = Convert.ToString(r);
                            textBox2.Text = Convert.ToString("día : " + (pos + 1));
                        }
                        else
                        {
                            button2_Click_1(null, e);
                        }
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("\a error de datos de entrada");
                button2_Click_1(null, e);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            diasfd.Text = "ingrese los dias de gastos";
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            pos = 0;
            suma = 0;
            r = 0;
            pos = 0;
            button3.Enabled = true;
        }
        private void borrar(object sender, EventArgs e)
        {
            if(diasfd.Text == "ingrese los dias de gastos")
            {
                diasfd.Clear();
            }
            else
            {
                diasfd.Focus();
            }
            
        }
    }
}
