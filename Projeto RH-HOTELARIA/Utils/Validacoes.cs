using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Projeto_RH_HOTELARIA.Utils
{
    class Validacoes
    {
        public static bool EmailValido(string email)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(email))
                {
                    return false;
                }
                email = email.Trim();
                if (email.Length > 250)
                {
                    return false;
                }
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;

            }
            catch
            {
                return false;
            }
        }
        public static bool SenhaValida(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                return false;
            }
            if (senha.Length < 8)
            {
                return false;
            }

            bool temMaiuscula = senha.Any(char.IsUpper);
            bool temDigito = senha.Any(char.IsDigit);
            bool temMinuscula = senha.Any(char.IsLower);

            return temMaiuscula && temDigito && temMinuscula;
        }
        public static bool NomeValido(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return false;
            }
            if (nome.Length < 3)
            {
                return false;
            }
            if (!Regex.IsMatch(nome, @"^[a-zA-ZÀ-ÿĀ-žА-я\s\-'\.]+$"))
            {
                return false;
            }
            return true;
        }
        public static bool DataValida(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                if (dataInicial == DateTime.MinValue)
                {
                    throw new ArgumentException("Data inicial não pode ser vazia ou inválida.");
                }
                if (dataFinal == DateTime.MinValue)
                {
                    throw new ArgumentException("Data final não pode ser vazia ou inválida.");
                }
                if (dataInicial.Year < 1900)
                {
                    throw new ArgumentOutOfRangeException(nameof(dataInicial), "Data inicial muito antiga.");
                }
                if (dataFinal > DateTime.Now.AddYears(10))
                {
                    throw new ArgumentOutOfRangeException(nameof(dataInicial), "Data final muito distante no futuro.");
                }
                if (dataFinal <= dataInicial)
                {
                    throw new InvalidOperationException("Data final deve ser maior ou igual à data inicial.");
                }
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (InvalidOperationException)
            {
                return false;
            }
        }
        /*public static bool EstadoValido(string estado)
        {
            try
            {

            }
            catch
            {
                return false;
            }
        }
        public static bool PaisValido(string pais)
        {
            try
            {

            }
            catch
            {
                return false;
            }
        }
        */

    }
}

