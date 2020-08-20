namespace Alterdata.Bimer.Core.Repositorio.Impl
{
    using System.Collections.Generic;

    using Alterdata.Bimer.Core.Modelo;
    using Dapper;

    /// <summary>
    /// Implementação concreta do respositório de empresas
    /// </summary>
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        private static IList<Empresa> _databaseMockado = new List<Empresa>
        {
            new Empresa
            {
                CNPJ = "36.462.778/0001-60",
                Identificador = 1,
                RazaoSocial = "Alterdata Tecnologia em Informática Ltda."
            },
            new Empresa
            {
                CNPJ = "99.152.438/0001-52",
                Identificador = 2,
                RazaoSocial = "Padaria do Zé Ltda."
            }
        };
        
        public void Adicionar(Empresa empresa)
        {
            _databaseMockado.Add(empresa);
        }

        public void Atualizar(Empresa empresa)
        {
            Remover(empresa);
            Adicionar(empresa);
        }

        public IEnumerable<Empresa> ObterTodos()
        {
            return new List<Empresa>(_databaseMockado);
        }

        public void Remover(Empresa empresa)
        {
            _databaseMockado.Remove(empresa);
        }
    }
}