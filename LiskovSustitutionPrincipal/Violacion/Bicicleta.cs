
namespace LiskovSustitutionPrincipal.Violacion
{
    internal class Bicicleta:Vehiculo
    {
        public override void EncenderMotor()
        {
            throw new Exception("Una bicicleta no tiene motor.");
        }
    }
}
