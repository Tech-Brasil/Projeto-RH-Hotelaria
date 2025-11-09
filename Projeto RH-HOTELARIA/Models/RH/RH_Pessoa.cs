using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Models.RH
{
    public class RH_Pessoa
    {
        [Key]
        public string Nome { get; set; } // PRIMARY KEY
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public string Nacionalidade { get; set; }
        public string EstadoCivil { get; set; }
        public int? EnderecoId { get; set; } // FK → RH_Endereco(EnderecoId)
        public DateTime DataCriacao { get; set; }
    }
}
