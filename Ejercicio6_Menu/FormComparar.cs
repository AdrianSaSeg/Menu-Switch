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
    public partial class FormComparar : Form
    {
        public FormComparar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            
            if (Funciones.MayorMenor(numero1, numero2) != 0)
            {
                MessageBox.Show("El mayor numero es: " + Convert.ToString(Funciones.MayorMenor(numero1, numero2)), "Comparación");
            }
            else
            {
                MessageBox.Show("Los números son iguales", "Comparación");
            }
        }
    }
}
