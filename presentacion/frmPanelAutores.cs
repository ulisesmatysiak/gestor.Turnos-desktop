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
    }
}
