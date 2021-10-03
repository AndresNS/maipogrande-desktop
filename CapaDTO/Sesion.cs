using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Sesion
    {
       
        private String nombre_usuario;
        private String password;
        private int idPerfil;
        private int idEstadoCuenta;

        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Password { get => password; set => password = value; }
        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public int IdEstadoCuenta { get => idEstadoCuenta; set => idEstadoCuenta = value; }
    }
}
