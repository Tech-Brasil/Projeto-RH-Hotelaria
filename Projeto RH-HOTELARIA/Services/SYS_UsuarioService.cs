using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Data.Repository;
using Projeto_RH_HOTELARIA.Models.SYS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Services
{
    public class SYS_UsuarioService
    {
        private readonly ISYS_Usuario _repository;

        public SYS_UsuarioService(ISYS_Usuario repository)
        {
            _repository = repository;
        }

        public void Inserir(SYS_Usuario usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            if (string.IsNullOrWhiteSpace(usuario.RG))
                throw new ArgumentException("O RG é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Login))
                throw new ArgumentException("O login é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.SenhaHash))
                throw new ArgumentException("A senha é obrigatória.");

            _repository.Inserir(usuario);
        }

        public void Alterar(SYS_Usuario usuario)
        {
            if (usuario.UsuarioId <= 0)
                throw new ArgumentException("O ID do usuário é obrigatório.");

            _repository.Alterar(usuario);
        }

        public void Excluir(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("O ID do usuário é obrigatório para exclusão.");

            _repository.Excluir(usuarioId);
        }

        public SYS_Usuario BuscarPorId(int usuarioId)
        {
            return _repository.BuscarPorId(usuarioId);
        }

        public SYS_Usuario BuscarPorLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("O login é obrigatório.");

            return _repository.BuscarPorLogin(login);
        }

        public IEnumerable<SYS_Usuario> ListarTodos()
        {
            return _repository.ListarTodos();
        }

    }
}
