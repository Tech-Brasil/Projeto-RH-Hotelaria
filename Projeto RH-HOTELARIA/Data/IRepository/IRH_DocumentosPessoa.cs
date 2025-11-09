using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_DocumentosPessoa
    {
        void Inserir(RH_DocumentosPessoa doc);
        void Alterar(RH_DocumentosPessoa doc);
        void Excluir(string rg);
        RH_DocumentosPessoa BuscarPorRG(string rg);
        List<RH_DocumentosPessoa> ListarTodos();
    }
}
