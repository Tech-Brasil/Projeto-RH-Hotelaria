using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Utils
{
    class Criptografia
    {
        public static string HashSenha(string senha)
        {
            string hash = null;
            if (Validacoes.SenhaValida(senha) == true)
            {
                hash = BCrypt.Net.BCrypt.HashPassword(senha);
                return hash;
            }
            else
            {
                throw new Exception("A senha não é valida!");
            }
            
        }

        public static bool Verificar(string senha, string hashDB)
        {
            bool verify = BCrypt.Net.BCrypt.Verify(senha, hashDB);
            if(verify == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
