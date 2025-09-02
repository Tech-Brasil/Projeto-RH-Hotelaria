using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class RH_EnderecoRepository : IRH_Endereco
    {
        private readonly string _context;

        public RH_EnderecoRepository(string context)
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }

        public void Inserir(RH_Endereco endereco)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_Endereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 1);
                    cmd.Parameters.AddWithValue("CidadeNome", endereco.CidadeNome);
                    cmd.Parameters.AddWithValue("@EstadoSigla", endereco.EstadoSigla);
                    cmd.Parameters.AddWithValue("@PaisSigla", endereco.PaisSigla);
                    cmd.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@CEP", endereco.Cep);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir endereço: " + ex.Message);
            }
        }

        public void Atualizar(RH_Endereco endereco)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_Endereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 2);
                    cmd.Parameters.AddWithValue("@EnderecoId", endereco.EnderecoId);
                    cmd.Parameters.AddWithValue("CidadeNome", endereco.CidadeNome);
                    cmd.Parameters.AddWithValue("@EstadoSigla", endereco.EstadoSigla);
                    cmd.Parameters.AddWithValue("@PaisSigla", endereco.PaisSigla);
                    cmd.Parameters.AddWithValue("@Logradouro", endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@CEP", endereco.Cep);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao atualizar endereço: " + ex.Message);
            }
        }

        public void Deletar(int enderecoId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Endereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 3);
                    cmd.Parameters.AddWithValue("@Id", enderecoId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao deletar endereço: " + ex.Message);
            }
        }

        public List<RH_Endereco> ListarTodos()
        {
            List<RH_Endereco> lista = new List<RH_Endereco>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Endereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 4);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RH_Endereco endereco = new RH_Endereco
                            {
                                EnderecoId = reader.GetInt32(reader.GetOrdinal("Id")),
                                CidadeNome = reader.GetString(reader.GetOrdinal("CidadeNome")),
                                EstadoSigla = reader.GetString(reader.GetOrdinal("EstadoSigla")),
                                PaisSigla = reader.GetString(reader.GetOrdinal("PaisSigla")),
                                Logradouro = reader.GetString(reader.GetOrdinal("Logradouro")),
                                Numero = reader.GetString(reader.GetOrdinal("Numero")),
                                Complemento = reader.GetString(reader.GetOrdinal("Complemento")),
                                Bairro = reader.GetString(reader.GetOrdinal("Bairro")),
                                Cep = reader.GetString(reader.GetOrdinal("CEP"))
                            };
                            lista.Add(endereco);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao listar endereços: " + ex.Message);
            }

            return lista;
        }

        public List<RH_Endereco> BuscarPorCEP(string cep)
        {
            List<RH_Endereco> lista = new List<RH_Endereco>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_Endereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@acao", 4);
                    cmd.Parameters.AddWithValue("@CEP", cep);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RH_Endereco endereco = new RH_Endereco
                        {
                            EnderecoId = reader.GetInt32(reader.GetOrdinal("Id")),
                            CidadeNome = reader.GetString(reader.GetOrdinal("CidadeNome")),
                            EstadoSigla = reader.GetString(reader.GetOrdinal("EstadoSigla")),
                            PaisSigla = reader.GetString(reader.GetOrdinal("PaisSigla")),
                            Logradouro = reader.GetString(reader.GetOrdinal("Logradouro")),
                            Numero = reader.GetString(reader.GetOrdinal("Numero")),
                            Complemento = reader.GetString(reader.GetOrdinal("Complemento")),
                            Bairro = reader.GetString(reader.GetOrdinal("Bairro")),
                            Cep = reader.GetString(reader.GetOrdinal("CEP"))
                        };
                        lista.Add(endereco);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar o cep do endereço: " + ex.Message);
            }

            return lista;
        }

        public List<RH_Endereco> BuscarPorCidade(string cidade)
        {
            List<RH_Endereco> lista = new List<RH_Endereco>();
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_Endereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@acao", 4);
                    cmd.Parameters.AddWithValue("@CidadeNome", cidade);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RH_Endereco endereco = new RH_Endereco
                        {
                            EnderecoId = reader.GetInt32(reader.GetOrdinal("Id")),
                            CidadeNome = reader.GetString(reader.GetOrdinal("CidadeNome")),
                            EstadoSigla = reader.GetString(reader.GetOrdinal("EstadoSigla")),
                            PaisSigla = reader.GetString(reader.GetOrdinal("PaisSigla")),
                            Logradouro = reader.GetString(reader.GetOrdinal("Logradouro")),
                            Numero = reader.GetString(reader.GetOrdinal("Numero")),
                            Complemento = reader.GetString(reader.GetOrdinal("Complemento")),
                            Bairro = reader.GetString(reader.GetOrdinal("Bairro")),
                            Cep = reader.GetString(reader.GetOrdinal("CEP"))
                        };
                        lista.Add(endereco);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar o cidade do endereço: " + ex.Message);
            }

            return lista;
        }

        public List<RH_Endereco> BuscarPorEstado(string estadoSigla)
        {
            List<RH_Endereco> lista = new List<RH_Endereco>();
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.Open();
                    
                    SqlCommand cmd = new SqlCommand("usp_RH_Endereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@acao", 4);
                    cmd.Parameters.AddWithValue("@EstadoSigla", estadoSigla);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RH_Endereco endereco = new RH_Endereco
                        {
                            EnderecoId = reader.GetInt32(reader.GetOrdinal("Id")),
                            CidadeNome = reader.GetString(reader.GetOrdinal("CidadeNome")),
                            EstadoSigla = reader.GetString(reader.GetOrdinal("EstadoSigla")),
                            PaisSigla = reader.GetString(reader.GetOrdinal("PaisSigla")),
                            Logradouro = reader.GetString(reader.GetOrdinal("Logradouro")),
                            Numero = reader.GetString(reader.GetOrdinal("Numero")),
                            Complemento = reader.GetString(reader.GetOrdinal("Complemento")),
                            Bairro = reader.GetString(reader.GetOrdinal("Bairro")),
                            Cep = reader.GetString(reader.GetOrdinal("CEP"))
                        };
                        lista.Add(endereco);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar o estado do endereço: " + ex.Message);
            }

            return lista;
        }

        public RH_Endereco BuscarPorId(int enderecoId)
        {
            RH_Endereco endereco = null;
            try
            {
                using (SqlConnection conn = new SqlConnection("YourConnectionStringHere"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_Endereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@acao", 4);
                    cmd.Parameters.AddWithValue("@enderecoId", enderecoId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        endereco = new RH_Endereco
                        {
                            EnderecoId = reader.GetInt32(reader.GetOrdinal("Id")),
                            CidadeNome = reader.GetString(reader.GetOrdinal("CidadeNome")),
                            EstadoSigla = reader.GetString(reader.GetOrdinal("EstadoSigla")),
                            PaisSigla = reader.GetString(reader.GetOrdinal("PaisSigla")),
                            Logradouro = reader.GetString(reader.GetOrdinal("Logradouro")),
                            Numero = reader.GetString(reader.GetOrdinal("Numero")),
                            Complemento = reader.GetString(reader.GetOrdinal("Complemento")),
                            Bairro = reader.GetString(reader.GetOrdinal("Bairro")),
                            Cep = reader.GetString(reader.GetOrdinal("CEP"))
                        };
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar o id do endereço: " + ex.Message);
            }

            return endereco;
        }
    }
}
