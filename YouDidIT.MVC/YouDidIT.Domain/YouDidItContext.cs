using Microsoft.EntityFrameworkCore;
using YouDidIT.Domain.Entities;

namespace YouDidIT.Domain
{
    public class YouDidItContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TaskApp> Tasks { get; set; }

        public YouDidItContext(DbContextOptions options): base(options)
        {
        }
    }
}
