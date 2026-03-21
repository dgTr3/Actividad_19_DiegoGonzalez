Console.WriteLine("Validar edad");
Console.WriteLine();
int edad;
bool valido = false;
while(!valido)
{
    Console.WriteLine("Ingrese la edad");
    valido=int.TryParse(Console.ReadLine(), out edad);
    if (!valido)
    {
        Console.WriteLine("Debe ingresar un número ");
    }

}
Console.WriteLine("Edad valida!");
