using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Services
{
    public class RH_FuncionarioService
    {
        private readonly IRH_Funcionario _repository;

        public RH_FuncionarioService(IRH_Funcionario repository)
        {
            _repository = repository;
        }

        public void Inserir(RH_Funcionario funcionario)
        {
            if (funcionario == null)
                throw new ArgumentNullException(nameof(funcionario));

            if (string.IsNullOrWhiteSpace(funcionario.PessoaNome))
                throw new ArgumentException("O nome da pessoa é obrigatório.");

            if (string.IsNullOrWhiteSpace(funcionario.Cargo))
                throw new ArgumentException("O cargo é obrigatório.");

            if (string.IsNullOrWhiteSpace(funcionario.Departamento))
                throw new ArgumentException("O departamento é obrigatório.");

            if (funcionario.Salario <= 0)
                throw new ArgumentException("O salário deve ser maior que zero.");

            _repository.Inserir(funcionario);
        }

        public void Alterar(RH_Funcionario funcionario)
        {
            if (funcionario.FuncionarioId <= 0)
                throw new ArgumentException("O ID do funcionário é obrigatório para atualização.");

            _repository.Alterar(funcionario);
        }

        public void Excluir(int funcionarioId)
        {
            if (funcionarioId <= 0)
                throw new ArgumentException("O ID do funcionário é obrigatório para exclusão.");

            _repository.Excluir(funcionarioId);
        }

        public RH_Funcionario BuscarPorId(int funcionarioId)
        {
            if (funcionarioId <= 0)
                throw new ArgumentException("O ID do funcionário é obrigatório para busca.");

            return _repository.BuscarPorId(funcionarioId);
        }

        public List<RH_Funcionario> ListarTodos()
        {
            return _repository.ListarTodos();
        }
    }
}
