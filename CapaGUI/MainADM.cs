﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class MainADM : MetroFramework.Forms.MetroForm
    {
        public MainADM()
        {
            InitializeComponent();
        }

        private void btnMantenedores_Click(object sender, EventArgs e)
        {
        
            MantenedorUsuario ven = new MantenedorUsuario();
            ven.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            VistaDistribuirProductos ven = new VistaDistribuirProductos();
            ven.ShowDialog();
        }

        private void btnControlContratos_Click(object sender, EventArgs e)
        {
            VistaControldeContratos ven = new VistaControldeContratos();
            ven.ShowDialog();
        }
    }
}