using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    [Serializable]

    public class Pirata : Barco
    {
        public Pirata() : base ()
        {
            
        }

        public Pirata(string nombre, EOperacion operacion) 
            : base(nombre,  operacion)
        {
            this.tripulacion = 0;
        }

        public override int Tripulacion 
        { 
            get 
            {
                if (this.tripulacion == 0)
                {
                    this.tripulacion = GenerarRandom.EnteroAleatorio(10, 30);
                }
                return this.tripulacion; } 
            set
            {
                this.tripulacion = value;
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
            return stringBuilder.ToString();
        }
    }
}
