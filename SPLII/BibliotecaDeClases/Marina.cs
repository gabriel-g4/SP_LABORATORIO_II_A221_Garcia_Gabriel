using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Barco;

namespace BibliotecaDeClases
{
    public class Marina : Barco
    {
        public Marina() : base()
        {

        }

        public Marina(string nombre, float costo, bool estadoReparado, EOperacion operacion, int tripulacion)
            : base(nombre, costo, estadoReparado, operacion, tripulacion)
        {
            
        }

        protected override int Tripulacion
        {
            get
            { return this.tripulacion; }
            set
            {
                if (this.tripulacion == 0)
                {
                    value = GenerarRandom.EnteroAleatorio(30, 60);
                }
            }
        }

        public override void CalcularCosto()
        {
            this.costo = GenerarRandom.EnteroAleatorio(5000, 25000);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(base.ToString());
            stringBuilder.AppendLine($"Costo: {this.costo}");
            stringBuilder.AppendLine($"Tripulacion: {this.Tripulacion}");
            return base.ToString();
        }
    }
}
