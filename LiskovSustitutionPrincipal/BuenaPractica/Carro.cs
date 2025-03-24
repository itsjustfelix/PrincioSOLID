
namespace LiskovSustitutionPrincipal.BuenaPractica
{
    internal class Carro: IVehiculo
    {
        public void Mover()
        {
            Console.WriteLine("El carro encendio el motor, se esta moviendo");
        }
    }
    
}
