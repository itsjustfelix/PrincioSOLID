
namespace SingularResponsabilityPrincipal.buenaPractica
{
    internal class ImprimirEmpleados
    {
        GuardarEmpleados guardarEmpleados = new GuardarEmpleados();
        public void imprimirEmpleados()
        {
            foreach (var empleado in guardarEmpleados.getEmpleados())
            {
                Console.WriteLine($"Nombre: {empleado.nombre}, Sueldo: {empleado.sueldo}");
            }
        }
    }
}
