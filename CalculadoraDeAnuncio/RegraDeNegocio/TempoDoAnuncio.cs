﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraDeAnuncio.RegraDeNegocio
{
    public class TempoDoAnuncio
    {
        public static int GetTempoDoAnuncio(DateTime? dataInicio, DateTime? dataTermino)
        {
            var soma = dataTermino - dataInicio;
            return soma.Value.Days;
        }
    }
}