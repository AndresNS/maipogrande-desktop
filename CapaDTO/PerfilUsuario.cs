using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class PerfilUsuario
    {
        private int idPerfilUsuario;
        private String nombrePerfil;

        public int IdPerfilUsuario { get => idPerfilUsuario; set => idPerfilUsuario = value; }
        public String NombrePerfil { get => nombrePerfil; set => nombrePerfil = value; }

    }
}
