using Projeto_RH_HOTELARIA.Models.RH;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_DocumentosFuncionario
    {
        void InserirDFuncionario(RH_DocumentosFuncionario Dfuncionario);
        RH_DocumentosFuncionario BuscarDFuncionarioPorRg(string rg);
        List<RH_DocumentosFuncionario> ListarDFuncionarios();
        void AlterarDFuncionario(RH_DocumentosFuncionario Dfuncionario);
        void ExcluirDFuncionario(string rg);
    }
}
