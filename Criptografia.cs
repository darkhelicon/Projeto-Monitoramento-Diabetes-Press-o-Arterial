using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Data.Extension;

namespace Data.Criptografia
{
    public class Criptografia
    {
        public string CriptografaSenha(string senha)
        {
            string auxStrSenha = TamanhoFormatado(senha, 6, true);
            char[] strSenha = new char[auxStrSenha.Length];

            for (int i = 0; i < auxStrSenha.Length; i++)
            {
                strSenha[i] = auxStrSenha[i];
            }

            string[] strAux = new string[auxStrSenha.Length];
            string strNumero = "";

            for (int i = 0; i < 6; i++)
            {
                if (strSenha[i] == ' ')
                    strSenha[i] = '0';
            }

            for (int i = 0; i < 6; i++)
            {

                for (int k = 0; k < 6; k++)
                {
                    strAux[k] = "";
                }

                strAux[0] = strSenha[i].ToString();

                string aux = "";
                for (int k = 0; k < 6; k++)
                {
                    aux += strAux[k].ToString();
                }

                int j = int.Parse(aux);

                switch (i)
                {
                    case 0:
                        j = j + 5;
                        break;
                    case 1:
                        j = j + 1;
                        break;
                    case 2:
                        j = j + 4;
                        break;
                    case 3:
                        j = j + 7;
                        break;
                    case 4:
                        j = j + 3;
                        break;
                    case 5:
                        j = j + 8;
                        break;
                }
                strNumero = j.ToString();

                if (j >= 10)
                    strSenha[i] = strNumero[1];
                else
                    strSenha[i] = strNumero[0];

            }

            string retorno = "";
            for (int i = 0; i < strSenha.Length; i++)
            {
                retorno += strSenha[i].ToString();
            }
            return retorno;
        }

        public static string TamanhoFormatado(string variavel, int tamanho, bool zeroEsquerda)
        {
            string strRetorno = "";
            if (variavel.Length > tamanho)
                strRetorno = variavel.Substring(1, tamanho);
            else
            {
                strRetorno = variavel.Trim();
                while (strRetorno.Length < tamanho)
                {
                    if (!zeroEsquerda)
                        strRetorno = strRetorno + " ";
                    else
                        strRetorno = "0" + strRetorno;
                }
            }
            return strRetorno;
        }

        public string CriptografarHmacSha256(string desString, string desChave)
        {
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(desChave); // Deve utilizar o campo serial da tabela.
            byte[] messageBytes = encoding.GetBytes(desString);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return BitConverter.ToString(hashmessage).Replace("-", "").ToUpper();
            }
        }

        public string DescriptografaSenha(string desSenha)
        {
            if (desSenha == "@@@@")
            {
                return desSenha;
            }
            string desSenhaDescriptografada = string.Empty;
            string strNumero = "";

            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0:
                        strNumero = (desSenha[i].ToString().ToInt32() - 5).ToString();
                        break;
                    case 1:
                        strNumero = (desSenha[i].ToString().ToInt32() - 1).ToString();
                        break;
                    case 2:
                        strNumero = (desSenha[i].ToString().ToInt32() - 4).ToString();
                        break;
                    case 3:
                        strNumero = (desSenha[i].ToString().ToInt32() - 7).ToString();
                        break;
                    case 4:
                        strNumero = (desSenha[i].ToString().ToInt32() - 3).ToString();
                        break;
                    case 5:
                        strNumero = (desSenha[i].ToString().ToInt32() - 8).ToString();
                        break;
                }
                if (strNumero.ToInt32() < 0)
                    strNumero = (strNumero.ToInt32() + 10).ToString();

                desSenhaDescriptografada += strNumero[0].ToString();
            }

            return desSenhaDescriptografada;
        }
    }
}
