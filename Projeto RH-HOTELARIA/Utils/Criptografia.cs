using BCrypt.Net;
using Projeto_RH_HOTELARIA.Utils.Model;

namespace Projeto_RH_HOTELARIA.Utils
{
    class Criptografia
    {
        public static HashResult HashSenha(string senha)
        {
            if(!Validacoes.SenhaValida(senha))
            {
                return new HashResult
                {
                    Success = false,
                    Hash = null,
                    Message = "A senha não atende aos requisitos mínimos."
                };
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(senha);

            return new HashResult
            {
                Success = true,
                Hash = hash,
                Message = "Senha válido."
            };
        }

        public static bool Verificar(string senha, string hashDB)
        {
            return BCrypt.Net.BCrypt.Verify(senha, hashDB);
        }
    }
}
