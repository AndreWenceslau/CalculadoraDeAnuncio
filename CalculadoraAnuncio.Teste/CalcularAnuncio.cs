using CalculadoraDeAnuncio.Models;
using CalculadoraDeAnuncio.RegraDeNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculadoraAnuncio.Teste
{
    [TestClass]
    public class CalcularAnuncio
    {
        [TestMethod]
        public void CalcularAnuncio_QuandoObterValor_DeveRetornarQtdView()
        {
            //Arrange
            Anuncio anuncio = new Anuncio();
            anuncio.Valor = 100;
            anuncio.Resultado = 0;
            var resultadoEsperado = 3160;

            //Act
            var qtdViewDia = (int)QtdViewDia.GetQtdViewDia(anuncio.Valor);
            var tempoAnuncio = VariavelFixa.TempoAnuncio;
            var cliques = qtdViewDia * tempoAnuncio / (int)VariavelFixa.ViewClique;
            var compartilhamentos = TotalCompartilhamento.GetCompartilhamentos(cliques, VariavelFixa.CliqueCompartilhamento);
            var tempoDoAnuncio = VariavelFixa.TempoAnuncio;
            var viewAdicionais = ViewAdicional.GetViewAdicionais(compartilhamentos);
            var resultado = qtdViewDia * tempoDoAnuncio + viewAdicionais;
            anuncio.Resultado = resultado;
            var resultadoAtual = anuncio.Resultado;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }
    }
}
