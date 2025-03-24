

namespace OpenClosePrincipal.Violacion
{
    internal class AreaCalculator
    {

        public double CalculateArea(string forma, double valor)
        {
            if(forma == "Cuadrado")
            {
                return valor * valor;
            }
            else if (forma == "Circulo")
            {
                return 3.1416 * valor * valor;
            }
            else if (forma == "Triangulo")
            {
                return (valor * valor) / 2;
            }
            return 0;
        }
        
    }
}
