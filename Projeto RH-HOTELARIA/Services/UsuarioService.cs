using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.SYS;
using Projeto_RH_HOTELARIA.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_RH_HOTELARIA.Services
{
    public class UsuarioService
    {
        private readonly ISYS_Usuario _usuarioRep;

        public UsuarioService(ISYS_Usuario usuarioRep)
        {
            _usuarioRep = usuarioRep;
        }

        /// <summary>
        /// Realiza login do usuário.
        /// </summary>
        public bool ValidarUsuario(string login, string senha)
        {
            var usuarioDB = _usuarioRep.BuscarPorLogin(login).FirstOrDefault();

            if (usuarioDB == null) return false;

            bool senhaCorreta = Criptografia.Verificar(senha, usuarioDB.Senha);

            if (!senhaCorreta) return false;

            return true;
        }

        /// <summary>
        /// Cadastra um novo usuário no sistema.
        /// </summary>
        public void CadastrarUsuario(SYS_Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Login) || string.IsNullOrWhiteSpace(usuario.Senha))
            {
                throw new ArgumentException("Login e senha são obrigatórios.");
            }   

            var usuariosExistentes = _usuarioRep.BuscarPorLogin(usuario.Login);
            if (usuariosExistentes.Any())
            {
                throw new InvalidOperationException("Já existe um usuário com este login.");
            }

            usuario.Senha = Criptografia.HashSenha(usuario.Senha);

            _usuarioRep.Inserir(usuario);
        }

        /// <summary>
        /// Atualiza os dados de um usuário.
        /// </summary>
        public void AtualizarUsuario(SYS_Usuario usuario)
        {
            if (usuario.ID <= 0)
            {
                throw new Exception("Usuário in´válido para atualização.");
            }

            if (!string.IsNullOrWhiteSpace(usuario.Senha))
            {
                usuario.Senha = Criptografia.HashSenha(usuario.Senha);
            }

            _usuarioRep.Alterar(usuario);
        }

        /// <summary>
        /// Exclui um usuário pelo Id.
        /// </summary>
        public void ExcluirUsuario(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Id inválido para exclusão.");
            }

            _usuarioRep.Excluir(id);
        }

        /// <summary>
        /// Lista todos os usuários.
        /// </summary>
        public List<SYS_Usuario> ListarUsuarios()
        {
            return _usuarioRep.ListarTodos();
        }

        /// <summary>
        /// Lista Por Login.
        /// </summary>
        public List<SYS_Usuario> ListarPorLogin(string login)
        {
            if(string.IsNullOrWhiteSpace(login))
            {
                throw new Exception("Login inválido para busca.");
            }

            return _usuarioRep.BuscarPorLogin(login);
        }
    }
}
