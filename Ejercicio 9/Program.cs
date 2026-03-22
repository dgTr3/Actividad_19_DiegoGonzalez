Console.WriteLine("Nota de estudientes");
int nota = 0;
bool valido = false;
while(valido==false)
{
    Console.WriteLine("Ingrese la nota del estudiante");
    valido = int.TryParse(Console.ReadLine(), out nota);
    if (!valido || nota < 0 || nota > 100)
    {
        Console.WriteLine("nota invalida");
        valido = false;
    }
}
if (nota >=60)
{
    Console.WriteLine("Aprueba");
}
else
{
    Console.WriteLine("Reprobado");
}