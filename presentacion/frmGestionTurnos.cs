using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmGestionTurnos : Form
    {
        private Turno turno = null;
        public frmGestionTurnos()
        {
            InitializeComponent();
        }
        public frmGestionTurnos(Turno turno)
        {
            InitializeComponent();
            this.turno = turno;
            Text = "Modificar turno";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGestionTurnos_Load(object sender, EventArgs e)
        {
            ServicioNegocio servicioNegocio = new ServicioNegocio();
            AutorNegocio autorNegocio = new AutorNegocio();

            try
            {
                cboServicio.DataSource = servicioNegocio.listar();
                cboServicio.ValueMember = "Id";
                cboServicio.DisplayMember = "Corte";
                cboAutor.DataSource = autorNegocio.listar();
                cboAutor.ValueMember = "Id";
                cboAutor.DisplayMember = "Nombre";

                if (turno != null)
                {
                    dtpFecha.Value = turno.Fecha;
                    txtCliente.Text = turno.Cliente;
                    cboServicio.SelectedValue = turno.Servicio.Id;
                    cboAutor.SelectedValue = turno.Autor.Id;
                    txtImporte.Text = turno.Importe.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TurnoNegocio negocio = new TurnoNegocio();
            try
            {
                if (turno == null)
                    turno = new Turno();

                turno.Fecha = dtpFecha.Value;
                turno.Cliente = txtCliente.Text;
                turno.Servicio = (Servicio)cboServicio.SelectedItem;
                turno.Autor = (Autor)cboAutor.SelectedItem;
                turno.Importe = decimal.Parse(txtImporte.Text);

                if (turno.Id != 0)
                {
                    negocio.modificar(turno);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(turno);
                    MessageBox.Show("Agregado exitosamente");
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
