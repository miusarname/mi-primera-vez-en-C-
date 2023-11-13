using mi_primera_vez.Entidades;
using mi_primera_vez;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = "Oscar";
        int age = 18;
        const bool estaRico = true;

        double sueldo = 1500.101;

        Console.WriteLine($"Hola {name}, tengo {age} años y soy {estaRico} y a esa edas gano {sueldo}");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Dame tu nombre colega:");
        string? nombre = Console.ReadLine();
        Console.WriteLine($"Tu nombre es {nombre} y eres un amigo...");

        if (nombre != "Juan")
        {
            Console.WriteLine("Eres una persona ejemplar...");
        }
        else
        {
            Console.WriteLine($"{nombre}, lo mama");
        }


        int[] Edades = new int[5];
        String[] Nombres = new String[] { "Juan", "Felipe", "Julian", "Lo maman", "putio" };
        int[] Algo = { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine(Edades[4]);
        Console.WriteLine(Algo[3]);

        Person p = new Person();
    }
}

