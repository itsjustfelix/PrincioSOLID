

namespace OpenClosePrincipal.BuenaPractica
{
    internal class AreaCirculo : IForma
    {
        double radio;
        public AreaCirculo(double radio)
        {
            this.radio = radio;
        }
        public double Area() => Math.PI * radio * radio;
    }
}
