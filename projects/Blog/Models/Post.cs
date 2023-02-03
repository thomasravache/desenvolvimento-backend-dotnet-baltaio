using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {
        [Key] // Deixa explícito que o Id é uma primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Id é gerado pelo banco com Identity, então explicitamos aqui
        public int Id { get; set; }

        public string Title { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        /*
            o valor passado para o Annotation ForeignKey vai separar pelo CamelCase
            procurando nesse caso a referência na tabela 'Cateogory' na propriedade 'Id'
            (CategoryId = Cateogory | Id)
        */
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        // a propriedade do tipo Cateogory é uma Navigation Property, o banco vai fazer o join pra gente
        public Category Category { get; set; } = null!;
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User Author { get; set; } = null!;
    }
}