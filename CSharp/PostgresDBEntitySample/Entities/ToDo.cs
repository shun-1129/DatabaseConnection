using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostgresDBEntitySample.Entities
{
    [Table ("ToDo")]
    public class ToDo
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public bool IsComplete { get; set; } = false;
    }
}
