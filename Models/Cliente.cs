﻿using System;
using System.Collections.Generic;


namespace ControladorVendasASP.NET.Models
{
    public class Cliente
    {
        public Cliente()
        {
            Venda = new HashSet<Venda>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
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

        public virtual ICollection<Venda> Venda { get; set; }
    }
}
