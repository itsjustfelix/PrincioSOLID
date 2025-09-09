
namespace LiskovSustitutionPrincipal.BuenaPractica
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("esta es la buena practica");
            IVehiculo carro = new Carro();
            carro.Mover();
            IVehiculo bicicleta = new Bicicleta();
            bicicleta.Mover();
        }
    }
}
