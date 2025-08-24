using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Models.RH
{
    public class RH_Endereco
    {
        public int EnderecoId { get; set; }
        public string CidadeNome { get; set; }
        public string EstadoSigla { get; set; }
        public string PaisSigla { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
    }
}
