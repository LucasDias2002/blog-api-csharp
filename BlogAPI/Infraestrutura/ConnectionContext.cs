using BlogAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace BlogAPI.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
            "Host =ep-black-rice-a4oskftg-pooler.us-east-1.aws.neon.tech; Database = neondb; Username = neondb_owner; Password = npg_sXikNVyB36UM; SSL Mode = Require; Trust Server Certificate = true");
        }
    }
}
