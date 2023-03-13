using ControladorVendasASP.NET.Models;
using ControleVendasAPS.NET.CORE.Servico.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ControleVendasAPS.NET.CORE.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly IFornecedorServicos _fornecedorServico;

        public FornecedorController(IFornecedorServicos fornecedorServico)
        {
            _fornecedorServico = fornecedorServico;
        }
        public ActionResult Index()
        {
            List<Fornecedor> fornecedor = _fornecedorServico.ListarFornecedor();
            return View(fornecedor);
        }
        public ActionResult InserirFornecedor()
        {
            return View();
        }

        public ActionResult<Fornecedor> EditarFornecedor(int id)
        {
            Fornecedor fornecedor = _fornecedorServico.ListarFornecedorPorId(id);
            return View(fornecedor);
        }

        public ActionResult<Fornecedor> RemoverConfirmacao(int id)
        {
            Fornecedor apagado = _fornecedorServico.ListarFornecedorPorId(id);
            return View(apagado);
        }
        public IActionResult Remover(int id)
        {
            _fornecedorServico.RemoverFornecedor(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult InserirFornecedor(Fornecedor FornecedorModel)
        {
            _fornecedorServico.InserirFornecedor(FornecedorModel);
            return RedirectToAction("Index");
        }

        [HttpPost]

        public IActionResult Alterar(Fornecedor fornecedor)
        {
            _fornecedorServico.EditarFornecedor(fornecedor);
            return RedirectToAction("Index");
        }

    }
}
