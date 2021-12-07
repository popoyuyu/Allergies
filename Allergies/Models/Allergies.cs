using System;
using System.Collections.Generic;

namespace Allergies
{
  public class Allergens
  {

    public static String[] decodeAllergens(int userInput)
    {
      int[] benchmarks = { 1, 2, 4, 8, 16, 32, 64, 128 };
      Dictionary<int, string> allergens = new Dictionary<int, string>(){
          {1,"eggs"},
          {2,"peanuts"},
          {4,"shellfish"},
          {8,"strawberries"},
          {16,"tomatoes"},
          {32,"chocolate"},
          {64,"pollen"},
          {128,"cats 2018"}
        };
      List<string> output = new List<string>();
      int X = userInput;
      for (int i = benchmarks.Length - 1; i >= 0; i--)
      {
        if (X >= benchmarks[i])
        {
          X = X - benchmarks[i];
          output.Add(allergens[benchmarks[i]]);
        }
      }
      string[] output2AttackOfTheClones = output.ToArray();
      return output2AttackOfTheClones;
    }
  }
}


