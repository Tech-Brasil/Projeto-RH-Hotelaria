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
            email = email.Trim();
            if (string.IsNullOrEmpty(email) || email.Length > 200)
            {
                return false;
            }

            var mailAddress = new System.Net.Mail.MailAddress(email);
            return true;
        }
        public static bool SenhaValida(string senha)
        {
            if (senha.Length < 8 || string.IsNullOrWhiteSpace(senha))
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
            if (dataInicial == DateTime.MinValue || dataFinal == DateTime.MinValue)
            {
                return false;
            }
            if (dataInicial.Year < 1900 || dataFinal > DateTime.Now.AddYears(10))
            {
                return false;
            }
            if (dataFinal <= dataInicial)
            {
                return false;
            }
            return true;

        }
        private static bool IsRepeatdSequence(string num)
        {
            return num.Distinct().Count() == 1;
        }
        private static bool IsSequencialNumero(string num)
        {
            var numero = num.Select(c => int.Parse(c.ToString())).ToArray();

            var ascendente = numero.SequenceEqual(Enumerable.Range(numero[0], numero.Length));
            var descendente = numero.SequenceEqual(Enumerable.Range(numero[0] - numero.Length + 1, numero.Length).Reverse());
            return ascendente || descendente;
        }
        public static bool RgValido(string rg)
        {
            rg = rg.Trim();
            var numeros = Regex.Replace(rg, @"[^0-9]", "");

            if (string.IsNullOrWhiteSpace(numeros))
            {
                return false;
            }

            if (numeros.Length < 7 || numeros.Length > 10)
            {
                return false;
            }
            if (IsRepeatdSequence(numeros))
            {
                return false;
            }
            if (IsSequencialNumero(numeros))
            {
                return false;
            }
            return true;
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

