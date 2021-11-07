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
    public partial class VistaPostulacionesProductores : MetroFramework.Forms.MetroForm
    {
        private int idProcesoVenta;

        public int IdProcesoVenta { get => idProcesoVenta; set => idProcesoVenta = value; }

        public VistaPostulacionesProductores(int idProcesoVenta)
        {
            InitializeComponent();
            this.IdProcesoVenta = idProcesoVenta;
        }
    }
}
