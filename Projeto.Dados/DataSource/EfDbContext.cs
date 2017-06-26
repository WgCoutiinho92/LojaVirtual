using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entidades.Entidades;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Configuration;
using Projeto.Dados.Configuracao;

namespace Projeto.Dados.DataSource
{
    public class EfDbContext : DbContext
    {
        public EfDbContext() : base(ConfigurationManager.ConnectionStrings["EfDbContext"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoConfiguration());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produto");
        }
        public DbSet<Produto> Produto { get; set; }
    }
}
