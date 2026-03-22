Console.WriteLine("Validar una fecha");
Console.WriteLine();
DateTime fecha = default;
bool valido = false;
while (!valido)
{
    Console.WriteLine("Ingrese una fecha (dd/MM/yyyy): ");
    valido = DateTime.TryParse(Console.ReadLine(), out fecha);
    if (!valido)
    {
        Console.WriteLine("Debe ingresar una fecha en el formato dd/MM/yyyy");
    }


}
Console.WriteLine("Fecha en formato corto: " + fecha);