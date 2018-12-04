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
    public partial class FormVolumen : Form
    {
        public FormVolumen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alto = double.Parse(textBox1.Text);
            double ancho = double.Parse(textBox2.Text);
            double largo = double.Parse(textBox3.Text);
            

            if (Funciones.CalcularVolumen(alto, ancho, largo))
            {
                MessageBox.Show("El volúmen está dentro de lo aceptado", "Volúmen");
            }
            else
            {
                MessageBox.Show("El volúmen no puede superar los 10m3");
            }
            
        }
    }
}
