using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto_RH_HOTELARIA.Models.SYS
{
    public class SYS_Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string RG { get; set; }
        public string Login { get; set; }
        public string SenhaHash { get; set; }
        public string Role { get; set; }
        public bool Ativo { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? UltimoLogin { get; set; }
    }
}
