using ControladorVendasASP.NET.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControladorVendasASP.NET.Servico.Interfaces
{
    public interface IClienteServicos
    {
        List<Cliente> ListarCliente();
        Cliente ListarClientePorId(int  id);
        Cliente InserirCliente(Cliente cliente);
        Cliente EditarClientes(Cliente cliente);
        bool RemoverClientes(int id);
    }
}
