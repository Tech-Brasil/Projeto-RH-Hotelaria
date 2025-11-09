using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Services
{
    public class RH_DocumentosPessoaService
    {
        private readonly IRH_DocumentosPessoa _repository;

        public RH_DocumentosPessoaService(IRH_DocumentosPessoa repository)
        {
            _repository = repository;
        }

        public void Inserir(RH_DocumentosPessoa doc)
        {
            if (doc == null)
                throw new ArgumentNullException(nameof(doc));

            if (string.IsNullOrWhiteSpace(doc.RG))
                throw new ArgumentException("O RG é obrigatório e serve como identificador.");

            if (string.IsNullOrWhiteSpace(doc.PessoaNome))
                throw new ArgumentException("O nome da pessoa é obrigatório.");

            if (string.IsNullOrWhiteSpace(doc.CPF))
                throw new ArgumentException("O CPF é obrigatório.");

            _repository.Inserir(doc);
        }

        public void Alterar(RH_DocumentosPessoa doc)
        {
            if (string.IsNullOrWhiteSpace(doc.RG))
                throw new ArgumentException("O RG é obrigatório para atualização.");

            _repository.Alterar(doc);
        }

        public void Excluir(string rg)
        {
            if (string.IsNullOrWhiteSpace(rg))
                throw new ArgumentException("O RG é obrigatório para exclusão.");

            _repository.Excluir(rg);
        }

        public RH_DocumentosPessoa BuscarPorRG(string rg)
        {
            if (string.IsNullOrWhiteSpace(rg))
                throw new ArgumentException("O RG é obrigatório para busca.");

            return _repository.BuscarPorRG(rg);
        }

        public List<RH_DocumentosPessoa> ListarTodos()
        {
            return _repository.ListarTodos();
        }
    }
}
