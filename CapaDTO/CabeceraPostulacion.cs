﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDTO
{
    public class CabeceraPostulacion
    {
        private int idCabeceraPostulacion;
        private DateTime fechaEmision;
        private int rutProductor;
        private int idCabeceraProcesoVenta;

        public int IdCabeceraPostulacion { get => idCabeceraPostulacion; set => idCabeceraPostulacion = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }
        public int RutProductor { get => rutProductor; set => rutProductor = value; }
        public int IdCabeceraProcesoVenta { get => idCabeceraProcesoVenta; set => idCabeceraProcesoVenta = value; }
    }
}
