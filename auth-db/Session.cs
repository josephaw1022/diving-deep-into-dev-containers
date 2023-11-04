
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace auth_db;


[Table("AuthSession")]
public class Session
{
    [Key]
    public Guid id { get; set; } = Guid.NewGuid();

    public int userId { get; set; }

    // Navigation property for the related User entity
    [ForeignKey("userId")]
    public AuthUser User { get; set; } = null!;


}

