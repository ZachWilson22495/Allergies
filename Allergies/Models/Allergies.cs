using System;
using System.Collections.Generic;

namespace Allergies{

  public class Allergy
  {
    public int AllergyScore;
    public Allergy(int allergyScore)
      {
        AllergyScore = allergyScore;
      }

    public List<string> AllergenTypes()
    {
      List<string> allergens = new List<string> {};
      string[] allergytypes = { "eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats" };
      string binary = Convert.ToString(AllergyScore, 2);
      for (int index = 0; index < Math.Min(allergytypes.Length, binary.Length); index++)
      {
        if(binary[binary.Length - index-1] == '1')
        {
          allergens.Add(allergytypes[index]);
        }
      }
      return allergens;
    }
  }
}