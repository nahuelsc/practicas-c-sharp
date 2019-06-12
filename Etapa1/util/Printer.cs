using static System.Console;

namespace CorEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle(string title)
        {
            var tamaño = title.Length + 4;
            Printer.DibujarLinea(tamaño);
            WriteLine($"| {title} | ");
            Printer.DibujarLinea(tamaño);
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }
    }
}