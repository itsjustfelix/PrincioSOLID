

namespace OpenClosePrincipal.BuenaPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IForma[] formas = new IForma[]
            {
                new AreaTriangulo(10, 5),
                new AreaCirculo(5),
                new AreaCuadrado(10)
            };

            foreach (var forma in formas)
            {
                Console.WriteLine(forma.Area());
            }
        }
    }
    
}
