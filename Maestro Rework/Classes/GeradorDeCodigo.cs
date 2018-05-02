using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Maestro_Rework.Classes
{
    public static class GeradorDeCodigo
    {
        public static string GerarCodigoRecuperacaoSenha() {
            char[] chars = new char[88];
            chars =
            "abcdefghijlmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            return GerarCodigoApartirDeUmaSequenciaDeCaracteres(chars, 8);
        }
        public static string GerarCodigoAcesso()
        {
            char[] chars = new char[62];
            chars =
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            return GerarCodigoApartirDeUmaSequenciaDeCaracteres(chars, 5);
        }

        private static string GerarCodigoApartirDeUmaSequenciaDeCaracteres(char[] chars, int comprimento)
        {
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[comprimento];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder resultado = new StringBuilder(comprimento);
            foreach (byte b in data)
            {
                resultado.Append(chars[b % (chars.Length)]);
            }
            return resultado.ToString();
        }
    }
}
