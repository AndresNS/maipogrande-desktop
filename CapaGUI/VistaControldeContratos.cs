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
    public partial class VistaControldeContratos : MetroFramework.Forms.MetroForm
    {
        public VistaControldeContratos()
        {
            InitializeComponent();
        }

        private void VistaControldeContratos_Load(object sender, EventArgs e)
        {

        }//metodo LOAD

        private void btnSalirProductor_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
