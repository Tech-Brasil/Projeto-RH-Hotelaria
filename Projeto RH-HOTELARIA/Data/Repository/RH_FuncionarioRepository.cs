using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
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
    public class RH_FuncionarioRepository : IRH_Funcionario
    {
        private readonly string _context;

        public RH_FuncionarioRepository()
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }

        private object DbNull(object value) => value ?? DBNull.Value;

        public void Inserir(RH_Funcionario funcionario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Funcionario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 1);
                    cmd.Parameters.AddWithValue("@PessoaId", funcionario.PessoaId);
                    cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Departamento);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
                    cmd.Parameters.AddWithValue("@DataDemissao", DbNull(funcionario.DataDemissao));
                    cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);
                    cmd.Parameters.AddWithValue("@Foto", DbNull(funcionario.Foto));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public void Alterar(RH_Funcionario funcionario)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Funcionario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 2);
                    cmd.Parameters.AddWithValue("@FuncionarioId", funcionario.FuncionarioId);
                    cmd.Parameters.AddWithValue("@PessoaId", funcionario.PessoaId);
                    cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Departamento);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
                    cmd.Parameters.AddWithValue("@DataDemissao", DbNull(funcionario.DataDemissao));
                    cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);
                    cmd.Parameters.AddWithValue("@Foto", DbNull(funcionario.Foto));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public void Excluir(int funcionarioId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Funcionario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 3);
                    cmd.Parameters.AddWithValue("@FuncionarioId", funcionarioId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public List<RH_Funcionario> ListarTodos()
        {
            try
            {
                List<RH_Funcionario> lista = new List<RH_Funcionario>();

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Funcionario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 4);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new RH_Funcionario
                            {
                                FuncionarioId = (int)reader["FuncionarioId"],
                                PessoaId = (int)reader["PessoaId"],
                                Cargo = reader["Cargo"].ToString(),
                                Departamento = reader["Departamento"].ToString(),
                                DataAdmissao = (DateTime)reader["DataAdmissao"],
                                DataDemissao = reader["DataDemissao"] == DBNull.Value ? null : (DateTime?)reader["DataDemissao"],
                                Salario = (decimal)reader["Salario"],
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

        public RH_Funcionario BuscarPorId(int funcionarioId)
        {
            try
            {
                RH_Funcionario func = null;

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Funcionario", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 4);
                    cmd.Parameters.AddWithValue("@FuncionarioId", funcionarioId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            func = new RH_Funcionario
                            {
                                FuncionarioId = (int)reader["FuncionarioId"],
                                PessoaId = (int)reader["PessoaId"],
                                Cargo = reader["Cargo"].ToString(),
                                Departamento = reader["Departamento"].ToString(),
                                DataAdmissao = (DateTime)reader["DataAdmissao"],
                                DataDemissao = reader["DataDemissao"] == DBNull.Value ? null : (DateTime?)reader["DataDemissao"],
                                Salario = (decimal)reader["Salario"],
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            };
                        }
                    }
                }

                return func;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

