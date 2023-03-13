using ControladorVendasASP.NET.Context;
using ControladorVendasASP.NET.Models;
using ControleVendasAPS.NET.CORE.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleVendasAPS.NET.CORE.Servico
{
    public class FornecedorServicos : IFornecedorServicos
    {
        private readonly DbControleVendasContext _dbContext;

        public FornecedorServicos(DbControleVendasContext dbContext)
        {
             _dbContext = dbContext;
        }
        public Fornecedor ListarFornecedorPorId(int id)
        {
            return _dbContext.Fornecedores.FirstOrDefault(x => x.Id == id);
        }
        public List<Fornecedor> ListarFornecedor()
        {
            return _dbContext.Fornecedores.ToList();
        }
        public Fornecedor InserirFornecedor(Fornecedor fornecedor)
        {
            _dbContext.Fornecedores.Add(fornecedor);
            _dbContext.SaveChanges();
            return fornecedor;
        }
        public Fornecedor EditarFornecedor(Fornecedor fornecedor)
        {

            Fornecedor fornecedorModel = ListarFornecedorPorId(fornecedor.Id);

            if (fornecedorModel == null)
            {
                throw new Exception($"Fornecedor: {fornecedor.Nome} não foi encontrado");
            }

            fornecedorModel.Nome = fornecedor.Nome;
            fornecedorModel.Cnpj = fornecedor.Cnpj;
            fornecedorModel.Email = fornecedor.Email;
            fornecedorModel.Telefone = fornecedor.Telefone;
            fornecedorModel.Celular = fornecedor.Celular;
            fornecedorModel.Cep = fornecedor.Cep;
            fornecedorModel.Endereco = fornecedor.Endereco;
            fornecedorModel.Numero = fornecedor.Numero;
            fornecedorModel.Complemento = fornecedor.Complemento;
            fornecedorModel.Bairro = fornecedor.Bairro;
            fornecedorModel.Cidade = fornecedor.Cidade;
            fornecedorModel.Estado = fornecedor.Estado;

            _dbContext.Update(fornecedorModel);

            _dbContext.SaveChanges();
            return fornecedorModel;
        }    
        public bool RemoverFornecedor(int id)
        {
            Fornecedor fornecedor = ListarFornecedorPorId(id);
            if (fornecedor == null)
            {
                throw new Exception($"Fornecedor com o ID: {id} não foi encontrado");
            }
            _dbContext.Fornecedores.Remove(fornecedor);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
