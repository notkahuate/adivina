using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adivina
{
    public class Programa
    {
          public static void Main(string[] args){

          var productosConEtiquetas = new List<(string Producto, List<string> Etiquetas)>
        {
            ("Laptop HP", new List<string> { "Electrónica", "Computadores", "Trabajo" }),
            ("Silla de Oficina", new List<string> { "Muebles", "Confort", "Oficina" }),
            ("Cafetera Oster", new List<string> { "Cocina", "Electrodomésticos", "Café" })
        };

        var aplanaretiquetas = productosConEtiquetas.SelectMany(p => p.Etiquetas).Distinct().ToList();

        
        var random = new Random();
        var etiquetaOculta = aplanaretiquetas[random.Next(aplanaretiquetas.Count)];

        Console.WriteLine("🎮 ¡Bienvenido al juego 'Encuentra la Etiqueta Oculta'!");
        Console.WriteLine("Adivina la etiqueta secreta entre las siguientes opciones:\n");

        foreach (var etiqueta in aplanaretiquetas)
        {
            Console.WriteLine($"- {etiqueta}");
        }
        Console.Write($"- etiqueta correcta  {etiquetaOculta}");
        Console.Write("\nIngresa tu intento: ");
        var intento = Console.ReadLine();

        if (etiquetaOculta.Equals(intento, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("¡Felicidades! ¡Adivinaste la etiqueta secreta!");
        }
        else
        {
            Console.WriteLine($"Error, no adivinaste. La etiqueta secreta era: {etiquetaOculta}");
        }

       }
    }
}