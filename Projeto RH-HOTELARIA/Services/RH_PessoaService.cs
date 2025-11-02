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
        private readonly IRH_Pessoa _PessoaRepository;

        public RH_PessoaService(IRH_Pessoa pessoaRepository)
        {
            _PessoaRepository = pessoaRepository;
        }

        public void Inserir(RH_Pessoa pessoa)
        {
            if (pessoa == null)
                throw new ArgumentNullException(nameof(pessoa), "Pessoa não pode ser nula.");

            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                throw new ArgumentException("O nome é obrigatório.");

            if (pessoa.DataNascimento == default)
                throw new ArgumentException("A data de nascimento é obrigatória.");

            _PessoaRepository.Inserir(pessoa);
        }

        public void Atualizar(RH_Pessoa pessoa)
        {
            if (pessoa == null)
                throw new ArgumentNullException(nameof(pessoa), "Pessoa não pode ser nula.");

            if (pessoa.PessoaId <= 0)
                throw new ArgumentException("O ID da pessoa é inválido.");

            if (string.IsNullOrWhiteSpace(pessoa.Nome))
                throw new ArgumentException("O nome é obrigatório.");

            _PessoaRepository.Alterar(pessoa);
        }

        public void Excluir(int pessoaId)
        {
            if (pessoaId <= 0)
                throw new ArgumentException("ID inválido para exclusão.");

            _PessoaRepository.Excluir(pessoaId);
        }

        public RH_Pessoa BuscarPorId(int pessoaId)
        {
            if (pessoaId <= 0)
                throw new ArgumentException("ID inválido.");

            return _PessoaRepository.BuscarPorId(pessoaId);
        }

        public List<RH_Pessoa> ListarTodos()
        {
            return _PessoaRepository.ListarTodos();
        }
    }
}

