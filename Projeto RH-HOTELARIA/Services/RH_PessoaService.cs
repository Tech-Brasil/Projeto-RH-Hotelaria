using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Services
{
    public class RH_PessoaService
    {
        private readonly IRH_Pessoa _repository;

        public RH_PessoaService(IRH_Pessoa repository)
        {
            _repository = repository;
        }

        public void Inserir(RH_Pessoa pessoa)
        {
            if (pessoa == null)
                throw new ArgumentNullException(nameof(pessoa));

            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                throw new ArgumentException("O nome é obrigatório e serve como identificador único.");

            if (pessoa.DataNascimento == default)
                throw new ArgumentException("A data de nascimento é obrigatória.");

            _repository.Inserir(pessoa);
        }

        public void Alterar(RH_Pessoa pessoa)
        {
            if (pessoa == null)
                throw new ArgumentNullException(nameof(pessoa));

            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                throw new ArgumentException("O nome é obrigatório para atualização.");

            _repository.Alterar(pessoa);
        }

        public void Excluir(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome é obrigatório para exclusão.");

            _repository.Excluir(nome);
        }

        public RH_Pessoa BuscarPorNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome é obrigatório para busca.");

            return _repository.BuscarPorNome(nome);
        }

        public List<RH_Pessoa> ListarTodos()
        {
            return _repository.ListarTodos();
        }
    }
}

