using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Models.SYS
{
    public class SYS_Auditoria
    {
        [Key]
        public int AuditoriaId { get; set; }
        public int? UsuarioId { get; set; }
        public string Acao { get; set; }
        public string TabelaAfetada { get; set; }
        public string ChaveRegistro { get; set; }
        public DateTime DataHora { get; set; }
        public string EnderecoIP { get; set; }
    }
}
