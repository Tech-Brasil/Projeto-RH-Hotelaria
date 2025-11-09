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
            using (SqlConnection conn = new SqlConnection(_context))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_RH_Pessoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Acao", 1);
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@DataNascimento", pessoa.DataNascimento);
                cmd.Parameters.AddWithValue("@Genero", (object)pessoa.Genero ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Nacionalidade", (object)pessoa.Nacionalidade ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EstadoCivil", (object)pessoa.EstadoCivil ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EnderecoId", (object)pessoa.EnderecoId ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        public void Alterar(RH_Pessoa pessoa)
        {
            using (SqlConnection conn = new SqlConnection(_context))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_RH_Pessoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Acao", 2);
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@DataNascimento", pessoa.DataNascimento);
                cmd.Parameters.AddWithValue("@Genero", (object)pessoa.Genero ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Nacionalidade", (object)pessoa.Nacionalidade ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EstadoCivil", (object)pessoa.EstadoCivil ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@EnderecoId", (object)pessoa.EnderecoId ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        public void Excluir(string nome)
        {
            using (SqlConnection conn = new SqlConnection(_context))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_RH_Pessoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Acao", 3);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.ExecuteNonQuery();
            }
        }

        public RH_Pessoa BuscarPorNome(string nome)
        {
            RH_Pessoa pessoa = null;

            using (SqlConnection conn = new SqlConnection(_context))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("usp_RH_Pessoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Acao", 4);
                cmd.Parameters.AddWithValue("@Nome", nome);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pessoa = new RH_Pessoa
                        {
                            Nome = reader["Nome"].ToString(),
                            DataNascimento = (DateTime)reader["DataNascimento"],
                            Genero = reader["Genero"].ToString(),
                            Nacionalidade = reader["Nacionalidade"].ToString(),
                            EstadoCivil = reader["EstadoCivil"].ToString(),
                            EnderecoId = reader["EnderecoId"] == DBNull.Value ? null : (int?)reader["EnderecoId"],
                            DataCriacao = (DateTime)reader["DataCriacao"]
                        };
                    }
                }
            }

            return pessoa;
        }

        public List<RH_Pessoa> ListarTodos()
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
                            Nome = reader["Nome"].ToString(),
                            DataNascimento = (DateTime)reader["DataNascimento"],
                            Genero = reader["Genero"].ToString(),
                            Nacionalidade = reader["Nacionalidade"].ToString(),
                            EstadoCivil = reader["EstadoCivil"].ToString(),
                            EnderecoId = reader["EnderecoId"] == DBNull.Value ? null : (int?)reader["EnderecoId"],
                            DataCriacao = (DateTime)reader["DataCriacao"]
                        });
                    }
                }
            }

            return lista;
        }
    }
}
