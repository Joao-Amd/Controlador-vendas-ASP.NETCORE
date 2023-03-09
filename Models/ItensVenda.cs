using System;
using System.Collections.Generic;


namespace ControladorVendasASP.NET.Models
{
    public partial class ItensVenda
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Qtd { get; set; }
        public decimal Subtotal { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual Venda Venda { get; set; }
    }
}
