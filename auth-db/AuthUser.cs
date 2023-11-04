using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace auth_db;


[Table("AuthUser")]
public class AuthUser
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required string firstName { get; set; } = null!;

    [Required]
    public required string lastName { get; set; } = null!;

    public required DateTime dateOfBirth { get; set; }

    [EmailAddress]
    public string email { get; set; } = null!;

    public ICollection<Session> Sessions { get; set; } = new List<Session>();
}