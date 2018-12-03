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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (password == "Password")
            {
                Form1 form1 = new Form1();
                Close();
                form1.ShowDialog();   
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta");
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
