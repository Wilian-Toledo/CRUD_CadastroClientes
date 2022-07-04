using CadastroClientes.Models;
using CadastroClientes.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroClientes.Controllers
{   
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public IActionResult Index()
        {
            List<ClienteModel> clientes = _clienteRepositorio.BuscarTodos();

            return View(clientes);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            ClienteModel clientes = _clienteRepositorio.ListarPorId(id);
            return View(clientes);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ClienteModel clientes = _clienteRepositorio.ListarPorId(id);
            return View(clientes);
        }

        public IActionResult Apagar(int id)
        {
            _clienteRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ClienteModel cliente)
        {
            _clienteRepositorio.Adicionar(cliente);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(ClienteModel cliente)
        {
            _clienteRepositorio.Atualizar(cliente);
            return RedirectToAction("Index");
        }
    }
}
