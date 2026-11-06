using System;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class Cifrado
    {
        private static readonly byte[] Clave = Encoding.UTF8.GetBytes("ClaveSecretaCUC1ClaveSecretaCuc1");

        public static string Cifrar(string textoPlano)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = Clave;
                aes.GenerateIV();

                using (var encriptador = aes.CreateEncryptor())
                {
                    byte[] datos = Encoding.UTF8.GetBytes(textoPlano);
                    byte[] cifrado = encriptador.TransformFinalBlock(datos, 0, datos.Length);

                    byte[] resultado = new byte[aes.IV.Length + cifrado.Length];
                    Buffer.BlockCopy(aes.IV, 0, resultado, 0, aes.IV.Length);
                    Buffer.BlockCopy(cifrado, 0, resultado, aes.IV.Length, cifrado.Length);

                    return Convert.ToBase64String(resultado);
                }
            }  
        }

        public static string Descifrar (string textoCifrado)
        {
            byte[] todo = Convert.FromBase64String(textoCifrado);

            using (var aes = Aes.Create())
            {
                aes.Key = Clave;

                int tamañoIv = aes.BlockSize / 8;
                
                if (todo.Length <= tamañoIv)
                {
                    throw new FormatException("El texto cifrado es demasiado corto");
                }

                byte[] iv = new byte[tamañoIv];
                Buffer.BlockCopy(todo, 0, iv, 0, tamañoIv);
                aes.IV = iv;

                using (var desencriptador = aes.CreateDecryptor())
                {
                    byte[] datos = desencriptador.TransformFinalBlock(todo, tamañoIv, todo.Length - tamañoIv);
                    return Encoding.UTF8.GetString(datos);
                }
            }
        }
    }
}
