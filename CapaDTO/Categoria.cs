using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Categoria
    {

        private int idCategoria;
        private String nombreCategoria;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public String NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
    }
}
