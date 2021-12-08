using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergensTests
  {
    [TestMethod]
    public void IsAllergen_SelectsCorrectKeyValuePair_True()
    {
      Allergens.decodeAllergens(1);
      Assert.AreEqual("eggs", Allergens.decodeAllergens(1)[0]);
    }
    [TestMethod]
    public void IsAllergen_SelectsCorrectKeyValuePair_False()
    {
      Allergens.decodeAllergens(1);
      Assert.AreNotEqual("Your Face!", Allergens.decodeAllergens(1)[0]);
    }
    [TestMethod]
    public void IsAllergen_selectingMultipleCorrectItems_True()
    {
      Assert.AreEqual("cats 2018", Allergens.decodeAllergens(131)[0]);
      Assert.AreEqual("peanuts", Allergens.decodeAllergens(131)[1]);
      Assert.AreEqual("eggs", Allergens.decodeAllergens(131)[2]);
    }
  }
}