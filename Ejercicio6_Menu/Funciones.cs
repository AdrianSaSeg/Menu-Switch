using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6_Menu
{
    class Funciones
    {
        public static void Enable(Button b, Label l1, Label l2, Label l3, TextBox tb1, TextBox tb2, TextBox tb3)
        {
            //activo todos los objetos
            b.Enabled = true;
            l1.Enabled = true;
            l2.Enabled = true;
            l3.Enabled = true;
            tb1.Enabled = true;
            tb2.Enabled = true;
            tb3.Enabled = true;
        }

        public static void Disable(Button b, Label l1, Label l2, Label l3, TextBox tb1, TextBox tb2, TextBox tb3)
        {
            //activo todos los objetos
            b.Enabled = false;
            l1.Enabled = false;
            l2.Enabled = false;
            l3.Enabled = false;
            tb1.Enabled = false;
            tb2.Enabled = false;
            tb3.Enabled = false;
        }

        public static void EnableDisable (Button b, Label l1, Label l2, Label l3, TextBox tb1, TextBox tb2, TextBox tb3)
        {

        }

        public static int suma(int x, int y)
        {
            return x + y;
        }

        public static int suma(int a, int b, int c = 0, int d = 0, int e = 0)
        {
            return a + b + c + d + e;
        }
        public static int MayorMenor(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else if (x < y)
            {
                return y;
            }
            else
            {
                return 0;
            }

        }

        public static void imprimirTexto(string texto)
        {
            MessageBox.Show("El texto introducido es: " + texto, "Imprimir");
        }
      
        public static Boolean CalcularVolumen(double x, double y, double z)
        {
            if ((x * y * z) / 1000 <= 10000)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public Boolean TrianguloEquilatero (double x, double y, double z)
        {
            if ((x == y) && (x == z) && (y == z))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Foo()
        {
            MessageBox.Show("Ejecutada la sobrecarga Foo()");
        }

        public static void Foo (string text)
        {
            MessageBox.Show("Ejecutada la sobrecarga Foo(" + text + ")");
        }

        public static void Foo(string text1, string text2)
        {
            MessageBox.Show("Ejecutada la sobrecarga Foo(" + text1 + " y  " + text2 +")");
        }

        public static void Foo(string text1, string text2, string text3)
        {
            MessageBox.Show("Ejecutada la sobrecarga Foo(" + text1 + ", " + text2 + " y " + text3 + ")");
        }
    }
}
