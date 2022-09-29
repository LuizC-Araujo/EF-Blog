using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Title", TypeName = "NVARCHAR")]
        public string Title { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Summary", TypeName = "NVARCHAR")]
        public string Summary { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Body", TypeName = "NVARCHAR")]
        public string Body { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }

        [Required]
        [Column("CreateDate", TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }

        [Required]
        [Column("LastUpdateDate", TypeName = "datetime2")]
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } 

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}
