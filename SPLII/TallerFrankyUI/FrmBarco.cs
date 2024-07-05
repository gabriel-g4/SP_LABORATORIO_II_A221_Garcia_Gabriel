using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerFrankyUi
{
    public partial class FrmBarco : Form
    {
        Barco barcoFormulario;
        public FrmBarco()
        {
            InitializeComponent();
            cmbTipo.DataSource = new List<ETipoBarco>{ ETipoBarco.Pirata, ETipoBarco.Marina };
            cmbOperacion.DataSource = new List<EOperacion> {EOperacion.Cambiar_Velas, EOperacion.Pintar, EOperacion.Recargar_Cañones, EOperacion.Reparar_Mascaron, EOperacion.Reparar_Mastil, EOperacion.Repara_Casco };
        }


        public Barco BarcoFormulario
        {
            get { return this.barcoFormulario; }
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            //TODO:Validar si el barco es pirata o marina y lo instancio
            // retornar DialogResult OK y cerrar el formulario
            // 

            try
            {
                string nombre = txtNombre.Text.ToString();
                ETipoBarco tipo = (ETipoBarco) cmbTipo.SelectedItem;
                EOperacion operacion = (EOperacion)cmbOperacion.SelectedItem;
                
                if (tipo == ETipoBarco.Marina)
                {
                    Marina barco = new Marina(nombre, operacion);
                    this.barcoFormulario = barco;
                }
                else if (tipo == ETipoBarco.Pirata)
                {
                    Pirata barco = new Pirata(nombre, operacion);
                    this.barcoFormulario = barco;
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show(ex.Message);
            }
            
            
        }
     
    }
}
