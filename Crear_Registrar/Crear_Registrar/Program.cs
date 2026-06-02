using System;
using System.Windows.Forms;

namespace Crear_Registrar
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Manejador de errores global - SILENCIOSO (no muestra nada)
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) =>
            {
                // No hacer nada - el error se ignora silenciosamente
                // El programa sigue funcionando sin mostrar ventana
            };

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                // No hacer nada - error silencioso
            };

            ApplicationConfiguration.Initialize();
            Application.Run(new MenuPrincipal());
        }
    }
}