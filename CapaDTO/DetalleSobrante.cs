﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class DetalleSobrante
    {
        int idSobrante;
        int idCabeceraSobrante;
        int idProducto;
        int cantidad;

        public int IdSobrante { get => idSobrante; set => idSobrante = value; }
        public int IdCabeceraSobrante { get => idCabeceraSobrante; set => idCabeceraSobrante = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
