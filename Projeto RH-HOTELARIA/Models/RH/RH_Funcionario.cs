using System;

namespace Projeto_RH_HOTELARIA.Models.RH
{
    public class RH_Funcionario
    {
        public string RG { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cargo { get; set; }
        public string Departamento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissao { get; set; }
        public decimal Salario { get; set; }
    }
}
