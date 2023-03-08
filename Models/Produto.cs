using System;
using System.Collections.Generic;

#nullable disable

namespace ControladorVendasASP.NET.Models
{
    public partial class Produto
    {
        public Produto()
        {
            Itensvenda = new HashSet<ItensVenda>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal? Preco { get; set; }
        public int? QtdEstoque { get; set; }
        public int? ForId { get; set; }

        public virtual Fornecedor For { get; set; }
        public virtual ICollection<ItensVenda> Itensvenda { get; set; }
    }
}
