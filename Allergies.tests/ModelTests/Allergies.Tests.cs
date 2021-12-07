using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Allergies;

namespace Allergies.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void Allergy_CreatesInstanceOfAllergy_Allergy()
      {
        Allergy newAllergy = new Allergy(2);
        Assert.AreEqual(typeof(Allergy), newAllergy.GetType());
      }
    [TestMethod]
    public void Allergy_CreatesMethodThatReturnslist_list()
      {
        Allergy newAllergy = new Allergy(6);
        Assert.IsInstanceOfType(newAllergy.AllergenTypes(), typeof(List<string>));
      }
    [TestMethod]
    public void Allergy_AllergenTypesConvertsAllergyScoretoAllergens_list()
    {
      Allergy newAllergy = new Allergy(9);
      List<string> allergenList = newAllergy.AllergenTypes();
      Assert.AreEqual("eggs", allergenList[0]);
      Assert.AreEqual("strawberries", allergenList[1]);
    }

  }
}