using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class EstadoVenta
    {
        private int idEstadoVenta;
        private String descripcion;
        public int IdEstadoVenta { get => idEstadoVenta; set => idEstadoVenta = value; }
        public String Descripcion { get => descripcion; set => descripcion = value; }
    }
}
