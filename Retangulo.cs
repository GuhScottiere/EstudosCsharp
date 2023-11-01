using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tipos
{
    public struct Retangulo
    {
        public double LadoX;
        public double LadoY;

        public Retangulo(double ladoX, double ladoY)
        {
            LadoX = ladoX;
            LadoY = ladoY;
        }

        public double CalcularArea()
        {
            return (LadoX * LadoY);
        }
    }
}