namespace Alterdata.Bimer.WebAPI.Contratos
{
    using System.Runtime.Serialization;
    using System;

    /// <summary>
    /// DTO para Endpoints de empresas
    /// </summary>
    [DataContract]
    public class ContratoRetornoCliente
    {
        
        /// <summary>
        /// Obtém ou define o nome da cliente.
        /// </summary>
        [DataMember(Name = "identificador")]
        public int Identificador { get; set; }

        /// <summary>
        /// Obtém ou define o nome da cliente.
        /// </summary>
        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o endereço do cliente.
        /// </summary>
        [DataMember(Name = "endereco")]
        public string Endereco { get; set; }

        /// <summary>
        /// Obtém ou define o telefone do cliente.
        /// </summary>
        [DataMember(Name = "telefone")]
        public string Telefone { get; set; }

        /// <summary>
        /// Obtém ou define a data de nascimento do cliente.
        /// </summary>
        [DataMember(Name = "dataNascimento")]
        public DateTime DataNascimento { get; set; }

    }
}