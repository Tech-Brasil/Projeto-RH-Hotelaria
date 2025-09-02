using Projeto_RH_HOTELARIA.Models.RH;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_DocumentoEndereco
    {
        void Inserir(string rg, int enderecoId);
        void Atualizar(string rg, int enderecoId);
        void Excluir(string rg, int enderecoId);

        List<RH_DocumentoEndereco> ListarPorFuncionario(string rg);
        List<RH_DocumentoEndereco> ListarTodos();
    }
}
