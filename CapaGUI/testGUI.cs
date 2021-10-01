using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDTO;

namespace CapaGUI
{
    public partial class testGUI : Form
    {
        public testGUI()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.NombreUsuario = this.txtNombreUsuario.Text;
            nuevoUsuario.Password = this.txtPassword.Text;
            nuevoUsuario.IdPerfil = 2; // Perfil cliente
            nuevoUsuario.IdEstadoCuenta = 1; // cuenta activa

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.IngresarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario Agregado");
        }

        private void btnMotrarUsuarios_Click(object sender, EventArgs e)
        {
            NegocioUsuario negocioUsuario = new NegocioUsuario();

            DataSet listaUsuarios = negocioUsuario.retornarUsuarios();

            this.dgvListaUsuarios.AutoGenerateColumns = true;
            this.dgvListaUsuarios.DataSource = listaUsuarios.Tables["USUARIO"];
            
        }
    }
}
