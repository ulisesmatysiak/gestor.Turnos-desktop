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
    public partial class frmPanelAutores : Form
    {
        List<Autor> listaAutores;
        public frmPanelAutores()
        {
            InitializeComponent();
        }

        private void frmPanelAutores_Load(object sender, EventArgs e)
        {
            cargar();
            ocultarColumnas();
        }

        private void cargar()
        {
            AutorNegocio negocio = new AutorNegocio();
            try
            {
                listaAutores = negocio.listar();
                dgvAutores.DataSource = listaAutores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionAutores nuevo = new frmGestionAutores();
            nuevo.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AutorNegocio negocio = new AutorNegocio();
            Autor seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Autor)dgvAutores.CurrentRow.DataBoundItem;
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
            dgvAutores.Columns["Id"].Visible = false;
        }
    }
}
