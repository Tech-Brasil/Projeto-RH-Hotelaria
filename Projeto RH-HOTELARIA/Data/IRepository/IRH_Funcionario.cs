using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_Funcionario
    {
        void Inserir(RH_Funcionario funcionario);
        void Alterar(RH_Funcionario funcionario);
        void Excluir(int funcionarioId);
        List<RH_Funcionario> BuscarPorNome(string nome);
        List<RH_Funcionario> ListarTodos();
    }
}
