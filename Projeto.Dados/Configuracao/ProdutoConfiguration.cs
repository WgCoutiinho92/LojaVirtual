using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.Dados.Configuracao
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            ToTable("Produto");
          {
                HasKey(p => p.IdProduto);

                Property(p => p.IdProduto)
               .HasColumnName("IdProduto_PK")
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(p => p.NomeProduto)
                    .HasColumnName("Nome_Produto")
                    .HasMaxLength(150)
                    .IsRequired();

                Property(p => p.DescricaoProduto)
                    .HasColumnName("Descricao_Produto")
                    .HasMaxLength(500)
                    .IsRequired();

                Property(p => p.PrecoProduto)
                    .HasColumnName("Preco_Produto")
                    .HasPrecision(18, 2)
                    .IsRequired();

            }

        }
    }
}
