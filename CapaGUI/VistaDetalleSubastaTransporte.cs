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
    public partial class VistaDetalleSubastaTransporte : MetroFramework.Forms.MetroForm
    {
        private int idSubastaTransporte;

        public int IdSubastaTransporte { get => idSubastaTransporte; set => idSubastaTransporte = value; }

        public VistaDetalleSubastaTransporte(int idSubastaTransporte)
        {
            InitializeComponent();
            this.IdSubastaTransporte = idSubastaTransporte;
        }
    }
}
