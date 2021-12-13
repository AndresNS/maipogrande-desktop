using CapaNegocio;
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
    public partial class VistaListadoVentasInternas : MetroFramework.Forms.MetroForm
    {
        public VistaListadoVentasInternas()
        {
            InitializeComponent();
        }

        private void VistaListadoVentasInternas_Load(object sender, EventArgs e)
        {
            // Cargar procesos de venta
            NegocioCabeceraOrdenCompra negocioCabeceraPV = new NegocioCabeceraOrdenCompra();
            DataSet listaOrdenesCompra = negocioCabeceraPV.ListarOrdenesCompra();

            this.dgvListaOrdenesCompra.AutoGenerateColumns = true;
            this.dgvListaOrdenesCompra.DataSource = listaOrdenesCompra.Tables["CABECERA_OC"];
        }
    }
}
