using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraDeAnuncio.RegraDeNegocio
{
    public class ViewAdicional
    {
        public static double GetViewAdicionais(double compartilhamentos)
        {
            return compartilhamentos * VariavelFixa.ViewPorCompartilhamneto;
        }
    }
}