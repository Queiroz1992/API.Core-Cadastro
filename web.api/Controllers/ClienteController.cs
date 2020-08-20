namespace Alterdata.Bimer.WebAPI.Controllers
{
    using System.Collections.Generic;
    using System;

    using Alterdata.Bimer.WebAPI.Contratos;
    using Alterdata.Bimer.WebAPI.ServicoAplicacao;

    using Microsoft.AspNetCore.Mvc;
    using Alterdata.Bimer.Core.Modelo;
    using Alterdata.Bimer.WebAPI.Parsers;

    /// <summary>
    /// Controladora de Clientes
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private IServicoAplicacaoCliente _servicoAplicacaoCliente;

        public ClienteController(IServicoAplicacaoCliente servicoAplicacaoCliente)
        {
            _servicoAplicacaoCliente = servicoAplicacaoCliente;
        }

        /// <summary>
        /// Obtém todas as clientes cadastradas.
        /// </summary>
        /// <returns>As clientes cadastradas.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<ContratoRetornoCliente>> ObterTodos()
        {
            try
            {
                return Ok(_servicoAplicacaoCliente.ObterClientes());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{IdCliente}", Name = "ObterCliente")]
        public IActionResult ObterClientePorId(int IdCliente)
        {
            try
            {
                return Ok(_servicoAplicacaoCliente.ObterClientePorId(IdCliente));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AdicionarCliente([FromBody] Cliente cliente)
        {
            try
            {

                if (cliente == null)
                {
                    return BadRequest();
                }
                _servicoAplicacaoCliente.AdicionarCliente(cliente);

                return Ok();//retorna sucesso no cadastro

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult AtualizarCliente([FromBody] Cliente cliente)
        {
            try
            {
                if (cliente == null)
                {
                    return BadRequest();
                }

                ContratoRetornoCliente ContratoCliente = _servicoAplicacaoCliente.ObterClientePorId(cliente.Identificador);

                if (ContratoCliente == null) return NotFound();//retorna não achado caso cliente não exista na base

                _servicoAplicacaoCliente.AtualizarCliente(cliente);

                return Ok();//retorna sucesso 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
        }

        [HttpDelete("{IdCliente}")]
        public IActionResult DeletarCliente(int IdCliente)
        {
            try
            {
                if (IdCliente == null)
                {
                    return BadRequest();
                }

                ContratoRetornoCliente ContratoCliente = _servicoAplicacaoCliente.ObterClientePorId(IdCliente);

                if (ContratoCliente == null) return NotFound();//retorna não achado caso cliente não exista na base

                Cliente cliente = ClienteParser.Converter(ContratoCliente);

                _servicoAplicacaoCliente.RemoverCliente(cliente);

                return Ok();//retorna sucesso 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
        }

    }
}