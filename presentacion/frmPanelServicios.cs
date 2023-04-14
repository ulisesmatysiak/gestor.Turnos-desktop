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
    public partial class frmPanelServicios : Form
    {
        List<Servicio> listaServicio;
        public frmPanelServicios()
        {
            InitializeComponent();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            cargar();
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
    }
}