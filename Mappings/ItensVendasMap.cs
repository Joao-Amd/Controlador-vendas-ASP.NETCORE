using ControladorVendasASP.NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleVendasAPS.NET.CORE.Mappings
{
    public class ItensVendasMap : IEntityTypeConfiguration<ItensVenda>
    {
        public void Configure(EntityTypeBuilder<ItensVenda> builder)
        {
            builder.ToTable("tb_itensvendas");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.ProdutoId).HasColumnName("produto_id");

            builder.Property(e => e.Qtd).HasColumnName("qtd");

            builder.Property(e => e.Subtotal)
                .HasPrecision(10, 2)
                .HasColumnName("subtotal");

            builder.Property(e => e.VendaId).HasColumnName("venda_id");

            builder.HasOne(d => d.Produto)
                .WithMany(p => p.TbItensvenda)
                .HasForeignKey(d => d.ProdutoId)
                .HasConstraintName("tb_itensvendas_produto_id_fkey");

            builder.HasOne(d => d.Venda)
                .WithMany(p => p.TbItensvenda)
                .HasForeignKey(d => d.VendaId)
                .HasConstraintName("tb_itensvendas_venda_id_fkey");
        }
    }
}
