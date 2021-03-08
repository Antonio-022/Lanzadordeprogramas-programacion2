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
    public partial class restaurant : Form
    {
        public restaurant()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }
        public string[,] datos;
        public string datos12;
        public string datos13;
        public string datos14;
        public int datos_1 = 0;
        public int bandera;
        public int j = 0;
        public int i = 0;
        public bool rd = true;
        public bool resultado = true;
        public bool busqueda = true;
        public string datos_2 = "";
        public int venta = 0;
        public int nu;
        public int disponible = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                datos_1 = Convert.ToInt32(textBox1.Text);
                datos = new string[datos_1, 3];
                if (datos_1 <= 0)
                {
                    MessageBox.Show("numero invalido");
                }
                else
                {
                    for (i = 0; i < datos_1; i++)
                    {
                        if (resultado == true)
                        {
                            datos[i, 0] = Interaction.InputBox("Ingrese el nombre del plato" + (i + 1)).ToLower();
                            for (int q = 0; q < datos[i, 0].Length; q++)
                            {
                                switch (datos[i, 0].Substring(q, 1))
                                {
                                    case "q":
                                    case "w":
                                    case "e":
                                    case "r":
                                    case "t":
                                    case "y":
                                    case "u":
                                    case "i":
                                    case "o":
                                    case "a":
                                    case "s":
                                    case "d":
                                    case "f":
                                    case "g":
                                    case "h":
                                    case "j":
                                    case "k":
                                    case "l":
                                    case "ñ":
                                    case "z":
                                    case "x":
                                    case "c":
                                    case "v":
                                    case "b":
                                    case "n":
                                    case "m":
                                    case "p":
                                        resultado = true; break;
                                    default:
                                        button1.Enabled = false;
                                        MessageBox.Show("error de datos");
                                        q = datos[i, 0].Length;
                                        label6.Visible = true;
                                        resultado = false;
                                        break;
                                }
                            }
                        }
                        if (resultado == true)
                        {
                            datos[i, 1] = Interaction.InputBox("ingrese precio el plato numero " + (i + 1));
                            if (datos[i, 1] != "0")
                            {
                                for (int q = 0; q < datos[i, 1].Length; q++)
                                {
                                    switch (datos[i, 1].Substring(q, 1))
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
                                        case "9": resultado = true; break;
                                        default:
                                            button1.Enabled = false;
                                            MessageBox.Show("error de datos");
                                            label6.Visible = true;
                                            q = datos[i, 1].Length;
                                            resultado = false;
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("error de datos");
                                resultado = false;
                            }
                        }
                        if (resultado == true)
                        {
                            datos[i, 2] = Interaction.InputBox("ingrese cantidad el plato numero " + (i + 1));
                            if (datos[i, 2] != "0")
                            {
                                for (int q = 0; q < datos[i, 2].Length; q++)
                                {
                                    switch (datos[i, 2].Substring(q, 1))
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
                                        case "9": resultado = true; break;
                                        default:
                                            button1.Enabled = false;
                                            MessageBox.Show("error de datos");
                                            q = datos[i, 2].Length;
                                            label6.Visible = true;
                                            resultado = false;
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("error de datos");
                                resultado = false;
                            }
                        }
                        if (resultado == true)
                        {
                            button2.Enabled = true;
                            button3.Enabled = true;
                            button1.Enabled = false;
                            textBox2.Enabled = true;
                            textBox1.Enabled = false;
                            textBox4.Enabled = true;
                            textBox3.Enabled = true;
                            button3.Enabled = false;

                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("error 404", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            datos_2 = textBox2.Text;
            for (int q = 0; q < textBox2.TextLength; q++)
            {
                switch (datos_2.Substring(q, 1))
                {
                    case "q":
                    case "w":
                    case "e":
                    case "r":
                    case "t":
                    case "y":
                    case "u":
                    case "i":
                    case "o":
                    case "a":
                    case "s":
                    case "d":
                    case "f":
                    case "g":
                    case "h":
                    case "j":
                    case "k":
                    case "l":
                    case "ñ":
                    case "z":
                    case "x":
                    case "c":
                    case "v":
                    case "b":
                    case "n":
                    case "m":
                    case "p":
                        resultado = true;
                        break;
                    default:
                        MessageBox.Show("error de datos");
                        q = datos_2.Length;
                        resultado = false;
                        break;
                }
            }
            if (resultado == true)
            {
                for (j = 0; j < datos_1; j++)
                {
                    if (datos[j, 0] == datos_2)
                    {
                        if (datos[j, 2] == "0")
                        {
                            MessageBox.Show("agotado");
                            textBox2.Clear();
                        }
                        else
                        {
                            textBox3.Text = datos[j, 1] + "bs";
                            textBox4.Text = datos[j, 2];
                            busqueda = false;
                            bandera = j;
                            textBox5.Enabled = true;
                            button2.Enabled = false;
                            button1.Enabled = false;
                            button3.Enabled = true;
                            break;
                        }
                    }
                }

                if (busqueda == true)
                {
                    MessageBox.Show("el nombre del plato no esta disponible");
                    textBox2.Clear();
                    textBox5.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            resultado = true;
            label6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                disponible = Convert.ToInt32(textBox4.Text);
                venta = Convert.ToInt32(textBox5.Text);
                if (venta > 0)
                {
                    if (disponible >= venta)
                    {
                        textBox4.Text = Convert.ToString(disponible - venta);
                        datos[bandera, 2] = Convert.ToString(disponible - venta);
                    }
                    else
                    {
                        MessageBox.Show("No hay suficiente cantidad de platos", "Restaurant", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox5.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("dato no valido");
                }
            }catch(Exception)
            {
                MessageBox.Show("error 509");
            }
        }
    }
}
