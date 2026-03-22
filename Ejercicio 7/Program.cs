Console.WriteLine("Salario de empleado");
decimal salario = 0;    
bool valido = false;
while(!valido)
{
    Console.WriteLine("Ingrese salario");
    valido=decimal.TryParse(Console.ReadLine(), out salario) && salario > 0;
    if (!valido)
    {
        Console.WriteLine("Debe ingresar un número mayor a 0");
    }
}
Console.WriteLine("Salario valido: " + salario);