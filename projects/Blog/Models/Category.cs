using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Category")] // Se não informar o EF assume que é o mesmo nome informado no referente DbSet
    public class Category
    {
        [Key] // Deixa explícito que o Id é uma primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Id é gerado pelo banco com Identity, então explicitamos aqui
        public int Id { get; set; }


        public string Name { get; set; } = null!;
        public string Slug { get; set; } = null!;
    }
}