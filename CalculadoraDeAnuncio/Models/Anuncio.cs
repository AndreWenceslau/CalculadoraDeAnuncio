using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalculadoraDeAnuncio.Models
{
    public class Anuncio
    {
        public int Id { get; set; }
        [Required]
        public double Valor { get; set; }
        public double Resultado { get; set; }
    }
}