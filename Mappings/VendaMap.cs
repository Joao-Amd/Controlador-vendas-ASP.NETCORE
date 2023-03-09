using ControladorVendasASP.NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleVendasAPS.NET.CORE.Mappings
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("tb_vendas");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.ClienteId).HasColumnName("cliente_id");

            builder.Property(e => e.DataVenda)
                .HasColumnType("date")
                .HasColumnName("data_venda");

            builder.Property(e => e.Observacoes).HasColumnName("observacoes");

            builder.Property(e => e.TotalVenda)
                .HasPrecision(10, 2)
                .HasColumnName("total_venda");

            builder.HasOne(d => d.Cliente)
                .WithMany(p => p.Venda)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("tb_vendas_cliente_id_fkey");
        }
    }
}
