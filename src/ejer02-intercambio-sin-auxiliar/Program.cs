int a, b;

Console.Write("Valor de a: ");
a = int.Parse(Console.ReadLine());
Console.Write("Valor de b: ");
b = int.Parse(Console.ReadLine());

a = a + b;   // a guarda la suma de ambos
b = a - b;   // aparece el a original
a = a - b;   // aparece el b original

Console.WriteLine("Ahora a = " + a + " y b = " + b);