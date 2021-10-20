using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Criptografia
{
    class CriptoMD5
    {
        public string RetornarMD5(string Senha)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return RetornarHash(md5Hash, Senha);
            }
        }

        public bool CompararMD5(string senhaGuardada, string senahMD5)
        {
            string senha = RetornarMD5(senhaGuardada);

            if (VerificaHash(senahMD5, senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string RetornarHash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuider = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuider.Append(data[i].ToString("X2"));
            }

            return sBuider.ToString();
        }

        private bool VerificaHash(string input, string hash)
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;

            if (comparar.Compare(input, hash) == 0)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

    }
}
