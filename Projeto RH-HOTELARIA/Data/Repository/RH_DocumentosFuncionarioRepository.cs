using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class RH_DocumentosFuncionarioRepository : IRH_DocumentosFuncionario
    {
        private readonly string _context;
        public RH_DocumentosFuncionarioRepository()
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }

        public void Inserir(RH_DocumentosFuncionario documentos)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentosFuncionario", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 1);
                    cmd.Parameters.AddWithValue("@RG", documentos.RG);
                    cmd.Parameters.AddWithValue("@CPF", documentos.CPF);
                    cmd.Parameters.AddWithValue("@TituloEleitor", documentos.TituloEleitor);
                    cmd.Parameters.AddWithValue("@CTPS_Numero", documentos.CTPS_Numero);
                    cmd.Parameters.AddWithValue("@CTPS_Serie", documentos.CTPS_Serie);
                    cmd.Parameters.AddWithValue("@CNH_Numero", documentos.CNH_Numero);
                    cmd.Parameters.AddWithValue("@CNH_Categoria", documentos.CNH_Categoria);
                    cmd.Parameters.AddWithValue("@CNH_Validade", documentos.CNH_Validade);
                    cmd.Parameters.AddWithValue("@Passaporte", documentos.Passaporte);
                    cmd.Parameters.AddWithValue("@PIS", documentos.PIS);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao inserir documentos do funcionário: " + ex.Message);
            }
        }

        public void Alterar(RH_DocumentosFuncionario documentos)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentosFuncionario", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 2);
                    cmd.Parameters.AddWithValue("@RG", documentos.RG);
                    cmd.Parameters.AddWithValue("@CPF", documentos.CPF);
                    cmd.Parameters.AddWithValue("@TituloEleitor", documentos.TituloEleitor);
                    cmd.Parameters.AddWithValue("@CTPS_Numero", documentos.CTPS_Numero);
                    cmd.Parameters.AddWithValue("@CTPS_Serie", documentos.CTPS_Serie);
                    cmd.Parameters.AddWithValue("@CNH_Numero", documentos.CNH_Numero);
                    cmd.Parameters.AddWithValue("@CNH_Categoria", documentos.CNH_Categoria);
                    cmd.Parameters.AddWithValue("@CNH_Validade", documentos.CNH_Validade);
                    cmd.Parameters.AddWithValue("@Passaporte", documentos.Passaporte);
                    cmd.Parameters.AddWithValue("@PIS", documentos.PIS);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao alterar documentos do funcionário: " + ex.Message);
            }
        }

        public void Excluir(string rg)
        {
            using (SqlConnection conn = new SqlConnection(_context))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("usp_RH_DocumentosFuncionario", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@acao", 3);
                cmd.Parameters.AddWithValue("@RG", rg);

                cmd.ExecuteNonQuery();
            }
        }

        public List<RH_DocumentosFuncionario> BuscarPorRg(string rg)
        {
            try
            {
                List<RH_DocumentosFuncionario> lista = new List<RH_DocumentosFuncionario>();

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentosFuncionario", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 4);
                    cmd.Parameters.AddWithValue("@RG", rg);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        RH_DocumentosFuncionario FunDoc = new RH_DocumentosFuncionario
                        {
                            RG = reader.GetString(reader.GetOrdinal("RG")),
                            CPF = reader.GetString(reader.GetOrdinal("CPF")),
                            TituloEleitor = reader.GetString(reader.GetOrdinal("TituloEleitor")),
                            CTPS_Numero = reader.GetString(reader.GetOrdinal("CTPS_Numero")),
                            CTPS_Serie = reader.GetString(reader.GetOrdinal("CTPS_Serie")),
                            CNH_Numero = reader.GetString(reader.GetOrdinal("CNH_Numero")),
                            CNH_Validade = reader.GetDateTime(reader.GetOrdinal("CNH_Validade")),
                            Passaporte = reader.GetString(reader.GetOrdinal("Passaporte")),
                            PIS = reader.GetString(reader.GetOrdinal("PIS")),
                            DataCriacao = reader.GetSqlDateTime(reader.GetOrdinal("DataCriacao"))
                        };
                        lista.Add(FunDoc);
                    }
                }

                return lista;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar o RG do funcionário: " + ex.Message);
            }
        }

        public List<RH_DocumentosFuncionario> ListarTodos()
        {
            try
            {
                List<RH_DocumentosFuncionario> lista = new List<RH_DocumentosFuncionario>();

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_DocumentosFuncionario", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 4);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RH_DocumentosFuncionario FunDoc = new RH_DocumentosFuncionario
                        {
                            RG = reader.GetString(reader.GetOrdinal("RG")),
                            CPF = reader.GetString(reader.GetOrdinal("CPF")),
                            TituloEleitor = reader.GetString(reader.GetOrdinal("TituloEleitor")),
                            CTPS_Numero = reader.GetString(reader.GetOrdinal("CTPS_Numero")),
                            CTPS_Serie = reader.GetString(reader.GetOrdinal("CTPS_Serie")),
                            CNH_Numero = reader.GetString(reader.GetOrdinal("CNH_Numero")),
                            CNH_Validade = reader.GetDateTime(reader.GetOrdinal("CNH_Validade")),
                            Passaporte = reader.GetString(reader.GetOrdinal("Passaporte")),
                            PIS = reader.GetString(reader.GetOrdinal("PIS")),
                            DataCriacao = reader.GetSqlDateTime(reader.GetOrdinal("DataCriacao"))
                        };
                        lista.Add(FunDoc);
                    }
                }

                return lista;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar a lista de todos os funcionários: " + ex.Message);
            }
        }
    }
}
