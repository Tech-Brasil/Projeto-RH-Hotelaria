using Projeto_RH_HOTELARIA.Models.RH;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_Funcionario
    {
        void InserirFuncionario(RH_Funcionario funcionario);
        RH_Funcionario BuscarFuncionarioPorRg(string rg);
        List<RH_Funcionario> ListarFuncionarios();
        void AlterarFuncionario(RH_Funcionario funcionario);
        void ExcluirFuncionario(string rg);
    }
}
