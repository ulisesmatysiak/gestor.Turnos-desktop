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
    public partial class frmPanelServicios : Form
    {
        List<Servicio> listaServicio;
        public frmPanelServicios()
        {
            InitializeComponent();
        }

        private void frmPanelServicios_Load(object sender, EventArgs e)
        {
            cargar();
            ocultarColumnas();
        }

        private void cargar()
        {
            ServicioNegocio negocio = new ServicioNegocio();
            try
            {
                listaServicio = negocio.listar();
                dgvServicios.DataSource = listaServicio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            frmGestionServicios nuevo = new frmGestionServicios();
            nuevo.ShowDialog();
            cargar();
        }

        private void btnElliminarServicio_Click(object sender, EventArgs e)
        {
            ServicioNegocio negocio = new ServicioNegocio();
            Servicio seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Servicio)dgvServicios.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ocultarColumnas()
        {
            dgvServicios.Columns["Id"].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Servicio seleccionado;
            seleccionado = (Servicio)dgvServicios.CurrentRow.DataBoundItem;

            frmGestionServicios modificar = new frmGestionServicios();
            modificar.ShowDialog();
            cargar();
        }
    }
}
