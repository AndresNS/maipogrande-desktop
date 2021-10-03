using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class Producto
    {

        private int idProducto;
        private int idCategoria;
        private String nombreProducto;
        private int precio;
        private int idCalidad;
        private double porcentajeMerma;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Precio { get => precio; set => precio = value; }
        public int IdCalidad { get => idCalidad; set => idCalidad = value; }
        public double PorcentajeMerma { get => porcentajeMerma; set => porcentajeMerma = value; }
    }
}
