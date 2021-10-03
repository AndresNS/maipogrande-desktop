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
            try
            {
                Productor nuevoProductor = new Productor();
                nuevoProductor.Rut = Int32.Parse(this.txtRutProductor.Text);
                nuevoProductor.DigitoVerificador = this.txtDvProductor.Text;
                nuevoProductor.RazonSocial = this.txtRazonSocialProductor.Text;
                nuevoProductor.Direccion = this.txtDireccionProductor.Text;
                nuevoProductor.Giro = this.txtGiroProductor.Text;
                nuevoProductor.IdComuna = Int32.Parse(this.mcbComunaProductor.Text);
                nuevoProductor.IdUsuario = Int32.Parse(this.mcbIdUsuarioProductor.Text);

                NegocioProductor negocioProductor = new NegocioProductor();
                negocioProductor.IngresarProductor(nuevoProductor);
                MessageBox.Show("Cliente Creado con exito");


            }
            catch (Exception exingresodatosproductor)
            {
                MessageBox.Show("Error al ingresar nuevo Productor:" +exingresodatosproductor);
            }
           

        }

       

        private void btnIngresarCliente_Click(object sender, EventArgs e) //BTN INGRESAR CLIENTE
        {
            try
            {
                Cliente nuevoCliente = new Cliente();
                nuevoCliente.Rut = Int32.Parse(this.txtRutCliente.Text);
                nuevoCliente.DvRut = this.txtDvCliente.Text;
                nuevoCliente.RazonSocial = this.txtRazonSocialCliente.Text;
                nuevoCliente.Direccion = this.txtDireccionCliente.Text;
                nuevoCliente.Giro = this.txtGiroCliente.Text;
                nuevoCliente.IdComuna = Int32.Parse(this.mcbComunaCliente.Text);
                nuevoCliente.IdTipo = Int32.Parse(this.mcbTipoUsuarioCliente.Text);
                nuevoCliente.IdUsuario = Int32.Parse(this.mcbUsuarioCliente.Text);

                NegocioCliente negocioCliente = new NegocioCliente();
                negocioCliente.IngresarCliente(nuevoCliente);
                MessageBox.Show("Cliente Creado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear cliente");
            }
          


        }
        private void btnActualizarCliente_Click(object sender, EventArgs e)//BTN ACTUALIZAR CLIENTE
        {
            Cliente actualizarCliente = new Cliente();
            actualizarCliente.Rut = Int32.Parse(this.txtRutCliente.Text);
            actualizarCliente.DvRut = this.txtDvCliente.Text;
            actualizarCliente.RazonSocial = this.txtRazonSocialCliente.Text;
            actualizarCliente.Direccion = this.txtDireccionCliente.Text;
            actualizarCliente.Giro = this.txtGiroCliente.Text;
            actualizarCliente.IdComuna = Int32.Parse(this.mcbComunaCliente.Text);
            actualizarCliente.IdTipo = Int32.Parse(this.mcbTipoUsuarioCliente.Text);
            actualizarCliente.IdUsuario = Int32.Parse(this.mcbUsuarioCliente.Text);

            NegocioCliente negocioCliente = new NegocioCliente();
            negocioCliente.actualizarCliente(actualizarCliente);
            MessageBox.Show("Cliente Actualizado");

        }
        private void btnMostrarCliente_Click(object sender, EventArgs e) //BTN BUSCAR CLIENTE
        {
            NegocioCliente negocioCliente = new NegocioCliente();
            int rutCliente = Int32.Parse(this.txtRutCliente.Text);
            Cliente cliente = negocioCliente.buscarCliente(rutCliente);

            this.txtDvCliente.Text = cliente.DvRut;
            this.txtRazonSocialCliente.Text = cliente.RazonSocial;
            this.txtDireccionCliente.Text = cliente.Direccion;
            this.txtGiroCliente.Text = cliente.Giro;
            this.mcbComunaCliente.Text = cliente.IdComuna.ToString();
            this.mcbTipoUsuarioCliente.Text = cliente.IdTipo.ToString();
            this.mcbUsuarioCliente.Text = cliente.IdUsuario.ToString();

        }
          private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int rutCliente = Int32.Parse(this.txtRutCliente.Text);
            NegocioCliente negociocliente = new NegocioCliente();
            negociocliente.eliminarCliente(rutCliente);
                    
            MessageBox.Show("Cliente eliminado");
        }
        private void btnIngresarUsuario_Click(object sender, EventArgs e) //INGRESAR USUARIO
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
        private void btnActualizarUsuario_Click(object sender, EventArgs e) //ACTUALIZAR USUARIO
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
        }//BUSCAR USUARIO

        private void btnMostrarUsuariosUsuario_Click(object sender, EventArgs e)
        {
            NegocioUsuario negocioUsuario = new NegocioUsuario();

            DataSet listaUsuarios = negocioUsuario.retornarUsuarios();

            this.dgvListaUsuarios.AutoGenerateColumns = true;
            this.dgvListaUsuarios.DataSource = listaUsuarios.Tables["USUARIO"];

        } //MOSTRAR USUARIO

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = Int32.Parse(this.txtIdUsuario.Text);

            NegocioUsuario negocioUsuario = new NegocioUsuario();
            negocioUsuario.eliminarUsuario(idUsuario);
            MessageBox.Show("Usuario eliminado");
        }//ELIMINAR USUARIO

        private void btnActualizarProductor_Click(object sender, EventArgs e)
        {
            Productor actualizarProductor = new Productor();
            Productor nuevoProductor = new Productor();
            actualizarProductor.Rut = Int32.Parse(this.txtRutProductor.Text);
            actualizarProductor.DigitoVerificador = this.txtDvProductor.Text;
            actualizarProductor.RazonSocial = this.txtRazonSocialProductor.Text;
            actualizarProductor.Direccion = this.txtDireccionProductor.Text;
            actualizarProductor.Giro = this.txtGiroProductor.Text;
            actualizarProductor.IdComuna = Int32.Parse(this.mcbComunaProductor.Text);
            actualizarProductor.IdUsuario = Int32.Parse(this.mcbIdUsuarioProductor.Text);


            NegocioProductor negocioProductor = new NegocioProductor();
            negocioProductor.actualizarProductor(actualizarProductor);
            MessageBox.Show("Productor Actualizado");
         
        }//ACTUALIZAR PRODUCTOR

        private void btnBuscarProductor_Click(object sender, EventArgs e)
        {
            NegocioProductor negocioProductor = new NegocioProductor();

            int rutProductor = Int32.Parse(this.txtRutProductor.Text);

            Productor productor = negocioProductor.buscarProductor(rutProductor);

            this.txtDvProductor.Text = productor.DigitoVerificador;
            this.txtRazonSocialProductor.Text = productor.RazonSocial;
            this.txtDireccionProductor.Text = productor.Direccion;
            this.txtGiroProductor.Text = productor.Giro;
            this.mcbComunaProductor.Text = productor.IdComuna.ToString();
            this.mcbIdUsuarioProductor.Text = productor.IdUsuario.ToString();

        }//BUSCAR PRODUCTOR

        private void btnEliminarProductor_Click(object sender, EventArgs e)
        {


            NegocioProductor negocioProductor = new NegocioProductor();

            int rutProductor = Int32.Parse(this.txtRutProductor.Text);

            negocioProductor.eliminarProductor(rutProductor);
            MessageBox.Show("Usuario eliminado");

        } //ELIMINAR PRODUCTOR

        private void btnIngresarEmpresaTransporte_Click(object sender, EventArgs e)
        {

            EmpresaTransporte nuevoTransaporte = new EmpresaTransporte();
            nuevoTransaporte.NombreEmpresa = this.txtNombreEmpresaTransporte.Text;
            nuevoTransaporte.IdUsuario = Int32.Parse(this.txtidUsuarioEmpresa.Text);

            NegocioEmpresaTransporte negocioTransporte = new NegocioEmpresaTransporte();
            negocioTransporte.IngresarEmpresaTransporte(nuevoTransaporte);
                   
            MessageBox.Show("Transporte Agregado");
        }

        private void btnBuscarEmpresaTransporte_Click(object sender, EventArgs e)
        {
            NegocioEmpresaTransporte negocioTransporte = new NegocioEmpresaTransporte();

            int idEmpresa = Int32.Parse(this.txtidEmpresaTransporte.Text);
            EmpresaTransporte transporte = negocioTransporte.buscarEmpresaTransporte(idEmpresa);
            
            this.txtNombreEmpresaTransporte.Text = transporte.NombreEmpresa;
            this.txtidUsuarioEmpresa.Text = transporte.IdUsuario.ToString();
        }

        private void btnActualizarEmpresaTransporte_Click(object sender, EventArgs e)
        {
            EmpresaTransporte actualizarEmpresaTransporte = new EmpresaTransporte();
            EmpresaTransporte updateTransporte = new EmpresaTransporte();

            actualizarEmpresaTransporte.IdEmpresa = Int32.Parse(this.txtidEmpresaTransporte.Text);
            actualizarEmpresaTransporte.NombreEmpresa = this.txtNombreEmpresaTransporte.Text;
            actualizarEmpresaTransporte.IdUsuario = Int32.Parse(this.txtidUsuarioEmpresa.Text);

            NegocioEmpresaTransporte negocioTransporte  = new NegocioEmpresaTransporte();

            negocioTransporte.actualizarEmpresaTransporte(actualizarEmpresaTransporte);
            MessageBox.Show("Empresa de Transporte  Actualizado");


        }

        private void btnEliminarEmpresaTransporte_Click(object sender, EventArgs e)
        {
            int idEmpresa = Int32.Parse(this.txtidEmpresaTransporte.Text);

            NegocioEmpresaTransporte negocioTransporte = new NegocioEmpresaTransporte();
            negocioTransporte.eliminarEmpresaTransporte(idEmpresa);
            
            MessageBox.Show("Empresa de Transporte Eliminada ");
        }

      
    }
}

