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
    public partial class FormParametrosOpcionales : Form
    {
        public FormParametrosOpcionales()
        {
            InitializeComponent();
        }

        private void FormParametrosOpcionales_Load(object sender, EventArgs e)
        {
            //reseteo el numeric
            numericUpDown1.Enabled = true;
            numericUpDown1.Value = 2;

            Label[] labelArray = new Label[5] {label1, label2, label3, label4, label5};

            TextBox[] textBoxArray = new TextBox[5] {textBox1, textBox2, textBox3, textBox4, textBox5};

            Funciones.DesactivarBotones(false, button1, labelArray, textBoxArray);

            button1.Enabled = true;
            label1.Enabled = true;
            label2.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            // Funciones.ActivarDesactivarBotones(Convert.ToInt32(numericUpDown1.Value), button1, label1, label2, label3, label4, label5, textBox1, textBox2, textBox3, textBox4, textBox5);

            //Se crea un bucle for en el que se utilizará la variable contador 'i' para navegar por los arrays
            Label[] labelArray = new Label[5] { label1, label2, label3, label4, label5 };

            TextBox[] textBoxArray = new TextBox[5] { textBox1, textBox2, textBox3, textBox4, textBox5 };
            
            for (int i = 0; i < textBoxArray.Length; i++)
            {

                /*Si el valor del contador es menor o igual que el valor de numericUpDown1 
                 los objetos label y textbox en la posición del array que marca el contador se activan,
                 mientras que en el caso contrario estos se desactivan*/

                if (i <= numericUpDown1.Value - 1)
                {
                    textBoxArray[i].Enabled = true;
                    labelArray[i].Enabled = true;
                }
                else
                {
                    textBoxArray[i].Enabled = false;
                    labelArray[i].Enabled = false;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (numericUpDown1.Value)
            {
                case 2:
                    MessageBox.Show("La suma es: " + Convert.ToString(Funciones.SumaOpcional(int.Parse(textBox1.Text), int.Parse(textBox2.Text))));
                    break;
                case 3:
                    MessageBox.Show("La suma es: " + Convert.ToString(Funciones.SumaOpcional(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text))));
                    break;
                case 4:
                    MessageBox.Show("La suma es: " + Convert.ToString(Funciones.SumaOpcional(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text))));
                    break;
                case 5:
                    MessageBox.Show("La suma es: " + Convert.ToString(Funciones.SumaOpcional(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text))));
                    break;
            }
              
        }
    }
}
