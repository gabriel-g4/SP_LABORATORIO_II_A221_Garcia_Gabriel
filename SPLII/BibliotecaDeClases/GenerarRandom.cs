using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class GenerarRandom
    {
        public static double DoubleAleatorio() 
        {
            // check      
            Random random = new Random();
            return random.NextDouble();
        }

        public static int EnteroAleatorio(int min, int max)
        {
            // check
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
