using Dsw2026Ej8.Problema1;
namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productHelper = new ProductHelper();
            string etiqueta = productHelper.ObtenerEtiquetaProducto(12345, "Camiseta", 19.99m);
            Console.WriteLine(etiqueta);
        }
    }
}
