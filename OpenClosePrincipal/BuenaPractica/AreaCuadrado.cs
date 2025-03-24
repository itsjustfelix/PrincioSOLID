

namespace OpenClosePrincipal.BuenaPractica
{
    internal class AreaCuadrado : IForma
    {
        double lonLado;
        public AreaCuadrado(double lonLado)
        {
            this.lonLado = lonLado;
        }
        public double Area() => lonLado * lonLado;

    }
}
