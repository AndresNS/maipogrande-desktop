using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Usuario
    {
        private int idUsuario;
        private String nombreUsuario;
        private String password;
        private DateTime fechaCreacion;
        private int idPerfil;
        private int idEstadoCuenta;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public String NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public String Password { get => password; set => password = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public int IdEstadoCuenta { get => idEstadoCuenta; set => idEstadoCuenta = value; }

    }
}
