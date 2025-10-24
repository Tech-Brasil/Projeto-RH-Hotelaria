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

        private object DbNull(object value) => value ?? DBNull.Value;

        public void Inserir(SYS_Usuario usuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 1);
                    cmd.Parameters.AddWithValue("@PessoaId", usuario.PessoaId);
                    cmd.Parameters.AddWithValue("@Login", usuario.Login);
                    cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                    cmd.Parameters.AddWithValue("@Role", usuario.Role);
                    cmd.Parameters.AddWithValue("@Ativo", usuario.Ativo);
                    cmd.Parameters.AddWithValue("@Foto", DbNull(usuario.Foto));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public void Alterar(SYS_Usuario usuario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 2);
                    cmd.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);
                    cmd.Parameters.AddWithValue("@PessoaId", usuario.PessoaId);
                    cmd.Parameters.AddWithValue("@Login", usuario.Login);
                    cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                    cmd.Parameters.AddWithValue("@Role", usuario.Role);
                    cmd.Parameters.AddWithValue("@Ativo", usuario.Ativo);
                    cmd.Parameters.AddWithValue("@Foto", DbNull(usuario.Foto));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public SYS_Usuario BuscarPorLogin(string login)
        {
            try
            {
                SYS_Usuario user = null;

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 5);
                    cmd.Parameters.AddWithValue("@Login", login);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new SYS_Usuario
                            {
                                UsuarioId = (int)reader["UsuarioId"],
                                PessoaId = (int)reader["PessoaId"],
                                Login = reader["Login"].ToString(),
                                Role = reader["Role"].ToString(),
                                Senha = reader["Senha"].ToString(),
                                Ativo = (bool)reader["Ativo"],
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            };
                        }
                    }
                }

                return user;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public void Excluir(int usuarioId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 3);
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public List<SYS_Usuario> ListarTodos()
        {
            try
            {
                List<SYS_Usuario> lista = new List<SYS_Usuario>();

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 4);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new SYS_Usuario
                            {
                                UsuarioId = (int)reader["UsuarioId"],
                                PessoaId = (int)reader["PessoaId"],
                                Login = reader["Login"].ToString(),
                                Role = reader["Role"].ToString(),
                                Ativo = (bool)reader["Ativo"],
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            });
                        }
                    }
                }

                return lista;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public SYS_Usuario BuscarPorId(int usuarioId)
        {
            try
            {
                SYS_Usuario user = null;

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 4);
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new SYS_Usuario
                            {
                                UsuarioId = (int)reader["UsuarioId"],
                                PessoaId = (int)reader["PessoaId"],
                                Login = reader["Login"].ToString(),
                                Role = reader["Role"].ToString(),
                                Senha = reader["Senha"].ToString(),
                                Ativo = (bool)reader["Ativo"],
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            };
                        }
                    }
                }

                return user;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }
    }
}
