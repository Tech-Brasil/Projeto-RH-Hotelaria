using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Models.SYS
{
    public class SYS_Usuario
    {
        public int UsuarioId { get; set; }
        public int PessoaId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
        public bool Ativo { get; set; }
        public byte[] Foto { get; set; }
    }
}
