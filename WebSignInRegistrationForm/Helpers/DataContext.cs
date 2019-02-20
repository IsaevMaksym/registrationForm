using Microsoft.EntityFrameworkCore;
using WebSignInRegistrationForm.Model;

namespace WebSignInRegistrationForm.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}