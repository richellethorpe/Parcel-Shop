namespace Parcel.Models
{
  public class ParcelShipment
  {
    public double Height { get; set; }
    public double Width { get; set; }

    public double Length { get; set; }

    public double Weight { get; set; }

    public ParcelShipment( double ht, double wd, double lgt, double wgt)
    {
      Height = ht;
      Width = wd;
      Length = lgt;
      Weight = wgt;
    }

    public double ReturnWeightPrice()
    {
      if (Weight <= 16)
      {
        return 2;
      }
      else if (Weight <= 80)
      {
        return 5;
      }
      else if (Weight > 80)
      {
        return 7;
      }
      return -1;
    }

    public double ReturnDimensionPrice ()
    {
      double totalPackageArea = (Height * Width * Length);
      if (totalPackageArea <= 100)
      {
        return 5;
      }
      if (totalPackageArea <= 300)
      {
        return 10;
      }
      if (totalPackageArea > 300)
      {
        return 50;
      }
      return -1;
    }

    public double ReturnTotalPrice()
    {
      return (ReturnWeightPrice() + ReturnDimensionPrice());
    }
  }
}