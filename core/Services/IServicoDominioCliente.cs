namespace Alterdata.Bimer.Core.Servico
{
    using System.Collections.Generic;

    using Alterdata.Bimer.Core.Modelo;

    /// <summary>
    /// Interface para abstração do serviço de domínio de empresas
    /// </summary>
    public interface IServicoDominioCliente
    {
        /// <summary>
        /// Obtém as empresas.
        /// </summary>
        /// <returns>A lista com todas as entidades de empresa encontradas.</returns>
        IEnumerable<Cliente> ObterClientes();
        Cliente ObterClientePorId(int IdCliente);
        void AdicionarCliente(Cliente cliente);
        void RemoverCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
    }
}