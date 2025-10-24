using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class RH_PessoaRepository : IRH_Pessoa
    {
        private readonly string _context;

        public RH_PessoaRepository()
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }

        public void Inserir(RH_Pessoa pessoa)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Pessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 1);
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", pessoa.DataNascimento);
                    cmd.Parameters.AddWithValue("@Genero", pessoa.Genero);
                    cmd.Parameters.AddWithValue("@Nacionalidade", pessoa.Nacionalidade);
                    cmd.Parameters.AddWithValue("@EstadoCivil", pessoa.EstadoCivil);
                    cmd.Parameters.AddWithValue("@EnderecoId", pessoa.EnderecoId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch(SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public void Alterar(RH_Pessoa pessoa)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Pessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 2);
                    cmd.Parameters.AddWithValue("@PessoaId", pessoa.PessoaId);
                    cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", pessoa.DataNascimento);
                    cmd.Parameters.AddWithValue("@Genero", pessoa.Genero);
                    cmd.Parameters.AddWithValue("@Nacionalidade", pessoa.Nacionalidade);
                    cmd.Parameters.AddWithValue("@EstadoCivil", pessoa.EstadoCivil);
                    cmd.Parameters.AddWithValue("@EnderecoId", pessoa.EnderecoId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public RH_Pessoa BuscarPorId(int pessoaId)
        {
            try
            {
                RH_Pessoa pessoa = null;

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Pessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 4);
                    cmd.Parameters.AddWithValue("@PessoaId", pessoaId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pessoa = new RH_Pessoa
                            {
                                PessoaId = (int)reader["PessoaId"],
                                Nome = reader["Nome"].ToString(),
                                DataNascimento = (DateTime)reader["DataNascimento"],
                                Genero = reader["Genero"].ToString(),
                                Nacionalidade = reader["Nacionalidade"].ToString(),
                                EstadoCivil = reader["EstadoCivil"].ToString(),
                                EnderecoId = (int)reader["EnderecoId"]
                            };
                        }
                    }
                }

                return pessoa;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public void Excluir(int pessoaId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Pessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 3);
                    cmd.Parameters.AddWithValue("@PessoaId", pessoaId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
        }

        public List<RH_Pessoa> ListarTodos()
        {
            try
            {
                List<RH_Pessoa> lista = new List<RH_Pessoa>();

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Pessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 4);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new RH_Pessoa
                            {
                                PessoaId = (int)reader["PessoaId"],
                                Nome = reader["Nome"].ToString(),
                                DataNascimento = (DateTime)reader["DataNascimento"],
                                Genero = reader["Genero"].ToString(),
                                Nacionalidade = reader["Nacionalidade"].ToString(),
                                EstadoCivil = reader["EstadoCivil"].ToString(),
                                EnderecoId = (int)reader["EnderecoId"]
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
    }
}
