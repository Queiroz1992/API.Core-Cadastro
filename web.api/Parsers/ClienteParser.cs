namespace Alterdata.Bimer.WebAPI.Parsers
{
    using System.Collections.Generic;
    using System.Linq;

    using Alterdata.Bimer.WebAPI.Contratos;
    using Alterdata.Bimer.Core.Modelo;

    /// <summary>
    /// Mapeador entre entidades e DTOs de empresas
    /// </summary>
    public static class ClienteParser
    {
        /// <summary>
        /// Converte um modelo de domínio de empresa em um DTO de empresa.
        /// </summary>
        /// <param name="empresa">O modelo a ser convertido.</param>
        /// <returns>O DTO convertido.</returns>
        public static ContratoRetornoCliente Converter(Cliente cliente)
        {
            return new ContratoRetornoCliente
            {
                Identificador = cliente.Identificador,
                Nome = cliente.Nome,
                Endereco = cliente.Endereco,
                Telefone = cliente.Telefone,
                DataNascimento = cliente.DataNascimento
            };
        }

        /// <summary>
        /// Converte um DTO de empresa em um modelo de domínio de empresa.
        /// </summary>
        /// <param name="cliente">O DTO a ser convertido.</param>
        /// <returns>O modelo convertido.</returns>
        public static Cliente Converter(ContratoRetornoCliente contratoRetornoCliente)
        {
            return new Cliente
            {
                Identificador = contratoRetornoCliente.Identificador,
                Nome = contratoRetornoCliente.Nome,
                Endereco = contratoRetornoCliente.Endereco,
                Telefone = contratoRetornoCliente.Telefone,
                DataNascimento = contratoRetornoCliente.DataNascimento
            };
        }

        /// <summary>
        /// Converte uma lista de modelos de domínio de empresa em uma lista de DTOs de empresa.
        /// </summary>
        /// <param name="empresa">Os modelos a serem convertidos.</param>
        /// <returns>Os DTOs convertidos.</returns>
        public static IEnumerable<ContratoRetornoCliente> Converter(IEnumerable<Cliente> clientes)
        {
            return clientes.Select(cliente => Converter(cliente));
        }

        /// <summary>
        /// Converte uma lista de DTOs de empresa em uma lista de modelos de domínio de empresa.
        /// </summary>
        /// <param name="empresa">Os DTOs a serem convertidos.</param>
        /// <returns>Os modelos convertidos.</returns>
        public static IEnumerable<Cliente> Converter(List<ContratoRetornoCliente> listaContratoRetornoCliente)
        {
            return listaContratoRetornoCliente.Select(contrato => Converter(contrato));
        }
    }
}