using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class frmPanelTurnos : Form
    {
        List<Turno> listaTurno;
        public frmPanelTurnos()
        {
            InitializeComponent();
        }

        private void frmTurnos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            TurnoNegocio negocio = new TurnoNegocio();
            try
            {
                listaTurno = negocio.listar();
                dgvTurnos.DataSource = listaTurno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestionTurnos nuevo = new frmGestionTurnos();
            nuevo.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Turno seleccionado;
            seleccionado = (Turno)dgvTurnos.CurrentRow.DataBoundItem;

            frmGestionTurnos modificar = new frmGestionTurnos(seleccionado); 
            modificar.ShowDialog();
            cargar();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            Turno seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Turno)dgvTurnos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        private void dgvTurnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTurnos.CurrentRow != null)
            {
                Turno seleccionado = (Turno)dgvTurnos.CurrentRow.DataBoundItem;
            }
        }
    }
}
