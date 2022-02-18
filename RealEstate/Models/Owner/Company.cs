using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models.Owner;

public class Company
{
    [Key] public int Id { get; set; }

    public Guid OwnerPersonId { get; set; }
    public Person OwnerPerson { get; set; } = null!;
}