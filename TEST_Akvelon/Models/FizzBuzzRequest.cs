using System.ComponentModel.DataAnnotations;

namespace TEST_Akvelon.Models
{
    public class FizzBuzzRequest
    {
        [Key]
        public int Id { get; set; }
        public required string Input { get; set; }
    }
}
