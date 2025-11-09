using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class RH_DocumentosPessoaRepository : IRH_DocumentosPessoa
    {
        private readonly string _context;

        public RH_DocumentosPessoaRepository()
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }
        private object DbNull(object value) => value ?? DBNull.Value;

        public void Inserir(RH_DocumentosPessoa doc)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentosPessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 1);
                    cmd.Parameters.AddWithValue("@RG", doc.RG);
                    cmd.Parameters.AddWithValue("@PessoaNome", doc.PessoaNome);
                    cmd.Parameters.AddWithValue("@CPF", doc.CPF);
                    cmd.Parameters.AddWithValue("@TituloEleitor", DbNull(doc.TituloEleitor));
                    cmd.Parameters.AddWithValue("@CTPS_Numero", DbNull(doc.CTPS_Numero));
                    cmd.Parameters.AddWithValue("@CTPS_Serie", DbNull(doc.CTPS_Serie));
                    cmd.Parameters.AddWithValue("@CNH_Numero", DbNull(doc.CNH_Numero));
                    cmd.Parameters.AddWithValue("@CNH_Categoria", DbNull(doc.CNH_Categoria));
                    cmd.Parameters.AddWithValue("@CNH_Validade", DbNull(doc.CNH_Validade));
                    cmd.Parameters.AddWithValue("@PIS", DbNull(doc.PIS));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir documento: " + ex.Message);
            }
        }
        public void Alterar(RH_DocumentosPessoa doc)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentosPessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Acao", 2);
                    cmd.Parameters.AddWithValue("@RG", doc.RG);
                    cmd.Parameters.AddWithValue("@PessoaNome", doc.PessoaNome);
                    cmd.Parameters.AddWithValue("@CPF", doc.CPF);
                    cmd.Parameters.AddWithValue("@TituloEleitor", DbNull(doc.TituloEleitor));
                    cmd.Parameters.AddWithValue("@CTPS_Numero", DbNull(doc.CTPS_Numero));
                    cmd.Parameters.AddWithValue("@CTPS_Serie", DbNull(doc.CTPS_Serie));
                    cmd.Parameters.AddWithValue("@CNH_Numero", DbNull(doc.CNH_Numero));
                    cmd.Parameters.AddWithValue("@CNH_Categoria", DbNull(doc.CNH_Categoria));
                    cmd.Parameters.AddWithValue("@CNH_Validade", DbNull(doc.CNH_Validade));
                    cmd.Parameters.AddWithValue("@PIS", DbNull(doc.PIS));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao alterar documento: " + ex.Message);
            }
        }

        public void Excluir(string rg)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentosPessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 3);
                    cmd.Parameters.AddWithValue("@RG", rg);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao excluir documento: " + ex.Message);
            }
        }

        public RH_DocumentosPessoa BuscarPorRG(string rg)
        {
            RH_DocumentosPessoa doc = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentosPessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 4);
                    cmd.Parameters.AddWithValue("@RG", rg);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            doc = new RH_DocumentosPessoa
                            {
                                RG = reader["RG"].ToString(),
                                PessoaNome = reader["PessoaNome"].ToString(),
                                CPF = reader["CPF"].ToString(),
                                TituloEleitor = reader["TituloEleitor"].ToString(),
                                CTPS_Numero = reader["CTPS_Numero"].ToString(),
                                CTPS_Serie = reader["CTPS_Serie"].ToString(),
                                CNH_Numero = reader["CNH_Numero"].ToString(),
                                CNH_Categoria = reader["CNH_Categoria"].ToString(),
                                CNH_Validade = reader["CNH_Validade"] == DBNull.Value ? null : (DateTime?)reader["CNH_Validade"],
                                PIS = reader["PIS"].ToString(),
                                DataEmissao = (DateTime)reader["DataEmissao"]
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar documento: " + ex.Message);
            }

            return doc;
        }

        public List<RH_DocumentosPessoa> ListarTodos()
        {
            List<RH_DocumentosPessoa> lista = new List<RH_DocumentosPessoa>();

            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentosPessoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Acao", 4);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new RH_DocumentosPessoa
                            {
                                RG = reader["RG"].ToString(),
                                PessoaNome = reader["PessoaNome"].ToString(),
                                CPF = reader["CPF"].ToString(),
                                TituloEleitor = reader["TituloEleitor"].ToString(),
                                CTPS_Numero = reader["CTPS_Numero"].ToString(),
                                CTPS_Serie = reader["CTPS_Serie"].ToString(),
                                CNH_Numero = reader["CNH_Numero"].ToString(),
                                CNH_Categoria = reader["CNH_Categoria"].ToString(),
                                CNH_Validade = reader["CNH_Validade"] == DBNull.Value ? null : (DateTime?)reader["CNH_Validade"],
                                PIS = reader["PIS"].ToString(),
                                DataEmissao = (DateTime)reader["DataEmissao"]
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao listar documentos: " + ex.Message);
            }

            return lista;
        }
    }
}
