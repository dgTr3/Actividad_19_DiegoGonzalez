Console.WriteLine("Estudiantes");
Console.WriteLine();
int estudiantes = 0;
bool valido = false;
while (!valido)
{
    Console.WriteLine("Ingrese cantidad de estudiantes: ");
    valido = int.TryParse(Console.ReadLine(), out estudiantes) && estudiantes > 0;
    if (!valido)
    {
        Console.WriteLine("Debe ingresar un número mayor a 0");
    }
}
Console.WriteLine("Cantidad de estudientes: " + estudiantes );