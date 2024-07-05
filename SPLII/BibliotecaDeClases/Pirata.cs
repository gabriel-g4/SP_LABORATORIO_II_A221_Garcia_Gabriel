using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Pirata : Barco
    {
        public Pirata() : base ()
        {
            
        }

        public Pirata(string nombre, float costo, bool estadoReparado, EOperacion operacion, int tripulacion) 
            : base(nombre, costo, estadoReparado, operacion, tripulacion)
        {
            CalcularCosto();
        }

        protected override int Tripulacion 
        { 
            get 
            { return this.tripulacion; } 
            set
            {
                if (this.tripulacion == 0)
                {
                    value = GenerarRandom.EnteroAleatorio(10, 30);
                }
            }
          }

        public override void CalcularCosto()
        {
            this.costo = GenerarRandom.EnteroAleatorio(2000, 12000);
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
