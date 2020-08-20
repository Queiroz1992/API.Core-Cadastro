namespace Alterdata.Bimer.WebAPI.ServicoAplicacao
{
    using System.Collections.Generic;
    using Alterdata.Bimer.Core.Modelo;
    using Alterdata.Bimer.WebAPI.Contratos;

    /// <summary>
    /// Interface para abstração do serviço de aplicação de empresas
    /// </summary>
    public interface IServicoAplicacaoCliente
    {
        /// <summary>
        /// Obtém todas as empresas cadastradas.
        /// </summary>
        /// <returns>As empresas cadastradas.</returns>
        IEnumerable<ContratoRetornoCliente> ObterClientes();
        ContratoRetornoCliente ObterClientePorId(int IdCliente);
        void AdicionarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void RemoverCliente(Cliente cliente);
    }
}