using System;

class Program
{
    static void Main(string[] args)
    {
        Personaje personaje = new Personaje
        {
            Nombre = "Guerrero",
            Vida = 100,
            Ataque = 50,
            Defensa = 30,
            Nivel = 1
        };

        Console.WriteLine($"Personaje: {personaje.Nombre}");
        Console.WriteLine($"Vida: {personaje.Vida}");
        Console.WriteLine($"Ataque: {personaje.Ataque}");
        Console.WriteLine($"Defensa: {personaje.Defensa}");
        Console.WriteLine($"Nivel: {personaje.Nivel}");
    }
}