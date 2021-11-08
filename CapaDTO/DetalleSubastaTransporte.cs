using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class DetalleSubastaTransporte
    {
        private int idDetalleSubasta;
        private int idEmpresaTransporte;
        private DateTime fechaEstimadaEntrega;
        private String capacidadCarga;
        private String refrigeracion;
        private String pesoMaximo;
        private String extras;
        private int precio;
        private int idCabeceraSubasta;

        public int IdDetalleSubasta { get => idDetalleSubasta; set => idDetalleSubasta = value; }
        public int IdEmpresaTransporte { get => idEmpresaTransporte; set => idEmpresaTransporte = value; }
        public DateTime FechaEstimadaEntrega { get => fechaEstimadaEntrega; set => fechaEstimadaEntrega = value; }
        public string CapacidadCarga { get => capacidadCarga; set => capacidadCarga = value; }
        public string Refrigeracion { get => refrigeracion; set => refrigeracion = value; }
        public string PesoMaximo { get => pesoMaximo; set => pesoMaximo = value; }
        public string Extras { get => extras; set => extras = value; }
        public int Precio { get => precio; set => precio = value; }
        public int IdCabeceraSubasta { get => idCabeceraSubasta; set => idCabeceraSubasta = value; }
    }
}
