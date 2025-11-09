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
                    cmd.Parameters.AddWithValue("@PessoaNome", funcionario.PessoaNome);
                    cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Departamento);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
                    cmd.Parameters.AddWithValue("@DataDemissao", DbNull(funcionario.DataDemissao));
                    cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);
                    cmd.Parameters.AddWithValue("@Ativo", funcionario.Ativo);
                    cmd.Parameters.AddWithValue("@Foto", DbNull(funcionario.Foto));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir funcionário: " + ex.Message);
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
                    cmd.Parameters.AddWithValue("@PessoaNome", funcionario.PessoaNome);
                    cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Departamento);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
                    cmd.Parameters.AddWithValue("@DataDemissao", DbNull(funcionario.DataDemissao));
                    cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);
                    cmd.Parameters.AddWithValue("@Ativo", funcionario.Ativo);
                    cmd.Parameters.AddWithValue("@Foto", DbNull(funcionario.Foto));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao alterar funcionário: " + ex.Message);
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
            catch (SqlException ex)
            {
                throw new Exception("Erro ao excluir funcionário: " + ex.Message);
            }
        }

        public List<RH_Funcionario> ListarTodos()
        {
            List<RH_Funcionario> lista = new List<RH_Funcionario>();

            try
            {
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
                                PessoaNome = reader["PessoaNome"].ToString(),
                                Cargo = reader["Cargo"].ToString(),
                                Departamento = reader["Departamento"].ToString(),
                                DataAdmissao = (DateTime)reader["DataAdmissao"],
                                DataDemissao = reader["DataDemissao"] == DBNull.Value ? null : (DateTime?)reader["DataDemissao"],
                                Salario = (decimal)reader["Salario"],
                                Ativo = (bool)reader["Ativo"],
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao listar funcionários: " + ex.Message);
            }

            return lista;
        }

        public RH_Funcionario BuscarPorId(int funcionarioId)
        {
            RH_Funcionario func = null;

            try
            {
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
                                PessoaNome = reader["PessoaNome"].ToString(),
                                Cargo = reader["Cargo"].ToString(),
                                Departamento = reader["Departamento"].ToString(),
                                DataAdmissao = (DateTime)reader["DataAdmissao"],
                                DataDemissao = reader["DataDemissao"] == DBNull.Value ? null : (DateTime?)reader["DataDemissao"],
                                Salario = (decimal)reader["Salario"],
                                Ativo = (bool)reader["Ativo"],
                                Foto = reader["Foto"] == DBNull.Value ? null : (byte[])reader["Foto"]
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar funcionário: " + ex.Message);
            }

            return func;
        }
    }
}

