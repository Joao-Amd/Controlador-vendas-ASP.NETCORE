using ControladorVendasASP.NET.Models;
using System.Collections.Generic;

namespace ControleVendasAPS.NET.CORE.Servico.Interfaces
{
    public interface IFornecedorServicos
    {
        List<Fornecedor> ListarFornecedor();
        Fornecedor ListarFornecedorPorId(int id);
        Fornecedor InserirFornecedor(Fornecedor fornecedor);
        Fornecedor EditarFornecedor(Fornecedor fornecedor);
        bool RemoverFornecedor(int id);
    }
}
