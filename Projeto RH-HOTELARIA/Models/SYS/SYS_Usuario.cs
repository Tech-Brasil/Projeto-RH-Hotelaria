using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public byte[] Foto { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? UltimoLogin { get; set; }
    }
}
