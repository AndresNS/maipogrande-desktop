using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class VistaControldeContratos : MetroFramework.Forms.MetroForm
    {
        public VistaControldeContratos()
        {
            InitializeComponent();
        }

        private void VistaControldeContratos_Load(object sender, EventArgs e)
        {
            //METODO LOAD RADIO BUTTON CONTRATO
            this.RadioBuscarContrato.Checked = true;
            deshabilitarCamposContrato();
           // this.btnEliminarContratos.Enabled = false;
            this.btnIngresarContratos.Enabled = false;
           // this.btnActualizarContratos.Enabled = false;
            this.txtIdContrato.Enabled = false;
        }//metodo LOAD
        private void limpiarContrato()
        {
            this.txtIdContrato.Text = String.Empty;
            this.txtFechaInicio.Text = String.Empty;
            this.txtFechaTermino.Text = String.Empty;
            this.txtRutProductorContrato.Text = String.Empty;
        }//METODO LIMPIAR CONTRATO
        private void deshabilitarCamposContrato()
        {
            //this.txtIdContrato.Enabled = false;
            this.txtFechaInicio.Enabled = false;
            this.txtFechaTermino.Enabled = false;
            this.txtRutProductorContrato.Enabled = false;
        }//METODO DESABILITAR
        private void habilitarCamposContrato()
        {
           // this.txtIdContrato.Enabled = true;
            this.txtFechaInicio.Enabled = true;
            this.txtFechaTermino.Enabled = true;
            this.txtRutProductorContrato.Enabled = true;
        }// HABILITAR CONTRATO
        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e) //RADIO BUSCAR  CONTRATO
        {
            if (RadioBuscarContrato.Checked)
            {
                deshabilitarCamposContrato();
                limpiarContrato();
                this.btnEliminarContratos.Enabled = false;
                this.btnIngresarContratos.Enabled = false;
                this.btnActualizarContratos.Enabled = false;
                this.txtBuscarContrato.Text = String.Empty;
                this.txtBuscarContrato.Enabled = true;
                this.btnBuscarContratos.Enabled = true;
            }
            else
            {
                limpiarContrato();
                habilitarCamposContrato();
                this.btnBuscarContratos.Enabled = false;
               // this.btnEliminarContratos.Enabled = false;
                this.btnIngresarContratos.Enabled = true;
                this.btnIngresarContratos.Text = "Nuevo Contrato";
                this.txtBuscarContrato.Text = String.Empty;
                this.txtBuscarContrato.Enabled = false;
                this.txtBuscarContrato.Enabled = false;

            }
        }
        private void btnSalirProductor_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnBuscarContratos_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioContrato ven = new NegocioContrato();
                int idContrato = Int32.Parse(this.txtBuscarContrato.Text);
                Contrato contra = ven.buscarContrato(idContrato);

                this.txtIdContrato.Text = contra.IdContrato.ToString();
                this.txtFechaInicio.Value = contra.FechaInicio;
                this.txtFechaTermino.Value = contra.FechaTermino;
                this.txtRutProductorContrato.Text = contra.RutProductor.ToString();


                //this.txtNombreEmpresaTransporte.Text = transporte.NombreEmpresa;
                //this.txtidUsuarioEmpresa.Text = transporte.IdUsuario.ToString();

               MessageBox.Show("Contrato encontrado con exito");
               habilitarCamposContrato();
                this.txtBuscarContrato.Text = "";
                this.btnActualizarContratos.Enabled = true;
                this.btnEliminarContratos.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ENCONTRAR CONTRATO" +ex);
            }
        }

        private void btnIngresarContratos_Click(object sender, EventArgs e) //METODO INGRESAR CONTRATO
        {
            try
            {

                Contrato nuevoContrato = new Contrato();
                //nuevoContrato.IdContrato = Int32.Parse(this.txtIdContrato.Text);
                nuevoContrato.FechaInicio =  this.txtFechaInicio.Value;
                nuevoContrato.FechaTermino = this.txtFechaTermino.Value;
                nuevoContrato.RutProductor = Int32.Parse(this.txtRutProductorContrato.Text);

                NegocioContrato ven = new NegocioContrato();
                ven.IngresarContrato(nuevoContrato);
                MessageBox.Show("Contrato Agregado");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR INGRESAR CONTRATO");
            }
        }

        private void btnActualizarContratos_Click(object sender, EventArgs e)
        {
            try
            {
              
                Contrato nuevoContrato = new Contrato();

                nuevoContrato.IdContrato = Int32.Parse(this.txtIdContrato.Text);
                nuevoContrato.FechaInicio = this.txtFechaInicio.Value;
                nuevoContrato.FechaTermino = this.txtFechaTermino.Value;
                nuevoContrato.RutProductor = Int32.Parse(this.txtRutProductorContrato.Text);

                NegocioContrato negocioContrato = new NegocioContrato();
                negocioContrato.actualizarContrato(nuevoContrato);


                MessageBox.Show("Contrato Actualizado");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEliminarContratos_Click(object sender, EventArgs e)
        {
            try
            {
                int idContrato = Int32.Parse(this.txtIdContrato.Text);

                NegocioContrato ven = new NegocioContrato();
                ven.eliminarContrato(idContrato);
                MessageBox.Show("Contrato Eliminado con Exito");
                limpiarContrato();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INTENTAR ELIMINAR CONTRATO");
            }
        }

        private void RadioIngresarNuevoContrato_CheckedChanged(object sender, EventArgs e)
        {
            this.btnEliminarContratos.Enabled = false;
            this.btnActualizarContratos.Enabled = false;
        }
    }
}
