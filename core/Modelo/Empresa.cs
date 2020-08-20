namespace Alterdata.Bimer.Core.Modelo
{    
    /// <summary>
    /// Modelo de domínio que representa uma Empresa
    /// </summary>
    public class Empresa
    {
        /// <summary>
        /// Obtém ou define o identificador da empresa.
        /// </summary>
        public int Identificador { get; set; }

        /// <summary>
        /// Obtém ou define a razão social da empresa.
        /// </summary>
        public string RazaoSocial { get; set; }

        /// <summary>
        /// Obtém ou define o CNPJ da empresa.
        /// </summary>
        public string CNPJ { get; set; }
    }
}