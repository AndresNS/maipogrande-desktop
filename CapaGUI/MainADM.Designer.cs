
namespace CapaGUI
{
    partial class MainADM
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
            this.btnIngresarVenta = new MetroFramework.Controls.MetroTile();
            this.btnControlContratos = new MetroFramework.Controls.MetroTile();
            this.btnProductos = new MetroFramework.Controls.MetroTile();
            this.btnRecepcionPagos = new MetroFramework.Controls.MetroTile();
            this.btnPublicarVentaInterna = new MetroFramework.Controls.MetroTile();
            this.btnGenerarReportes = new MetroFramework.Controls.MetroTile();
            this.btnMantenedores = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresarVenta
            // 
            this.btnIngresarVenta.ActiveControl = null;
            this.btnIngresarVenta.Location = new System.Drawing.Point(12, 28);
            this.btnIngresarVenta.Name = "btnIngresarVenta";
            this.btnIngresarVenta.Size = new System.Drawing.Size(184, 62);
            this.btnIngresarVenta.TabIndex = 1;
            this.btnIngresarVenta.Text = "Procesos de Venta";
            this.btnIngresarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresarVenta.UseSelectable = true;
            this.btnIngresarVenta.Click += new System.EventHandler(this.btnIngresarVenta_Click);
            // 
            // btnControlContratos
            // 
            this.btnControlContratos.ActiveControl = null;
            this.btnControlContratos.Location = new System.Drawing.Point(12, 28);
            this.btnControlContratos.Name = "btnControlContratos";
            this.btnControlContratos.Size = new System.Drawing.Size(189, 62);
            this.btnControlContratos.TabIndex = 2;
            this.btnControlContratos.Text = "Control de Contratos";
            this.btnControlContratos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnControlContratos.UseSelectable = true;
            this.btnControlContratos.Click += new System.EventHandler(this.btnControlContratos_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.ActiveControl = null;
            this.btnProductos.Location = new System.Drawing.Point(222, 28);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(195, 62);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Distribuir Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProductos.UseSelectable = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnRecepcionPagos
            // 
            this.btnRecepcionPagos.ActiveControl = null;
            this.btnRecepcionPagos.Location = new System.Drawing.Point(12, 120);
            this.btnRecepcionPagos.Name = "btnRecepcionPagos";
            this.btnRecepcionPagos.Size = new System.Drawing.Size(184, 63);
            this.btnRecepcionPagos.TabIndex = 5;
            this.btnRecepcionPagos.Text = "Recepcion de Pagos";
            this.btnRecepcionPagos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecepcionPagos.UseSelectable = true;
            this.btnRecepcionPagos.Click += new System.EventHandler(this.btnRecepcionPagos_Click);
            // 
            // btnPublicarVentaInterna
            // 
            this.btnPublicarVentaInterna.ActiveControl = null;
            this.btnPublicarVentaInterna.Location = new System.Drawing.Point(214, 28);
            this.btnPublicarVentaInterna.Name = "btnPublicarVentaInterna";
            this.btnPublicarVentaInterna.Size = new System.Drawing.Size(175, 62);
            this.btnPublicarVentaInterna.TabIndex = 6;
            this.btnPublicarVentaInterna.Text = "Publicar Venta Interna \r\n";
            this.btnPublicarVentaInterna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPublicarVentaInterna.UseSelectable = true;
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.ActiveControl = null;
            this.btnGenerarReportes.Location = new System.Drawing.Point(214, 120);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(175, 63);
            this.btnGenerarReportes.TabIndex = 7;
            this.btnGenerarReportes.Text = "Generar Reportes\r\n";
            this.btnGenerarReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarReportes.UseSelectable = true;
            this.btnGenerarReportes.Click += new System.EventHandler(this.btnGenerarReportes_Click);
            // 
            // btnMantenedores
            // 
            this.btnMantenedores.ActiveControl = null;
            this.btnMantenedores.Location = new System.Drawing.Point(65, 120);
            this.btnMantenedores.Name = "btnMantenedores";
            this.btnMantenedores.Size = new System.Drawing.Size(305, 63);
            this.btnMantenedores.TabIndex = 0;
            this.btnMantenedores.Text = "Mantenedores";
            this.btnMantenedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMantenedores.UseSelectable = true;
            this.btnMantenedores.Click += new System.EventHandler(this.btnMantenedores_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnControlContratos);
            this.metroPanel1.Controls.Add(this.btnProductos);
            this.metroPanel1.Controls.Add(this.btnMantenedores);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(447, 126);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(440, 225);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(525, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(293, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "MANTENEDORES / CONTRATOS / PRODUCTOS";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnIngresarVenta);
            this.metroPanel2.Controls.Add(this.btnGenerarReportes);
            this.metroPanel2.Controls.Add(this.btnPublicarVentaInterna);
            this.metroPanel2.Controls.Add(this.btnRecepcionPagos);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 126);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(405, 225);
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(172, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(131, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "VENTAS / REPORTES";
            // 
            // MainADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 452);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainADM";
            this.Text = "Menu";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnIngresarVenta;
        private MetroFramework.Controls.MetroTile btnControlContratos;
        private MetroFramework.Controls.MetroTile btnProductos;
        private MetroFramework.Controls.MetroTile btnRecepcionPagos;
        private MetroFramework.Controls.MetroTile btnPublicarVentaInterna;
        private MetroFramework.Controls.MetroTile btnGenerarReportes;
        private MetroFramework.Controls.MetroTile btnMantenedores;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}