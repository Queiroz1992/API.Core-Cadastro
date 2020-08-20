namespace Alterdata.Bimer.Core.Repositorio
{
    using System.Collections.Generic;
    using Alterdata.Bimer.Core.Modelo;

    /// <summary>
    /// Interface para abstração do repositório de clientes
    /// </summary>    
    public interface IRepositorioCliente
    {
        /// <summary>
        /// Obtém as clientes.
        /// </summary>
        /// <returns>A lista com todas as entidades de cliente encontradas.</returns>
        IEnumerable<Cliente> ObterTodos();       

        /// <summary>
        /// Adiciona uma cliente ao repositório.
        /// </summary>
        /// <param name="Cliente">A cliente a ser adicionada.</param>
        void Adicionar(Cliente cliente);

        /// <summary>
        /// recupera um cliente pelo Id
        /// </summary>
        /// <param name="IdCliente">O Id a ser recuperado.</param>
        Cliente ObterClientePorId(int idCliente);

        /// <summary>
        /// Atualiza uma cliente no repositório.
        /// </summary>
        /// <param name="cliente">A cliente a ser atualizada.</param>
        void Atualizar(Cliente cliente);

        /// <summary>
        /// Remove uma cliente do repositório.
        /// </summary>
        /// <param name="cliente">A cliente a ser removida.</param>
        void Remover(Cliente cliente);
    }
}