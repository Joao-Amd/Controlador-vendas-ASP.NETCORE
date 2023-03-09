using ControladorVendasASP.NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleVendasAPS.NET.CORE.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("tb_produtos");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasColumnName("descricao");

            builder.Property(e => e.ForId).HasColumnName("for_id");

            builder.Property(e => e.Preco)
                .HasPrecision(10, 2)
                .HasColumnName("preco");

            builder.Property(e => e.QtdEstoque).HasColumnName("qtd_estoque");

            builder.HasOne(d => d.For)
                .WithMany(p => p.Produtos)
                .HasForeignKey(d => d.ForId)
                .HasConstraintName("tb_produtos_for_id_fkey");
        }
    }
}
