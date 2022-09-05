using System;
using System.Collections;
namespace Full_GRASP_And_SOLID.Library
{
   public class ConsolePrinter
   {
    /*
    Si bien imprimir la receta definitivamente precisa información de la clase Recipe, si se quisiera imprimirse
    en una impresora y no en la consola, debería cambiar la clase recipe. Pero la responsabilidad de esta
    es cambiar unicamente en función de los steps y su lista de arrays por lo que debería de tener más de una 
    razón para cambiar y no cumpliría con el SRP. 

    Tarjeta crc: Nombre: ConsolePrinter
Responsabilidades:                              Colaboraciones: Recipe
Imprimir una receta en la consola
    */
    public static void PrintRecipe(Recipe receta)
    {
        Console.WriteLine($"Receta de : {receta.FinalProduct.Description}");
        foreach (Step step in receta.steps)
       {
         Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
       }
   }
   } 











}