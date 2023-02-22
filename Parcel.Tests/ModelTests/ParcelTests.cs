using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcel.Models;

namespace Parcel.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_CreateInstance_ParcelShipment()
    {
      ParcelShipment newParcelShipment = new ParcelShipment(2, 4, 5, 6);
      Assert.AreEqual(typeof(ParcelShipment), newParcelShipment.GetType());
    }
  
    [TestMethod]
    public void GetWeight_ReturnWeightPrice_Double()
    {
      double wgt = 5;
      ParcelShipment newParcelShipment = new ParcelShipment(0, 0, 0, wgt);
      double weightPrice = newParcelShipment.ReturnWeightPrice(wgt);
      
      Assert.AreEqual(weightPrice, 2);
    }
    [TestMethod]
    public void GetDimensions_ReturnDimensionPrice_Double()
    {
      ParcelShipment newParcelShipment = new ParcelShipment(5, 10, 2, 0);
      double dimensionPrice = newParcelShipment.ReturnDimensionPrice(5, 10, 2);
      Assert.AreEqual(dimensionPrice, 5);
    }

    [TestMethod]
    public void GetTotalPrice_ReturnTotalPrice_Double()
    {
      ParcelShipment newParcelShipment = new ParcelShipment(5, 10, 2, 5);
      double totalPrice = newParcelShipment.ReturnTotalPrice(5, 10, 2, 5);
      Assert.AreEqual(totalPrice, 7);
    }
  }
}