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
using Oracle.ManagedDataAccess.Client;

namespace CapaGUI
{
    public partial class MantenedorUsuario : MetroFramework.Forms.MetroForm
    {
        public MantenedorUsuario()
        {
            InitializeComponent();
        }

        private void MantenedorUsuario_Load(object sender, EventArgs e) //LOAD MANTENEDOR 
        {
            this.txtIdUsuario.Enabled = false;

            //Load Perfil Usuario

            NegocioPerfil negocioPerfil = new NegocioPerfil();
            DataSet perfiles = negocioPerfil.retornarPerfiles();

            this.mcbPerfilUsuarioUsuario.DataSource = perfiles.Tables["PERFIL"];
            this.mcbPerfilUsuarioUsuario.ValueMember = "ID_PERFIL";
            this.mcbPerfilUsuarioUsuario.DisplayMember = "DESC_PERFIL";

            //Load Estado Cuenta

            NegocioEstadoCuenta negocioEstadoCuenta = new NegocioEstadoCuenta();
            DataSet estados = negocioEstadoCuenta.retornarEstadoCuenta();

            this.mcbEstadoUsuario.DataSource = estados.Tables["ESTD_CTA"];
            this.mcbEstadoUsuario.ValueMember = "ID_ESTD_CTA";
            this.mcbEstadoUsuario.DisplayMember = "NOMBRE_ESTD_CTA";

            //Load Comuna 

            NegocioComuna negocioComuna = new NegocioComuna();
            DataSet comunas = negocioComuna.retornarComunas();

            //Load Comuna Cliente

            this.mcbComunaCliente.DataSource = comunas.Tables["COMUNA"];
            this.mcbComunaCliente.ValueMember = "ID";
            this.mcbComunaCliente.DisplayMember = "NOMBRE_COMUNA";


            //Load Comuna Productor


            this.mcbComunaProductor.DataSource = comunas.Tables["COMUNA"];
            this.mcbComunaProductor.ValueMember = "ID";
            this.mcbComunaProductor.DisplayMember = "NOMBRE_COMUNA";

            //Load Tipo Cliente

            NegocioTipoCliente negocioTipoCliente = new NegocioTipoCliente();
            DataSet tiposCliente = negocioTipoCliente.retornarTipos();

            this.mcbTipoCliente.DataSource = tiposCliente.Tables["TIPO_CLIENTE"];
            this.mcbTipoCliente.ValueMember = "ID_TIPO";
            this.mcbTipoCliente.DisplayMember = "DESC_TIPO";


            //METODO LOAD CLIENTE
            //this.radiobtnBuscarClienteCliente.Checked = true;
            //deshabilitarCamposCliente();
            //this.btnEliminarCliente.Enabled = false;
            //this.btnActualizarCliente.Enabled = false;
            //this.btnIngresarCliente.Enabled = false;
            //this.btnActualizarCliente.Enabled = false;
            ///////////////////////////////////////////
            //METODO LOAD USUARIO
            //this.RadioBuscarUsuario.Checked = true;
            //deshabilitarCamposUsuario();
            //this.btnEliminarUsuario.Enabled = false;
            //this.btnIngresarUsuario.Enabled = false;
            //this.btnActualizarUsuario.Enabled = false;
            //////////////////////////////////////////////
            //METODO LOAD PRODUCTOR
            //this.RadioBuscarProductor.Checked = true;
            //deshabilitarCamposProductor();
            //this.btnEliminarProductor.Enabled = false;
            //this.btnActualizarProductor.Enabled = false;
            //this.btnIngresarProductor.Enabled = false;
            //
            ///////////////////////////////////////////////
            //METODO LOAD DE EMPRESA
            //this.RadioBuscarEmpresa.Checked = true;
            //deshabilitarCamposEmpresa();
            //this.btnEliminarEmpresaTransporte.Enabled = false;
            // this.btnIngresarEmpresaTransporte.Enabled = false;
            //this.btnActualizarEmpresaTransporte.Enabled = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        } //BTN SALIR CLIENTE
        private void limpiarCamposCliente() // METODO LIMPIAR CAMPOS CLIENTE
        {
            this.txtRutCliente.Text = String.Empty;
            this.txtDvCliente.Text = String.Empty;
            this.txtRazonSocialCliente.Text = String.Empty;
            this.txtDireccionCliente.Text = String.Empty;
            this.txtGiroCliente.Text = String.Empty;
            this.mcbComunaCliente.Text = "";
            this.mcbTipoCliente.Text = "";
            this.mcbUsuarioCliente.Text = "";
        }
        private void limpiarCamposUsuario() //METODO LIMPIAR CAMPOS USUARIO
        {
            this.txtIdUsuario.Text = String.Empty;
            this.txtNombreUsuario.Text = String.Empty;
            this.txtContraseñaUsuario.Text = String.Empty;
            this.txtFechaCreacionUsuario.Text = String.Empty;
            this.mcbPerfilUsuarioUsuario.Text = String.Empty;
            this.mcbEstadoUsuario.Text = String.Empty;
        }
        private void limpiarCamposProductor() //METODO LIMPIAR CAMPOS PRODUCTOR
        {
            this.txtRutProductor.Text = String.Empty;
            this.txtDvProductor.Text = String.Empty;
            this.txtRazonSocialProductor.Text = String.Empty;
            this.txtDireccionProductor.Text = String.Empty;
            this.txtGiroProductor.Text = String.Empty;
            this.mcbComunaProductor.Text = String.Empty;
            this.mcbIdUsuarioProductor.Text = String.Empty;
        }
        private void limpiarCamposEmpresa() //  METODO LIMPIAR CAMPOS EMPRESA
        {
            this.txtidEmpresaTransporte.Text = String.Empty;
            this.txtNombreEmpresaTransporte.Text = String.Empty;
            this.txtidUsuarioEmpresa.Text = String.Empty;
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void deshabilitarCamposCliente() //DESACTIVAR TEXTOS CLIENTE
        {
            this.txtRutCliente.Enabled = false;
            this.txtDvCliente.Enabled = false;
            this.txtRazonSocialCliente.Enabled = false;
            this.txtDireccionCliente.Enabled = false;
            this.txtGiroCliente.Enabled = false;
            this.mcbComunaCliente.Enabled = false;
            this.mcbTipoCliente.Enabled = false;
            this.mcbUsuarioCliente.Enabled = false;
        }
        private void deshabilitarCamposUsuario() //DESACTIVAR TEXTOS DE USUARIO
        {
            this.txtIdUsuario.Enabled = false;
            this.txtNombreUsuario.Enabled = false;
            this.txtContraseñaUsuario.Enabled = false;
            this.txtFechaCreacionUsuario.Enabled = false;
            this.mcbPerfilUsuarioUsuario.Enabled = false;
            this.mcbEstadoUsuario.Enabled = false;
        }
        private void deshabilitarCamposProductor() //DESACTIVAR TEXTOS DE PRODUCTOR
        {
            this.txtRutProductor.Enabled = false;
            this.txtDvProductor.Enabled = false;
            this.txtRazonSocialProductor.Enabled = false;
            this.txtDireccionProductor.Enabled = false;
            this.txtGiroProductor.Enabled = false;
            this.mcbComunaProductor.Enabled = false;
            this.mcbIdUsuarioProductor.Enabled = false;
        }
        private void deshabilitarCamposEmpresa() // DESACTIVAR TEXTOS DE EMPRESA
        {
            this.txtidEmpresaTransporte.Enabled = false;
            this.txtNombreEmpresaTransporte.Enabled = false;
            this.txtidUsuarioEmpresa.Enabled = false;
        }
        private void habilitarCamposCliente() //ACTIVAR TEXTOS DE CLIENTE
        {
            this.txtRutCliente.Enabled = true;
            this.txtDvCliente.Enabled = true;
            this.txtRazonSocialCliente.Enabled = true;
            this.txtDireccionCliente.Enabled = true;
            this.txtGiroCliente.Enabled = true;
            this.mcbComunaCliente.Enabled = true;
            this.mcbTipoCliente.Enabled = true;
            this.mcbUsuarioCliente.Enabled = true;
        }
        private void habilitarCamposUsuario() //ACTIVAR TEXTOS DE USUARIOS
        {
            this.txtIdUsuario.Enabled = true;
            this.txtNombreUsuario.Enabled = true;
            this.txtContraseñaUsuario.Enabled = true;
            this.txtFechaCreacionUsuario.Enabled = true;
            this.mcbPerfilUsuarioUsuario.Enabled = true;
            this.mcbEstadoUsuario.Enabled = true;
        }
        private void habilitarCamposProductor() //ACTIVAR TEXTOS DE PRODUCTOR
        {
            this.txtRutProductor.Enabled = true;
            this.txtDvProductor.Enabled = true;
            this.txtRazonSocialProductor.Enabled = true;
            this.txtDireccionProductor.Enabled = true;
            this.txtGiroProductor.Enabled = true;
            this.mcbComunaProductor.Enabled = true;
            this.mcbIdUsuarioProductor.Enabled = true;
        }
        private void habilitarCamposEmpresa() //ACTIVAR TEXTOS DE EMPRESA
        {
            this.txtidEmpresaTransporte.Enabled = true;
            this.txtNombreEmpresaTransporte.Enabled = true;
            this.txtidUsuarioEmpresa.Enabled = true;
        }

        /*private void radiobtnIngresarClienteCliente_CheckedChanged(object sender, EventArgs e) //RADIO INGRESAR CLIENTE
        {

        }
        private void radiobtnBuscarClienteCliente_CheckedChanged(object sender, EventArgs e) //RADIO BUTTON BUSCAR CLIENTE
        {
            if (radiobtnBuscarClienteCliente.Checked)
            {
                deshabilitarCamposCliente();
                limpiarCamposCliente();
                this.btnEliminarCliente.Enabled = false;
                this.btnIngresarCliente.Enabled = false;
                this.btnActualizarCliente.Enabled = false;
                this.txtBuscarClienteCliente.Text = String.Empty;
                this.txtBuscarClienteCliente.Enabled = true;
                this.btnMostrarCliente.Enabled = true;
            }
            else
            {
                limpiarCamposCliente();
                habilitarCamposCliente();
                //this.txtRutCliente.Enabled = false;
                //this.txtDvCliente.Enabled = false;
                this.btnEliminarCliente.Enabled = false;
                this.btnIngresarCliente.Enabled = true;
                this.btnIngresarCliente.Text = "Nuevo Cliente";
                this.txtBuscarClienteCliente.Text = String.Empty;
                this.txtBuscarClienteCliente.Enabled = false;
                this.btnMostrarCliente.Enabled = false;

            }
        }
        private void RadioBuscarUsuario_CheckedChanged(object sender, EventArgs e) //RADIO BUTTON BUSCAR USUARIO
        {
            if (RadioBuscarUsuario.Checked)
            {
                deshabilitarCamposUsuario();
                limpiarCamposUsuario();
                this.btnEliminarUsuario.Enabled = false;
                this.btnIngresarUsuario.Enabled = false;
                this.txtBuscarUsuario.Text = String.Empty;
                this.txtBuscarUsuario.Enabled = true;
                this.btnBuscarUsuario.Enabled = true;
            }
            else
            {
                limpiarCamposUsuario();
                habilitarCamposUsuario();
                //this.txtRutCliente.Enabled = false;
                //this.txtDvCliente.Enabled = false;
                this.btnEliminarUsuario.Enabled = false;
                this.btnIngresarUsuario.Enabled = true;
                this.btnIngresarUsuario.Text = "Nuevo Usuario";
                this.txtBuscarUsuario.Text = String.Empty;
                this.txtBuscarUsuario.Enabled = false;
                this.btnBuscarUsuario.Enabled = false;

            }

        }
        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e) //RADIO BUTTON BUSCAR EMPRESA
        {
            if (RadioBuscarEmpresa.Checked)
            {
                deshabilitarCamposEmpresa();
                limpiarCamposEmpresa();
                this.btnEliminarEmpresaTransporte.Enabled = false;
                this.btnIngresarEmpresaTransporte.Enabled = false;
                this.btnActualizarEmpresaTransporte.Enabled = false;
                this.txtBuscarEmpresa.Text = String.Empty;
                this.txtBuscarEmpresa.Enabled = true;
                this.btnBuscarEmpresaTransporte.Enabled = true;
            }
            else
            {
                limpiarCamposEmpresa();
                habilitarCamposEmpresa();

                this.btnEliminarEmpresaTransporte.Enabled = false;
                this.btnIngresarEmpresaTransporte.Enabled = true;
                this.btnActualizarEmpresaTransporte.Enabled = false;
                this.btnIngresarEmpresaTransporte.Text = "Nuevo Transporte";
                this.txtBuscarEmpresa.Text = String.Empty;
                this.txtBuscarEmpresa.Enabled = false;
                this.txtBuscarEmpresa.Enabled = false;

            }
        }
        private void RadioBuscarProductor_CheckedChanged(object sender, EventArgs e) //RADIO BUSCAR PRODUCTOR
        {
            if (RadioBuscarProductor.Checked)
            {
                deshabilitarCamposProductor();
                limpiarCamposProductor();
                this.btnEliminarProductor.Enabled = false;
                this.btnIngresarProductor.Enabled = false;
                this.btnActualizarProductor.Enabled = false;
                this.txtBuscarProductor.Text = String.Empty;
                this.txtBuscarProductor.Enabled = true;
                this.btnBuscarProductor.Enabled = true;
            }
            else
            {
                limpiarCamposProductor();
                habilitarCamposProductor();
                this.btnEliminarProductor.Enabled = false;
                this.btnIngresarProductor.Enabled = true;
                this.btnIngresarProductor.Text = "Nuevo Usuario";
                this.txtBuscarProductor.Text = String.Empty;
                this.txtBuscarProductor.Enabled = false;
                this.btnBuscarProductor.Enabled = false;

            }
        }
        */


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
                nuevoCliente.IdTipo = Int32.Parse(this.mcbTipoCliente.Text);
                nuevoCliente.IdUsuario = Int32.Parse(this.mcbUsuarioCliente.Text);

                NegocioCliente negocioCliente = new NegocioCliente();
                negocioCliente.IngresarCliente(nuevoCliente);
                MessageBox.Show("Cliente Creado con exito");
                limpiarCamposCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear cliente "+ex);
            }
          


        }
        private void btnActualizarCliente_Click(object sender, EventArgs e)//BTN ACTUALIZAR CLIENTE
        {
            try
            {
                Cliente actualizarCliente = new Cliente();
                actualizarCliente.Rut = Int32.Parse(this.txtRutCliente.Text);
                actualizarCliente.DvRut = this.txtDvCliente.Text;
                actualizarCliente.RazonSocial = this.txtRazonSocialCliente.Text;
                actualizarCliente.Direccion = this.txtDireccionCliente.Text;
                actualizarCliente.Giro = this.txtGiroCliente.Text;
                actualizarCliente.IdComuna = Int32.Parse(this.mcbComunaCliente.Text);
                actualizarCliente.IdTipo = Int32.Parse(this.mcbTipoCliente.Text);
                actualizarCliente.IdUsuario = Int32.Parse(this.mcbUsuarioCliente.Text);

                NegocioCliente negocioCliente = new NegocioCliente();
                negocioCliente.actualizarCliente(actualizarCliente);
                MessageBox.Show("Cliente Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR AL ACTUALIZAR CLIENTE" +ex);
            }


        }
        //private void btnMostrarCliente_Click(object sender, EventArgs e) //BTN BUSCAR CLIENTE
        //{
        //    NegocioCliente negocioCliente = new NegocioCliente();
        //    int rutCliente = Int32.Parse(this.txtRutCliente.Text);
        //    Cliente cliente = negocioCliente.buscarCliente(rutCliente);

