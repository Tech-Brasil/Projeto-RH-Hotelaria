using Projeto_RH_HOTELARIA.Models.SYS;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface ISYS_Usuario
    {
        void Inserir(SYS_Usuario usuario);
        List<SYS_Usuario> BuscarPorLogin(string login);
        List<SYS_Usuario> ListarTodos();
        void Alterar(SYS_Usuario usuario);
        void Excluir(int id);
    }
}
