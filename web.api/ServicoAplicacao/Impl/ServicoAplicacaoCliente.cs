namespace Alterdata.Bimer.WebAPI.ServicoAplicacao.Impl
{
    using System.Collections.Generic;

    using Alterdata.Bimer.WebAPI.Parsers;
    using Alterdata.Bimer.WebAPI.Contratos;
    using Alterdata.Bimer.Core.Servico;
    using Alterdata.Bimer.Core.Modelo;

    /// <summary>
    /// Implementação concreta do serviço de domínio de clientes
    /// </summary>
    public class ServicoAplicacaoCliente : IServicoAplicacaoCliente
    {
        private IServicoDominioCliente _servicoDominioCliente;

        public ServicoAplicacaoCliente(IServicoDominioCliente servicoDominioCliente)
        {
            _servicoDominioCliente = servicoDominioCliente;
        }

        public ContratoRetornoCliente ObterClientePorId(int idCliente)
        {
            var cliente = _servicoDominioCliente.ObterClientePorId(idCliente);
            return ClienteParser.Converter(cliente);
        }

        public IEnumerable<ContratoRetornoCliente> ObterClientes()
        {
            var listaClientes = _servicoDominioCliente.ObterClientes();
            return ClienteParser.Converter(listaClientes);
        }

        public void AdicionarCliente(Cliente cliente)
        {
            _servicoDominioCliente.AdicionarCliente(cliente); //me mostra a documentação
            //return ClienteParser.Converter(cliente);
        }

        public void AtualizarCliente(Cliente cliente)
        {
            _servicoDominioCliente.AtualizarCliente(cliente); //me mostra a documentação
            //return ClienteParser.Converter(cliente);
        }

        public void RemoverCliente(Cliente cliente)
        {
            _servicoDominioCliente.RemoverCliente(cliente); //me mostra a documentação
            //return ClienteParser.Converter(cliente);
        }


    }
}