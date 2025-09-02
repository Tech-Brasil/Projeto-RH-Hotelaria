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
    public class RH_DocumentoEnderecoRepository : IRH_DocumentoEndereco
    {
        private readonly string _context;

        public RH_DocumentoEnderecoRepository(string context)
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }

        public void Inserir(string rg, int enderecoId)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentoEndereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 1);
                    cmd.Parameters.AddWithValue("@RG", rg);
                    cmd.Parameters.AddWithValue("@EnderecoId", enderecoId);
                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir o documento-endereço: " + ex.Message);
            }
        }

        public void Atualizar(string rg, int enderecoId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentoEndereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 2);
                    cmd.Parameters.AddWithValue("@RG", rg);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao Alterar o documento-endereço: " + ex.Message);
            }
        }

        public void Excluir(string rg, int enderecoId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentoEndereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 3);
                    cmd.Parameters.AddWithValue("@RG", rg);
                    cmd.Parameters.AddWithValue("@EnderecoId", enderecoId);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao Deletar o documento-endereço: " + ex.Message);
            }
        }

        public List<RH_DocumentoEndereco> ListarPorFuncionario(string rg)
        {
            try
            {
                List<RH_DocumentoEndereco> lista = new List<RH_DocumentoEndereco>();

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentoEndereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 4);
                    cmd.Parameters.AddWithValue("@RG", rg);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RH_DocumentoEndereco DocEndereco = new RH_DocumentoEndereco
                        {
                            RG = reader.GetString(reader.GetOrdinal("RG")),
                            EnderecoId = Convert.ToInt32(reader["EnderecoId"])
                        };
                        lista.Add(DocEndereco);
                    }
                }

                return lista;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao listar o documento-endereço por RG: " + ex.Message);
            }
        }

        public List<RH_DocumentoEndereco> ListarTodos()
        {
            try
            {
                List<RH_DocumentoEndereco> lista = new List<RH_DocumentoEndereco>();

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentoEndereco", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 4);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RH_DocumentoEndereco DocEndereco = new RH_DocumentoEndereco
                        {
                            RG = reader.GetString(reader.GetOrdinal("RG")),
                            EnderecoId = Convert.ToInt32(reader["EnderecoId"])
                        };
                        lista.Add(DocEndereco);
                    }
                }

                return lista;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao listar todos os documento-endereço: " + ex.Message);
            }
        }
    }
}
