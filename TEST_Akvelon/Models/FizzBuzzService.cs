using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using TEST_Akvelon.Repositories;
using TEST_Akvelon.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TEST_Akvelon.Models
{
    public class FizzBuzzService : IFizzBuzzService
    {

        [Key]  // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment
        public int Id { get; set; }

        public required string Input { get; set; }

        public required string Output { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public FizzBuzzResult GetOverlappings(String input)
        {
            var words = Regex.Split(input, "(\\W+)").Where(w=>!string.IsNullOrWhiteSpace(w)).ToArray();

            int fizzCount = 0, buzzCount = 0, fizzBuzzCount = 0;

            for (int i = 0, wordIndex = 1; i< words.Length; i++)
            {
                if (!Regex.IsMatch(words[i], "^[a-zA-Z0-9]+$")) continue;

                bool isFizz = wordIndex % 3 == 0;

                bool isBuzz = wordIndex % 5 == 0;

                if (isFizz && isBuzz)
                {
                    words[i] = "FizzBuzz";
                    fizzBuzzCount++;
                }
                else if (isFizz)
                {
                    words[i] = "Fizz";
                    fizzCount++;
                }
                else if (isBuzz)
                {
                    words[i] = "Buzz";
                    buzzCount++;
                }

                wordIndex++;
            }

           

            return new FizzBuzzResult
            {
                Output = string.Join("", words),

                Count = fizzCount + buzzCount + fizzBuzzCount
            };
        }

        //TEST_Akvelon.FizzBuzzResult IFizzBuzzService.GetOverlappings(string input)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
