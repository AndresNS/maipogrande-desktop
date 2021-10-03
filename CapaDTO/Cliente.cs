using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Cliente
    {
        private int rut;
        private String dvRut;
        private String razonSocial;
        private String direccion;
        private String giro;
        private int idComuna;
        private int idUsuario;
        private int idTipo;

        public int Rut { get => rut; set => rut = value; }
        public string DvRut { get => dvRut; set => dvRut = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Giro { get => giro; set => giro = value; }
        public int IdComuna { get => idComuna; set => idComuna = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
    }
}
