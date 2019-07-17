using System;

namespace animalList
{
    class Animal
    {
      private string _Name;
      private string _Species;
      private int _Weight;
      private int _Height;
      
      public Animal(string name, string species, int weight, int height)
      {
        _Name = name;
        _Species = species;
        _Weight = weight;
        _Height = height;
      }
      public string GetName()
      {
        return _Name;
      }
      public string GetSpecies()
      {
        return _Species;
      }
      public int GetWeight()
      {
        return _Weight;
      }
      public int GetHeight()
      {
        return _Height;
      }
      
      // public bool AnimalName(int maxPrice)
      // {
      // return (_Price < maxPrice);
      // }

    }


}