        //    this.txtDvCliente.Text = cliente.DvRut;
        //    this.txtRazonSocialCliente.Text = cliente.RazonSocial;
        //    this.txtDireccionCliente.Text = cliente.Direccion;
        //    this.txtGiroCliente.Text = cliente.Giro;
        //    this.mcbComunaCliente.Text = cliente.IdComuna.ToString();
        //    this.mcbTipoUsuarioCliente.Text = cliente.IdTipo.ToString();
        //    this.mcbUsuarioCliente.Text = cliente.IdUsuario.ToString();

        //}
        private void btnMostrarCliente_Click_1(object sender, EventArgs e) // BTN BUSCAR CLIENTE
        {

        }//MOSTRAR CLIENTE
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int rutCliente = Int32.Parse(this.txtRutCliente.Text);
                NegocioCliente negociocliente = new NegocioCliente();
                negociocliente.eliminarCliente(rutCliente);

                MessageBox.Show("Cliente eliminado");
                limpiarCamposCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR ELIMINAR CLIENTE "+ex);
            }

        }//ELIMINAR CLIENTE
        private void btnIngresarUsuario_Click(object sender, EventArgs e) //INGRESAR USUARIO
        {
            try
            {
                Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.NombreUsuario = this.txtNombreUsuario.Text;
                nuevoUsuario.Password = this.txtContraseñaUsuario.Text;
                nuevoUsuario.IdPerfil = Int32.Parse(this.mcbPerfilUsuarioUsuario.Text);
                nuevoUsuario.IdEstadoCuenta = Int32.Parse(this.mcbEstadoUsuario.Text);

                NegocioUsuario negocioUsuario = new NegocioUsuario();
                negocioUsuario.IngresarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario Agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR INGRESAR USUARIO" +ex);
            }                

        }//BTN INGRESAR USUARIO
        private void btnActualizarUsuario_Click(object sender, EventArgs e) //ACTUALIZAR USUARIO
        {
            try
            {
                Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.IdUsuario = Int32.Parse(this.txtIdUsuario.Text);
                nuevoUsuario.NombreUsuario = this.txtNombreUsuario.Text;
                nuevoUsuario.Password = this.txtContraseñaUsuario.Text;
                nuevoUsuario.FechaCreacion = DateTime.Parse(this.txtFechaCreacionUsuario.Text);
                nuevoUsuario.IdPerfil = Int32.Parse(this.mcbPerfilUsuarioUsuario.Text); // Perfil cliente
                nuevoUsuario.IdEstadoCuenta = Int32.Parse(this.mcbEstadoUsuario.Text); // cuenta activa

                NegocioUsuario negocioUsuario = new NegocioUsuario();
                negocioUsuario.actualizarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR ACTUALIZAR USUARIO "+ex);
            }

        }

        /*private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioUsuario negocioUsuario = new NegocioUsuario();

                int idUsuario = Int32.Parse(this.txtBuscarIDUsuario.Text);
                Usuario user = negocioUsuario.buscarUsuario(idUsuario);

                this.txtNombreUsuario.Text = user.NombreUsuario;
                this.txtContraseñaUsuario.Text = user.Password;
                this.txtFechaCreacionUsuario.Text = user.FechaCreacion.ToString();
                this.mcbPerfilUsuarioUsuario.Text = user.IdPerfil.ToString();
                this.mcbEstadoUsuario.Text = user.IdEstadoCuenta.ToString();
                MessageBox.Show("Usuario Encontrado");
                habilitarCamposUsuario(); // NUEVO
                this.btnActualizarUsuario.Enabled = true; // NUEVO
                this.btnEliminarUsuario.Enabled = true; //NUEVO
                this.txtIdUsuario.Text = (txtBuscarIDUsuario.Text); //NUEVO
                this.txtBuscarIDUsuario.Text = ""; //NUEVO
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL BUSCAR USUARIO");
                limpiarCamposUsuario(); //NUEVO
                btnActualizarUsuario.Enabled = false;// nuevo
                btnEliminarUsuario.Enabled = false; //nuevo
            }

        }//BUSCAR USUARIO
        */
        //private void btnMostrarUsuariosUsuario_Click(object sender, EventArgs e)
        //{
        //    NegocioUsuario negocioUsuario = new NegocioUsuario();

        //    DataSet listaUsuarios = negocioUsuario.retornarUsuarios();

        //    this.dgvListaUsuarios.AutoGenerateColumns = true;
        //    this.dgvListaUsuarios.DataSource = listaUsuarios.Tables["USUARIO"];

        //} //MOSTRAR USUARIO

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Int32.Parse(this.txtIdUsuario.Text);

                NegocioUsuario negocioUsuario = new NegocioUsuario();
                negocioUsuario.eliminarUsuario(idUsuario);
                MessageBox.Show("Usuario eliminado");
                limpiarCamposUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR USUARIO" +ex);
            }

        }//ELIMINAR USUARIO

        private void btnActualizarProductor_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ACTUALIZAR PRODUCTOR "+ex);
            }

         
        }//ACTUALIZAR PRODUCTOR

        private void btnEliminarProductor_Click(object sender, EventArgs e) //BTN ELIMINAR PRODUCTOR
        {
            try
            {
                NegocioProductor negocioProductor = new NegocioProductor();

                int rutProductor = Int32.Parse(this.txtRutProductor.Text);

                negocioProductor.eliminarProductor(rutProductor);
                MessageBox.Show("Usuario eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR ELIMINAR PRODUCTOR" +ex);
            }

 

        } //ELIMINAR PRODUCTOR

        private void btnIngresarEmpresaTransporte_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaTransporte nuevoTransaporte = new EmpresaTransporte();
                nuevoTransaporte.NombreEmpresa = this.txtNombreEmpresaTransporte.Text;
                nuevoTransaporte.IdUsuario = Int32.Parse(this.txtidUsuarioEmpresa.Text);

                NegocioEmpresaTransporte negocioTransporte = new NegocioEmpresaTransporte();
                negocioTransporte.IngresarEmpresaTransporte(nuevoTransaporte);

                MessageBox.Show("Transporte Agregado");
                limpiarCamposEmpresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR INGRESAR EMPRESA DE TRANSPORTE " +ex);
            }

        }//BTN INGRESAR EMPRESA TRANSPORTE

        private void btnActualizarEmpresaTransporte_Click(object sender, EventArgs e)
        {
            try
            {
                EmpresaTransporte actualizarEmpresaTransporte = new EmpresaTransporte();
               
                actualizarEmpresaTransporte.IdEmpresa = Int32.Parse(this.txtidEmpresaTransporte.Text);
                actualizarEmpresaTransporte.NombreEmpresa = this.txtNombreEmpresaTransporte.Text;
                actualizarEmpresaTransporte.IdUsuario = Int32.Parse(this.txtidUsuarioEmpresa.Text);

                NegocioEmpresaTransporte negocioTransporte = new NegocioEmpresaTransporte();

                negocioTransporte.actualizarEmpresaTransporte(actualizarEmpresaTransporte);
                MessageBox.Show("Empresa de Transporte  Actualizado");
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR ACTUALIZAR EMPRESA DE TRANSPORTE: " + ex);
            }


        }//BTN ACTUALIZAR EMPRESA DE TRANSPORTE

        private void btnEliminarEmpresaTransporte_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpresa = Int32.Parse(this.txtidEmpresaTransporte.Text);

                NegocioEmpresaTransporte negocioTransporte = new NegocioEmpresaTransporte();
                negocioTransporte.eliminarEmpresaTransporte(idEmpresa);

                MessageBox.Show("Empresa de Transporte Eliminada ");
                limpiarCamposEmpresa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR ELIMINAR EMPRES " +ex);
                
            }

        }//BTN ELIMINAR EMPRESA TRANSPORTE


        private void btnSalirEmpresaTransaporte_Click(object sender, EventArgs e) //BTN SALIR DE EMPRESA
        {
            this.Close();
            this.Dispose();
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }//error, bug si se elimina.

        private void mcbPerfilUsuarioUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.TAB.SelectedIndex = this.mcbPerfilUsuarioUsuario.SelectedIndex;

            switch (this.mcbPerfilUsuarioUsuario.SelectedIndex) { 
                case 0: //admin
                    deshabilitarCamposCliente();
                    deshabilitarCamposEmpresa();
                    deshabilitarCamposProductor();
                    break;
                case 1: //cliente
                    habilitarCamposCliente();
                    deshabilitarCamposProductor();
                    deshabilitarCamposEmpresa();
                    break;
                case 2: //empresa transportes
                    deshabilitarCamposCliente();
                    deshabilitarCamposProductor();
                    habilitarCamposEmpresa();
                    break;
                case 3: //productor
                    deshabilitarCamposCliente();
                    habilitarCamposProductor();
                    deshabilitarCamposEmpresa();
                    break;

            }
        }
    }
}

