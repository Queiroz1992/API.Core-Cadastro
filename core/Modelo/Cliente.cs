using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alterdata.Bimer.Core.Modelo
{    
    /// <summary>
    /// Modelo de domínio que representa uma Empresa
    /// </summary>
    [Table("TB_CLIENTE")]
    public class Cliente
    {
        /// <summary>
        /// Obtém ou define o identificador da empresa.
        /// </summary>
        [Key]
        [Column("id")]
        public int Identificador { get; set; }

        /// <summary>
        /// Obtém ou define nome do cliente.
        /// </summary>
        
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define o endereço do cliente.
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Obtém ou define o telefone do cliente.
        /// </summary>
        public string Telefone { get; set; }    

        //public List<Contato> Contatos { get; set; }

        /// <summary>
        /// Obtém ou define a data de nascimento do cliente.
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime DataNascimento { get; set; }
    }
}