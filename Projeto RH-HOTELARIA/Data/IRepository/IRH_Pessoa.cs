using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_Pessoa
    {
        void Inserir(RH_Pessoa pessoa);
        void Alterar(RH_Pessoa pessoa);
        void Excluir(string nome);
        RH_Pessoa BuscarPorNome(string nome);
        List<RH_Pessoa> ListarTodos();
    }
}
