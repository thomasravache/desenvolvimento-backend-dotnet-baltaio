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

        [Required] // Informa que esse campo no banco é NOT NULL
        [MinLength(3)] // É possível validar a nível de código isso aqui, mesmo não existindo minLength no banco
        [MaxLength(80)]
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; } = null!;

        [Required] // Informa que esse campo no banco é NOT NULL
        [MinLength(3)] // É possível validar a nível de código isso aqui, mesmo não existindo minLength no banco
        [MaxLength(80)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; } = null!;
    }
}