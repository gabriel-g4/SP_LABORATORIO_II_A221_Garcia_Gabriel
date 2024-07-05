using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace TallerFrankyUi
{
    public partial class FrmReparacion : Form
    {
        Taller taller;
        public FrmReparacion(Taller taller)
        {
            InitializeComponent();
            this.taller = taller;
        }

        private void FrmReparacion_Load(object sender, EventArgs e)
        {
            //TODO: Asocio el evento que va a imprimir el ticket
            //TODO: Instanciar y comenzar el hilo que se va a encargar de reparar los barcos del taller
           
            foreach (Barco barco in this.taller.Barcos)
            {
                taller.Reparar(taller);
                if (barco is Pirata)
                {
                    Pirata pirata = (Pirata)barco;
                    lstTaller.Items.Add(pirata.ToString());
                }
                else if (barco is Marina)
                {
                    Marina marina = (Marina)barco;
                    lstTaller.Items.Add(marina.ToString());
                }
            }


           
        }

        private void FrmReparacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void lblBarcoTipo_Click(object sender, EventArgs e)
        {

        }
    }
}
