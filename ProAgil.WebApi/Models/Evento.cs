﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil.WebApi.Models
{
    public class Evento
    {
        public int EventoID { get; set; }

        public string Local { get; set; }

        public string DataEvento { get; set; }

        public string Tema { get; set; }

        public int QtdePessoas { get; set; }

        public string Lote { get; set; }
    }
}
