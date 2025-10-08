using GramsevaAbhiyaan.Model;
using Microsoft.EntityFrameworkCore;

namespace GramsevaAbhiyaan.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<SarveyForm> SarveyForms { get; set; }
        public DbSet<AnswersOfSurvey> AnswersOfSurveys { get; set; }

    }
}
