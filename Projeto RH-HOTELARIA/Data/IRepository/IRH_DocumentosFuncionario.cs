using Projeto_RH_HOTELARIA.Models.RH;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_DocumentosFuncionario
    {
        void Inserir(RH_DocumentosFuncionario documentos);
        RH_DocumentosFuncionario BuscarPorRg(string rg);
        List<RH_DocumentosFuncionario> ListarTodos();
        void Alterar(RH_DocumentosFuncionario documentos);
        void Excluir(string rg);
    }
}
