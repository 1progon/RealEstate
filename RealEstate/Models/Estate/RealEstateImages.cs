namespace RealEstate.Models.Estate;

public class RealEstateImages
{
    public string Folder { get; set; } = null!;
    public string Filename { get; set; } = null!;


    public int RealEstateId { get; set; }
    public RealEstate RealEstate { get; set; } = null!;
}