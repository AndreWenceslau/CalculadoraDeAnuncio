using CalculadoraDeAnuncio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CalculadoraDeAnuncio.BancoDados
{
    public class AnuncioContext  : DbContext
    {
        public DbSet<Anuncio> Anuncios { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
        }
    }
}