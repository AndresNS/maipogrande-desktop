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

            this.cbxCategoriaProductos.DataSource = categorias.Tables["CATEGORIA"];
            this.cbxCategoriaProductos.ValueMember = "ID_CATEGORIA";
            this.cbxCategoriaProductos.DisplayMember = "NOMBRE_CATEGORIA";

            NegocioCalidad negocioCalidad = new NegocioCalidad();
            DataSet calidades = negocioCalidad.retornarCalidades();

            this.cbxCalidadProductos.DataSource = calidades.Tables["CALIDAD"];
            this.cbxCalidadProductos.ValueMember = "ID_CALIDAD";
            this.cbxCalidadProductos.DisplayMember = "DESCRIPCION";
        }

        private void btnSalirCrearCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnIngresarCrearCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.NombreCategoria = this.txtCrearNombreCategoria.Text;

            NegocioCategoria negocioCategoria = new NegocioCategoria();
            negocioCategoria.IngresarCategoria(categoria);
            MessageBox.Show("Categoria creada");
        }

        private void btnBuscarCrearCategoria_Click(object sender, EventArgs e)
        {
            NegocioCategoria negocioCategoria = new NegocioCategoria();

            int idCategoria = Int32.Parse(this.txtCrearCategoria.Text);
            Categoria categoria = negocioCategoria.buscarCategoria(idCategoria);

            this.txtCrearCategoria.Text = categoria.IdCategoria.ToString();
            this.txtCrearNombreCategoria.Text = categoria.NombreCategoria;
        }

        private void btnActualizarCrearAztualizar_Click(object sender, EventArgs e)
        {
            Categoria nuevaCategoria = new Categoria();
            nuevaCategoria.IdCategoria = Int32.Parse(this.txtCrearCategoria.Text);
            nuevaCategoria.NombreCategoria = this.txtCrearNombreCategoria.Text;

            NegocioCategoria negocioCategoria = new NegocioCategoria();
            negocioCategoria.actualizarCategoria(nuevaCategoria);
            MessageBox.Show("Categoria Actualizada");
        }

        private void btnEliminarCrearCategoria_Click(object sender, EventArgs e)
        {
            int idCategoria = Int32.Parse(this.txtCrearCategoria.Text);

            NegocioCategoria negocioCategoria = new NegocioCategoria();
            negocioCategoria.eliminarCategoria(idCategoria);
            MessageBox.Show("Categoria eliminada");
        }

        private void btnIngresarProductos_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.NombreProducto = this.txtNombreProductoProductos.Text;
            producto.PorcentajeMerma = Double.Parse(this.txtPorcentajeMerma.Text);
            producto.IdCalidad = Int32.Parse(cbxCalidadProductos.SelectedValue.ToString());
            producto.IdCategoria = Int32.Parse(cbxCategoriaProductos.SelectedValue.ToString());
            producto.Precio = Int32.Parse(txtPrecioProductos.Text);

            NegocioProducto negocioProducto = new NegocioProducto();
            negocioProducto.IngresarProducto(producto);
            MessageBox.Show("Producto creado");
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            Producto nuevoProducto = new Producto();
            nuevoProducto.IdProducto= Int32.Parse(this.txtIdProductoProductos.Text);
            nuevoProducto.NombreProducto = this.txtNombreProductoProductos.Text;
            nuevoProducto.IdCategoria = Int32.Parse(this.cbxCategoriaProductos.SelectedValue.ToString());
            nuevoProducto.IdCalidad = Int32.Parse(this.cbxCalidadProductos.SelectedValue.ToString());
            nuevoProducto.Precio = Int32.Parse(this.txtPrecioProductos.Text);
            nuevoProducto.PorcentajeMerma = Double.Parse(this.txtPorcentajeMerma.Text);

            NegocioProducto negocioProducto = new NegocioProducto();
            negocioProducto.actualizarProducto(nuevoProducto);
            MessageBox.Show("Producto Actualizado");
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            NegocioProducto negocioProducto = new NegocioProducto();

            int idProducto = Int32.Parse(this.txtIdProductoProductos.Text);
            Producto producto = negocioProducto.buscarProducto(idProducto);

            this.txtIdProductoProductos.Text = producto.IdProducto.ToString();
            this.txtNombreProductoProductos.Text = producto.NombreProducto;
            this.txtPrecioProductos.Text = producto.Precio.ToString();
            this.cbxCategoriaProductos.SelectedValue = producto.IdCategoria;
            this.cbxCalidadProductos.SelectedValue = producto.IdCalidad;
            this.txtPorcentajeMerma.Text = producto.PorcentajeMerma.ToString();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            int idProducto = Int32.Parse(this.txtIdProductoProductos.Text);

            NegocioProducto negocioProducto = new NegocioProducto();
            negocioProducto.eliminarProducto(idProducto);
            MessageBox.Show("Producto eliminado");
        }

        private void btnListarProductosProductos_Click(object sender, EventArgs e)
        {
            NegocioProducto negocioProducto = new NegocioProducto();

            DataSet listaProductos = negocioProducto.retornarProductos();

            this.dgvListaProductos.AutoGenerateColumns = true;
            this.dgvListaProductos.DataSource = listaProductos.Tables["PRODUCTO"];
        }
    }
}
