
namespace CapaGUI
{
    partial class VistaDistribuirProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.RadioIngresarProducto = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBuscarProducto = new MetroFramework.Controls.MetroRadioButton();
            this.txtBuscarProductos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnMostrarProductos = new MetroFramework.Controls.MetroTile();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.btnIngresarProductos = new MetroFramework.Controls.MetroTile();
            this.btnActualizarProducto = new MetroFramework.Controls.MetroTile();
            this.btnEliminarProducto = new MetroFramework.Controls.MetroTile();
            this.btnSalirProductos = new MetroFramework.Controls.MetroTile();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.lblProductos = new MetroFramework.Controls.MetroLabel();
            this.txtIdProductoProductos = new MetroFramework.Controls.MetroTextBox();
            this.lblNombreProducto = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblIdCategoriaProducto = new MetroFramework.Controls.MetroLabel();
            this.txtPrecioProductos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtCategoriaProductos = new MetroFramework.Controls.MetroComboBox();
            this.txtCalidadProductos = new MetroFramework.Controls.MetroComboBox();
            this.txtNombreProductoProductos = new MetroFramework.Controls.MetroTextBox();
            this.txtPorcentajeMerma = new MetroFramework.Controls.MetroTextBox();
            this.dgvListaProductos = new MetroFramework.Controls.MetroGrid();
            this.btnListarProductosProductos = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.RadioIngresarCategoria = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBuscarCategoria = new MetroFramework.Controls.MetroRadioButton();
            this.txtBuscaridCategoria = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscarCrearCategoria = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnIngresarCrearCategoria = new MetroFramework.Controls.MetroTile();
            this.btnActualizarCrearAztualizar = new MetroFramework.Controls.MetroTile();
            this.btnSalirCrearCategoria = new MetroFramework.Controls.MetroTile();
            this.btnEliminarCrearCategoria = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblIdCrearCategoria = new MetroFramework.Controls.MetroLabel();
            this.lblNombreCrearCategoria = new MetroFramework.Controls.MetroLabel();
            this.txtIDCategoriaProductos = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreCategoriaProductos = new MetroFramework.Controls.MetroTextBox();
            this.Tab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.metroTabPage1);
            this.Tab.Controls.Add(this.metroTabPage2);
            this.Tab.Location = new System.Drawing.Point(23, 73);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(754, 587);
            this.Tab.TabIndex = 0;
            this.Tab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel6);
            this.metroTabPage1.Controls.Add(this.metroPanel5);
            this.metroTabPage1.Controls.Add(this.metroPanel4);
            this.metroTabPage1.Controls.Add(this.dgvListaProductos);
            this.metroTabPage1.Controls.Add(this.btnListarProductosProductos);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(746, 545);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Productos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroPanel6
            // 
            this.metroPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel6.Controls.Add(this.RadioIngresarProducto);
            this.metroPanel6.Controls.Add(this.RadioBuscarProducto);
            this.metroPanel6.Controls.Add(this.txtBuscarProductos);
            this.metroPanel6.Controls.Add(this.metroLabel3);
            this.metroPanel6.Controls.Add(this.btnMostrarProductos);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(393, 15);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(323, 100);
            this.metroPanel6.TabIndex = 32;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // RadioIngresarProducto
            // 
            this.RadioIngresarProducto.AutoSize = true;
            this.RadioIngresarProducto.Location = new System.Drawing.Point(168, 12);
            this.RadioIngresarProducto.Name = "RadioIngresarProducto";
            this.RadioIngresarProducto.Size = new System.Drawing.Size(117, 15);
            this.RadioIngresarProducto.TabIndex = 30;
            this.RadioIngresarProducto.Text = "Ingresar Producto";
            this.RadioIngresarProducto.UseSelectable = true;
            // 
            // RadioBuscarProducto
            // 
            this.RadioBuscarProducto.AutoSize = true;
            this.RadioBuscarProducto.Location = new System.Drawing.Point(16, 12);
            this.RadioBuscarProducto.Name = "RadioBuscarProducto";
            this.RadioBuscarProducto.Size = new System.Drawing.Size(110, 15);
            this.RadioBuscarProducto.TabIndex = 29;
            this.RadioBuscarProducto.Text = "Buscar Producto";
            this.RadioBuscarProducto.UseSelectable = true;
            this.RadioBuscarProducto.CheckedChanged += new System.EventHandler(this.RadioBuscarProducto_CheckedChanged);
            // 
            // txtBuscarProductos
            // 
            // 
            // 
            // 
            this.txtBuscarProductos.CustomButton.Image = null;
            this.txtBuscarProductos.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txtBuscarProductos.CustomButton.Name = "";
            this.txtBuscarProductos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscarProductos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscarProductos.CustomButton.TabIndex = 1;
            this.txtBuscarProductos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscarProductos.CustomButton.UseSelectable = true;
            this.txtBuscarProductos.CustomButton.Visible = false;
            this.txtBuscarProductos.Lines = new string[0];
            this.txtBuscarProductos.Location = new System.Drawing.Point(79, 61);
            this.txtBuscarProductos.MaxLength = 32767;
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.PasswordChar = '\0';
            this.txtBuscarProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarProductos.SelectedText = "";
            this.txtBuscarProductos.SelectionLength = 0;
            this.txtBuscarProductos.SelectionStart = 0;
            this.txtBuscarProductos.ShortcutsEnabled = true;
            this.txtBuscarProductos.Size = new System.Drawing.Size(120, 23);
            this.txtBuscarProductos.TabIndex = 28;
            this.txtBuscarProductos.UseSelectable = true;
            this.txtBuscarProductos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscarProductos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(5, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "BUSCAR:";
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.ActiveControl = null;
            this.btnMostrarProductos.Location = new System.Drawing.Point(205, 54);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(98, 35);
            this.btnMostrarProductos.TabIndex = 26;
            this.btnMostrarProductos.Text = "Buscar";
            this.btnMostrarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrarProductos.UseSelectable = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // metroPanel5
            // 
            this.metroPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel5.Controls.Add(this.btnIngresarProductos);
            this.metroPanel5.Controls.Add(this.btnActualizarProducto);
            this.metroPanel5.Controls.Add(this.btnEliminarProducto);
            this.metroPanel5.Controls.Add(this.btnSalirProductos);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(393, 121);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(323, 126);
            this.metroPanel5.TabIndex = 31;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // btnIngresarProductos
            // 
            this.btnIngresarProductos.ActiveControl = null;
            this.btnIngresarProductos.Location = new System.Drawing.Point(35, 20);
            this.btnIngresarProductos.Name = "btnIngresarProductos";
            this.btnIngresarProductos.Size = new System.Drawing.Size(127, 39);
            this.btnIngresarProductos.TabIndex = 23;
            this.btnIngresarProductos.Text = "Ingresar";
            this.btnIngresarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresarProductos.UseSelectable = true;
            this.btnIngresarProductos.Click += new System.EventHandler(this.btnIngresarProductos_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.ActiveControl = null;
            this.btnActualizarProducto.Location = new System.Drawing.Point(168, 20);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(119, 42);
            this.btnActualizarProducto.TabIndex = 24;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizarProducto.UseSelectable = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.ActiveControl = null;
            this.btnEliminarProducto.Location = new System.Drawing.Point(35, 68);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(127, 40);
            this.btnEliminarProducto.TabIndex = 25;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarProducto.UseSelectable = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnSalirProductos
            // 
            this.btnSalirProductos.ActiveControl = null;
            this.btnSalirProductos.Location = new System.Drawing.Point(168, 68);
            this.btnSalirProductos.Name = "btnSalirProductos";
            this.btnSalirProductos.Size = new System.Drawing.Size(119, 40);
            this.btnSalirProductos.TabIndex = 27;
            this.btnSalirProductos.Text = "SALIR";
            this.btnSalirProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalirProductos.UseSelectable = true;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.lblProductos);
            this.metroPanel4.Controls.Add(this.txtIdProductoProductos);
            this.metroPanel4.Controls.Add(this.lblNombreProducto);
            this.metroPanel4.Controls.Add(this.metroLabel1);
            this.metroPanel4.Controls.Add(this.lblIdCategoriaProducto);
            this.metroPanel4.Controls.Add(this.txtPrecioProductos);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.metroLabel5);
            this.metroPanel4.Controls.Add(this.txtCategoriaProductos);
            this.metroPanel4.Controls.Add(this.txtCalidadProductos);
            this.metroPanel4.Controls.Add(this.txtNombreProductoProductos);
            this.metroPanel4.Controls.Add(this.txtPorcentajeMerma);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 14);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(326, 233);
            this.metroPanel4.TabIndex = 30;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(16, 25);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(87, 19);
            this.lblProductos.TabIndex = 3;
            this.lblProductos.Text = "ID Productos:";
            // 
            // txtIdProductoProductos
            // 
            // 
            // 
            // 
            this.txtIdProductoProductos.CustomButton.Image = null;
            this.txtIdProductoProductos.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtIdProductoProductos.CustomButton.Name = "";
            this.txtIdProductoProductos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdProductoProductos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdProductoProductos.CustomButton.TabIndex = 1;
            this.txtIdProductoProductos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdProductoProductos.CustomButton.UseSelectable = true;
            this.txtIdProductoProductos.CustomButton.Visible = false;
            this.txtIdProductoProductos.Lines = new string[0];
            this.txtIdProductoProductos.Location = new System.Drawing.Point(140, 21);
            this.txtIdProductoProductos.MaxLength = 32767;
            this.txtIdProductoProductos.Name = "txtIdProductoProductos";
            this.txtIdProductoProductos.PasswordChar = '\0';
            this.txtIdProductoProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdProductoProductos.SelectedText = "";
            this.txtIdProductoProductos.SelectionLength = 0;
            this.txtIdProductoProductos.SelectionStart = 0;
            this.txtIdProductoProductos.ShortcutsEnabled = true;
            this.txtIdProductoProductos.Size = new System.Drawing.Size(172, 23);
            this.txtIdProductoProductos.TabIndex = 2;
            this.txtIdProductoProductos.UseSelectable = true;
            this.txtIdProductoProductos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdProductoProductos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(13, 89);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(120, 19);
            this.lblNombreProducto.TabIndex = 4;
            this.lblNombreProducto.Text = "Nombre Producto:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Precio";
            // 
            // lblIdCategoriaProducto
            // 
            this.lblIdCategoriaProducto.AutoSize = true;
            this.lblIdCategoriaProducto.Location = new System.Drawing.Point(14, 57);
            this.lblIdCategoriaProducto.Name = "lblIdCategoriaProducto";
            this.lblIdCategoriaProducto.Size = new System.Drawing.Size(86, 19);
            this.lblIdCategoriaProducto.TabIndex = 5;
            this.lblIdCategoriaProducto.Text = "ID Categoria:";
            // 
            // txtPrecioProductos
            // 
            // 
            // 
            // 
            this.txtPrecioProductos.CustomButton.Image = null;
            this.txtPrecioProductos.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtPrecioProductos.CustomButton.Name = "";
            this.txtPrecioProductos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioProductos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioProductos.CustomButton.TabIndex = 1;
            this.txtPrecioProductos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioProductos.CustomButton.UseSelectable = true;
            this.txtPrecioProductos.CustomButton.Visible = false;
            this.txtPrecioProductos.Lines = new string[0];
            this.txtPrecioProductos.Location = new System.Drawing.Point(140, 120);
            this.txtPrecioProductos.MaxLength = 32767;
            this.txtPrecioProductos.Name = "txtPrecioProductos";
            this.txtPrecioProductos.PasswordChar = '\0';
            this.txtPrecioProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioProductos.SelectedText = "";
            this.txtPrecioProductos.SelectionLength = 0;
            this.txtPrecioProductos.SelectionStart = 0;
            this.txtPrecioProductos.ShortcutsEnabled = true;
            this.txtPrecioProductos.Size = new System.Drawing.Size(173, 23);
            this.txtPrecioProductos.TabIndex = 28;
            this.txtPrecioProductos.UseSelectable = true;
            this.txtPrecioProductos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioProductos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 152);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "ID Calidad:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 190);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(120, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Porcentaje Merma:";
            // 
            // txtCategoriaProductos
            // 
            this.txtCategoriaProductos.FormattingEnabled = true;
            this.txtCategoriaProductos.ItemHeight = 23;
            this.txtCategoriaProductos.Location = new System.Drawing.Point(140, 50);
            this.txtCategoriaProductos.Name = "txtCategoriaProductos";
            this.txtCategoriaProductos.Size = new System.Drawing.Size(172, 29);
            this.txtCategoriaProductos.TabIndex = 8;
            this.txtCategoriaProductos.UseSelectable = true;
            // 
            // txtCalidadProductos
            // 
            this.txtCalidadProductos.FormattingEnabled = true;
            this.txtCalidadProductos.ItemHeight = 23;
            this.txtCalidadProductos.Location = new System.Drawing.Point(140, 149);
            this.txtCalidadProductos.Name = "txtCalidadProductos";
            this.txtCalidadProductos.Size = new System.Drawing.Size(172, 29);
            this.txtCalidadProductos.TabIndex = 9;
            this.txtCalidadProductos.UseSelectable = true;
            // 
            // txtNombreProductoProductos
            // 
            // 
            // 
            // 
            this.txtNombreProductoProductos.CustomButton.Image = null;
            this.txtNombreProductoProductos.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtNombreProductoProductos.CustomButton.Name = "";
            this.txtNombreProductoProductos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreProductoProductos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreProductoProductos.CustomButton.TabIndex = 1;
            this.txtNombreProductoProductos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreProductoProductos.CustomButton.UseSelectable = true;
            this.txtNombreProductoProductos.CustomButton.Visible = false;
            this.txtNombreProductoProductos.Lines = new string[0];
            this.txtNombreProductoProductos.Location = new System.Drawing.Point(140, 88);
            this.txtNombreProductoProductos.MaxLength = 32767;
            this.txtNombreProductoProductos.Name = "txtNombreProductoProductos";
            this.txtNombreProductoProductos.PasswordChar = '\0';
            this.txtNombreProductoProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreProductoProductos.SelectedText = "";
            this.txtNombreProductoProductos.SelectionLength = 0;
            this.txtNombreProductoProductos.SelectionStart = 0;
            this.txtNombreProductoProductos.ShortcutsEnabled = true;
            this.txtNombreProductoProductos.Size = new System.Drawing.Size(172, 23);
            this.txtNombreProductoProductos.TabIndex = 10;
            this.txtNombreProductoProductos.UseSelectable = true;
            this.txtNombreProductoProductos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreProductoProductos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPorcentajeMerma
            // 
            // 
            // 
            // 
            this.txtPorcentajeMerma.CustomButton.Image = null;
            this.txtPorcentajeMerma.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtPorcentajeMerma.CustomButton.Name = "";
            this.txtPorcentajeMerma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentajeMerma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentajeMerma.CustomButton.TabIndex = 1;
            this.txtPorcentajeMerma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentajeMerma.CustomButton.UseSelectable = true;
            this.txtPorcentajeMerma.CustomButton.Visible = false;
            this.txtPorcentajeMerma.Lines = new string[0];
            this.txtPorcentajeMerma.Location = new System.Drawing.Point(139, 190);
            this.txtPorcentajeMerma.MaxLength = 32767;
            this.txtPorcentajeMerma.Name = "txtPorcentajeMerma";
            this.txtPorcentajeMerma.PasswordChar = '\0';
            this.txtPorcentajeMerma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentajeMerma.SelectedText = "";
            this.txtPorcentajeMerma.SelectionLength = 0;
            this.txtPorcentajeMerma.SelectionStart = 0;
            this.txtPorcentajeMerma.ShortcutsEnabled = true;
            this.txtPorcentajeMerma.Size = new System.Drawing.Size(173, 23);
            this.txtPorcentajeMerma.TabIndex = 11;
            this.txtPorcentajeMerma.UseSelectable = true;
            this.txtPorcentajeMerma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentajeMerma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToResizeRows = false;
            this.dgvListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaProductos.EnableHeadersVisualStyles = false;
            this.dgvListaProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListaProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListaProductos.Location = new System.Drawing.Point(144, 253);
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProductos.Size = new System.Drawing.Size(572, 212);
            this.dgvListaProductos.TabIndex = 25;
            // 
            // btnListarProductosProductos
            // 
            this.btnListarProductosProductos.ActiveControl = null;
            this.btnListarProductosProductos.Location = new System.Drawing.Point(5, 253);
            this.btnListarProductosProductos.Name = "btnListarProductosProductos";
            this.btnListarProductosProductos.Size = new System.Drawing.Size(132, 66);
            this.btnListarProductosProductos.TabIndex = 24;
            this.btnListarProductosProductos.Text = "Mostrar Productos";
            this.btnListarProductosProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListarProductosProductos.UseSelectable = true;
            this.btnListarProductosProductos.Click += new System.EventHandler(this.btnListarProductosProductos_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanel3);
            this.metroTabPage2.Controls.Add(this.metroPanel2);
            this.metroTabPage2.Controls.Add(this.metroPanel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(746, 545);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Crear Categoria";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.RadioIngresarCategoria);
            this.metroPanel3.Controls.Add(this.RadioBuscarCategoria);
            this.metroPanel3.Controls.Add(this.txtBuscaridCategoria);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.btnBuscarCrearCategoria);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(387, 30);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(341, 137);
            this.metroPanel3.TabIndex = 35;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // RadioIngresarCategoria
            // 
            this.RadioIngresarCategoria.AutoSize = true;
            this.RadioIngresarCategoria.Location = new System.Drawing.Point(184, 19);
            this.RadioIngresarCategoria.Name = "RadioIngresarCategoria";
            this.RadioIngresarCategoria.Size = new System.Drawing.Size(119, 15);
            this.RadioIngresarCategoria.TabIndex = 35;
            this.RadioIngresarCategoria.Text = "Ingresar Categoria";
            this.RadioIngresarCategoria.UseSelectable = true;
            // 
            // RadioBuscarCategoria
            // 
            this.RadioBuscarCategoria.AutoSize = true;
            this.RadioBuscarCategoria.Location = new System.Drawing.Point(16, 19);
            this.RadioBuscarCategoria.Name = "RadioBuscarCategoria";
            this.RadioBuscarCategoria.Size = new System.Drawing.Size(112, 15);
            this.RadioBuscarCategoria.TabIndex = 34;
            this.RadioBuscarCategoria.Text = "Buscar Categoria";
            this.RadioBuscarCategoria.UseSelectable = true;
            this.RadioBuscarCategoria.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // txtBuscaridCategoria
            // 
            // 
            // 
            // 
            this.txtBuscaridCategoria.CustomButton.Image = null;
            this.txtBuscaridCategoria.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtBuscaridCategoria.CustomButton.Name = "";
            this.txtBuscaridCategoria.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscaridCategoria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscaridCategoria.CustomButton.TabIndex = 1;
            this.txtBuscaridCategoria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscaridCategoria.CustomButton.UseSelectable = true;
            this.txtBuscaridCategoria.CustomButton.Visible = false;
            this.txtBuscaridCategoria.Lines = new string[0];
            this.txtBuscaridCategoria.Location = new System.Drawing.Point(84, 74);
            this.txtBuscaridCategoria.MaxLength = 32767;
            this.txtBuscaridCategoria.Name = "txtBuscaridCategoria";
            this.txtBuscaridCategoria.PasswordChar = '\0';
            this.txtBuscaridCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscaridCategoria.SelectedText = "";
            this.txtBuscaridCategoria.SelectionLength = 0;
            this.txtBuscaridCategoria.SelectionStart = 0;
            this.txtBuscaridCategoria.ShortcutsEnabled = true;
            this.txtBuscaridCategoria.Size = new System.Drawing.Size(118, 23);
            this.txtBuscaridCategoria.TabIndex = 33;
            this.txtBuscaridCategoria.UseSelectable = true;
            this.txtBuscaridCategoria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscaridCategoria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(16, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 32;
            this.metroLabel2.Text = "BUSCAR:";
            // 
            // btnBuscarCrearCategoria
            // 
            this.btnBuscarCrearCategoria.ActiveControl = null;
            this.btnBuscarCrearCategoria.Location = new System.Drawing.Point(208, 65);
            this.btnBuscarCrearCategoria.Name = "btnBuscarCrearCategoria";
            this.btnBuscarCrearCategoria.Size = new System.Drawing.Size(119, 37);
            this.btnBuscarCrearCategoria.TabIndex = 31;
            this.btnBuscarCrearCategoria.Text = "Buscar";
            this.btnBuscarCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarCrearCategoria.UseSelectable = true;
            this.btnBuscarCrearCategoria.Click += new System.EventHandler(this.btnBuscarCrearCategoria_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnIngresarCrearCategoria);
            this.metroPanel2.Controls.Add(this.btnActualizarCrearAztualizar);
            this.metroPanel2.Controls.Add(this.btnSalirCrearCategoria);
            this.metroPanel2.Controls.Add(this.btnEliminarCrearCategoria);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(387, 173);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(341, 129);
            this.metroPanel2.TabIndex = 34;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnIngresarCrearCategoria
            // 
            this.btnIngresarCrearCategoria.ActiveControl = null;
            this.btnIngresarCrearCategoria.Location = new System.Drawing.Point(44, 16);
            this.btnIngresarCrearCategoria.Name = "btnIngresarCrearCategoria";
            this.btnIngresarCrearCategoria.Size = new System.Drawing.Size(127, 46);
            this.btnIngresarCrearCategoria.TabIndex = 28;
            this.btnIngresarCrearCategoria.Text = "Ingresar";
            this.btnIngresarCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresarCrearCategoria.UseSelectable = true;
            this.btnIngresarCrearCategoria.Click += new System.EventHandler(this.btnIngresarCrearCategoria_Click);
            // 
            // btnActualizarCrearAztualizar
            // 
            this.btnActualizarCrearAztualizar.ActiveControl = null;
            this.btnActualizarCrearAztualizar.Location = new System.Drawing.Point(177, 16);
            this.btnActualizarCrearAztualizar.Name = "btnActualizarCrearAztualizar";
            this.btnActualizarCrearAztualizar.Size = new System.Drawing.Size(119, 46);
            this.btnActualizarCrearAztualizar.TabIndex = 29;
            this.btnActualizarCrearAztualizar.Text = "Actualizar";
            this.btnActualizarCrearAztualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizarCrearAztualizar.UseSelectable = true;
            this.btnActualizarCrearAztualizar.Click += new System.EventHandler(this.btnActualizarCrearAztualizar_Click);
            // 
            // btnSalirCrearCategoria
            // 
            this.btnSalirCrearCategoria.ActiveControl = null;
            this.btnSalirCrearCategoria.Location = new System.Drawing.Point(177, 68);
            this.btnSalirCrearCategoria.Name = "btnSalirCrearCategoria";
            this.btnSalirCrearCategoria.Size = new System.Drawing.Size(119, 40);
            this.btnSalirCrearCategoria.TabIndex = 32;
            this.btnSalirCrearCategoria.Text = "SALIR";
            this.btnSalirCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalirCrearCategoria.UseSelectable = true;
            this.btnSalirCrearCategoria.Click += new System.EventHandler(this.btnSalirCrearCategoria_Click);
            // 
            // btnEliminarCrearCategoria
            // 
            this.btnEliminarCrearCategoria.ActiveControl = null;
            this.btnEliminarCrearCategoria.Location = new System.Drawing.Point(44, 68);
            this.btnEliminarCrearCategoria.Name = "btnEliminarCrearCategoria";
            this.btnEliminarCrearCategoria.Size = new System.Drawing.Size(127, 40);
            this.btnEliminarCrearCategoria.TabIndex = 30;
            this.btnEliminarCrearCategoria.Text = "Eliminar";
            this.btnEliminarCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarCrearCategoria.UseSelectable = true;
            this.btnEliminarCrearCategoria.Click += new System.EventHandler(this.btnEliminarCrearCategoria_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lblIdCrearCategoria);
            this.metroPanel1.Controls.Add(this.lblNombreCrearCategoria);
            this.metroPanel1.Controls.Add(this.txtIDCategoriaProductos);
            this.metroPanel1.Controls.Add(this.txtNombreCategoriaProductos);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(378, 137);
            this.metroPanel1.TabIndex = 33;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblIdCrearCategoria
            // 
            this.lblIdCrearCategoria.AutoSize = true;
            this.lblIdCrearCategoria.Location = new System.Drawing.Point(15, 35);
            this.lblIdCrearCategoria.Name = "lblIdCrearCategoria";
            this.lblIdCrearCategoria.Size = new System.Drawing.Size(86, 19);
            this.lblIdCrearCategoria.TabIndex = 6;
            this.lblIdCrearCategoria.Text = "ID Categoria:";
            // 
            // lblNombreCrearCategoria
            // 
            this.lblNombreCrearCategoria.AutoSize = true;
            this.lblNombreCrearCategoria.Location = new System.Drawing.Point(15, 79);
            this.lblNombreCrearCategoria.Name = "lblNombreCrearCategoria";
            this.lblNombreCrearCategoria.Size = new System.Drawing.Size(143, 19);
            this.lblNombreCrearCategoria.TabIndex = 7;
            this.lblNombreCrearCategoria.Text = "Nombre de Categoria:";
            // 
            // txtIDCategoriaProductos
            // 
            // 
            // 
            // 
            this.txtIDCategoriaProductos.CustomButton.Image = null;
            this.txtIDCategoriaProductos.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtIDCategoriaProductos.CustomButton.Name = "";
            this.txtIDCategoriaProductos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDCategoriaProductos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDCategoriaProductos.CustomButton.TabIndex = 1;
            this.txtIDCategoriaProductos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDCategoriaProductos.CustomButton.UseSelectable = true;
            this.txtIDCategoriaProductos.CustomButton.Visible = false;
            this.txtIDCategoriaProductos.Lines = new string[0];
            this.txtIDCategoriaProductos.Location = new System.Drawing.Point(164, 35);
            this.txtIDCategoriaProductos.MaxLength = 32767;
            this.txtIDCategoriaProductos.Name = "txtIDCategoriaProductos";
            this.txtIDCategoriaProductos.PasswordChar = '\0';
            this.txtIDCategoriaProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDCategoriaProductos.SelectedText = "";
            this.txtIDCategoriaProductos.SelectionLength = 0;
            this.txtIDCategoriaProductos.SelectionStart = 0;
            this.txtIDCategoriaProductos.ShortcutsEnabled = true;
            this.txtIDCategoriaProductos.Size = new System.Drawing.Size(195, 23);
            this.txtIDCategoriaProductos.TabIndex = 8;
            this.txtIDCategoriaProductos.UseSelectable = true;
            this.txtIDCategoriaProductos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDCategoriaProductos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombreCategoriaProductos
            // 
            // 
            // 
            // 
            this.txtNombreCategoriaProductos.CustomButton.Image = null;
            this.txtNombreCategoriaProductos.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtNombreCategoriaProductos.CustomButton.Name = "";
            this.txtNombreCategoriaProductos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreCategoriaProductos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreCategoriaProductos.CustomButton.TabIndex = 1;
            this.txtNombreCategoriaProductos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreCategoriaProductos.CustomButton.UseSelectable = true;
            this.txtNombreCategoriaProductos.CustomButton.Visible = false;
            this.txtNombreCategoriaProductos.Lines = new string[0];
            this.txtNombreCategoriaProductos.Location = new System.Drawing.Point(164, 79);
            this.txtNombreCategoriaProductos.MaxLength = 32767;
            this.txtNombreCategoriaProductos.Name = "txtNombreCategoriaProductos";
            this.txtNombreCategoriaProductos.PasswordChar = '\0';
            this.txtNombreCategoriaProductos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreCategoriaProductos.SelectedText = "";
            this.txtNombreCategoriaProductos.SelectionLength = 0;
            this.txtNombreCategoriaProductos.SelectionStart = 0;
            this.txtNombreCategoriaProductos.ShortcutsEnabled = true;
            this.txtNombreCategoriaProductos.Size = new System.Drawing.Size(195, 23);
            this.txtNombreCategoriaProductos.TabIndex = 9;
            this.txtNombreCategoriaProductos.UseSelectable = true;
            this.txtNombreCategoriaProductos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreCategoriaProductos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // VistaDistribuirProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 611);
            this.Controls.Add(this.Tab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaDistribuirProductos";
            this.Text = "VistaDistribuirProductos";
            this.Load += new System.EventHandler(this.VistaDistribuirProductos_Load);
            this.Tab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox txtPorcentajeMerma;
        private MetroFramework.Controls.MetroTextBox txtNombreProductoProductos;
        private MetroFramework.Controls.MetroComboBox txtCalidadProductos;
        private MetroFramework.Controls.MetroComboBox txtCategoriaProductos;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblIdCategoriaProducto;
        private MetroFramework.Controls.MetroLabel lblNombreProducto;
        private MetroFramework.Controls.MetroLabel lblProductos;
        private MetroFramework.Controls.MetroTextBox txtIdProductoProductos;
        private MetroFramework.Controls.MetroTile btnSalirProductos;
        private MetroFramework.Controls.MetroTile btnMostrarProductos;
        private MetroFramework.Controls.MetroTile btnEliminarProducto;
        private MetroFramework.Controls.MetroTile btnActualizarProducto;
        private MetroFramework.Controls.MetroTile btnIngresarProductos;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel lblNombreCrearCategoria;
        private MetroFramework.Controls.MetroLabel lblIdCrearCategoria;
        private MetroFramework.Controls.MetroTile btnSalirCrearCategoria;
        private MetroFramework.Controls.MetroTile btnBuscarCrearCategoria;
        private MetroFramework.Controls.MetroTile btnEliminarCrearCategoria;
        private MetroFramework.Controls.MetroTile btnActualizarCrearAztualizar;
        private MetroFramework.Controls.MetroTile btnIngresarCrearCategoria;
        private MetroFramework.Controls.MetroTextBox txtNombreCategoriaProductos;
        private MetroFramework.Controls.MetroTextBox txtIDCategoriaProductos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPrecioProductos;
        private MetroFramework.Controls.MetroTile btnListarProductosProductos;
        private MetroFramework.Controls.MetroGrid dgvListaProductos;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroRadioButton RadioIngresarProducto;
        private MetroFramework.Controls.MetroRadioButton RadioBuscarProducto;
        private MetroFramework.Controls.MetroTextBox txtBuscarProductos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroRadioButton RadioIngresarCategoria;
        private MetroFramework.Controls.MetroRadioButton RadioBuscarCategoria;
        private MetroFramework.Controls.MetroTextBox txtBuscaridCategoria;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}