﻿
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
            this.dgvListaProductos = new MetroFramework.Controls.MetroGrid();
            this.btnListarProductosProductos = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtPrecioProductos = new MetroFramework.Controls.MetroTextBox();
            this.btnSalirProductos = new MetroFramework.Controls.MetroTile();
            this.btnMostrarProductos = new MetroFramework.Controls.MetroTile();
            this.btnEliminarProducto = new MetroFramework.Controls.MetroTile();
            this.btnActualizarProducto = new MetroFramework.Controls.MetroTile();
            this.btnIngresarProductos = new MetroFramework.Controls.MetroTile();
            this.txtPorcentajeMerma = new MetroFramework.Controls.MetroTextBox();
            this.txtNombreProductoProductos = new MetroFramework.Controls.MetroTextBox();
            this.cbxCalidadProductos = new MetroFramework.Controls.MetroComboBox();
            this.cbxCategoriaProductos = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblIdCategoriaProducto = new MetroFramework.Controls.MetroLabel();
            this.lblNombreProducto = new MetroFramework.Controls.MetroLabel();
            this.lblProductos = new MetroFramework.Controls.MetroLabel();
            this.txtIdProductoProductos = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnSalirCrearCategoria = new MetroFramework.Controls.MetroTile();
            this.btnBuscarCrearCategoria = new MetroFramework.Controls.MetroTile();
            this.btnEliminarCrearCategoria = new MetroFramework.Controls.MetroTile();
            this.btnActualizarCrearAztualizar = new MetroFramework.Controls.MetroTile();
            this.btnIngresarCrearCategoria = new MetroFramework.Controls.MetroTile();
            this.txtCrearNombreCategoria = new MetroFramework.Controls.MetroTextBox();
            this.txtCrearCategoria = new MetroFramework.Controls.MetroTextBox();
            this.lblNombreCrearCategoria = new MetroFramework.Controls.MetroLabel();
            this.lblIdCrearCategoria = new MetroFramework.Controls.MetroLabel();
            this.Tab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            this.metroTabPage2.SuspendLayout();
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
            this.metroTabPage1.Controls.Add(this.dgvListaProductos);
            this.metroTabPage1.Controls.Add(this.btnListarProductosProductos);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.txtPrecioProductos);
            this.metroTabPage1.Controls.Add(this.btnSalirProductos);
            this.metroTabPage1.Controls.Add(this.btnMostrarProductos);
            this.metroTabPage1.Controls.Add(this.btnEliminarProducto);
            this.metroTabPage1.Controls.Add(this.btnActualizarProducto);
            this.metroTabPage1.Controls.Add(this.btnIngresarProductos);
            this.metroTabPage1.Controls.Add(this.txtPorcentajeMerma);
            this.metroTabPage1.Controls.Add(this.txtNombreProductoProductos);
            this.metroTabPage1.Controls.Add(this.cbxCalidadProductos);
            this.metroTabPage1.Controls.Add(this.cbxCategoriaProductos);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.lblIdCategoriaProducto);
            this.metroTabPage1.Controls.Add(this.lblNombreProducto);
            this.metroTabPage1.Controls.Add(this.lblProductos);
            this.metroTabPage1.Controls.Add(this.txtIdProductoProductos);
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
            this.dgvListaProductos.Location = new System.Drawing.Point(192, 253);
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
            this.dgvListaProductos.Size = new System.Drawing.Size(524, 276);
            this.dgvListaProductos.TabIndex = 25;
            // 
            // btnListarProductosProductos
            // 
            this.btnListarProductosProductos.ActiveControl = null;
            this.btnListarProductosProductos.Location = new System.Drawing.Point(17, 253);
            this.btnListarProductosProductos.Name = "btnListarProductosProductos";
            this.btnListarProductosProductos.Size = new System.Drawing.Size(127, 66);
            this.btnListarProductosProductos.TabIndex = 24;
            this.btnListarProductosProductos.Text = "Mostrar Productos";
            this.btnListarProductosProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListarProductosProductos.UseSelectable = true;
            this.btnListarProductosProductos.Click += new System.EventHandler(this.btnListarProductosProductos_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 131);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Precio";
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
            this.txtPrecioProductos.Location = new System.Drawing.Point(141, 131);
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
            // btnSalirProductos
            // 
            this.btnSalirProductos.ActiveControl = null;
            this.btnSalirProductos.Location = new System.Drawing.Point(453, 187);
            this.btnSalirProductos.Name = "btnSalirProductos";
            this.btnSalirProductos.Size = new System.Drawing.Size(252, 40);
            this.btnSalirProductos.TabIndex = 27;
            this.btnSalirProductos.Text = "SALIR";
            this.btnSalirProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalirProductos.UseSelectable = true;
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.ActiveControl = null;
            this.btnMostrarProductos.Location = new System.Drawing.Point(586, 109);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(119, 66);
            this.btnMostrarProductos.TabIndex = 26;
            this.btnMostrarProductos.Text = "Buscar";
            this.btnMostrarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMostrarProductos.UseSelectable = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.ActiveControl = null;
            this.btnEliminarProducto.Location = new System.Drawing.Point(453, 109);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(127, 66);
            this.btnEliminarProducto.TabIndex = 25;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarProducto.UseSelectable = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.ActiveControl = null;
            this.btnActualizarProducto.Location = new System.Drawing.Point(586, 28);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(119, 67);
            this.btnActualizarProducto.TabIndex = 24;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizarProducto.UseSelectable = true;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnIngresarProductos
            // 
            this.btnIngresarProductos.ActiveControl = null;
            this.btnIngresarProductos.Location = new System.Drawing.Point(453, 28);
            this.btnIngresarProductos.Name = "btnIngresarProductos";
            this.btnIngresarProductos.Size = new System.Drawing.Size(127, 66);
            this.btnIngresarProductos.TabIndex = 23;
            this.btnIngresarProductos.Text = "Ingresar";
            this.btnIngresarProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresarProductos.UseSelectable = true;
            this.btnIngresarProductos.Click += new System.EventHandler(this.btnIngresarProductos_Click);
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
            this.txtPorcentajeMerma.Location = new System.Drawing.Point(140, 201);
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
            this.txtNombreProductoProductos.Location = new System.Drawing.Point(141, 99);
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
            // cbxCalidadProductos
            // 
            this.cbxCalidadProductos.FormattingEnabled = true;
            this.cbxCalidadProductos.ItemHeight = 23;
            this.cbxCalidadProductos.Location = new System.Drawing.Point(141, 160);
            this.cbxCalidadProductos.Name = "cbxCalidadProductos";
            this.cbxCalidadProductos.Size = new System.Drawing.Size(172, 29);
            this.cbxCalidadProductos.TabIndex = 9;
            this.cbxCalidadProductos.UseSelectable = true;
            // 
            // cbxCategoriaProductos
            // 
            this.cbxCategoriaProductos.FormattingEnabled = true;
            this.cbxCategoriaProductos.ItemHeight = 23;
            this.cbxCategoriaProductos.Location = new System.Drawing.Point(141, 61);
            this.cbxCategoriaProductos.Name = "cbxCategoriaProductos";
            this.cbxCategoriaProductos.Size = new System.Drawing.Size(172, 29);
            this.cbxCategoriaProductos.TabIndex = 8;
            this.cbxCategoriaProductos.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(14, 201);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(120, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Porcentaje Merma:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(15, 163);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "ID Calidad:";
            // 
            // lblIdCategoriaProducto
            // 
            this.lblIdCategoriaProducto.AutoSize = true;
            this.lblIdCategoriaProducto.Location = new System.Drawing.Point(15, 68);
            this.lblIdCategoriaProducto.Name = "lblIdCategoriaProducto";
            this.lblIdCategoriaProducto.Size = new System.Drawing.Size(86, 19);
            this.lblIdCategoriaProducto.TabIndex = 5;
            this.lblIdCategoriaProducto.Text = "ID Categoria:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(14, 100);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(120, 19);
            this.lblNombreProducto.TabIndex = 4;
            this.lblNombreProducto.Text = "Nombre Producto:";
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(17, 36);
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
            this.txtIdProductoProductos.Location = new System.Drawing.Point(141, 32);
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
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnSalirCrearCategoria);
            this.metroTabPage2.Controls.Add(this.btnBuscarCrearCategoria);
            this.metroTabPage2.Controls.Add(this.btnEliminarCrearCategoria);
            this.metroTabPage2.Controls.Add(this.btnActualizarCrearAztualizar);
            this.metroTabPage2.Controls.Add(this.btnIngresarCrearCategoria);
            this.metroTabPage2.Controls.Add(this.txtCrearNombreCategoria);
            this.metroTabPage2.Controls.Add(this.txtCrearCategoria);
            this.metroTabPage2.Controls.Add(this.lblNombreCrearCategoria);
            this.metroTabPage2.Controls.Add(this.lblIdCrearCategoria);
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
            // btnSalirCrearCategoria
            // 
            this.btnSalirCrearCategoria.ActiveControl = null;
            this.btnSalirCrearCategoria.Location = new System.Drawing.Point(447, 179);
            this.btnSalirCrearCategoria.Name = "btnSalirCrearCategoria";
            this.btnSalirCrearCategoria.Size = new System.Drawing.Size(252, 40);
            this.btnSalirCrearCategoria.TabIndex = 32;
            this.btnSalirCrearCategoria.Text = "SALIR";
            this.btnSalirCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalirCrearCategoria.UseSelectable = true;
            this.btnSalirCrearCategoria.Click += new System.EventHandler(this.btnSalirCrearCategoria_Click);
            // 
            // btnBuscarCrearCategoria
            // 
            this.btnBuscarCrearCategoria.ActiveControl = null;
            this.btnBuscarCrearCategoria.Location = new System.Drawing.Point(580, 101);
            this.btnBuscarCrearCategoria.Name = "btnBuscarCrearCategoria";
            this.btnBuscarCrearCategoria.Size = new System.Drawing.Size(119, 66);
            this.btnBuscarCrearCategoria.TabIndex = 31;
            this.btnBuscarCrearCategoria.Text = "Buscar";
            this.btnBuscarCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarCrearCategoria.UseSelectable = true;
            this.btnBuscarCrearCategoria.Click += new System.EventHandler(this.btnBuscarCrearCategoria_Click);
            // 
            // btnEliminarCrearCategoria
            // 
            this.btnEliminarCrearCategoria.ActiveControl = null;
            this.btnEliminarCrearCategoria.Location = new System.Drawing.Point(447, 101);
            this.btnEliminarCrearCategoria.Name = "btnEliminarCrearCategoria";
            this.btnEliminarCrearCategoria.Size = new System.Drawing.Size(127, 66);
            this.btnEliminarCrearCategoria.TabIndex = 30;
            this.btnEliminarCrearCategoria.Text = "Eliminar";
            this.btnEliminarCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarCrearCategoria.UseSelectable = true;
            this.btnEliminarCrearCategoria.Click += new System.EventHandler(this.btnEliminarCrearCategoria_Click);
            // 
            // btnActualizarCrearAztualizar
            // 
            this.btnActualizarCrearAztualizar.ActiveControl = null;
            this.btnActualizarCrearAztualizar.Location = new System.Drawing.Point(580, 20);
            this.btnActualizarCrearAztualizar.Name = "btnActualizarCrearAztualizar";
            this.btnActualizarCrearAztualizar.Size = new System.Drawing.Size(119, 67);
            this.btnActualizarCrearAztualizar.TabIndex = 29;
            this.btnActualizarCrearAztualizar.Text = "Actualizar";
            this.btnActualizarCrearAztualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizarCrearAztualizar.UseSelectable = true;
            this.btnActualizarCrearAztualizar.Click += new System.EventHandler(this.btnActualizarCrearAztualizar_Click);
            // 
            // btnIngresarCrearCategoria
            // 
            this.btnIngresarCrearCategoria.ActiveControl = null;
            this.btnIngresarCrearCategoria.Location = new System.Drawing.Point(447, 20);
            this.btnIngresarCrearCategoria.Name = "btnIngresarCrearCategoria";
            this.btnIngresarCrearCategoria.Size = new System.Drawing.Size(127, 66);
            this.btnIngresarCrearCategoria.TabIndex = 28;
            this.btnIngresarCrearCategoria.Text = "Ingresar";
            this.btnIngresarCrearCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresarCrearCategoria.UseSelectable = true;
            this.btnIngresarCrearCategoria.Click += new System.EventHandler(this.btnIngresarCrearCategoria_Click);
            // 
            // txtCrearNombreCategoria
            // 
            // 
            // 
            // 
            this.txtCrearNombreCategoria.CustomButton.Image = null;
            this.txtCrearNombreCategoria.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtCrearNombreCategoria.CustomButton.Name = "";
            this.txtCrearNombreCategoria.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCrearNombreCategoria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCrearNombreCategoria.CustomButton.TabIndex = 1;
            this.txtCrearNombreCategoria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCrearNombreCategoria.CustomButton.UseSelectable = true;
            this.txtCrearNombreCategoria.CustomButton.Visible = false;
            this.txtCrearNombreCategoria.Lines = new string[0];
            this.txtCrearNombreCategoria.Location = new System.Drawing.Point(162, 101);
            this.txtCrearNombreCategoria.MaxLength = 32767;
            this.txtCrearNombreCategoria.Name = "txtCrearNombreCategoria";
            this.txtCrearNombreCategoria.PasswordChar = '\0';
            this.txtCrearNombreCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCrearNombreCategoria.SelectedText = "";
            this.txtCrearNombreCategoria.SelectionLength = 0;
            this.txtCrearNombreCategoria.SelectionStart = 0;
            this.txtCrearNombreCategoria.ShortcutsEnabled = true;
            this.txtCrearNombreCategoria.Size = new System.Drawing.Size(195, 23);
            this.txtCrearNombreCategoria.TabIndex = 9;
            this.txtCrearNombreCategoria.UseSelectable = true;
            this.txtCrearNombreCategoria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCrearNombreCategoria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCrearCategoria
            // 
            // 
            // 
            // 
            this.txtCrearCategoria.CustomButton.Image = null;
            this.txtCrearCategoria.CustomButton.Location = new System.Drawing.Point(173, 1);
            this.txtCrearCategoria.CustomButton.Name = "";
            this.txtCrearCategoria.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCrearCategoria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCrearCategoria.CustomButton.TabIndex = 1;
            this.txtCrearCategoria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCrearCategoria.CustomButton.UseSelectable = true;
            this.txtCrearCategoria.CustomButton.Visible = false;
            this.txtCrearCategoria.Lines = new string[0];
            this.txtCrearCategoria.Location = new System.Drawing.Point(162, 57);
            this.txtCrearCategoria.MaxLength = 32767;
            this.txtCrearCategoria.Name = "txtCrearCategoria";
            this.txtCrearCategoria.PasswordChar = '\0';
            this.txtCrearCategoria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCrearCategoria.SelectedText = "";
            this.txtCrearCategoria.SelectionLength = 0;
            this.txtCrearCategoria.SelectionStart = 0;
            this.txtCrearCategoria.ShortcutsEnabled = true;
            this.txtCrearCategoria.Size = new System.Drawing.Size(195, 23);
            this.txtCrearCategoria.TabIndex = 8;
            this.txtCrearCategoria.UseSelectable = true;
            this.txtCrearCategoria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCrearCategoria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNombreCrearCategoria
            // 
            this.lblNombreCrearCategoria.AutoSize = true;
            this.lblNombreCrearCategoria.Location = new System.Drawing.Point(13, 101);
            this.lblNombreCrearCategoria.Name = "lblNombreCrearCategoria";
            this.lblNombreCrearCategoria.Size = new System.Drawing.Size(143, 19);
            this.lblNombreCrearCategoria.TabIndex = 7;
            this.lblNombreCrearCategoria.Text = "Nombre de Categoria:";
            // 
            // lblIdCrearCategoria
            // 
            this.lblIdCrearCategoria.AutoSize = true;
            this.lblIdCrearCategoria.Location = new System.Drawing.Point(13, 57);
            this.lblIdCrearCategoria.Name = "lblIdCrearCategoria";
            this.lblIdCrearCategoria.Size = new System.Drawing.Size(86, 19);
            this.lblIdCrearCategoria.TabIndex = 6;
            this.lblIdCrearCategoria.Text = "ID Categoria:";
            // 
            // VistaDistribuirProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 683);
            this.Controls.Add(this.Tab);
            this.Name = "VistaDistribuirProductos";
            this.Text = "VistaDistribuirProductos";
            this.Load += new System.EventHandler(this.VistaDistribuirProductos_Load);
            this.Tab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Tab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox txtPorcentajeMerma;
        private MetroFramework.Controls.MetroTextBox txtNombreProductoProductos;
        private MetroFramework.Controls.MetroComboBox cbxCalidadProductos;
        private MetroFramework.Controls.MetroComboBox cbxCategoriaProductos;
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
        private MetroFramework.Controls.MetroTextBox txtCrearNombreCategoria;
        private MetroFramework.Controls.MetroTextBox txtCrearCategoria;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPrecioProductos;
        private MetroFramework.Controls.MetroTile btnListarProductosProductos;
        private MetroFramework.Controls.MetroGrid dgvListaProductos;
    }
}