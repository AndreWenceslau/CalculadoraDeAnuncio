using CalculadoraDeAnuncio.Models;
using CalculadoraDeAnuncio.RegraDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraDeAnuncio.Controllers
{
    public class CalcularAnuncioController : Controller
    {
        // GET: CalcularAnuncio
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Anuncio());
        }

        [HttpPost]
        public ActionResult Index(Anuncio anuncio, double valor)
        {
            var qtdViewDia = (int)QtdViewDia.GetQtdViewDia(anuncio.Valor);
            var tempoAnuncio = VariavelFixa.TempoAnuncio;
            var cliques = qtdViewDia * tempoAnuncio / (int)VariavelFixa.ViewClique;
            var compartilhamentos = TotalCompartilhamento.GetCompartilhamentos(cliques, VariavelFixa.CliqueCompartilhamento);
            var tempoDoAnuncio = VariavelFixa.TempoAnuncio;
            var viewAdicionais = ViewAdicional.GetViewAdicionais(compartilhamentos);
            var resultado = qtdViewDia * tempoDoAnuncio + viewAdicionais;
            anuncio.Resultado = resultado;

            return View(anuncio);

        }
    }
}