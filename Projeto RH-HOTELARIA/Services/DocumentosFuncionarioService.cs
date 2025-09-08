using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Services
{
    public class DocumentosFuncionarioService
    {
        private readonly IRH_DocumentosFuncionario _DocumentosFuncionario;
        public DocumentosFuncionarioService(IRH_DocumentosFuncionario DocumentosFuncionario)
        {
            _DocumentosFuncionario = DocumentosFuncionario;
        }

        /// <summary>
        /// Cadastra um novo documento do funcionário.
        /// </summary>
        public void CadastrarDocFuncionario(RH_DocumentosFuncionario docFuncionario)
        {
            if(string.IsNullOrWhiteSpace(docFuncionario.RG) || string.IsNullOrWhiteSpace(docFuncionario.CPF))
            {
                throw new ArgumentException("RG e CPF são obrigatórios.");
            }
            if (!Validacoes.RgValido(docFuncionario.RG))
            {
                throw new ArgumentException("RG inválido.");
            }

            _DocumentosFuncionario.Inserir(docFuncionario);
        }

        /// <summary>
        /// Atualiza os dados do documento do funcionário.
        /// </summary>
        public void AtualizarDocFuncionario(RH_DocumentosFuncionario docFuncionario)
        {
            if (string.IsNullOrWhiteSpace(docFuncionario.RG) || string.IsNullOrWhiteSpace(docFuncionario.CPF))
            {
                throw new ArgumentException("RG e CPF são obrigatórios.");
            }
            if (!Validacoes.RgValido(docFuncionario.RG))
            {
                throw new ArgumentException("RG inválido.");
            }
            _DocumentosFuncionario.Alterar(docFuncionario);
        }

        /// <summary>
        /// Rremove o documento do funcionário.
        /// </summary>
        public void RemoverDocFuncionario(string rg)
        {
            if (string.IsNullOrWhiteSpace(rg))
            {
                throw new ArgumentException("RG é obrigatório.");
            }
            if (!Validacoes.RgValido(rg))
            {
                throw new ArgumentException("RG inválido.");
            }
            _DocumentosFuncionario.Excluir(rg);
        }

        /// <summary>
        /// Busca documentos do funcionário pelo RG.
        /// </summary>
        public List<RH_DocumentosFuncionario> BuscarDocFuncionarioRG(string rg)
        {
            if (string.IsNullOrWhiteSpace(rg))
            {
                throw new ArgumentException("RG é obrigatório.");
            }
            if (!Validacoes.RgValido(rg))
            {
                throw new ArgumentException("RG inválido.");
            }
            return _DocumentosFuncionario.BuscarPorRg(rg);
        }

        /// <summary>
        /// Obtém todos os documentos do funcionário.
        /// </summary>
        public List<RH_DocumentosFuncionario> ObterTodosDocumento()
        {
            return _DocumentosFuncionario.ListarTodos();
        }
    }
}
