using System.Text;
using System.Security.Cryptography;

namespace BLL
{
    public class Cifrado
    {
        private static readonly byte[] Clave = Encoding.UTF8.GetBytes("ClaveSecretaCUC1ClaveSecretaCuc1");

        public static string Cifrar(string textoPlano)
        {
            using var aes = Aes.Create();
            aes.Key = Clave;
            aes.GenerateIV();

            using var encriptador = aes.CreateEncryptor();
            byte[] datos = Encoding.UTF8.GetBytes(textoPlano);
            byte[] cifrado = encriptador.TransformFinalBlock(datos, 0, datos.Length);

            byte[] resultado = new byte[aes.IV.Length + cifrado.Length];
            Buffer.BlockCopy(aes.IV, 0, resultado, 0, aes.IV.Length);
            Buffer.BlockCopy(cifrado, 0, resultado, aes.IV.Length, cifrado.Length);

            return Convert.ToBase64String(resultado);
        }
    }
}
