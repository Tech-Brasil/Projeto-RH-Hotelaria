using Projeto_RH_HOTELARIA.Models.RH;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_Funcionario
    {
        void Inserir(RH_Funcionario funcionario);
        RH_Funcionario BuscarPorRg(string rg);
        List<RH_Funcionario> ListarTodos();
        void Alterar(RH_Funcionario funcionario);
        void Excluir(string rg);
    }
}
