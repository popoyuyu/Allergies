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
  }
}