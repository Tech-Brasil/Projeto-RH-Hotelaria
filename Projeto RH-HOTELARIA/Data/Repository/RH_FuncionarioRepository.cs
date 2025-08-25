using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class RH_FuncionarioRepository : IRH_Funcionario
    {
        private readonly string _context;

        public RH_FuncionarioRepository()
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }

        public void AlterarFuncionario(RH_Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public RH_Funcionario BuscarFuncionarioPorRg(string rg)
        {
            throw new NotImplementedException();
        }

        public void ExcluirFuncionario(string rg)
        {
            throw new NotImplementedException();
        }

        public void InserirFuncionario(RH_Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public List<RH_Funcionario> ListarFuncionarios()
        {
            throw new NotImplementedException();
        }
    }
}
