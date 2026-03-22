Console.WriteLine("Cantidad de productos");
int cantidad =0;
bool valido = false;    
while (!valido)
{
    Console.WriteLine("Ingrese cantidad de productos: ");
    valido = int.TryParse(Console.ReadLine(), out cantidad);
    if (!valido || cantidad<=0)
    {
        Console.WriteLine("Debe ingresar un número mayor a 0");
        valido = false;

    }

}
for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine("Ingrese el nombre del producto" + i  );
    string producto = Console.ReadLine();   
}