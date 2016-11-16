using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.LojaVirtual.Dominio.Entidade;

namespace Lojinha.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public  DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().ToTable("Produtos");

        }

    }
}
