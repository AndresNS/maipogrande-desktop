using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Pais
    {
        private int idPais;
        private String nombrePais;
        
        public int IdPais { get => idPais; set => idPais = value; }
        public String NombrePais { get => nombrePais; set => nombrePais = value; }
    }
}
