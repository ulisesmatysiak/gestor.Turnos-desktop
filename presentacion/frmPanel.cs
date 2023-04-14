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
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            frmPanelTurnos turnos = new frmPanelTurnos();
            turnos.ShowDialog();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            frmPanelServicios servicios = new frmPanelServicios();
            servicios.ShowDialog();      
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            frmPanelAutores autores = new frmPanelAutores();
            autores.ShowDialog();
        }
    }
}
