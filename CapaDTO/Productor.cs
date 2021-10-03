using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Productor
    {
        private int rut;
        private String digitoVerificador;
        private String razonSocial;
        private String direccion;
        private String giro;
        private int idComuna;
        private int idUsuario;

        public int Rut { get => rut; set => rut = value; }
        public String DigitoVerificador { get => digitoVerificador; set => digitoVerificador = value; }
        public String RazonSocial { get => razonSocial; set => razonSocial = value; }
        public String Direccion { get => direccion; set => direccion = value; }
        public String Giro { get => giro; set => giro = value; }
        public int IdComuna { get => idComuna; set => idComuna = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
