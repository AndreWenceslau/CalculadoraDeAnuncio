using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraDeAnuncio.RegraDeNegocio
{
    public class TotalCompartilhamento
    {
        public static double GetCompartilhamentos(double? qtdMaxClique, double cliqueCompartilhamento)
        {
            var compartilhamentos = (int)qtdMaxClique / (int)cliqueCompartilhamento;

            if (qtdMaxClique < cliqueCompartilhamento)
            {
                compartilhamentos = 0;
            }
            if (compartilhamentos > 4)
            {
                compartilhamentos = 4;
            }
            return compartilhamentos;
        }
    }
}