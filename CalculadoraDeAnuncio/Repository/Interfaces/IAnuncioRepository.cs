using CalculadoraDeAnuncio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeAnuncio.Interfaces
{
    public interface IAnuncioRepository
    {
        int Inserir(Anuncio anuncio);

        bool Alterar(Anuncio anuncio);

        List<Anuncio> ObterTodos();

        bool Apagar(int id);

        Anuncio ObterPeloId(int id);

    }
}
