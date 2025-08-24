using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Models.SYS
{
    public class SYS_Usuario
    {
        public int ID { get; set; }
        public char RG { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
        public SqlDateTime CriadoEm { get; set; }
    }
}
