namespace ApiIncidencias.Helpers;

public class Autorizacion
{
    public enum Roles
    {
        Administrador,
        Gerenrte,
        Empleado
    }

    public const Roles rol_predeterminado = Roles.Empleado;
}