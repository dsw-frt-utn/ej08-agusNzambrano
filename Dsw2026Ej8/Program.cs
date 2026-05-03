using Dsw2026Ej8.Problema1;
namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productHelper = new ProductHelper();
            string etiqueta = productHelper.ObtenerEtiquetaProducto(12345, "Camiseta", 19.99m);
            Console.WriteLine("--Prueba Ej01--");
            Console.WriteLine(etiqueta);

            var p2 = new Dsw2026Ej8.Problema2();
            string resumen = p2.CrearResumenVenta(12345, "Camiseta", 2, 19.99m);
            Console.WriteLine("--Prueba Ej02--");
            Console.WriteLine(resumen);

            Problema4 p4 = new Problema4();
            Console.WriteLine("--Prueba Ej04--");
            double promedio = p4.CalcularPromedio(7, 8, null);
            Console.WriteLine($"prueba 1 ( 7, 8, null): {promedio}");
             promedio = p4.CalcularPromedio(null, null, null);
            Console.WriteLine($"prueba 2 (null, null, null): {promedio}");
             promedio = p4.CalcularPromedio(10, 9, 8);
            Console.WriteLine($"prueba 3 (10, 9, 8): {promedio}");

        }
    }
}
