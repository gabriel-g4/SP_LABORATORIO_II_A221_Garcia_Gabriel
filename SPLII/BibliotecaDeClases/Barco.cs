using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Barco
    {
        protected float costo;
        protected bool estadoReparado;
        protected string nombre;
        protected EOperacion operacion;
        protected int tripulacion;

        public float Costo { get => costo; set => costo = value; }
        public bool EstadoReparado { get => estadoReparado; set => estadoReparado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EOperacion Operacion { get => operacion; set => operacion = value; }
        protected abstract int Tripulacion { get; set; }

        public Barco()
        {

        }
        public Barco(string nombre, float costo, bool estadoReparado, EOperacion operacion, int tripulacion)
        {
            this.nombre = nombre;
            this.costo = costo;
            this.estadoReparado = estadoReparado;
            this.operacion = operacion;
            this.tripulacion = tripulacion;
        }


        public abstract void CalcularCosto();

        public static bool CompararBarcos(Barco a, Barco b)
        {
            return a.Nombre == b.Nombre;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {this.Nombre}");
            //stringBuilder.AppendLine($"Costo: {this.Costo}");
            stringBuilder.AppendLine($"Estado reparado: {this.EstadoReparado}");
            stringBuilder.AppendLine($"EOperacion: {this.Operacion}");
            //stringBuilder.AppendLine($"Tripulacion: {this.Tripulacion}");

            return stringBuilder.ToString();
        }
    }
}
