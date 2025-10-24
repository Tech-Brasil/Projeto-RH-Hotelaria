using System;

namespace Projeto_RH_HOTELARIA.Models.RH
{
    public class RH_Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public int CidadeId { get; set; }
    }
}
