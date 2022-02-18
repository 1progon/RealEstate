using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.Models.Estate;

public class RealEstateSubCategory : BaseModel
{
    public override int Id { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "varchar(255)")] public string? Image { get; set; }

    public int? CategoryId { get; set; }
    public RealEstateCategory? Category { get; set; }

    public IList<RealEstate>? RealEstates { get; set; }
}