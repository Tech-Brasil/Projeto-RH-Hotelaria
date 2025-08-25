using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class RH_DocumentosFuncionarioRepository : IRH_DocumentosFuncionario
    {
        private readonly string _context;
        public RH_DocumentosFuncionarioRepository()
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }

        public void AlterarDFuncionario(RH_DocumentosFuncionario Dfuncionario)
        {
            throw new NotImplementedException();
        }

        public RH_DocumentosFuncionario BuscarDFuncionarioPorRg(string rg)
        {
            throw new NotImplementedException();
        }

        public void ExcluirDFuncionario(string rg)
        {
            throw new NotImplementedException();
        }

        public void InserirDFuncionario(RH_DocumentosFuncionario Dfuncionario)
        {
            throw new NotImplementedException();
        }

        public List<RH_DocumentosFuncionario> ListarDFuncionarios()
        {
            throw new NotImplementedException();
        }
    }
}
