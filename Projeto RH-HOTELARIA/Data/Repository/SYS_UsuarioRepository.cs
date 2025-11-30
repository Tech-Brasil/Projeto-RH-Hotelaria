using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.SYS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class SYS_UsuarioRepository : ISYS_Usuario
    {
        private object DbNull(object value) => value ?? DBNull.Value;

        public void Inserir(SYS_Usuario usuario)
        {
            try
            {
                using (SqlConnection conn = Db.Connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 1);
                    cmd.Parameters.AddWithValue("@RG", usuario.RG);
                    cmd.Parameters.AddWithValue("@Login", usuario.Login);
                    cmd.Parameters.AddWithValue("@SenhaHash", usuario.SenhaHash);
                    cmd.Parameters.AddWithValue("@Role", usuario.Role);
                    cmd.Parameters.AddWithValue("@Ativo", usuario.Ativo);
                    cmd.Parameters.AddWithValue("@Foto", DbNull(usuario.Foto));

                    cmd.ExecuteNonQuery();
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
                using (SqlConnection conn = Db.Connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 2);
                    cmd.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);
                    cmd.Parameters.AddWithValue("@RG", usuario.RG);
                    cmd.Parameters.AddWithValue("@Login", usuario.Login);
                    cmd.Parameters.AddWithValue("@SenhaHash", usuario.SenhaHash);
                    cmd.Parameters.AddWithValue("@Role", usuario.Role);
                    cmd.Parameters.AddWithValue("@Ativo", usuario.Ativo);
                    cmd.Parameters.AddWithValue("@Foto", DbNull(usuario.Foto));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao alterar usuário: " + ex.Message);
            }
        }

        public void Excluir(int usuarioId)
        {
            try
            {
                using (SqlConnection conn = Db.Connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 3);
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao excluir usuário: " + ex.Message);
            }
        }

        public SYS_Usuario BuscarPorLogin(string login)
        {
            SYS_Usuario user = null;

            try
            {
                using (SqlConnection conn = Db.Connect())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_SYS_Usuario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 4);
                    cmd.Parameters.AddWithValue("@Login", login);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new SYS_Usuario
                            {
                                UsuarioId = (int)reader["UsuarioId"],
                                RG = reader["RG"].ToString(),
                                Login = reader["Login"].ToString(),
                                SenhaHash = reader["SenhaHash"].ToString(),
                                Role = reader["Role"].ToString(),
                                Ativo = (bool)reader["Ativo"],
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar usuário: " + ex.Message);
            }

            return user;
        }

        public SYS_Usuario BuscarPorId(int usuarioId)
        {
            SYS_Usuario user = null;

            try
            {
                using (SqlConnection conn = Db.Connect())
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
                                RG = reader["RG"].ToString(),
                                Login = reader["Login"].ToString(),
                                SenhaHash = reader["SenhaHash"].ToString(),
                                Role = reader["Role"].ToString(),
                                Ativo = (bool)reader["Ativo"],
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar usuário: " + ex.Message);
            }

            return user;
        }

        public List<SYS_Usuario> ListarTodos()
        {
            List<SYS_Usuario> lista = new List<SYS_Usuario>();

            try
            {
                using (SqlConnection conn = Db.Connect())
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
                                RG = reader["RG"].ToString(),
                                Login = reader["Login"].ToString(),
                                Role = reader["Role"].ToString(),
                                Ativo = (bool)reader["Ativo"],
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao listar usuários: " + ex.Message);
            }

            return lista;
        }

        public void AtualizarUltimoLogin(int usuarioId)
        {
            using(SqlConnection conn = Db.Connect())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE SYS_Usuario SET UltimoLogin = GETDATE() WHERE UsuarioId = @id",
                    conn);

                cmd.Parameters.Add("id", SqlDbType.Int).Value = usuarioId;

                cmd.ExecuteNonQuery();
            }
        }
    }
}
