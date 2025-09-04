using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.SYS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        public void Inserir(SYS_Usuario usuario)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    
                    SqlCommand cmd = new SqlCommand("usp_UserCRUD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 1);
                    cmd.Parameters.AddWithValue("@RG", usuario.RG);
                    cmd.Parameters.AddWithValue("@Login", usuario.Login);
                    cmd.Parameters.AddWithValue("@SenhaHash", usuario.Senha);
                    cmd.Parameters.AddWithValue("@Role", usuario.Role);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir usuário: " + ex.Message);
            }
        }

        public void Alterar(SYS_Usuario usuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_UserCRUD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 2);
                    cmd.Parameters.AddWithValue("@Id", usuario.ID);
                    cmd.Parameters.AddWithValue("@RG", usuario.RG);
                    cmd.Parameters.AddWithValue("@Login", usuario.Login);
                    cmd.Parameters.AddWithValue("@SenhaHash", usuario.Senha);
                    cmd.Parameters.AddWithValue("@Role", usuario.Role);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao alterar usuário: " + ex.Message);
            }
        }

        public void Excluir(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_UserCRUD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 3);
                    cmd.Parameters.AddWithValue("@Id", id);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao deletar usuário: " + ex.Message);
            }
        }

        public List<SYS_Usuario> BuscarPorLogin(string login)
        {
            try
            {
                List<SYS_Usuario> usuarios = new List<SYS_Usuario>();

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_UserCRUD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 4);
                    cmd.Parameters.AddWithValue("@Login", login);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SYS_Usuario usuario = new SYS_Usuario
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("Id")),
                                RG = reader.GetString(reader.GetOrdinal("RG")),
                                Login = reader.GetString(reader.GetOrdinal("Login")),
                                Senha = reader.GetString(reader.GetOrdinal("SenhaHash")),
                                Role = reader.GetString(reader.GetOrdinal("Role"))
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
                return usuarios;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao listar usuários: " + ex.Message);
            }
        }

        public List<SYS_Usuario> ListarTodos()
        {
            try
            {
                List<SYS_Usuario> usuarios = new List<SYS_Usuario>();
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_UserCRUD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 4);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SYS_Usuario usuario = new SYS_Usuario
                            {
                                ID = reader.GetInt32(reader.GetOrdinal("Id")),
                                RG = reader.GetString(reader.GetOrdinal("RG")),
                                Login = reader.GetString(reader.GetOrdinal("Login")),
                                Senha = reader.GetString(reader.GetOrdinal("SenhaHash")),
                                Role = reader.GetString(reader.GetOrdinal("Role"))
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
                return usuarios;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao listar usuários: " + ex.Message);
            }
        }
    }
}
