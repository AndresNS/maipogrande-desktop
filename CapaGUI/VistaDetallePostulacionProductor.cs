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
    public partial class VistaDetallePostulacionProductor : MetroFramework.Forms.MetroForm
    {
        private int idCabeceraPostulacion;

        public int IdCabeceraPostulacion { get => idCabeceraPostulacion; set => idCabeceraPostulacion = value; }

        public VistaDetallePostulacionProductor(int idCabeceraPostulacion)
        {
            InitializeComponent();
            this.IdCabeceraPostulacion = idCabeceraPostulacion;
        }

        private void VistaDetallePostulacionProductor_Load(object sender, EventArgs e)
        {
            // cargar cabecera y detalles de proceso de venta
            NegocioCabeceraPostulacion negocioCabeceraPostulacion = new NegocioCabeceraPostulacion();
            CabeceraPostulacion postulacion = negocioCabeceraPostulacion.buscarCabeceraPostulacion(this.IdCabeceraPostulacion);

            NegocioProductor negocioProductor = new NegocioProductor();
            Productor productor = negocioProductor.buscarProductor(postulacion.RutProductor);

            // Agregar tabla estado postulacion
            //NegocioEstadoVenta negocioEstadoVenta = new NegocioEstadoVenta();
            //EstadoVenta estadoVenta = negocioEstadoVenta.buscarEstado(procesoVenta.IdEstado);

            this.txtIDPostulacion.Text = postulacion.IdCabeceraPostulacion.ToString();
            this.txtRutProductor.Text = productor.Rut.ToString() + "-" + productor.DigitoVerificador;
            this.txtRazonSocial.Text = productor.RazonSocial;
            this.mdtFechaEmision.Value = postulacion.FechaEmision;

            NegocioDetallePostulacion negocioDetallePostulacion = new NegocioDetallePostulacion();
            DataSet detallePostulacion = negocioDetallePostulacion.listarDetallesPostulacion(postulacion.IdCabeceraPostulacion);

            this.dgvDetallePostulacion.DataSource = detallePostulacion.Tables["DETALLE_POSTULACION"];
        }
    }
}
