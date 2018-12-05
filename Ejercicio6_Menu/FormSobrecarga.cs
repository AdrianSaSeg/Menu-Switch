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
    public partial class FormSobrecarga : Form
    {
        public FormSobrecarga()
        {
            InitializeComponent();
        }

        private void FormSobrecarga_Load(object sender, EventArgs e)
        {
            //desactivo los objetos del formulario
            Funciones.Disable(button1, label1, label2, label3, textBox1, textBox2, textBox3);
            // ComboBox1 (array (metodo 1, metodo 2, metodo 3 y metodo 4)
            //Foo(string text1, string text2, string text3)

            //0 -> metodo1
            //1 -> metodo2
            //2 -> metodo3
            //3 -> metodo4

            //Lleno el array

            comboBox1.Items.AddRange(new object[] {0, 1, 2, 3});
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selectedIndex = comboBox1.SelectedIndex;
            
            switch (selectedIndex)
            {
                case 0:
                    Funciones.Foo();
                    button1.Enabled = true;
                    break;

                case 1:
                    button1.Enabled = true;
                    label1.Enabled = true;
                    textBox1.Enabled = true;
                    break;

                case 2:
                    button1.Enabled = true;
                    label1.Enabled = true;
                    label2.Enabled = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    break;

                case 3:
                    button1.Enabled = true;
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato1 = textBox1.Text;
            string dato2 = textBox2.Text;
            string dato3 = textBox3.Text;

            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    Funciones.Foo(dato1);
                    break;

                case 2:
                    Funciones.Foo(dato1, dato2);
                    break;

                case 3:
                    Funciones.Foo(dato1, dato2, dato3);
                    break;
            }

        }
    }
}
