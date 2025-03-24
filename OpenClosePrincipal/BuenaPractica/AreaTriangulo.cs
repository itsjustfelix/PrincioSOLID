

namespace OpenClosePrincipal.BuenaPractica
{
    internal class AreaTriangulo : IForma
    {
        double Base;
        double Altura;
        public AreaTriangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public double Area() => (Base * Altura) / 2;
    }
}
