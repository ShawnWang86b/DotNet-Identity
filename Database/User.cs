using Microsoft.AspNetCore.Identity;

namespace Identity.Database;

public class User :IdentityUser
{
    public string? Initials { get; set; }
}