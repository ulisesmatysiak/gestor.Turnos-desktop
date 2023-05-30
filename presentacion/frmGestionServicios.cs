using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmGestionServicios : Form
    {
        private Servicio servicio = null;
        public frmGestionServicios()
        {
            InitializeComponent();
        }

        public frmGestionServicios(Servicio servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
            Text = "Modificar servicio";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGestionServicios_Load(object sender, EventArgs e)
        {
            ServicioNegocio negocio = new ServicioNegocio();
            try
            {
                if (servicio != null)
                {
                    txtServicios.Text = servicio.Corte;
                    txtValor.Text = servicio.Valor.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Servicio servicio = new Servicio();
            ServicioNegocio negocio = new ServicioNegocio();

            try
            {
                if (servicio == null)
                    servicio = new Servicio();

                servicio.Corte = txtServicios.Text;
                servicio.Valor = decimal.Parse(txtValor.Text);

                if (servicio.Id != 0)
                {
                    negocio.modificar(servicio);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(servicio);
                    MessageBox.Show("Agregado Exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
