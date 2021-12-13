using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class CabeceraOrdenCompra
    {
        private int idCabeceraOrdenCompra;
        private DateTime fechaEmision;
        private int rutCliente;

        public int IdCabeceraOrdenCompra { get => idCabeceraOrdenCompra; set => idCabeceraOrdenCompra = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public int RutCliente { get => rutCliente; set => rutCliente = value; }
    }
}
