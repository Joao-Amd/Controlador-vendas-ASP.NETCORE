using System;
using System.Collections.Generic;


namespace ControladorVendasASP.NET.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public int? Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
