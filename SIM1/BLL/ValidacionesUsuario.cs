using System.Linq;
using System.Text.RegularExpressions;

namespace BLL
{
    public static class ValidacionesUsuario
    {
        private static readonly Regex PatronCorreo = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public static bool EsIdentificacionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor) && valor.Trim().All(char.IsDigit);
        }

        public static bool EsNombreValido(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor) && !valor.Any(char.IsDigit);
        }

        public static bool EsCorreoValido(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor) && PatronCorreo.IsMatch(valor.Trim());
        }

        public static bool EsUsuarioValido(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        public static bool EsContrasenaValida(string valor)
        {
            return valor != null
                && valor.Length == 14
                && valor.Any(char.IsUpper)
                && valor.Any(char.IsLower)
                && valor.Any(char.IsDigit)
                && valor.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
        }
    }
}