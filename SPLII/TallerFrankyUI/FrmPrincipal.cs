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
using System.IO;

namespace TallerFrankyUi
{
    public partial class FrmPrincipal : Form
    {
        Taller taller;
        public FrmPrincipal()
        {
            InitializeComponent();
            //TODO: Instanciar el taller
            taller = new Taller();
            
        }

        private void btnCargarBarco_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBarco frmBarco = new FrmBarco();
                if (frmBarco.ShowDialog() == DialogResult.OK)
                {
                    if (!taller.EncontrarBarco(frmBarco.BarcoFormulario))
                    {
                        taller.IngresarBarco(frmBarco.BarcoFormulario);
                        MessageBox.Show("Se pudo cargar el barco.");
                    }
                    else
                    {
                        MessageBox.Show("El barco ya se encuentra en el taller.");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo cargar el barco.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnReparar_Click(object sender, EventArgs e)
        {
            FrmReparacion frmReparacion = new FrmReparacion(this.taller);
            frmReparacion.Show();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Preguntarle al usuario si esta seguro de salir del formulario
            //if (MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) 
            //    == DialogResult.OK )
            //{
            //    this.Close();
            //}
            //else
            //{
            //    this.Close();
            //}
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //TODO: Utilizar la clase XmlManager para guardar el archivo xml
            XmlManager xmlManager = new XmlManager();
            try
            {
                xmlManager.Guardar("barcos.xml", taller.Barcos);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            XmlManager xmlManager = new XmlManager();
            string path = "barcos.xml";
            if (File.Exists(path))
            {
                try
                {
                    taller.Barcos = xmlManager.Leer(path);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            
        }
    }
}
