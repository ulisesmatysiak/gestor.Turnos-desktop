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
    public partial class frmGestionAutores : Form
    {
        private Autor autor = null;
        public frmGestionAutores()
        {
            InitializeComponent();
        }

        public frmGestionAutores(Autor autor)
        {
            InitializeComponent();
            this.autor = autor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AutorNegocio negocio = new AutorNegocio();
            try
            {
                if (autor == null)
                    autor = new Autor();

                negocio.agregar(autor);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }      
        }      
    }
}
