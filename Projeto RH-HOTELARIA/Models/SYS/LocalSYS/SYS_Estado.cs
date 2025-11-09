using System.ComponentModel.DataAnnotations;

namespace Projeto_RH_HOTELARIA.Models.SYS.LocalSYS
{
    public class SYS_Estado
    {
        [Key]
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string PaisNome { get; set; }
    }
}
