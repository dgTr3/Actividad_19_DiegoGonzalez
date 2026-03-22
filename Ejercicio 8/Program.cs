Console.WriteLine("Sacar raiz cuadrada");
double numero=0;
bool valido = false;
while (!valido)
{
    Console.WriteLine("Ingrese un número: ");
    valido = double.TryParse(Console.ReadLine(), out numero) && numero >= 0;
    if (!valido)
    {
        Console.WriteLine("Debe ingresar un número mayor o igual a 0");
    }
}
double raiz = numero / 2;
Console.WriteLine("La raiz cuadrada es: " + raiz );