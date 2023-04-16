﻿using dominio;
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ServicioNegocio negocio = new ServicioNegocio();

            if (servicio == null)
                servicio = new Servicio();

            negocio.agregar(servicio);
            MessageBox.Show("AgregadoExitosamente");
        }
    }
}
