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
    public partial class promedio : Form
    {
        public promedio()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }
        public int[] nota;
        public int suma = 0;
        public int promedio1 = 0;
        public int datos = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                datos = Convert.ToInt32(datos_nota.Text);
                nota = new int[datos];
                notas_text.Text = "click para ver todas las notas >>";
                if (datos < 0)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                    try
                    {
                        for (int i = 0; i < datos; i++)
                        {
                            nota[i] = Convert.ToInt32(Interaction.InputBox("ingrese la nota numero " + (i + 1)));
                            if (nota[i] < 1 || nota[i] > 100)
                            {
                                button4_Click(null, e);
                                MessageBox.Show("la nota no es valida");
                                button1.Enabled = true;
                                break;
                            }
                        }
                        for (int i = 0; i < datos; i++)
                        {
 
                            if (nota[i] > 1 && nota[i] <= 100)
                            {
                                notas_text.Items.Add("nota " + (i + 1) + " : " + (nota[i]));
                                suma = suma + nota[i];
                                promedio1 = suma / datos;
                                promedio_text.Text = Convert.ToString(promedio1);
                                label4.Text = promedio1.ToString();
                            }
                            else
                            {
                                button4_Click(null, e);
                            }
                        }
                        // promedio = suma / datos;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ha ocurrido  un error en el proceso");
                        button1.Enabled = true;
                        button4_Click(null, e);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("datos incorrectos");
                button4_Click(null, e);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            notas_text.Items.Clear();
            promedio_text.Clear();
            notas_text.Text = "";
            datos_nota.Clear();
            suma = 0;
            datos_nota.Text = "ingrese el numero de notas";
            promedio_text.Text = "";
            promedio1 = 0;
            label4.Text = "";
            button1.Enabled = true;
            
        }

        private void borrar(object sender, EventArgs e)
        {
            if (datos_nota.Text == "ingrese el numero de notas")
            {
                datos_nota.Clear();
            }
            else
            {
                datos_nota.Focus();
            }
        }
    }
}
