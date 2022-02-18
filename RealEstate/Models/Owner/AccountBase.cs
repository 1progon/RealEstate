using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RealEstate.Models.Owner;

public abstract class AccountBase : IdentityUser<Guid>
{
    [Key] public override Guid Id { get; set; }
}