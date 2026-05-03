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

        }
    }
}
