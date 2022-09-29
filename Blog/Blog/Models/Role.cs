using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class Role
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
