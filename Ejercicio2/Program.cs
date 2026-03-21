Console.WriteLine("Precio de producto");
Console.WriteLine();
decimal precio;
bool valido = false;
while (!valido)
{
    Console.WriteLine("Ingrese precio: ");
    valido = decimal.TryParse(Console.ReadLine(), out precio) && precio > 0;
    if (!valido)
    {
        Console.WriteLine("Debe ingresar un número mayor a 0");
    }
}
Console.WriteLine("Precio valido");
