
namespace CapaGUI
{
    partial class VistaControldeContratos
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIdContrato = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtFechaInicio = new MetroFramework.Controls.MetroDateTime();
            this.txtFechaTermino = new MetroFramework.Controls.MetroDateTime();
            this.txtRutProductorContrato = new MetroFramework.Controls.MetroTextBox();
            this.btnSalirContratos = new MetroFramework.Controls.MetroTile();
            this.btnBuscarContratos = new MetroFramework.Controls.MetroTile();
            this.btnEliminarContratos = new MetroFramework.Controls.MetroTile();
            this.btnActualizarContratos = new MetroFramework.Controls.MetroTile();
            this.btnIngresarContratos = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.RadioIngresarNuevoContrato = new MetroFramework.Controls.MetroRadioButton();
            this.RadioBuscarContrato = new MetroFramework.Controls.MetroRadioButton();
            this.txtBuscarContrato = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID de Contrato:";
            // 
            // txtIdContrato
            // 
            // 
            // 
            // 
            this.txtIdContrato.CustomButton.Image = null;
            this.txtIdContrato.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtIdContrato.CustomButton.Name = "";
            this.txtIdContrato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdContrato.CustomButton.TabIndex = 1;
            this.txtIdContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdContrato.CustomButton.UseSelectable = true;
            this.txtIdContrato.CustomButton.Visible = false;
            this.txtIdContrato.Lines = new string[0];
            this.txtIdContrato.Location = new System.Drawing.Point(126, 45);
            this.txtIdContrato.MaxLength = 32767;
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.PasswordChar = '\0';
            this.txtIdContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdContrato.SelectedText = "";
            this.txtIdContrato.SelectionLength = 0;
            this.txtIdContrato.SelectionStart = 0;
            this.txtIdContrato.ShortcutsEnabled = true;
            this.txtIdContrato.Size = new System.Drawing.Size(226, 23);
            this.txtIdContrato.TabIndex = 1;
            this.txtIdContrato.UseSelectable = true;
            this.txtIdContrato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Fecha Inicio:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 120);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Fecha Termino:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 156);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Rut Productor:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaInicio.Location = new System.Drawing.Point(126, 77);
            this.txtFechaInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(226, 29);
            this.txtFechaInicio.TabIndex = 5;
            // 
            // txtFechaTermino
            // 
            this.txtFechaTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaTermino.Location = new System.Drawing.Point(126, 116);
            this.txtFechaTermino.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtFechaTermino.Name = "txtFechaTermino";
            this.txtFechaTermino.Size = new System.Drawing.Size(226, 29);
            this.txtFechaTermino.TabIndex = 6;
            // 
            // txtRutProductorContrato
            // 
            // 
            // 
            // 
            this.txtRutProductorContrato.CustomButton.Image = null;
            this.txtRutProductorContrato.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtRutProductorContrato.CustomButton.Name = "";
            this.txtRutProductorContrato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRutProductorContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRutProductorContrato.CustomButton.TabIndex = 1;
            this.txtRutProductorContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRutProductorContrato.CustomButton.UseSelectable = true;
            this.txtRutProductorContrato.CustomButton.Visible = false;
            this.txtRutProductorContrato.Lines = new string[0];
            this.txtRutProductorContrato.Location = new System.Drawing.Point(126, 156);
            this.txtRutProductorContrato.MaxLength = 32767;
            this.txtRutProductorContrato.Name = "txtRutProductorContrato";
            this.txtRutProductorContrato.PasswordChar = '\0';
            this.txtRutProductorContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRutProductorContrato.SelectedText = "";
            this.txtRutProductorContrato.SelectionLength = 0;
            this.txtRutProductorContrato.SelectionStart = 0;
            this.txtRutProductorContrato.ShortcutsEnabled = true;
            this.txtRutProductorContrato.Size = new System.Drawing.Size(226, 23);
            this.txtRutProductorContrato.TabIndex = 7;
            this.txtRutProductorContrato.UseSelectable = true;
            this.txtRutProductorContrato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRutProductorContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSalirContratos
            // 
            this.btnSalirContratos.ActiveControl = null;
            this.btnSalirContratos.Location = new System.Drawing.Point(181, 98);
            this.btnSalirContratos.Name = "btnSalirContratos";
            this.btnSalirContratos.Size = new System.Drawing.Size(119, 48);
            this.btnSalirContratos.TabIndex = 37;
            this.btnSalirContratos.Text = "SALIR";
            this.btnSalirContratos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalirContratos.UseSelectable = true;
            this.btnSalirContratos.Click += new System.EventHandler(this.btnSalirProductor_Click);
            // 
            // btnBuscarContratos
            // 
            this.btnBuscarContratos.ActiveControl = null;
            this.btnBuscarContratos.Location = new System.Drawing.Point(209, 68);
            this.btnBuscarContratos.Name = "btnBuscarContratos";
            this.btnBuscarContratos.Size = new System.Drawing.Size(96, 38);
            this.btnBuscarContratos.TabIndex = 36;
            this.btnBuscarContratos.Text = "Buscar";
            this.btnBuscarContratos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarContratos.UseSelectable = true;
            this.btnBuscarContratos.Click += new System.EventHandler(this.btnBuscarContratos_Click);
            // 
            // btnEliminarContratos
            // 
            this.btnEliminarContratos.ActiveControl = null;
            this.btnEliminarContratos.Location = new System.Drawing.Point(48, 98);
            this.btnEliminarContratos.Name = "btnEliminarContratos";
            this.btnEliminarContratos.Size = new System.Drawing.Size(127, 48);
            this.btnEliminarContratos.TabIndex = 35;
            this.btnEliminarContratos.Text = "Eliminar";
            this.btnEliminarContratos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminarContratos.UseSelectable = true;
            this.btnEliminarContratos.Click += new System.EventHandler(this.btnEliminarContratos_Click);
            // 
            // btnActualizarContratos
            // 
            this.btnActualizarContratos.ActiveControl = null;
            this.btnActualizarContratos.Location = new System.Drawing.Point(181, 31);
            this.btnActualizarContratos.Name = "btnActualizarContratos";
            this.btnActualizarContratos.Size = new System.Drawing.Size(119, 51);
            this.btnActualizarContratos.TabIndex = 34;
            this.btnActualizarContratos.Text = "Actualizar";
            this.btnActualizarContratos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnActualizarContratos.UseSelectable = true;
            this.btnActualizarContratos.Click += new System.EventHandler(this.btnActualizarContratos_Click);
            // 
            // btnIngresarContratos
            // 
            this.btnIngresarContratos.ActiveControl = null;
            this.btnIngresarContratos.Location = new System.Drawing.Point(48, 31);
            this.btnIngresarContratos.Name = "btnIngresarContratos";
            this.btnIngresarContratos.Size = new System.Drawing.Size(127, 51);
            this.btnIngresarContratos.TabIndex = 33;
            this.btnIngresarContratos.Text = "Ingresar";
            this.btnIngresarContratos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIngresarContratos.UseSelectable = true;
            this.btnIngresarContratos.Click += new System.EventHandler(this.btnIngresarContratos_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtIdContrato);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtRutProductorContrato);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtFechaTermino);
            this.metroPanel1.Controls.Add(this.txtFechaInicio);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(383, 317);
            this.metroPanel1.TabIndex = 38;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.btnSalirContratos);
            this.metroPanel2.Controls.Add(this.btnIngresarContratos);
            this.metroPanel2.Controls.Add(this.btnEliminarContratos);
            this.metroPanel2.Controls.Add(this.btnActualizarContratos);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(412, 209);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(340, 190);
            this.metroPanel2.TabIndex = 39;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.RadioIngresarNuevoContrato);
            this.metroPanel3.Controls.Add(this.RadioBuscarContrato);
            this.metroPanel3.Controls.Add(this.txtBuscarContrato);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.btnBuscarContratos);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(412, 82);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(340, 121);
            this.metroPanel3.TabIndex = 40;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // RadioIngresarNuevoContrato
            // 
            this.RadioIngresarNuevoContrato.AutoSize = true;
            this.RadioIngresarNuevoContrato.Location = new System.Drawing.Point(178, 17);
            this.RadioIngresarNuevoContrato.Name = "RadioIngresarNuevoContrato";
            this.RadioIngresarNuevoContrato.Size = new System.Drawing.Size(153, 15);
            this.RadioIngresarNuevoContrato.TabIndex = 40;
            this.RadioIngresarNuevoContrato.Text = "Ingresar Nuevo Contrato";
            this.RadioIngresarNuevoContrato.UseSelectable = true;
            // 
            // RadioBuscarContrato
            // 
            this.RadioBuscarContrato.AutoSize = true;
            this.RadioBuscarContrato.Location = new System.Drawing.Point(19, 17);
            this.RadioBuscarContrato.Name = "RadioBuscarContrato";
            this.RadioBuscarContrato.Size = new System.Drawing.Size(108, 15);
            this.RadioBuscarContrato.TabIndex = 39;
            this.RadioBuscarContrato.Text = "Buscar Contrato";
            this.RadioBuscarContrato.UseSelectable = true;
            this.RadioBuscarContrato.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // txtBuscarContrato
            // 
            // 
            // 
            // 
            this.txtBuscarContrato.CustomButton.Image = null;
            this.txtBuscarContrato.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtBuscarContrato.CustomButton.Name = "";
            this.txtBuscarContrato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscarContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscarContrato.CustomButton.TabIndex = 1;
            this.txtBuscarContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscarContrato.CustomButton.UseSelectable = true;
            this.txtBuscarContrato.CustomButton.Visible = false;
            this.txtBuscarContrato.Lines = new string[0];
            this.txtBuscarContrato.Location = new System.Drawing.Point(76, 79);
            this.txtBuscarContrato.MaxLength = 32767;
            this.txtBuscarContrato.Name = "txtBuscarContrato";
            this.txtBuscarContrato.PasswordChar = '\0';
            this.txtBuscarContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarContrato.SelectedText = "";
            this.txtBuscarContrato.SelectionLength = 0;
            this.txtBuscarContrato.SelectionStart = 0;
            this.txtBuscarContrato.ShortcutsEnabled = true;
            this.txtBuscarContrato.Size = new System.Drawing.Size(127, 23);
            this.txtBuscarContrato.TabIndex = 38;
            this.txtBuscarContrato.UseSelectable = true;
            this.txtBuscarContrato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscarContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(8, 81);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 37;
            this.metroLabel5.Text = "BUSCAR:";
            // 
            // VistaControldeContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VistaControldeContratos";
            this.Text = "VistaControldeContratos";
            this.Load += new System.EventHandler(this.VistaControldeContratos_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIdContrato;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime txtFechaInicio;
        private MetroFramework.Controls.MetroDateTime txtFechaTermino;
        private MetroFramework.Controls.MetroTextBox txtRutProductorContrato;
        private MetroFramework.Controls.MetroTile btnSalirContratos;
        private MetroFramework.Controls.MetroTile btnBuscarContratos;
        private MetroFramework.Controls.MetroTile btnEliminarContratos;
        private MetroFramework.Controls.MetroTile btnActualizarContratos;
        private MetroFramework.Controls.MetroTile btnIngresarContratos;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroRadioButton RadioIngresarNuevoContrato;
        private MetroFramework.Controls.MetroRadioButton RadioBuscarContrato;
        private MetroFramework.Controls.MetroTextBox txtBuscarContrato;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}