using System.ComponentModel.DataAnnotations;

namespace Projeto_RH_HOTELARIA.Models.SYS.LocalSYS
{
    public class SYS_Pais
    {
        [Key]
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
