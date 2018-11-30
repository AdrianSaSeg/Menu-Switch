using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6_Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salir?", "Salir");
            Close();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            //creo el objeto del formulario de la suma 
            FormSuma formSuma = new FormSuma();
            //muestro el segundo form (la opcion ShowDialog impide clickar en otra ventana)
            formSuma.ShowDialog();
            //muestro el primer form
            Show();
            //cierro el formulario de la suma
            formSuma.Close();
        }

        
    }
}
