using System;
using ControladorVendasASP.NET.Models;
using ControleVendasAPS.NET.CORE.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ControladorVendasASP.NET.Context
{
    public partial class DB_Controle_vendasContext : DbContext
    {
        public DB_Controle_vendasContext()
        {
        }

        public DB_Controle_vendasContext(DbContextOptions<DB_Controle_vendasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Fornecedor> Fornecedores { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<ItensVenda> ItensVendas { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Pooling=true;Database=DB_Controle_vendas;User Id=postgres;Password=3005;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new ItensVendasMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new VendaMap());
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
