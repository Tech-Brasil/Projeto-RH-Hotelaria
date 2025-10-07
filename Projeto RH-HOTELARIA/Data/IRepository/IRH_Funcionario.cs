using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;

namespace Projeto_RH_HOTELARIA.Data.IRepository
{
    public interface IRH_Funcionario
    {
        void Inserir(RH_Funcionario funcionario);
        void Alterar(RH_Funcionario funcionario);
        void Excluir(string rg);

        List<RH_Funcionario> Buscar(string rg = null, string nome = null,
            DateTime? dataNascimento = null, DateTime? dataAdmissao = null);
    }
}
