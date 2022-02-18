using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.Models.Estate;

public class RealEstateCategory : BaseModel
{
    public override int Id { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "varchar(255)")] public string? Image { get; set; }

    public IList<RealEstateSubCategory>? SubCategories { get; set; }
}