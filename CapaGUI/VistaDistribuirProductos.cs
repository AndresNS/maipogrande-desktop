using System;
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
    public partial class VistaDistribuirProductos : MetroFramework.Forms.MetroForm
    {
        public VistaDistribuirProductos()
        {
            InitializeComponent();
        }

        private void VistaDistribuirProductos_Load(object sender, EventArgs e)
        {
           

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirCrearCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
