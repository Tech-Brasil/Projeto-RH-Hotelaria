using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Services
{
    public class FuncionarioService
    {
        private readonly IRH_Funcionario _rH_Funcionario;

        public FuncionarioService(IRH_Funcionario rH_Funcionario)
        {
            _rH_Funcionario = rH_Funcionario;
        }

        /// <summary>
        /// Cadastra um novo funcionário no sistema.
        /// </summary>
        public void CadastrarFuncionario(RH_Funcionario funcionario)
        {
            if (string.IsNullOrWhiteSpace(funcionario.RG) || Validacoes.RgValido(funcionario.RG))
            {
                throw new Exception("RG está errado ou RG inválido");
            }
            if(string.IsNullOrWhiteSpace(funcionario.Nome) || Validacoes.NomeValido(funcionario.Nome))
            {
                throw new Exception("O nome está incorreto/Vazio ou ele não é válido");
            }
            if(Validacoes.DataValida(funcionario.DataAdmissao, funcionario.DataDemissao))
            {
                throw new Exception("A Data está incorreta ou a data demissão é maior que a data de admissão");
            }

            _rH_Funcionario.Inserir(funcionario);
        }

        /// <summary>
        /// Atualiza um funcionário no sistema.
        /// </summary>
        public void AtualizaFuncionario(RH_Funcionario funcionario)
        {
            if (string.IsNullOrWhiteSpace(funcionario.RG) || Validacoes.RgValido(funcionario.RG))
            {
                throw new Exception("RG está errado ou RG inválido");
            }
            if (string.IsNullOrWhiteSpace(funcionario.Nome) || Validacoes.NomeValido(funcionario.Nome))
            {
                throw new Exception("O nome está incorreto/Vazio ou ele não é válido");
            }
            if (Validacoes.DataValida(funcionario.DataAdmissao, funcionario.DataDemissao))
            {
                throw new Exception("A Data está incorreta ou a data demissão é maior que a data de admissão");
            }

            _rH_Funcionario.Alterar(funcionario);
        }

        /// <summary>
        /// Excluir um funcionário no sistema.
        /// </summary>
        public void ExcluirFuncionario(string rg)
        {
            if (string.IsNullOrWhiteSpace(rg) || Validacoes.RgValido(rg))
            {
                throw new Exception("RG está errado ou RG inválido");
            }

            _rH_Funcionario.Excluir(rg);
        }

        /// <summary>
        /// Obter o funcionário por RG.
        /// </summary>
        public List<RH_Funcionario> ObterFuncPorRG(string rg)
        {
            if (string.IsNullOrWhiteSpace(rg) || Validacoes.RgValido(rg))
            {
                throw new Exception("RG está errado ou RG inválido");
            }

            return _rH_Funcionario.BuscarPorRg(rg);
        }

        /// <summary>
        /// Obter o funcionário.
        /// </summary>
        public List<RH_Funcionario> ObterFunc()
        {
            return _rH_Funcionario.ListarTodos();
        }
    }
}
