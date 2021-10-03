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
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.NombreUsuario = this.txtNombreUsuario.Text;
            nuevoUsuario.Password = this.txtContraseñaUsuario.Text;
            nuevoUsuario.IdPerfil = Int32.Parse(this.mcbPerfilUsuarioUsuario.Text);
            nuevoUsuario.IdEstadoCuenta = Int32.Parse(this.mcbEstadoUsuario.Text);

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.IngresarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario Agregado");
        }//BTN INGRESAR USUARIO

        private void btnIngresarCliente_Click(object sender, EventArgs e) //BTN INGRESAR CLIENTE
        {

        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.IdUsuario = Int32.Parse(this.txtIdUsuario.Text);
            nuevoUsuario.NombreUsuario = this.txtNombreUsuario.Text;
            nuevoUsuario.Password = this.txtContraseñaUsuario.Text;
            nuevoUsuario.FechaCreacion = DateTime.Parse(this.mdtFechaCreacionUsuario.Text);
            nuevoUsuario.IdPerfil = Int32.Parse(this.mcbPerfilUsuarioUsuario.Text); // Perfil cliente
            nuevoUsuario.IdEstadoCuenta = Int32.Parse(this.mcbEstadoUsuario.Text); // cuenta activa

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.actualizarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario Actualizado");
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            NegocioUsuario negocioUsuario = new NegocioUsuario();

            int idUsuario = Int32.Parse(this.txtIdUsuario.Text);
            Usuario user = negocioUsuario.buscarUsuario(idUsuario);

            this.txtNombreUsuario.Text = user.NombreUsuario;
            this.txtContraseñaUsuario.Text = user.Password;
            this.mdtFechaCreacionUsuario.Text = user.FechaCreacion.ToString();
            this.mcbPerfilUsuarioUsuario.Text = user.IdPerfil.ToString();
            this.mcbEstadoUsuario.Text = user.IdEstadoCuenta.ToString();
        }

        private void btnMostrarUsuariosUsuario_Click(object sender, EventArgs e)
        {
            NegocioUsuario negocioUsuario = new NegocioUsuario();

            DataSet listaUsuarios = negocioUsuario.retornarUsuarios();

            this.dgvListaUsuarios.AutoGenerateColumns = true;
            this.dgvListaUsuarios.DataSource = listaUsuarios.Tables["USUARIO"];

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = Int32.Parse(this.txtIdUsuario.Text);

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.eliminarUsuario(idUsuario);
            MessageBox.Show("Usuario eliminado");
        }
    }
}

