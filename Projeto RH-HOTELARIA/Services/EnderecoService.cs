using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Services
{
    public class EnderecoService
    {
        private readonly IRH_Endereco _enderecoRep;

        public EnderecoService(IRH_Endereco enderecoRep)
        {
            _enderecoRep = enderecoRep;
        }

        public void CadastrarEndereco(RH_Endereco endereco)
        {
            if (string.IsNullOrWhiteSpace(endereco.CidadeNome) 
                || string.IsNullOrWhiteSpace(endereco.EstadoSigla)
                || string.IsNullOrWhiteSpace(endereco.PaisSigla))
            {
                throw new Exception("Todos os campos são obrigatórios.");
            }

            _enderecoRep.Inserir(endereco);
        }

        public void AtualizarEndereco(RH_Endereco endereco)
        {
            if (string.IsNullOrWhiteSpace(endereco.CidadeNome)
                || string.IsNullOrWhiteSpace(endereco.EstadoSigla)
                || string.IsNullOrWhiteSpace(endereco.PaisSigla))
            {
                throw new Exception("Todos os campos são obrigatórios.");
            }

            _enderecoRep.Atualizar(endereco);
        }

        public void ExcluirEndereco(int enderecoId)
        {
            if (enderecoId > 0)
            {
                _enderecoRep.Deletar(enderecoId);
            }
            else
            {
                throw new Exception("O Id não existe/Id inválido");
            }
        }

        public List<RH_Endereco> Listar(int enderecoId, string cidade, string estadoSigla, string cep)
        {
            return _enderecoRep.ListarTodos();
        }
    }
}
