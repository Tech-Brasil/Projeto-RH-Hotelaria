using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.SYS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class SYS_UsuarioRepository : ISYS_Usuario
    {
        private readonly string _context;

        public SYS_UsuarioRepository()
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }

        public void Alterar(SYS_Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public SYS_Usuario BuscarPorLogin(string login)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(SYS_Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public List<SYS_Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
