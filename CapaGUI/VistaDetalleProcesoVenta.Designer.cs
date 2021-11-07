
namespace CapaGUI
{
    partial class VistaDetalleProcesoVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVerPostulacionesTransporte = new MetroFramework.Controls.MetroTile();
            this.btnVerPostulacionesProductores = new MetroFramework.Controls.MetroTile();
            this.dgvDetalleProcesoVenta = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIDProcesoVenta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtObservaciones = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mdtFechaEmision = new MetroFramework.Controls.MetroDateTime();
            this.txtRutCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEstado = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtEmpresaTransporte = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtRazonSocial = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProcesoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerPostulacionesTransporte
            // 
            this.btnVerPostulacionesTransporte.ActiveControl = null;
            this.btnVerPostulacionesTransporte.Location = new System.Drawing.Point(337, 542);
            this.btnVerPostulacionesTransporte.Name = "btnVerPostulacionesTransporte";
            this.btnVerPostulacionesTransporte.Size = new System.Drawing.Size(195, 42);
            this.btnVerPostulacionesTransporte.TabIndex = 2;
            this.btnVerPostulacionesTransporte.Text = "Ver Subastas de Transporte";
            this.btnVerPostulacionesTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerPostulacionesTransporte.UseSelectable = true;
            this.btnVerPostulacionesTransporte.Click += new System.EventHandler(this.btnVerPostulacionesTransporte_Click);
            // 
            // btnVerPostulacionesProductores
            // 
            this.btnVerPostulacionesProductores.ActiveControl = null;
            this.btnVerPostulacionesProductores.Location = new System.Drawing.Point(556, 542);
            this.btnVerPostulacionesProductores.Name = "btnVerPostulacionesProductores";
            this.btnVerPostulacionesProductores.Size = new System.Drawing.Size(244, 42);
            this.btnVerPostulacionesProductores.TabIndex = 3;
            this.btnVerPostulacionesProductores.Text = "Ver Postulaciones de Productoress";
            this.btnVerPostulacionesProductores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerPostulacionesProductores.UseSelectable = true;
            this.btnVerPostulacionesProductores.Click += new System.EventHandler(this.btnVerPostulacionesProductores_Click);
            // 
            // dgvDetalleProcesoVenta
            // 
            this.dgvDetalleProcesoVenta.AllowUserToAddRows = false;
            this.dgvDetalleProcesoVenta.AllowUserToDeleteRows = false;
            this.dgvDetalleProcesoVenta.AllowUserToResizeRows = false;
            this.dgvDetalleProcesoVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetalleProcesoVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleProcesoVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetalleProcesoVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleProcesoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleProcesoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleProcesoVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalleProcesoVenta.EnableHeadersVisualStyles = false;
            this.dgvDetalleProcesoVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDetalleProcesoVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetalleProcesoVenta.Location = new System.Drawing.Point(175, 255);
            this.dgvDetalleProcesoVenta.Name = "dgvDetalleProcesoVenta";
            this.dgvDetalleProcesoVenta.ReadOnly = true;
            this.dgvDetalleProcesoVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleProcesoVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleProcesoVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetalleProcesoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleProcesoVenta.Size = new System.Drawing.Size(625, 270);
            this.dgvDetalleProcesoVenta.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(145, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "ID:";
            // 
            // txtIDProcesoVenta
            // 
            // 
            // 
            // 
            this.txtIDProcesoVenta.CustomButton.Image = null;
            this.txtIDProcesoVenta.CustomButton.Location = new System.Drawing.Point(51, 1);
            this.txtIDProcesoVenta.CustomButton.Name = "";
            this.txtIDProcesoVenta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIDProcesoVenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIDProcesoVenta.CustomButton.TabIndex = 1;
            this.txtIDProcesoVenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIDProcesoVenta.CustomButton.UseSelectable = true;
            this.txtIDProcesoVenta.CustomButton.Visible = false;
            this.txtIDProcesoVenta.Enabled = false;
            this.txtIDProcesoVenta.Lines = new string[0];
            this.txtIDProcesoVenta.Location = new System.Drawing.Point(175, 63);
            this.txtIDProcesoVenta.MaxLength = 32767;
            this.txtIDProcesoVenta.Name = "txtIDProcesoVenta";
            this.txtIDProcesoVenta.PasswordChar = '\0';
            this.txtIDProcesoVenta.ReadOnly = true;
            this.txtIDProcesoVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIDProcesoVenta.SelectedText = "";
            this.txtIDProcesoVenta.SelectionLength = 0;
            this.txtIDProcesoVenta.SelectionStart = 0;
            this.txtIDProcesoVenta.ShortcutsEnabled = true;
            this.txtIDProcesoVenta.Size = new System.Drawing.Size(73, 23);
            this.txtIDProcesoVenta.TabIndex = 6;
            this.txtIDProcesoVenta.UseSelectable = true;
            this.txtIDProcesoVenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIDProcesoVenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(437, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Fecha Emisión:";
            // 
            // txtObservaciones
            // 
            // 
            // 
            // 
            this.txtObservaciones.CustomButton.Image = null;
            this.txtObservaciones.CustomButton.Location = new System.Drawing.Point(541, 1);
            this.txtObservaciones.CustomButton.Name = "";
            this.txtObservaciones.CustomButton.Size = new System.Drawing.Size(83, 83);
            this.txtObservaciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservaciones.CustomButton.TabIndex = 1;
            this.txtObservaciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservaciones.CustomButton.UseSelectable = true;
            this.txtObservaciones.CustomButton.Visible = false;
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Lines = new string[0];
            this.txtObservaciones.Location = new System.Drawing.Point(175, 150);
            this.txtObservaciones.MaxLength = 32767;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.SelectionLength = 0;
            this.txtObservaciones.SelectionStart = 0;
            this.txtObservaciones.ShortcutsEnabled = true;
            this.txtObservaciones.Size = new System.Drawing.Size(625, 85);
            this.txtObservaciones.TabIndex = 10;
            this.txtObservaciones.UseSelectable = true;
            this.txtObservaciones.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservaciones.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(71, 150);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Observaciones:";
            // 
            // mdtFechaEmision
            // 
            this.mdtFechaEmision.Enabled = false;
            this.mdtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.mdtFechaEmision.Location = new System.Drawing.Point(538, 57);
            this.mdtFechaEmision.MinimumSize = new System.Drawing.Size(0, 29);
            this.mdtFechaEmision.Name = "mdtFechaEmision";
            this.mdtFechaEmision.Size = new System.Drawing.Size(262, 29);
            this.mdtFechaEmision.TabIndex = 11;
            // 
            // txtRutCliente
            // 
            // 
            // 
            // 
            this.txtRutCliente.CustomButton.Image = null;
            this.txtRutCliente.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtRutCliente.CustomButton.Name = "";
            this.txtRutCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRutCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRutCliente.CustomButton.TabIndex = 1;
            this.txtRutCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutCliente.CustomButton.UseSelectable = true;
            this.txtRutCliente.CustomButton.Visible = false;
            this.txtRutCliente.Enabled = false;
            this.txtRutCliente.Lines = new string[0];
            this.txtRutCliente.Location = new System.Drawing.Point(175, 92);
            this.txtRutCliente.MaxLength = 32767;
            this.txtRutCliente.Name = "txtRutCliente";
            this.txtRutCliente.PasswordChar = '\0';
            this.txtRutCliente.ReadOnly = true;
            this.txtRutCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRutCliente.SelectedText = "";
            this.txtRutCliente.SelectionLength = 0;
            this.txtRutCliente.SelectionStart = 0;
            this.txtRutCliente.ShortcutsEnabled = true;
            this.txtRutCliente.Size = new System.Drawing.Size(183, 23);
            this.txtRutCliente.TabIndex = 13;
            this.txtRutCliente.UseSelectable = true;
            this.txtRutCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRutCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(94, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Rut Cliente:";
            // 
            // txtEstado
            // 
            // 
            // 
            // 
            this.txtEstado.CustomButton.Image = null;
            this.txtEstado.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txtEstado.CustomButton.Name = "";
            this.txtEstado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEstado.CustomButton.TabIndex = 1;
            this.txtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEstado.CustomButton.UseSelectable = true;
            this.txtEstado.CustomButton.Visible = false;
            this.txtEstado.Enabled = false;
            this.txtEstado.Lines = new string[0];
            this.txtEstado.Location = new System.Drawing.Point(538, 121);
            this.txtEstado.MaxLength = 32767;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.ReadOnly = true;
            this.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.ShortcutsEnabled = true;
            this.txtEstado.Size = new System.Drawing.Size(262, 23);
            this.txtEstado.TabIndex = 15;
            this.txtEstado.UseSelectable = true;
            this.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(481, 124);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Estado:";
            // 
            // txtEmpresaTransporte
            // 
            // 
            // 
            // 
            this.txtEmpresaTransporte.CustomButton.Image = null;
            this.txtEmpresaTransporte.CustomButton.Location = new System.Drawing.Point(161, 1);
            this.txtEmpresaTransporte.CustomButton.Name = "";
            this.txtEmpresaTransporte.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmpresaTransporte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmpresaTransporte.CustomButton.TabIndex = 1;
            this.txtEmpresaTransporte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmpresaTransporte.CustomButton.UseSelectable = true;
            this.txtEmpresaTransporte.CustomButton.Visible = false;
            this.txtEmpresaTransporte.Enabled = false;
            this.txtEmpresaTransporte.Lines = new string[0];
            this.txtEmpresaTransporte.Location = new System.Drawing.Point(175, 121);
            this.txtEmpresaTransporte.MaxLength = 32767;
            this.txtEmpresaTransporte.Name = "txtEmpresaTransporte";
            this.txtEmpresaTransporte.PasswordChar = '\0';
            this.txtEmpresaTransporte.ReadOnly = true;
            this.txtEmpresaTransporte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmpresaTransporte.SelectedText = "";
            this.txtEmpresaTransporte.SelectionLength = 0;
            this.txtEmpresaTransporte.SelectionStart = 0;
            this.txtEmpresaTransporte.ShortcutsEnabled = true;
            this.txtEmpresaTransporte.Size = new System.Drawing.Size(183, 23);
            this.txtEmpresaTransporte.TabIndex = 17;
            this.txtEmpresaTransporte.UseSelectable = true;
            this.txtEmpresaTransporte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmpresaTransporte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(43, 119);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(129, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Empresa Transporte:";
            // 
            // txtRazonSocial
            // 
            // 
            // 
            // 
            this.txtRazonSocial.CustomButton.Image = null;
            this.txtRazonSocial.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txtRazonSocial.CustomButton.Name = "";
            this.txtRazonSocial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRazonSocial.CustomButton.TabIndex = 1;
            this.txtRazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRazonSocial.CustomButton.UseSelectable = true;
            this.txtRazonSocial.CustomButton.Visible = false;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Lines = new string[0];
            this.txtRazonSocial.Location = new System.Drawing.Point(538, 92);
            this.txtRazonSocial.MaxLength = 32767;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.SelectionLength = 0;
            this.txtRazonSocial.SelectionStart = 0;
            this.txtRazonSocial.ShortcutsEnabled = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(262, 23);
            this.txtRazonSocial.TabIndex = 19;
            this.txtRazonSocial.UseSelectable = true;
            this.txtRazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRazonSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(446, 96);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(86, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Razon Social:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(98, 255);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(71, 19);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "Productos:";
            // 
            // VistaDetalleProcesoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 607);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtEmpresaTransporte);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtRutCliente);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mdtFechaEmision);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtIDProcesoVenta);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvDetalleProcesoVenta);
            this.Controls.Add(this.btnVerPostulacionesProductores);
            this.Controls.Add(this.btnVerPostulacionesTransporte);
            this.Name = "VistaDetalleProcesoVenta";
            this.Text = "Proceso de Venta";
            this.Load += new System.EventHandler(this.VistaDetalleProcesoVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleProcesoVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnVerPostulacionesTransporte;
        private MetroFramework.Controls.MetroTile btnVerPostulacionesProductores;
        private MetroFramework.Controls.MetroGrid dgvDetalleProcesoVenta;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIDProcesoVenta;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtObservaciones;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroDateTime mdtFechaEmision;
        private MetroFramework.Controls.MetroTextBox txtRutCliente;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEstado;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtEmpresaTransporte;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtRazonSocial;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}