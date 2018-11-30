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
    public partial class FormSuma : Form
    {
        public FormSuma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);

            MessageBox.Show(Convert.ToString(Funciones.suma(numero1, numero2)));
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
