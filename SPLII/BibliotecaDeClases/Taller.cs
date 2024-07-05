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

        public bool EncontrarBarco(Barco barco)
        {
            bool retorno = false;
            foreach (Barco barcoLista in barcos)
            {
                if (Barco.CompararBarcos(barcoLista, barco))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public Taller IngresarBarco(Barco barco)
        {
            if (!this.EncontrarBarco(barco))
            {
                barcos.Add(barco);
            }
            return this;
        }

        public bool Reparar(Taller taller)
        {
            bool retorno = false;
            try
            {
                if (taller is Taller)
                {
                    foreach (Barco barco in taller.Barcos)
                    { 
                        if (barco.EstadoReparado == false)
                        {
                            barco.CalcularCosto();
                            AccesoDatos.Guardar("localhost", "barcos", barco, "GarciaGabriel");
                            barco.EstadoReparado = true;
                        }
                    }
                    retorno = true;
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return retorno;
            }
        }
    }
}
