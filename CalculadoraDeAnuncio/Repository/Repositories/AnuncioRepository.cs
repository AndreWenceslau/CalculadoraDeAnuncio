using CalculadoraDeAnuncio.BancoDados;
using CalculadoraDeAnuncio.Interfaces;
using CalculadoraDeAnuncio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraDeAnuncio.Repository.Repositories
{
    public class AnuncioRepository : IAnuncioRepository
    {
        private AnuncioContext context = new AnuncioContext();

        public bool Alterar(Anuncio anuncio)
        {
            var anuncioOriginal = context.Anuncios.FirstOrDefault(x => x.Id == anuncio.Id);

            if (anuncioOriginal == null)
                return false;

            anuncioOriginal.Valor = anuncio.Valor;
            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;

        }

        public bool Apagar(int id)
        {
            var anuncio = context.Anuncios.FirstOrDefault(x => x.Id == id);

            if (anuncio == null)
            {
                return false;
            }

            int quantidadeAfetada = context.SaveChanges();
            return quantidadeAfetada == 1;
        }

        public int Inserir(Anuncio anuncio)
        {
            context.Anuncios.Add(anuncio);
            context.SaveChanges();
            return anuncio.Id;
        }

        public Anuncio ObterPeloId(int id)
        {
            var anuncio = context.Anuncios.FirstOrDefault(x => x.Id == id);
            return anuncio;
        }

        public List<Anuncio> ObterTodos()
        {
            return context.Anuncios.OrderBy(x => x.Id).ToList();
        }

    }
}