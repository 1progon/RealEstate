using System.ComponentModel.DataAnnotations.Schema;
using RealEstate.Models.Owner;

namespace RealEstate.Models.Estate;

public class RealEstate : BaseModel
{
    public override int Id { get; set; }

    public string? Description { get; set; }
    public string? Article { get; set; }

    public int? SubCategoryId { get; set; }
    public RealEstateSubCategory? SubCategory { get; set; }

    [Column(TypeName = "varchar(255)")] public string? Image { get; set; }

    public IList<RealEstateImages>? Images { get; set; }

    public Guid? OwnerPersonId { get; set; }
    public Person? OwnerPerson { get; set; }

    public int? OwnerCompanyId { get; set; }
    public Company? OwnerCompany { get; set; }
}