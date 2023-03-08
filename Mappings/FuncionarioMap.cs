using ControladorVendasASP.NET.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleVendasAPS.NET.CORE.Mappings
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("tb_funcionarios");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Bairro)
                .HasMaxLength(100)
                .HasColumnName("bairro");

            builder.Property(e => e.Cargo)
                .HasMaxLength(100)
                .HasColumnName("cargo");

            builder.Property(e => e.Celular)
                .HasMaxLength(30)
                .HasColumnName("celular");

            builder.Property(e => e.Cep)
                .HasMaxLength(100)
                .HasColumnName("cep");

            builder.Property(e => e.Cidade)
                .HasMaxLength(100)
                .HasColumnName("cidade");

            builder.Property(e => e.Complemento)
                .HasMaxLength(200)
                .HasColumnName("complemento");

            builder.Property(e => e.Cpf)
                .HasMaxLength(20)
                .HasColumnName("cpf");

            builder.Property(e => e.Email)
                .HasMaxLength(200)
                .HasColumnName("email");

            builder.Property(e => e.Endereco)
                .HasMaxLength(255)
                .HasColumnName("endereco");

            builder.Property(e => e.Estado)
                .HasMaxLength(2)
                .HasColumnName("estado");

            builder.Property(e => e.NivelAcesso)
                .HasMaxLength(50)
                .HasColumnName("nivel_acesso");

            builder.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome");

            builder.Property(e => e.Numero).HasColumnName("numero");

            builder.Property(e => e.Rg)
                .HasMaxLength(30)
                .HasColumnName("rg");

            builder.Property(e => e.Senha)
                .HasMaxLength(10)
                .HasColumnName("senha");

            builder.Property(e => e.Telefone)
                .HasMaxLength(30)
                .HasColumnName("telefone");
        }
    }
}
