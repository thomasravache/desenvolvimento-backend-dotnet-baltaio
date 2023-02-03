using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("User")]
    public class User
    {
        [Key] // Deixa explícito que o Id é uma primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Id é gerado pelo banco com Identity, então explicitamos aqui
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Bio { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Slug { get; set; } = null!;
    }
}