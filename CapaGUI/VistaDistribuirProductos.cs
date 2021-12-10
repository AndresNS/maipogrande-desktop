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
    public partial class VistaDistribuirProductos : MetroFramework.Forms.MetroForm
    {
        public VistaDistribuirProductos()
        {
            InitializeComponent();
        }

        private void VistaDistribuirProductos_Load(object sender, EventArgs e)
        {
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            DataSet categorias = negocioCategoria.retornarCategorias();

            this.txtCategoriaProductos.DataSource = categorias.Tables["CATEGORIA"];
            this.txtCategoriaProductos.ValueMember = "ID_CATEGORIA";
            this.txtCategoriaProductos.DisplayMember = "NOMBRE_CATEGORIA";

            NegocioCalidad negocioCalidad = new NegocioCalidad();
            DataSet calidades = negocioCalidad.retornarCalidades();

            this.txtCalidadProductos.DataSource = calidades.Tables["CALIDAD"];
            this.txtCalidadProductos.ValueMember = "ID_CALIDAD";
            this.txtCalidadProductos.DisplayMember = "DESCRIPCION";
            ///////////////////////////////////////////////////////////
            // METODO LOAD  RADIO BUTTON BUSCAR CATEGORIA 
            this.RadioBuscarCategoria.Checked = true;
            DeshabilitarCamposCategoria();
            this.btnEliminarCrearCategoria.Enabled = false;
            this.btnIngresarCrearCategoria.Enabled = false;
            this.btnActualizarCrearAztualizar.Enabled = false;
            ////////////////////////////////////////////////////////
            /////METODO LOAD BUTTON BUSCAR PRODUCTO
            ///

            ///////////////////////////LOAD DESABILITAR BTN PRODUCTO
            this.btnEliminarProducto.Enabled = false;
            this.btnActualizarProducto.Enabled = false;
            this.btnIngresarProductos.Enabled = false;

        }//METODO LOAD

        private void limpiarProductos()
        {
            this.txtIdProductoProductos.Text = String.Empty;
            this.txtCategoriaProductos.Text = String.Empty;
            this.txtNombreProductoProductos.Text = String.Empty;
            this.txtPrecioProductos.Text = String.Empty;
            this.txtCalidadProductos.Text = String.Empty;
            this.txtPorcentajeMerma.Text = String.Empty;
        } 
        private void limpiarCategoria()
        {
            this.txtIDCategoriaProductos.Text = String.Empty;
            this.txtNombreCategoriaProductos.Text = String.Empty;
        }
        private void DeshabilitarCamposProductos()
        {
            this.txtIdProductoProductos.Enabled = false;
            this.txtCategoriaProductos.Enabled = false;
            this.txtNombreProductoProductos.Enabled = false;
            this.txtPrecioProductos.Enabled = false;
            this.txtCalidadProductos.Enabled = false;
            this.txtPorcentajeMerma.Enabled = false;
        }
        private void DeshabilitarCamposCategoria()
        {
            this.txtIDCategoriaProductos.Enabled = false;
            this.txtNombreCategoriaProductos.Enabled = false;
        }
        private void HabilitarCamposProductos()
        {
            this.txtIdProductoProductos.Enabled = true;
            this.txtCategoriaProductos.Enabled = true;
            this.txtNombreProductoProductos.Enabled = true;
            this.txtPrecioProductos.Enabled = true;
            this.txtCalidadProductos.Enabled = true;
            this.txtPorcentajeMerma.Enabled = true;
        } 
        private void HabilitarCamposCategoria()
        {
            this.txtIDCategoriaProductos.Enabled = true;
            this.txtNombreCategoriaProductos.Enabled = true;
        }
        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e) // RADIO BUSCAR CATEGORIA
        {
            if (RadioBuscarCategoria.Checked)
            {
                DeshabilitarCamposCategoria();
                limpiarCategoria();
                this.btnEliminarCrearCategoria.Enabled = false;
                this.btnIngresarCrearCategoria.Enabled = false;
                this.btnActualizarCrearAztualizar.Enabled = false;
                this.txtBuscaridCategoria.Text = String.Empty;
                this.txtBuscaridCategoria.Enabled = true;
                this.btnBuscarCrearCategoria.Enabled = true;
            }
            else
            {
                limpiarCategoria();
                HabilitarCamposCategoria();

                this.btnEliminarCrearCategoria.Enabled = false;
                this.btnIngresarCrearCategoria.Enabled = true;
                this.btnIngresarCrearCategoria.Text = "Nueva Categoria";
                this.txtBuscaridCategoria.Text = String.Empty;
                this.txtBuscaridCategoria.Enabled = false;
                //this.txtBuscarEmpresa.Enabled = false;

            }
        }
        private void RadioBuscarProducto_CheckedChanged(object sender, EventArgs e) //METODO RADIO BUTTON BUSCAR PRODUCTOS
        {
            if (RadioBuscarProducto.Checked)
            {
                DeshabilitarCamposProductos();
                limpiarProductos();
                this.btnEliminarProducto.Enabled = false;
                this.btnIngresarProductos.Enabled = false;
                this.btnActualizarProducto.Enabled = false;
                this.txtBuscarProductos.Text = String.Empty;
                this.txtBuscarProductos.Enabled = true;
                this.txtBuscarProductos.Enabled = true;
            }
            else
            {
                limpiarProductos();
                HabilitarCamposProductos();

                this.btnEliminarProducto.Enabled = false;
                this.btnIngresarProductos.Enabled = true;
                this.btnIngresarProductos.Text = "Nuevo Producto";
                this.txtBuscarProductos.Text = String.Empty;
                this.txtBuscarProductos.Enabled = false;
                

            }
        }
        private void btnSalirCrearCategoria_Click(object sender, EventArgs e) //BTN SALIR CATEGORIA
        {
            this.Close();
            this.Dispose();
        }

        private void btnIngresarCrearCategoria_Click(object sender, EventArgs e) //BTN INGRESAR CATEGORIA
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.NombreCategoria = this.txtNombreCategoriaProductos.Text;

                NegocioCategoria negocioCategoria = new NegocioCategoria();
                negocioCategoria.IngresarCategoria(categoria);
                MessageBox.Show("Categoria creada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INGRESAR CATEGORIA" +ex);
            }

        }

        private void btnBuscarCrearCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioCategoria negocioCategoria = new NegocioCategoria();

                int idCategoria = Int32.Parse(this.txtBuscaridCategoria.Text);
                Categoria categoria = negocioCategoria.buscarCategoria(idCategoria);

                this.txtIDCategoriaProductos.Text = categoria.IdCategoria.ToString();
                this.txtNombreCategoriaProductos.Text = categoria.NombreCategoria;

                MessageBox.Show("Categoria Encontrada " );
                this.txtBuscaridCategoria.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL BUSCAR CATEGORIA " +ex);
            }

        }

        private void btnActualizarCrearAztualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria nuevaCategoria = new Categoria();
                nuevaCategoria.IdCategoria = Int32.Parse(this.txtIDCategoriaProductos.Text);
                nuevaCategoria.NombreCategoria = this.txtNombreCategoriaProductos.Text;

                NegocioCategoria negocioCategoria = new NegocioCategoria();
                negocioCategoria.actualizarCategoria(nuevaCategoria);
                MessageBox.Show("Categoria Actualizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ACTUALIZAR CATEGORIA" +ex);
            }
        }//BTNACTUALIZAR 

        private void btnEliminarCrearCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = Int32.Parse(this.txtIDCategoriaProductos.Text);

                NegocioCategoria negocioCategoria = new NegocioCategoria();
                negocioCategoria.eliminarCategoria(idCategoria);
                MessageBox.Show("Categoria eliminada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR CATEGORIA" +ex );
            }

        }//BTN ELIMINAR CATEGORIA

        private void btnIngresarProductos_Click(object sender, EventArgs e) //BTN INGRESAR PRODUCTOS
        {
            try
            {
                Producto producto = new Producto();
                producto.NombreProducto = this.txtNombreProductoProductos.Text;
                producto.PorcentajeMerma = Double.Parse(this.txtPorcentajeMerma.Text);
                producto.IdCalidad = Int32.Parse(txtCalidadProductos.SelectedValue.ToString());
                producto.IdCategoria = Int32.Parse(txtCategoriaProductos.SelectedValue.ToString());
                producto.Precio = Int32.Parse(txtPrecioProductos.Text);

                NegocioProducto negocioProducto = new NegocioProducto();
                negocioProducto.IngresarProducto(producto);
                MessageBox.Show("Producto creado");
                this.btnActualizarProducto.Enabled = true;
                this.btnEliminarProducto.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INGRESAR PRRODUCTO" +ex);
            }
        }//BTN INGRESAR PRODUCTOS

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevoProducto = new Producto();
                nuevoProducto.IdProducto = Int32.Parse(this.txtIdProductoProductos.Text);
                nuevoProducto.NombreProducto = this.txtNombreProductoProductos.Text;
                nuevoProducto.IdCategoria = Int32.Parse(this.txtCategoriaProductos.SelectedValue.ToString());
                nuevoProducto.IdCalidad = Int32.Parse(this.txtCalidadProductos.SelectedValue.ToString());
                nuevoProducto.Precio = Int32.Parse(this.txtPrecioProductos.Text);
                nuevoProducto.PorcentajeMerma = Double.Parse(this.txtPorcentajeMerma.Text);

                NegocioProducto negocioProducto = new NegocioProducto();
                negocioProducto.actualizarProducto(nuevoProducto);
                MessageBox.Show("Producto Actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ACTUALIZAR PRODUCTO" +ex);
            }

        }//BTN ACTUALIZAR PRODUCTO

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioProducto negocioProducto = new NegocioProducto();

                int idProducto = Int32.Parse(this.txtBuscarProductos.Text); //cambio txt buscar productos
                Producto producto = negocioProducto.buscarProducto(idProducto);

                this.txtIdProductoProductos.Text = producto.IdProducto.ToString();
                this.txtNombreProductoProductos.Text = producto.NombreProducto;
                this.txtPrecioProductos.Text = producto.Precio.ToString();
                this.txtCategoriaProductos.SelectedValue = producto.IdCategoria;
                this.txtCalidadProductos.SelectedValue = producto.IdCalidad;
                this.txtPorcentajeMerma.Text = producto.PorcentajeMerma.ToString();


                MessageBox.Show("Producto Encontrado ");
                this.txtBuscarProductos.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MOSTRAR PRODUCTOS" +ex);
            }

        }//BTN BUSCAR PRODUCTOS

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Int32.Parse(this.txtIdProductoProductos.Text);

                NegocioProducto negocioProducto = new NegocioProducto();
                negocioProducto.eliminarProducto(idProducto);
                MessageBox.Show("Producto eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR PRODUCTO" +ex);
            }

        } //BTN ELIMINAR PRODUCTO

        private void btnListarProductosProductos_Click(object sender, EventArgs e) //METODO LISTAR PRODUCTOS
        {
            try
            {
                NegocioProducto negocioProducto = new NegocioProducto();

                DataSet listaProductos = negocioProducto.retornarProductos();

                this.dgvListaProductos.AutoGenerateColumns = true;
                this.dgvListaProductos.DataSource = listaProductos.Tables["PRODUCTO"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL LISTAR PRODUCTOS" +ex);
            }

        }


    }
}
