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
                throw new ArgumentNullException(nameof(usuario), "Usuário não pode ser nulo.");

            if (string.IsNullOrWhiteSpace(usuario.Login))
                throw new ArgumentException("O login é obrigatório.");

            if (string.IsNullOrWhiteSpace(usuario.Senha))
                throw new ArgumentException("A senha é obrigatória.");

            _repository.Inserir(usuario);
        }

        public void Atualizar(SYS_Usuario usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            if (usuario.UsuarioId <= 0)
                throw new ArgumentException("O ID do usuário é inválido.");

            _repository.Alterar(usuario);
        }

        public void Excluir(int usuarioId)
        {
            if (usuarioId <= 0)
                throw new ArgumentException("ID inválido para exclusão.");

            _repository.Excluir(usuarioId);
        }

        public SYS_Usuario BuscarPorId(int usuarioId)
        {
            return _repository.BuscarPorId(usuarioId);
        }

        public IEnumerable<SYS_Usuario> ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public void AtivarOuDesativar(int usuarioId, bool ativo)
        {
            var usuario = _repository.BuscarPorId(usuarioId);

            if (usuario == null)
                throw new Exception("Usuário não encontrado.");

            usuario.Ativo = ativo;
            _repository.Alterar(usuario);
        }

    }
}
