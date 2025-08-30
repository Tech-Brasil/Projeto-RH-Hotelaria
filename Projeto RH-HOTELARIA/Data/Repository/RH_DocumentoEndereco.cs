using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class RH_DocumentoEndereco : IRH_DocumentoEndereco
    {
        public void Atualizar(string rg, int enderecoId)
        {
            throw new NotImplementedException();
        }

        public void Excluir(string rg, int enderecoId)
        {
            throw new NotImplementedException();
        }

        public void Inserir(string rg, int enderecoId)
        {
            throw new NotImplementedException();
        }

        public List<RH_Endereco> ListarPorFuncionario(string rg)
        {
            throw new NotImplementedException();
        }

        List<Models.RH.RH_DocumentoEndereco> IRH_DocumentoEndereco.ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
