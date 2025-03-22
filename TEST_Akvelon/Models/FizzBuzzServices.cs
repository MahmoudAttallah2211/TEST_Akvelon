using System.ComponentModel.DataAnnotations;

namespace TEST_Akvelon.Models
{
    public class FizzBuzzServices
    {
        [Key]

        public int Id { get; set; }

        public required string Input { get; set; }

        public required string Output { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
