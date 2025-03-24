

namespace OpenClosePrincipal.Violacion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();
            Console.WriteLine(areaCalculator.CalculateArea("Cuadrado", 5));
            Console.WriteLine(areaCalculator.CalculateArea("Circulo", 5));
            Console.WriteLine(areaCalculator.CalculateArea("Triangulo", 5));
        }
    }
}
