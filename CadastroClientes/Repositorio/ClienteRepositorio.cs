using CadastroClientes.Data;
using CadastroClientes.Models;
using System.Collections.Generic;
using System.Linq;

namespace CadastroClientes.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ClienteRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ClienteModel ListarPorId(int id)
        {
            return _bancoContext.Clientes.FirstOrDefault(x => x.Id == id);
        }

        public List<ClienteModel> BuscarTodos()
        {
            return _bancoContext.Clientes.ToList();
        }

        public ClienteModel Adicionar(ClienteModel cliente)
        {
            // Gravar no Bando de Dados
            _bancoContext.Clientes.Add(cliente);
            _bancoContext.SaveChanges();
            return cliente;
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDB = ListarPorId(cliente.Id);

            if (clienteDB == null) throw new System.Exception("Houve um erro na atualização do cliente!");

            clienteDB.Nome = cliente.Nome;
            clienteDB.CPF = cliente.CPF;
            clienteDB.RG = cliente.RG;
            clienteDB.DataExp = cliente.DataExp;
            clienteDB.OrgExp = cliente.OrgExp;
            clienteDB.UfExp = cliente.UfExp;
            clienteDB.Nascimento = cliente.Nascimento;
            clienteDB.Sexo = cliente.Sexo;
            clienteDB.EstCivil = cliente.EstCivil;
            clienteDB.CEP = cliente.CEP;
            clienteDB.Rua = cliente.Rua;
            clienteDB.Numero = cliente.Numero;
            clienteDB.Complemento = cliente.Complemento;
            clienteDB.Bairro = cliente.Bairro;
            clienteDB.Cidade = cliente.Cidade;
            clienteDB.UF = cliente.UF;

            _bancoContext.Clientes.Update(clienteDB);
            _bancoContext.SaveChanges();

            return clienteDB;
        }

        public bool Apagar(int id)
        {
            ClienteModel clienteDB = ListarPorId(id);

            if (clienteDB == null) throw new System.Exception("Houve um erro na deleção do cliente!");

            _bancoContext.Clientes.Remove(clienteDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
