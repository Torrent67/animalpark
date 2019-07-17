using System;
using System.Collections.Generic;

namespace animalList
{
  public class Program
  {
    public static void Main()
    {
      Animal giraffe = new Animal("Giraffe", "Cervus", 15, 1800);
      Animal gazelle = new Animal("Gazelle", "G. cuvieri", 3 , 40);

      List<Animal> Animals = new List<Animal>() { giraffe, gazelle };

      // Console.WriteLine("Enter animal you'd like to search for: ");
      // string usersAnimal = Console.ReadLine();



      List<Animal> AnimalsMatchingSearch = new List<Animal>(0);

      // foreach (Animal type in Animals)
      // {
      //   if (type.GetName(usersAnimal))
      //   {
      //      Console.WriteLine(type.GetSpecies());
      //   }
      // }
      foreach (Animal type in Animals)
      {
        Console.WriteLine(type.GetName());
      }
    }
  }
  
}