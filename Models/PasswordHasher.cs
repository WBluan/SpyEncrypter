using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Moving_Image.Models
{
    /// <summary>
    /// Classe que contém a lógica para gerar o sal, hash da senha e fazer a conversão para base64
    /// </summary>
    public static class PasswordHasher
    {
        public static byte[] GeneratePasswordHash(byte[] plainText, byte[] salt)
        {

            using (var algorithm = new SHA256Managed())
            {
                byte[] plainTextWithSalt = new byte[plainText.Length + salt.Length];
                plainText.CopyTo(plainTextWithSalt, 0);
                salt.CopyTo(plainTextWithSalt, plainText.Length);

                return algorithm.ComputeHash(plainTextWithSalt);
            }
        }

        public static byte[] GenerateSalt(int lenght)
        {
            //cria um número criptográfico aleatório
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[lenght];
                //Preenche o sal com uma sequência criptográfica forte
                rng.GetBytes(salt);
                return salt;
            }
        }

        public static string ConvertToBase64String(byte[] encriptedByte)
        {
            string encriptedString = Convert.ToBase64String(encriptedByte);
            return encriptedString;
        }
    }
}
