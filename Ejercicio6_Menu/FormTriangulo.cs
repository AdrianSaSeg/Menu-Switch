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
    public partial class FormTriangulo : Form
    {
        public FormTriangulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funciones funciones = new Funciones();

            double lado1 = double.Parse(textBox1.Text);
            double lado2 = double.Parse(textBox2.Text);
            double lado3 = double.Parse(textBox3.Text);

            if (funciones.TrianguloEquilatero(lado1, lado2, lado3))
            {
                MessageBox.Show("El triángulo es equilátero");
            }
            else
            {
                MessageBox.Show("El triángulo no es equilátero");
            }

        }
    }
}
