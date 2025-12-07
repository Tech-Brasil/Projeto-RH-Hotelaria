using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto_RH_HOTELARIA.Models.RH
{
    public class RH_Pessoa
    {
        [Key]
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public string Nacionalidade { get; set; }
        public string EstadoCivil { get; set; }
        public int? EnderecoId { get; set; }
        public DateTime DataCriacao { get; set; }

        public override string ToString()
        {
            return $"{Nome} | Nacionalidade: {Nacionalidade}";
        }
    }
}
