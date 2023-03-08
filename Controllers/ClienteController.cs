using ControladorVendasASP.NET.Models;
using ControladorVendasASP.NET.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ControladorVendasASP.NET.Controllers
{
    public class ClienteController : Controller
    {

        private readonly IClienteServicos _clienteServicos;

        public ClienteController(IClienteServicos clienteServicos)
        {
            _clienteServicos = clienteServicos;
        }
        public IActionResult Index()
        {
            List<Cliente> cliente = _clienteServicos.ListarCliente();

            return View(cliente);
        }
       
        public IActionResult InserirClientes()
        {
            return View();
        }
        public ActionResult<Cliente> EditarClientes(int id)
        {
            Cliente cliente = _clienteServicos.ListarClientePorId(id);
            return View(cliente);
        }

        public ActionResult<Cliente> RemoverClienteConfirmacao(int id)
        {
            Cliente apagado = _clienteServicos.ListarClientePorId(id);
            return View(apagado);
        }
        public IActionResult Remover(int id)
        {
            _clienteServicos.RemoverClientes(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult InserirClientes(Cliente clienteModel)
        {
            _clienteServicos.InserirCliente(clienteModel);
            return RedirectToAction("Index");
        }

        [HttpPut]

        public IActionResult Alterar (Cliente contato)
        {
            _clienteServicos.EditarClientes(contato);
            return RedirectToAction("Index");
        }

       
        


        

    }
}
