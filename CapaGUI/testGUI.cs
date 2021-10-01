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

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {

            int idUsuario = Int32.Parse(this.txtIdUsuario.Text);

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.eliminarUsuario(idUsuario);
            MessageBox.Show("Usuario eliminado");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioUsuario negocioUsuario = new NegocioUsuario();

            int idUsuario = Int32.Parse(this.txtIdUsuario.Text);
            Usuario user = negocioUsuario.buscarUsuario(idUsuario);

            this.txtNombre.Text = user.NombreUsuario;
            this.txtPass.Text = user.Password;
            this.txtFechaCreacion.Text = user.FechaCreacion.ToString();
            this.txtPerfil.Text = user.IdPerfil.ToString();
            this.txtEstado.Text = user.IdEstadoCuenta.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.IdUsuario = Int32.Parse(this.txtIdUsuario.Text);
            nuevoUsuario.NombreUsuario = this.txtNombre.Text;
            nuevoUsuario.Password = this.txtPass.Text;
            nuevoUsuario.FechaCreacion = DateTime.Parse(this.txtFechaCreacion.Text);
            nuevoUsuario.IdPerfil = Int32.Parse(this.txtPerfil.Text); // Perfil cliente
            nuevoUsuario.IdEstadoCuenta = Int32.Parse(this.txtEstado.Text); // cuenta activa

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.actualizarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario Actualizado");
        }
    }
}
