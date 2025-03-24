

namespace SingularResponsabilityPrincipal.buenaPractica
{
    internal class Empleado
    {
        public string nombre { get; set; }
        public float sueldo { get; set; }
        public Empleado(string nombre, float sueldo)
        {
            this.nombre = nombre;
            this.sueldo = sueldo;
        }
    }
}
