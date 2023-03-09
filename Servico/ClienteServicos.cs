using ControladorVendasASP.NET.Context;
using ControladorVendasASP.NET.Models;
using ControladorVendasASP.NET.Servico.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControladorVendasASP.NET.Servico
{
    public class ClienteServicos : IClienteServicos
    {
        private readonly DbControleVendasContext _dbContext;

        public ClienteServicos(DbControleVendasContext dbContex)
        {
            _dbContext = dbContex;
        }
        public Cliente ListarClientePorId(int id)
        {
            return _dbContext.Clientes.FirstOrDefault(x => x.Id == id);
        }
        public  List<Cliente> ListarCliente()
        {
            return _dbContext.Clientes.ToList();
        }
        public Cliente InserirCliente(Cliente cliente)
        {
            _dbContext.Clientes.Add(cliente);
           
             _dbContext.SaveChanges();
            return cliente;
        }
        public Cliente EditarClientes(Cliente cliente)
        {
            Cliente clienteModel = ListarClientePorId(cliente.Id);

            if (clienteModel == null)
            {
                throw new Exception($"Usuário para  o ID: {cliente.Id} não foi encontrado");
            }
            clienteModel.Cpf = cliente.Cpf; 
            clienteModel.Nome = cliente.Nome;
            clienteModel.Rg = cliente.Rg;
            clienteModel.Cpf = cliente.Cpf;
            clienteModel.Email = cliente.Email;
            clienteModel.Telefone = cliente.Telefone;
            clienteModel.Celular = cliente.Celular;
            clienteModel.Cep = cliente.Cep;
            clienteModel.Endereco = cliente.Endereco;
            clienteModel.Numero = cliente.Numero;
            clienteModel.Complemento = cliente.Complemento;
            clienteModel.Bairro = cliente.Bairro;
            clienteModel.Cidade = cliente.Cidade;
            clienteModel.Estado = cliente.Estado;

            _dbContext.Clientes.Update(clienteModel);
            _dbContext.SaveChanges();

            return clienteModel;

        }          
        public bool RemoverClientes(int id)
        {
            Cliente clienteModel = ListarClientePorId(id);

            if (clienteModel == null)
            {
                throw new Exception($"Usuário para  o ID: {id} não foi encontrado");
            }

            _dbContext.Clientes.Remove(clienteModel);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
