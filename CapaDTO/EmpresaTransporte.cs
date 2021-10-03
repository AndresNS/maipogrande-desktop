using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class EmpresaTransporte
    {
        private int idEmpresa;
        private String nombreEmpresa;
        private int idUsuario;

        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public String NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
