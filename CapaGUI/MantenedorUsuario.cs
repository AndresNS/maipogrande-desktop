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
    public partial class MantenedorUsuario : MetroFramework.Forms.MetroForm
    {
        public MantenedorUsuario()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtContraseñaUsuario.Text ="";
            txtDireccionCliente.Text = "";
            txtDireccionProductor.Text = "";
            txtDvCliente.Text = "";
            txtDvProductor.Text = "";
            txtGiroCliente.Text = "";
            txtGiroProductor.Text = "";
            txtIdUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtRazonSocialCliente.Text = "";
            txtRazonSocialProductor.Text = "";
            txtRutCliente.Text = "";
            txtRutProductor.Text = "";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        } //BTN SALIR CLIENTE

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }//CREADO X ERROR

        private void btnSalirUsuario_Click(object sender, EventArgs e)//BTN SALIR USUARIO
        {
            this.Close();
            this.Dispose();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        } //BTN SALIR PRODUCTOR

        private void btnIngresarProductor_Click(object sender, EventArgs e)//BTN INGRESAR PRODUCTOR
        {
          
        }

        private void btnIngresarUsuario_Click(object sender, EventArgs e)
        {

        }//BTN INGRESAR USUARIO

        private void btnIngresarCliente_Click(object sender, EventArgs e) //BTN INGRESAR CLIENTE
        {

        }
    }
}

