namespace Alterdata.Bimer.Core.Repositorio
{
    using System.Collections.Generic;
    using Alterdata.Bimer.Core.Modelo;

    /// <summary>
    /// Interface para abstração do repositório de empresas
    /// </summary>    
    public interface IRepositorioEmpresa
    {
        /// <summary>
        /// Obtém as empresas.
        /// </summary>
        /// <returns>A lista com todas as entidades de empresa encontradas.</returns>
        IEnumerable<Empresa> ObterTodos();

        /// <summary>
        /// Adiciona uma empresa ao repositório.
        /// </summary>
        /// <param name="empresa">A empresa a ser adicionada.</param>
        void Adicionar(Empresa empresa);

        /// <summary>
        /// Atualiza uma empresa no repositório.
        /// </summary>
        /// <param name="empresa">A empresa a ser atualizada.</param>
        void Atualizar(Empresa empresa);

        /// <summary>
        /// Remove uma empresa do repositório.
        /// </summary>
        /// <param name="empresa">A empresa a ser removida.</param>
        void Remover(Empresa empresa);
    }
}