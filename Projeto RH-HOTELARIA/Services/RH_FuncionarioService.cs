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
        private readonly IRH_Funcionario _funcionarioRepo;

        public RH_FuncionarioService(IRH_Funcionario funcionarioRepo)
        {
            _funcionarioRepo = funcionarioRepo;
        }

        public void Inserir(RH_Funcionario funcionario)
        {
            if (funcionario == null)
                throw new ArgumentNullException(nameof(funcionario), "O funcionário não pode ser nulo.");

            if (funcionario.PessoaId <= 0)
                throw new ArgumentException("PessoaId é obrigatório e deve ser válido.");

            if (string.IsNullOrWhiteSpace(funcionario.Nome))
                throw new ArgumentException("O nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(funcionario.Cargo))
                throw new ArgumentException("O cargo é obrigatório.");

            if (string.IsNullOrWhiteSpace(funcionario.Departamento))
                throw new ArgumentException("O departamento é obrigatório.");

            if (funcionario.Salario <= 0)
                throw new ArgumentException("O salário deve ser maior que zero.");

            if (funcionario.DataAdmissao == DateTime.MinValue)
                throw new ArgumentException("A data de admissão é obrigatória.");

            _funcionarioRepo.Inserir(funcionario);
        }

        public void Atualizar(RH_Funcionario funcionario)
        {
            if (funcionario == null)
                throw new ArgumentNullException(nameof(funcionario), "O funcionário não pode ser nulo.");

            if (funcionario.FuncionarioId <= 0)
                throw new ArgumentException("O ID do funcionário é obrigatório para atualização.");

            _funcionarioRepo.Alterar(funcionario);
        }

        public void Excluir(int funcionarioId)
        {
            if (funcionarioId <= 0)
                throw new ArgumentException("O ID do funcionário é obrigatório para exclusão.");

            _funcionarioRepo.Excluir(funcionarioId);
        }

        public RH_Funcionario BuscarPorId(int funcionarioId)
        {
            if (funcionarioId <= 0)
                throw new ArgumentException("O ID do funcionário é obrigatório para busca.");

            var funcionario = _funcionarioRepo.BuscarPorId(funcionarioId);

            if (funcionario == null)
                throw new Exception("Funcionário não encontrado.");

            return funcionario;
        }

        public IEnumerable<RH_Funcionario> ListarTodos()
        {
            var lista = _funcionarioRepo.ListarTodos();

            if (lista == null || lista.Count == 0)
                throw new Exception("Nenhum funcionário encontrado.");

            return lista;
        }

        //public void AtivarOuDesativar(int funcionarioId, bool ativo)
        //{
        //    if (funcionarioId <= 0)
        //        throw new ArgumentException("O ID do funcionário é obrigatório.");

        //    _funcionarioRepo.(funcionarioId, ativo);
        //}
    }
}
