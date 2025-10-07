﻿using Projeto_RH_HOTELARIA.Data.IRepository;
using Projeto_RH_HOTELARIA.Models.RH;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_RH_HOTELARIA.Data.Repository
{
    public class RH_FuncionarioRepository : IRH_Funcionario
    {
        private readonly string _context;

        public RH_FuncionarioRepository()
        {
            _context = ConfigurationManager.ConnectionStrings["Projeto_RHotelaria"].ConnectionString;
        }

        public void Inserir(RH_Funcionario funcionario)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_FuncionarioCRUD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 1);
                    cmd.Parameters.AddWithValue("@RG", funcionario.RG);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", funcionario.DataNascimento);
                    cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Departamento);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
                    cmd.Parameters.AddWithValue("@DataDemissao", funcionario.DataDemissao);
                    cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);

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

                    SqlCommand cmd = new SqlCommand("usp_RH_FuncionarioCRUD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 2);
                    cmd.Parameters.AddWithValue("@RG", funcionario.RG);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@DataNascimento", funcionario.DataNascimento);
                    cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Departamento);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
                    cmd.Parameters.AddWithValue("@DataDemissao", funcionario.DataDemissao);
                    cmd.Parameters.AddWithValue("@Salario", funcionario.Salario);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao alterar funcionário: " + ex.Message);
            }
        }

        public void Excluir(string rg)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_FuncionarioCRUD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 3);
                    cmd.Parameters.AddWithValue("@RG", rg);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao excluir funcionário: " + ex.Message);
            }
        }

        public List<RH_Funcionario> Buscar(string rg = null, string nome = null, DateTime? dataNascimento = null, DateTime? dataAdmissao = null)
        {
            try
            {
                List<RH_Funcionario> lista = new List<RH_Funcionario>();

                using (SqlConnection conn = new SqlConnection(_context))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("usp_RH_FuncionarioCRUD", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@acao", 4);
                    cmd.Parameters.AddWithValue("@RG", (object)rg ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Nome", (object)nome ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataNascimento", (object)dataNascimento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@DataAdmissao", (object)dataAdmissao ?? DBNull.Value);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RH_Funcionario funcionario = new RH_Funcionario
                        {
                            RG = reader.GetString(reader.GetOrdinal("RG")),
                            Nome = reader.GetString(reader.GetOrdinal("Nome")),
                            DataNascimento = reader.GetDateTime(reader.GetOrdinal("DataNascimento")),
                            Cargo = reader.GetString(reader.GetOrdinal("Cargo")),
                            Departamento = reader.GetString(reader.GetOrdinal("Departamento")),
                            DataAdmissao = reader.GetDateTime(reader.GetOrdinal("DataAdmissao")),
                            DataDemissao = reader.IsDBNull(reader.GetOrdinal("DataDemissao"))
                        ? (DateTime?)null
                        : reader.GetDateTime(reader.GetOrdinal("DataDemissao")),
                            Salario = reader.GetDecimal(reader.GetOrdinal("Salario"))
                        };
                        lista.Add(funcionario);
                    }
                }

                return lista;
            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao buscar funcionários: " + ex.Message);
            }
        }
    }
}
