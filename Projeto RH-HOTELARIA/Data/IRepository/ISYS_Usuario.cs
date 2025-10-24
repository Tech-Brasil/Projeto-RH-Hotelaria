using Projeto_RH_HOTELARIA.Models.SYS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface ISYS_Usuario
    {
        void Inserir(SYS_Usuario usuario);
        void Alterar(SYS_Usuario usuario);
        void Excluir(int usuarioId);
        SYS_Usuario BuscarPorId(int usuarioId);
        SYS_Usuario BuscarPorLogin(string login);
        List<SYS_Usuario> ListarTodos();
    }
}
