using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Models.RH
{
    public class RH_Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        public string PessoaNome { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime? DataDemissao { get; set; }
        public decimal Salario { get; set; }
        public bool Ativo { get; set; }
        public byte[] Foto { get; set; }
    }
}
