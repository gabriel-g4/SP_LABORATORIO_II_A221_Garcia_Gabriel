using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Barco;

namespace BibliotecaDeClases
{
    [Serializable]

    public class Marina : Barco
    {

        public Marina() : base()
        {

        }

        public Marina(string nombre, EOperacion operacion)
            : base(nombre, operacion)
        {
            this.tripulacion = 0;
        }

        public override int Tripulacion
        {
            get
            {
                if (this.tripulacion == 0)
                {
                    this.tripulacion = GenerarRandom.EnteroAleatorio(30, 60);
                }
                return this.tripulacion;
            }
            set
            {
                this.tripulacion = value;
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
            return stringBuilder.ToString();
        }
    }
}
