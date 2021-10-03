using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class EstadoCuenta
    {
        private int idEstadoCuenta;
        private String nombreEstadoCuenta;

        public int IdEstadoCuenta { get => idEstadoCuenta; set => idEstadoCuenta = value; }
        public String NombreEstadoCuenta { get => nombreEstadoCuenta; set => nombreEstadoCuenta = value; }
    }
}
