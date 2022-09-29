using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Email", TypeName = "NVARCHAR")]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(80)]
        [Column("PasswordHash", TypeName = "NVARCHAR")]
        public string PasswordHash { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Bio", TypeName = "NVARCHAR")]
        public string Bio { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Image", TypeName = "NVARCHAR")]
        public string Image { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }
}
