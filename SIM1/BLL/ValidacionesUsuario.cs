using System.Linq;
using System.Text.RegularExpressions;

namespace BLL
{
    public static class ValidacionesUsuario
    {
        private static readonly Regex PatronCorreo = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        public static bool EsIdentificacionValida(string valor) //No permite valores vacíos y exige únicamente números.
        {
            return !string.IsNullOrWhiteSpace(valor) && valor.Trim().All(char.IsDigit);
        }

        public static bool EsNombreValido(string valor) //No permite valores vacíos ni números.
        {
            return !string.IsNullOrWhiteSpace(valor) && !valor.Any(char.IsDigit);
        }

        public static bool EsCorreoValido(string valor) //Comprueba que el correo tenga un formato básico válido.
        {
            return !string.IsNullOrWhiteSpace(valor) && PatronCorreo.IsMatch(valor.Trim());
        }

        public static bool EsUsuarioValido(string valor) //Comprueba que el nombre de usuario no esté vacío.
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        public static bool EsContrasenaValida(string valor) //14 caracteres, una mayúscula, una minúscula, un número y un carácter especial.
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