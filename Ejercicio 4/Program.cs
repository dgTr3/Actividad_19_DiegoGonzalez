Console.WriteLine("Año de nacimineto");
int year = 0;
int actual= DateTime.Now.Year;
bool valido=false;
while(!valido)
{
    Console.WriteLine("Ingrese año de nacimiento: ");
    valido=int.TryParse(Console.ReadLine(), out year) && year > 1900 && year <= actual;
    if (valido)
    {
        Console.WriteLine("Ingrese un año valido");
    }

}
Console.WriteLine("Año valido: "+ year);