﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Turno
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public string Cliente { get; set; }

        public Servicio Servicio { get; set; }

        public Servicio Valor { get; set; }

        public Autor Autor { get; set; }

    }
}
