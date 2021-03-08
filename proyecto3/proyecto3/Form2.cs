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
    public partial class Form2 : Form
    {
        // inciamos con doble buffered optimizado abriendo el programa de creditos
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            mostrar(new creditos());
            button4.Enabled = false;
            cambio = 6;
        }
        
        public int colores = 0;
        public int cambio = 0;
        //cerrar programa
        private void button1_Click(object sender, EventArgs e)
        {

            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Form1 sa = new Form1();
            sa.Show();
            this.Close();

        }
        //mostrar programas en un panel
        public void mostrar(object formulario_secundario)
        {
            if (this.programas.Controls.Count > 0)
                this.programas.Controls.RemoveAt(0);
            Form fh = formulario_secundario as Form;
            fh.TopLevel = false;
            if (colores == 1) { fh.BackColor = Color.ForestGreen; }
            else if (colores == 2) { fh.BackColor = Color.Orange; }
            else if (colores == 3) { fh.BackColor = Color.Indigo; }
            else if (colores == 4) { fh.BackColor = Color.Navy; }
            else { fh.BackColor = Color.Navy; }
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.programas.Controls.Add(fh);
            this.programas.Tag = fh;
            fh.Show();
        }
        //abrir primer programa
        private void button2_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            button2.Enabled = false;
            button3.Enabled = true;
            button9.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button5.Enabled = true;
            mostrar(new Form3());
            cambio = 1;
        }
        //abrir segundo programa
        private void button3_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            mostrar(new cuadratica());
            button2.Enabled = true;
            button9.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button5.Enabled = true;
            cambio = 2;
        }
        //abrir tercero programa
        public void button5_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            mostrar(new sueldo_trabajador());
            button9.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button5.Enabled = false;
            cambio = 3;
        }
        //abrir cuarto programa
        public void button6_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            mostrar(new promedio());
            button9.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = true;
            button5.Enabled = true;
            cambio = 4;
        }
        //abrir quinto programa
        public void button7_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            mostrar(new gasto());
            button9.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = false;
            button5.Enabled = true;
            cambio = 5;
        }
        //abrir sexto programa
        public void button4_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            mostrar(new creditos());
            button9.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = true;
            button5.Enabled = true;
            cambio = 6;
        }
        //abrir septimo programa
        private void button9_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            mostrar(new restaurant());
            button9.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button5.Enabled = true;
            cambio = 7;
        }
        // metodos de combinaciones de colores
        public void combinacion_1()
        {
            panel1.BackColor = Color.SeaGreen;
            panel2.BackColor = Color.SeaGreen;
            programas.BackColor = Color.ForestGreen;
        }
        public void combinacion_2()
        {
            panel2.BackColor = Color.Coral;
            panel1.BackColor = Color.Coral;
            programas.BackColor = Color.Orange;
        }
        public void combinacion_3()
        {
            panel2.BackColor = Color.DarkViolet;
            panel1.BackColor = Color.DarkViolet;
            programas.BackColor = Color.Indigo;
        }
        public void combinacion_4()
        {
            panel2.BackColor = Color.RoyalBlue;
            panel1.BackColor = Color.RoyalBlue;
            programas.BackColor = Color.Navy;
        }
        //metodo de eventos de cambio de color en paneles
        public void cambios(EventArgs e)
        {
            if (cambio == 2)
            {
                button3_Click(null, e);
            }
            else if (cambio == 1)
            {
                button2_Click(null, e);
            }
            else if (cambio == 6)
            {
                button4_Click(null, e);
            }
            else if (cambio == 4)
            {
                button6_Click(null, e);
            }
            else if (cambio == 5)
            {
                button7_Click(null, e);
            }
            else if (cambio == 3)
            {
                button5_Click(null, e);
            }
            else if (cambio == 7)
            {
                button9_Click(null, e);
            }
        }
        //combinacion de colores 1
        public void pictureBox2_Click_1(object sender, EventArgs e)
        {
            combinacion_1();
            colores = 1;
            cambios(e);
            borrado();

        }
        //segunda combinacion de colores
        public void pictureBox3_Click(object sender, EventArgs e)
        {
            combinacion_2();
            colores = 2;
            cambios(e);
            borrado();
        }
        //tercera combinacion de colores
        public void pictureBox4_Click(object sender, EventArgs e)
        {
            combinacion_3();
            colores = 3;
            cambios(e);
            borrado();
        }
        //cuarta combinacion de colores
        public void pictureBox5_Click(object sender, EventArgs e)
        {
            combinacion_4();
            colores = 4;
            cambios(e);
            borrado();
        }
        //metodo de borrado de barra de colores
        public void borrado()
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }
        //herencia primer combinacion
        public void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox3_Click(null, e);
        }
        //herencia segunda combinacion
        public void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox5_Click(null, e);
        }
        //herencia tercera combinacion
        public void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox2_Click_1(null, e);
        }
        //herencia cuarta combinacion
        public void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox4_Click(null, e);
        }
        //mostrar barra de colores
        private void button8_Click_1(object sender, EventArgs e)
        {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox6.Visible = true;
                pictureBox5.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
        }
        //mostrar texto de ayuda para el boton de muestra de barra de colores
        private void button8_MouseHover(object sender, EventArgs e)
        {
           if (panel2.Width == 57)
            {
                label3.Visible = false;
            }
            else
            {
                label3.Visible = true;
            }
        }
        //ocultar texto de ayuda para el boton de muestra de barra de colores
        private void button8_MouseLeave_1(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
        //mostrar y ocultar panel lateral
        private void mostrar_indice1_Click_1(object sender, EventArgs e)
        {
            if (panel2.Width == 296)
            {
                button8.Visible = false;
                panel2.Width = 57;
                label4.Location = new Point(320, 1);
                label1hora.Location = new Point(1100, 1);
                label1.Visible = false;
                mostrar_indice1.Location = new Point(6, 6);
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                button8.Visible = false;
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                programas.Font = new Font("0", 10);
            }
            else if (panel2.Width == 57)
            {
                button8.Visible = true;
                label1.Visible = true;
                label4.Location = new Point(176, 1);
                label1hora.Location = new Point(883, 1);
                panel2.Width = 296;
                mostrar_indice1.Location = new Point(244, 5);
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                programas.Font = new Font("0", 8);
            }
        }
        // muestra texto de ayuda del btnslide
        private void mostrar_indice1_MouseHover(object sender, EventArgs e)
        { 
            if (panel2.Width == 296)
            {
                label2.Visible = true;
                label2.Location = new Point(1, 43);
            }
            else if (panel2.Width == 57)
            {
                label2.Location = new Point(1, 43);
                label2.Visible = true;
            }
        }
        //oculta texto de ayuda del btnslide
        private void mostrar_indice1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
    

