namespace Alterdata.Bimer.Core.Servico.Impl
{
    using System.Collections.Generic;

    using Alterdata.Bimer.Core.Modelo;
    using Alterdata.Bimer.Core.Repositorio;

    /// <summary>
    /// Implementação concreta do serviço de domínio de empresas
    /// </summary>
    public class ServicoDominioCliente : IServicoDominioCliente
    {
        private IRepositorioCliente _repositorio;

        public ServicoDominioCliente(IRepositorioCliente repositorio)
        {
            _repositorio = repositorio;
        }

        public IEnumerable<Cliente> ObterClientes()
        {
            return _repositorio.ObterTodos();
        }

        public Cliente ObterClientePorId(int IdCliente)
        {
            return _repositorio.ObterClientePorId(IdCliente);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _repositorio.Adicionar(cliente);
        }

        public void RemoverCliente(Cliente cliente)
        {
            _repositorio.Remover(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _repositorio.Atualizar(cliente);
        }

    }
}