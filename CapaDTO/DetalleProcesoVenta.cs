using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class DetalleProcesoVenta
    {
        private int idDetalleVenta;
        private int idProducto;
        private int cantidad;
        private int precioUnitario;
        private int idCabeceraVenta;

        public int IdDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int IdCabeceraVenta { get => idCabeceraVenta; set => idCabeceraVenta = value; }
    }
}
