using Projeto_RH_HOTELARIA.Models.RH;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_Endereco
    {
        void Inserir(RH_Endereco endereco);
        void Atualizar(RH_Endereco endereco);
        void Deletar(int enderecoId);

        RH_Endereco BuscarPorId(int enderecoId);
        List<RH_Endereco> BuscarPorCidade(string cidade);
        List<RH_Endereco> BuscarPorEstado(string estadoSigla);
        List<RH_Endereco> BuscarPorCEP(string cep);
        List<RH_Endereco> ListarTodos();
    }
}
