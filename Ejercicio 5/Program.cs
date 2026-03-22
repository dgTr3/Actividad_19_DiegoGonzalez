Console.WriteLine("Número par o impar");
int numero = 0;
bool valido = false;
while (!valido)
{
    Console.WriteLine("Ingrese un número: ");
    valido = int.TryParse(Console.ReadLine(), out numero);
    if (!valido)
    {
        Console.WriteLine("Debe ingresar un número");
    }
}
if (numero % 2 == 0)
{
    Console.WriteLine("El número es par");
}
else
{
    Console.WriteLine("El número es impar");
}