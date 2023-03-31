using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public static class CalculoDeArea
    {
        public static double CalcularCuadrado(double numeroBase) 
        {
            return Math.Pow(numeroBase, 2);
        }
        public static double CalcularTriangulo(double numeroAltura, double numeroBase)
        {
            return (numeroAltura * numeroBase) / 2;
        }
        public static double CalcularCirculo(double numeroRadio)
        {
            return numeroRadio* Math.PI;
        }
    }
}
