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
    public partial class creditos : Form
    {
        public creditos()
        {
            InitializeComponent();
            label2.Visible = true;
            label2.Text = "programa realizado por : " + " antonio arauz cabello " + Environment.NewLine + "carrera de : " +
                " ingenieria de sistemas " + Environment.NewLine + "materia : " + " programación 2 ";
        
        }
    }
}
