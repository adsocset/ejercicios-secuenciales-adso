//Programa que intercambie valores
//definimos variables 
int a, b, c;

//ingresamos datos
Console.Write("ingrese el el valor de A: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("ingrese el el valor de B: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Los valores originales resultan como: A:{a} y B:{b}");
//proceso
c = a;
a = b;
b = c;

//irmprimimos
Console.WriteLine($"Los valores cambiados resultan como: A:{a} y B:{b}");
