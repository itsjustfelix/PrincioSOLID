
namespace LiskovSustitutionPrincipal.BuenaPractica
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IVehiculo carro = new Carro();
            carro.Mover();
            IVehiculo bicicleta = new Bicicleta();
            bicicleta.Mover();
        }
    }
}
