using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraDeAnuncio.RegraDeNegocio
{
    public class QtdViewDia
    {
        public static double GetQtdViewDia(double investimentoDia)
        {
            return investimentoDia * VariavelFixa.ViewPorUmReal;
        }
    }
}