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
        public static bool DataAdmissaoValida(DateTime admissao,  DateTime ? demissao)
        {
            if(demissao.HasValue && admissao > demissao)
            {
                return false ;
            }
            return true;
        }
        public static bool ContratoAtivo(DateTime? demissao)
        {
            return !demissao.HasValue;
        }
        public static bool CpfValido(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf)) 
            { 
                return false; 
            }
            cpf = cpf.Trim();
            cpf = new string(cpf.Where(char.IsDigit).ToArray());        
            if (cpf.Length != 11)
            {
                return false;
            }
            if (IsRepeatdSequence(cpf))
            {
                return false;
            }
            if (IsSequencialNumero(cpf))
            {
                return false;
            }
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (int.Parse(cpf[9].ToString()) != digito1)
            {
                return false;
            }
            soma = 0;
            for(int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            if (int.Parse(cpf[10].ToString()) != digito2)
            {
                return false;
            }

            return true;
        }
        public static bool SalarioValido(decimal salario)
        {
            if (salario > 0)
            {
                return true;
            }
            return false;
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
        public static bool DataValida(DateTime dataInicial, DateTime? dataFinal)
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

        #region Metodos Auxiliares
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
        #endregion
    }

}   

