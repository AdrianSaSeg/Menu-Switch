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
            FormSuma formSuma = new FormSuma();

            formSuma.Show();
        }
    }
}
