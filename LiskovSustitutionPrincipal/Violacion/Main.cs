
namespace LiskovSustitutionPrincipal.Violacion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vehiculo bicicleta = new Bicicleta();
            bicicleta.EncenderMotor();
        }
    }
}
