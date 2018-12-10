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
            //Para cerrar el formulario principal
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

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            //creo el objeto del formulario de la comparación
            FormComparar formComparar = new FormComparar();
            //muestro el segundo form (la opcion ShowDialog impide clickar en otra ventana)
            formComparar.ShowDialog();
            //muestro el primer form
            Show();
            //cierro el formulario de la comparación
            formComparar.Close();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            FormImprimir formImprimir = new FormImprimir();

            formImprimir.ShowDialog();

            Show();

            formImprimir.Close();
        }

        private void cálculoVolúmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVolumen formVolumen = new FormVolumen();

            formVolumen.ShowDialog();

            Show();

            formVolumen.Close();

        }

        private void triánguloEquiláteroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTriangulo formTriangulo = new FormTriangulo();

            formTriangulo.ShowDialog();

            Show();

            formTriangulo.Close();
        }

        private void sobrecargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobrecarga formSobrecarga = new FormSobrecarga();

            formSobrecarga.ShowDialog();
        }

        private void parámetrosOpcionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametrosOpcionales formParametrosOpcionales = new FormParametrosOpcionales();

            formParametrosOpcionales.ShowDialog();
        }
    }
}
