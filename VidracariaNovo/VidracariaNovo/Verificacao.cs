using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidracariaNovo
{
    class Verificacao
    {
        public void validaCpf(string cpf)
        {

            int[] multiplicador1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string CPF = cpf;
            string auxCPF;
            string digito;
            int soma = 0;
            int resto;


            CPF = CPF.Trim();
            CPF = CPF.Replace(".", "").Replace("-", "");
            if (CPF.Length == 11)
            {
                auxCPF = CPF.Substring(0, 9);

                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(auxCPF[i].ToString()) * multiplicador1[i];
                }

                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                auxCPF = auxCPF + digito;

                soma = 0;

                for (int j = 0; j < 10; j++)
                {
                    soma += int.Parse(auxCPF[j].ToString()) * multiplicador2[j];
                }

                resto = soma % 11;

                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = resto.ToString();
                auxCPF = auxCPF + resto;

                if (CPF == auxCPF)
                {
                }
                else
                {
                    MessageBox.Show("O CPF é inválido.");
                }
            }
            else
            {
                MessageBox.Show("O CPF é inválido.");
            }
        }

        public void validaEmail(string email)
        {

            Regex vemail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            string txt = email;
            if (vemail.IsMatch(txt) == true)
            {
            }
            else
            {
                MessageBox.Show("E-mail inválido.");
            }

        }

        public void validaRG(string rg)
        {
            int[] multiplicador1 = new int[] { 2, 3, 4, 5, 6, 7, 8, 9 };
            string RG = rg;
            string auxRg;
            string digito;
            int soma = 0;
            int resto;

            RG = RG.Trim();
            RG = RG.Replace(".", "").Replace("-", "");
            if (RG.Length == 9)
            {
                auxRg = RG.Substring(0, 8);

                for (int i = 0; i < 8; i++)
                {
                    soma += int.Parse(auxRg[i].ToString()) * multiplicador1[i];
                }

                resto = soma % 11;
                resto = 11 - resto;
                if (resto == 11)
                {
                    resto = 0;
                }
                if (resto != 10)
                {

                    digito = resto.ToString();
                    auxRg = auxRg + digito;
                }
                if (resto == 1)
                {
                    auxRg = auxRg + 'X';
                }

                if (RG == auxRg)
                {
                }
                else
                {
                    MessageBox.Show("O RG é inválido.");
                }
            }
            else
            {
                MessageBox.Show("O RG é inválido.");
            }

        }
    }

}

