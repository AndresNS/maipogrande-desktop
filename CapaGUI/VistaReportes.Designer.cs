
namespace CapaGUI
{
    partial class VistaReportes
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
            this.TAB = new MetroFramework.Controls.MetroTabControl();
            this.TabVentaExterna = new MetroFramework.Controls.MetroTabPage();
            this.dgvReporte = new MetroFramework.Controls.MetroGrid();
            this.btnBuscarReporte = new MetroFramework.Controls.MetroTile();
            this.txtFechatermino = new MetroFramework.Controls.MetroDateTime();
            this.txtFechaInicio = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TabVentaInterna = new MetroFramework.Controls.MetroTabPage();
            this.metroListView2 = new MetroFramework.Controls.MetroListView();
            this.metroDateTime3 = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime4 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TAB.SuspendLayout();
            this.TabVentaExterna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.TabVentaInterna.SuspendLayout();
            this.SuspendLayout();
            // 
            // TAB
            // 
            this.TAB.Controls.Add(this.TabVentaExterna);
            this.TAB.Controls.Add(this.TabVentaInterna);
            this.TAB.Location = new System.Drawing.Point(23, 89);
            this.TAB.Name = "TAB";
            this.TAB.SelectedIndex = 0;
            this.TAB.Size = new System.Drawing.Size(847, 425);
            this.TAB.TabIndex = 1;
            this.TAB.UseSelectable = true;
            // 
            // TabVentaExterna
            // 
            this.TabVentaExterna.Controls.Add(this.dgvReporte);
            this.TabVentaExterna.Controls.Add(this.btnBuscarReporte);
            this.TabVentaExterna.Controls.Add(this.txtFechatermino);
            this.TabVentaExterna.Controls.Add(this.txtFechaInicio);
            this.TabVentaExterna.Controls.Add(this.metroLabel2);
            this.TabVentaExterna.Controls.Add(this.metroLabel1);
            this.TabVentaExterna.HorizontalScrollbarBarColor = true;
            this.TabVentaExterna.HorizontalScrollbarHighlightOnWheel = false;
            this.TabVentaExterna.HorizontalScrollbarSize = 10;
            this.TabVentaExterna.Location = new System.Drawing.Point(4, 38);
            this.TabVentaExterna.Name = "TabVentaExterna";
            this.TabVentaExterna.Size = new System.Drawing.Size(839, 383);
            this.TabVentaExterna.TabIndex = 0;
            this.TabVentaExterna.Text = "Reporte Venta Externa";
            this.TabVentaExterna.VerticalScrollbarBarColor = true;
            this.TabVentaExterna.VerticalScrollbarHighlightOnWheel = false;
            this.TabVentaExterna.VerticalScrollbarSize = 10;
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToResizeRows = false;
            this.dgvReporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvReporte.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReporte.Location = new System.Drawing.Point(3, 217);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporte.Size = new System.Drawing.Size(836, 150);
            this.dgvReporte.TabIndex = 8;
            // 
            // btnBuscarReporte
            // 
            this.btnBuscarReporte.ActiveControl = null;
            this.btnBuscarReporte.Location = new System.Drawing.Point(703, 78);
            this.btnBuscarReporte.Name = "btnBuscarReporte";
            this.btnBuscarReporte.Size = new System.Drawing.Size(133, 45);
            this.btnBuscarReporte.TabIndex = 7;
            this.btnBuscarReporte.Text = "BUSCAR";
            this.btnBuscarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarReporte.UseSelectable = true;
            this.btnBuscarReporte.Click += new System.EventHandler(this.btnBuscarReporte_Click);
            // 
            // txtFechatermino
            // 
            this.txtFechatermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechatermino.Location = new System.Drawing.Point(94, 74);
            this.txtFechatermino.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtFechatermino.Name = "txtFechatermino";
            this.txtFechatermino.Size = new System.Drawing.Size(200, 29);
            this.txtFechatermino.TabIndex = 5;
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaInicio.Location = new System.Drawing.Point(94, 31);
            this.txtFechaInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(200, 29);
            this.txtFechaInicio.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-4, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(97, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Fecha Termino:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-4, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Fecha Inicio:";
            // 
            // TabVentaInterna
            // 
            this.TabVentaInterna.Controls.Add(this.metroListView2);
            this.TabVentaInterna.Controls.Add(this.metroDateTime3);
            this.TabVentaInterna.Controls.Add(this.metroDateTime4);
            this.TabVentaInterna.Controls.Add(this.metroLabel3);
            this.TabVentaInterna.Controls.Add(this.metroLabel4);
            this.TabVentaInterna.HorizontalScrollbarBarColor = true;
            this.TabVentaInterna.HorizontalScrollbarHighlightOnWheel = false;
            this.TabVentaInterna.HorizontalScrollbarSize = 10;
            this.TabVentaInterna.Location = new System.Drawing.Point(4, 38);
            this.TabVentaInterna.Name = "TabVentaInterna";
            this.TabVentaInterna.Size = new System.Drawing.Size(839, 383);
            this.TabVentaInterna.TabIndex = 1;
            this.TabVentaInterna.Text = "Reporte Venta Interna";
            this.TabVentaInterna.VerticalScrollbarBarColor = true;
            this.TabVentaInterna.VerticalScrollbarHighlightOnWheel = false;
            this.TabVentaInterna.VerticalScrollbarSize = 10;
            // 
            // metroListView2
            // 
            this.metroListView2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView2.FullRowSelect = true;
            this.metroListView2.Location = new System.Drawing.Point(3, 228);
            this.metroListView2.Name = "metroListView2";
            this.metroListView2.OwnerDraw = true;
            this.metroListView2.Size = new System.Drawing.Size(833, 142);
            this.metroListView2.TabIndex = 10;
            this.metroListView2.UseCompatibleStateImageBehavior = false;
            this.metroListView2.UseSelectable = true;
            // 
            // metroDateTime3
            // 
            this.metroDateTime3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime3.Location = new System.Drawing.Point(101, 77);
            this.metroDateTime3.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime3.Name = "metroDateTime3";
            this.metroDateTime3.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime3.TabIndex = 9;
            // 
            // metroDateTime4
            // 
            this.metroDateTime4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime4.Location = new System.Drawing.Point(101, 34);
            this.metroDateTime4.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime4.Name = "metroDateTime4";
            this.metroDateTime4.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime4.TabIndex = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Fecha Termino:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 38);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Fecha Inicio:";
            // 
            // VistaReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 550);
            this.Controls.Add(this.TAB);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaReportes";
            this.Text = "VistaReportes";
            this.TAB.ResumeLayout(false);
            this.TabVentaExterna.ResumeLayout(false);
            this.TabVentaExterna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.TabVentaInterna.ResumeLayout(false);
            this.TabVentaInterna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TAB;
        private MetroFramework.Controls.MetroTabPage TabVentaExterna;
        private MetroFramework.Controls.MetroDateTime txtFechatermino;
        private MetroFramework.Controls.MetroDateTime txtFechaInicio;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage TabVentaInterna;
        private MetroFramework.Controls.MetroDateTime metroDateTime3;
        private MetroFramework.Controls.MetroDateTime metroDateTime4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroListView metroListView2;
        private MetroFramework.Controls.MetroGrid dgvReporte;
        private MetroFramework.Controls.MetroTile btnBuscarReporte;
    }
}