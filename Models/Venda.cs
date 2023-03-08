using System;
using System.Collections.Generic;

#nullable disable

namespace ControladorVendasASP.NET.Models
{
    public partial class Venda
    {
        public Venda()
        {
            Itensvenda = new HashSet<ItensVenda>();
        }

        public int Id { get; set; }
        public int? ClienteId { get; set; }
        public DateTime? DataVenda { get; set; }
        public decimal? TotalVenda { get; set; }
        public string Observacoes { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<ItensVenda> Itensvenda { get; set; }
    }
}
