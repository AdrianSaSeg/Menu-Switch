using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_Menu
{
    class Funciones
    {
        public static int suma(int x, int y)
        {
            return x + y;
        }

        public static double calculaIRPF(double sueldoBruto, double porcentaje)
        {
            return (sueldoBruto * porcentaje) / 100;
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

        }
      
    }
}
