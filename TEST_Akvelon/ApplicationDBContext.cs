using Microsoft.EntityFrameworkCore;
using TEST_Akvelon.Models;

namespace TEST_Akvelon
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {
            
        }

        public DbSet<FizzBuzzRequest> FizzBuzzRequests { get; set; }
        public DbSet<FizzBuzzResult> FizzBuzzResults { get; set; }

        public DbSet<FizzBuzzEntity> FizzBuzzEntities { get; set; }

        public DbSet<FizzBuzzService> FizzBuzzServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<FizzBuzzResult>().HasNoKey();
            modelBuilder.Entity<FizzBuzzRequest>().HasNoKey();
            modelBuilder.Entity<FizzBuzzService>().HasNoKey();
            modelBuilder.Entity<FizzBuzzService>().ToTable("FizzBuzzServices");
            modelBuilder.Entity<FizzBuzzEntity>().HasData(
                
                new FizzBuzzEntity { Id=1,Input= "Mary had a little lamb", Output= "Buzz had Fizz little lamb", Count=2}
                );
        }
    }
}
