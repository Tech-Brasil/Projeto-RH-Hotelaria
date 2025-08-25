using Projeto_RH_HOTELARIA.Models.SYS;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface ISYS_Usuario
    {
        void InserirUsuario(SYS_Usuario usuario);
        SYS_Usuario BuscarUsuarioPorLogin(string login);
        List<SYS_Usuario> ListarUsuarios();
        void AlterarUsuario(SYS_Usuario usuario);
        void ExcluirUsuario(int id);
    }
}
