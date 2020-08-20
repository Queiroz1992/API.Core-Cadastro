namespace Alterdata.Bimer.Core.Repositorio.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Alterdata.Bimer.Core.Context;
    using Alterdata.Bimer.Core.Modelo;
    using Dapper;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Implementação concreta do respositório de empresas
    /// </summary>
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly ClienteContext _context;

        public RepositorioCliente(ClienteContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        //private static IList<Cliente> _databaseMockado = new List<Cliente>
        //{
        //    new Cliente
        //    {
        //        Identificador = 1,
        //        Nome = "Rodrigo Feitosa",
        //        Endereco = "Rua dos Marimbondos",
        //        Telefone = "27247826",
        //        DataNascimento = DateTime.Now,

        //    },
        //    new Cliente
        //    {
        //        Identificador = 2,
        //        Nome = "Isabele Feitosa",
        //        Endereco = "Rua Italva",
        //        Telefone = "27788224",
        //        DataNascimento = DateTime.Now,
        //    }
        //};

        public void Adicionar(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
        }

        public void Atualizar(Cliente cliente)
        {
            _context.Update(cliente);
            _context.SaveChanges();
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            //return new List<Cliente>(_databaseMockado);
            IQueryable<Cliente> cliente = _context.Clientes;
            
            return cliente.ToList();
        }

        public void Remover(Cliente cliente)
        {
            _context.Remove(cliente);
            _context.SaveChanges();
        }

        public Cliente ObterClientePorId(int idCliente)
        {
            return _context.Clientes.FirstOrDefault(c => c.Identificador == idCliente);
        }

       
    }
}