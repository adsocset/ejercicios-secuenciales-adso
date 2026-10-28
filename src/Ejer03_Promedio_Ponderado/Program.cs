//Promedio ponderado
// variables
double nota1, nota2, nota3, prom;

//Proceso
Console.Write("Ingrese la nota 1 ");
nota1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese la nota 2 ");
nota2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese la nota 3 ");
nota3 = Convert.ToInt32(Console.ReadLine());
nota1 = nota1 * 0.20;
nota2 = nota2 * 0.30;
nota3 = nota3 * 0.40;
prom = nota1 + nota2 + nota3;

//Salida
Console.WriteLine($"El promedio ponderado es: {prom}");