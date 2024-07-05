using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Taller
    {
        List<Barco> barcos;

        public Taller()
        {
            barcos = new List<Barco>();
        }
        public List<Barco> Barcos { get =>  barcos; set => barcos = value;}
    }
}
