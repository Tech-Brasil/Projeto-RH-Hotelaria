using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Projeto_RH_HOTELARIA.Services
{
    public class DocumentoEnderecoService
    {
        private readonly IRH_DocumentoEndereco _documentoEnderecoRep;
        public DocumentoEnderecoService(IRH_DocumentoEndereco documentoEnderecoRep)
        {
            _documentoEnderecoRep = documentoEnderecoRep;
        }

        public void CadastrarDocEndereco(string rg, int enderecoId)
        {
            if (string.IsNullOrWhiteSpace(rg) || Validacoes.RgValido(rg))
            {
                throw new ArgumentException("RG inválido.");
            }

            _documentoEnderecoRep.Inserir(rg, enderecoId);
        }

        public void AtualizarDocEndereco(string rg, int enderecoId)
        {
            if (string.IsNullOrWhiteSpace(rg) || Validacoes.RgValido(rg))
            {
                throw new ArgumentException("RG inválido.");
            }

            _documentoEnderecoRep.Atualizar(rg, enderecoId);
        }

        public void ExcluirDocEndereco(string rg, int enderecoId)
        {
            if (string.IsNullOrWhiteSpace(rg) || Validacoes.RgValido(rg))
            {
                throw new ArgumentException("RG inválido.");
            }

            _documentoEnderecoRep.Excluir(rg, enderecoId);
        }

        public List<RH_DocumentoEndereco> ListarPorFuncionario(string rg)
        {
            if (!Validacoes.RgValido(rg))
            {
                throw new ArgumentException("RG inválido.");
            }

            return _documentoEnderecoRep.ListarPorFuncionario(rg);
        }

        public List<RH_DocumentoEndereco> ListarTodos()
        {
            return _documentoEnderecoRep.ListarTodos();
        }
    }
}
