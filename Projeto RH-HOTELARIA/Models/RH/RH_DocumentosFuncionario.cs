using System;
using System.Data.SqlTypes;

namespace Projeto_RH_HOTELARIA.Models.RH
{
    public class RH_DocumentosFuncionario
    {
        public string RG { get; set; }
        public string CPF { get; set; }
        public string TituloEleitor { get; set; }
        public string CTPS_Numero { get; set; }
        public string CTPS_Serie { get; set; }
        public string CNH_Numero { get; set; }
        public string CNH_Categoria { get; set; }
        public DateTime CNH_Validade { get; set; }
        public string Passaporte { get; set; }
        public string PIS { get; set; }
        public SqlDateTime DataCriacao { get; set; }
    }
}
