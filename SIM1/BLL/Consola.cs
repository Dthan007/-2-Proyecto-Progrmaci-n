using System.Diagnostics;

namespace BLL
{
    public static class Consola
    {
        public static void Error(string mensaje, Exception? ex = null)
        {
            var texto = ex == null ? mensaje : mensaje + " | " + ex.GetType().Name + ": " + ex.Message;

            Console.Error.WriteLine("[ERROR] " + texto);
            Trace.TraceError(texto);
        }
    }
}